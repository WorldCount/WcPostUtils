using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using LK.Core.Libs.Stat;
using NLog;
using WcApi.Print.Base;

namespace LK.Core.Libs.PrintDocuments
{
    public class MassReportPrintDocument : TablePrintDocument
    {
        private readonly DataGridView _dataGridView;
        private readonly int[] _columnWidths;

        private readonly bool _clear;

        private readonly SingleReportData _singleReport;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        // Форматирование строк
        private readonly StringFormat _stringFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter
        };

        private readonly ArrayList _columnLefts = new ArrayList();
        private int _cellHeight;
        private int _rowCount;
        private bool _firstPage;
        private bool _newPage;
        private int _headerHeight = 40;
        private int _currentPageCount = 1;
        private bool _printCityStat;
        private bool _lastPage;
        private int _lastCount;


        // Отображать номера страниц
        public bool PrintNumPageInfo { get; set; }
        public int PagesCount { get; set; } = 0;
        public string ReportTitle { get; set; } = "";

        public MassReportPrintDocument(DataGridView dataGridView, SingleReportData singleReport, int[] columnWidths, bool clear = false)
        {
            _dataGridView = dataGridView;
            _singleReport = singleReport;
            _columnWidths = columnWidths;
            _clear = clear;

            DefaultPageSettings.Margins = new Margins(10, 10, 40, 40);
        }

        // ReSharper disable once UnusedMember.Global
        public void SetMargin(Margins margins)
        {
            DefaultPageSettings.Margins = margins;
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            base.OnBeginPrint(e);

            try
            {
                _columnLefts.Clear();
                _rowCount = 0;
                _firstPage = true;
                _newPage = true;
                _currentPageCount = 1;
                _printCityStat = false;
                _lastCount = 0;
            }
            catch (Exception exception)
            {
                Logger.Error($"Ошибка: {exception.Message}");
                Logger.Error($"{exception}");
            }
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            try
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                // Левый отступ
                int leftMargin = e.MarginBounds.Left;
                // Верхний отступ
                int topMargin = e.MarginBounds.Top;
                // Печатать остальные страницы
                bool morePagesToPrint = false;

                int pageWidth = (int)e.PageSettings.PrintableArea.Width - e.MarginBounds.Left + 1;

                string pageNumString = $"Страница {_currentPageCount}";
                if (PagesCount > 0)
                    pageNumString = $"Страница {_currentPageCount} из {_currentPageCount}";

                int pageNumHeight = (int)CheckHeight(e, PrintPens.BoldFont, pageNumString);

                if (_firstPage)
                {
                    int countWidth = 0;
                    while (countWidth < _columnWidths.Length)
                    {
                        _columnLefts.Add(leftMargin);
                        leftMargin += _columnWidths[countWidth];
                        countWidth++;
                    }

                    topMargin = PrintReportInfo(e, topMargin, pageWidth);
                    PrintDate(e);
                }

                while (_rowCount < _dataGridView.Rows.Count)
                {
                    DataGridViewRow gridRow = _dataGridView.Rows[_rowCount];

                    // Высота ячейки
                    _cellHeight = gridRow.Height;

                    int tableSize = topMargin + _cellHeight;
                    if (PrintNumPageInfo)
                        tableSize += pageNumHeight;

                    // Проверка, позволяет ли текущая страница напечатать эту строку
                    if (tableSize >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        _newPage = true;
                        _firstPage = false;
                        morePagesToPrint = true;
                        _currentPageCount += 1;
                        break;
                    }
                    else
                    {

                        if (_newPage)
                        {
                            topMargin = _firstPage ? topMargin : e.MarginBounds.Top;
                            // Заголовок таблицы
                            PrintTableHeader(e, topMargin);

                            if (PrintNumPageInfo)
                            {
                                PrintNumsPages(e, pageWidth);
                            }

                            _newPage = false;
                            topMargin += _headerHeight;
                        }

                        // Отрисовка строки
                        PrintRow(e, gridRow, topMargin);
                    }

                    _rowCount++;
                    topMargin += _cellHeight;
                    _lastPage = _rowCount == _dataGridView.Rows.Count;
                }

                // Проверка, позволяет ли текущая страница напечатать эту строку
                if (_lastPage)
                {
                    if (topMargin + _cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        _newPage = true;
                        _firstPage = false;
                        _currentPageCount += 1;
                        morePagesToPrint = true;
                    }
                    else
                    {
                        if (PrintNumPageInfo)
                        {
                            PrintNumsPages(e, pageWidth);
                        }

                        if (!_printCityStat)
                        {
                            topMargin = PrintCityStat(e, topMargin);
                            _printCityStat = true;
                        }

                        for (int i = _lastCount; i < _singleReport.NumsList.Count; i++)
                        {
                            _lastCount = i;

                            int newTopMargin = CalculateListInfo(e, _singleReport.NumsList[i]);

                            if (topMargin + newTopMargin + 30 >= e.MarginBounds.Height + e.MarginBounds.Top)
                            {
                                _newPage = true;
                                _firstPage = false;
                                _currentPageCount += 1;
                                morePagesToPrint = true;
                                break;
                            }

                            topMargin = PrintListInfo(e, topMargin, newTopMargin, _singleReport.NumsList[i]);
                        }

                        PrintOperNameInfo(e, topMargin, _singleReport.Operators);

                    }
                }

                e.HasMorePages = morePagesToPrint;
            }
            catch (Exception ex)
            {
                Logger.Error($"Ошибка: {ex.Message}");
                Logger.Error($"{ex}");
            }
        }

        private void PrintRow(PrintPageEventArgs e, DataGridViewRow gridRow, int topMargin)
        {
            bool clear = (string)gridRow.Cells[0].Value == "Clear";
            bool clearRow = _clear && clear;

            int cellCount = 0;
            while (cellCount < gridRow.Cells.Count)
            {
                DataGridViewCell cell = gridRow.Cells[cellCount];

                int colLeft = (int)_columnLefts[cellCount];
                int colWidth = _columnWidths[cellCount];

                // Значение
                if (cell?.Value != null)
                {
                    if (!clearRow && !clear)
                    {
                        e.Graphics.DrawString(cell.Value.ToString(), PrintPens.CellFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight), _stringFormat);
                    }
                }

                if (!clearRow)
                    // Границы
                    e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight));

                cellCount++;
            }
        }

        private void PrintTableHeader(PrintPageEventArgs e, int topMargin)
        {
            int colCount = 0;
            while (colCount < _dataGridView.Columns.Count)
            {
                DataGridViewColumn gridCol = _dataGridView.Columns[colCount];

                int colLeft = (int)_columnLefts[colCount];
                int colWidth = _columnWidths[colCount];

                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(colLeft, topMargin, colWidth, _headerHeight));
                e.Graphics.DrawString(gridCol.HeaderText, PrintPens.BoldFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight), _stringFormat);

                colCount++;
            }
        }

        private void PrintNumsPages(PrintPageEventArgs e, int pageWidth)
        {
            string pageNumString = $"Страница {_currentPageCount}";

            if (PagesCount > 0)
                pageNumString = $"Страница {_currentPageCount} из {PagesCount}";

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Far,
            };

            Rectangle rect = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10, pageWidth, 20);
            e.Graphics.DrawString(pageNumString, PrintPens.BoldFont, PrintPens.ForeBrush, rect, stringFormat);
        }

        private int PrintReportInfo(PrintPageEventArgs e, int margin, int pageWidth)
        {
            int offset = 20;
            int marginTop = margin - 20;

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle rect = new Rectangle(e.MarginBounds.Left, marginTop, pageWidth, offset);

            e.Graphics.DrawString(_singleReport.FirmName, PrintPens.HeaderBoldFont, PrintPens.ForeBrush, rect, stringFormat);

            Rectangle titleRect = new Rectangle(e.MarginBounds.Right - 78, marginTop, 40, offset + 20);
            e.Graphics.DrawString(ReportTitle, PrintPens.HeaderBoldFont, PrintPens.ForeBrush, titleRect, stringFormat);
            e.Graphics.DrawRectangle(Pens.Black, titleRect);

            marginTop += offset;

            string info = $"ИНН: {_singleReport.FirmInn}";

            rect.Y += offset;


            if (!string.IsNullOrEmpty(_singleReport.FirmContract) && _singleReport.FirmContract != "1")
                info += $", Договор: {_singleReport.FirmContract.ToUpper()}";

            e.Graphics.DrawString(info, PrintPens.HeaderFont, PrintPens.ForeBrush, rect, stringFormat);
            marginTop += offset;

            return marginTop + 10;
        }

        private int PrintCityStat(PrintPageEventArgs e, int margin)
        {
            int topMargin = 10 + margin;

            string[] data = new[]
            {
                $"Всего отправлений: {_singleReport.CityCollector.SumCount}",
                $"Город: {_singleReport.CityCollector.CityCount}",
                $"Москва: {_singleReport.CityCollector.MoscowCount}",
                $"МЖД: {_singleReport.CityCollector.InterCount}",
                $"Неизвестно: {_singleReport.CityCollector.UnkownCount}"
            };

            int cellCount = 0;
            while (cellCount < data.Length)
            {
                int colLeft = (int)_columnLefts[cellCount];
                int colWidth = _columnWidths[cellCount];

                e.Graphics.DrawString(data[cellCount], PrintPens.CellFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight), _stringFormat);
                cellCount++;
            }

            topMargin += 40;

            return topMargin;
        }

        private int CalculateListInfo(PrintPageEventArgs e, DateList dateList)
        {
            int size = 0;
            int colWidth = _columnWidths.Sum();

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near,
                Trimming = StringTrimming.None
            };

            int rowHeight = _cellHeight + 20;

            SizeF area = new SizeF(colWidth, _cellHeight);
            size += (int)e.Graphics.MeasureString(dateList.Date.ToShortDateString(), PrintPens.BoldFont, area, stringFormat).Height;
            size += 20;

            area = new SizeF(colWidth, rowHeight);
            size += (int)e.Graphics.MeasureString(dateList.NumsToString(), PrintPens.BoldFont, area, stringFormat).Height;

            return size;
        }

        private int PrintListInfo(PrintPageEventArgs e, int margin, int newTopMargin, DateList dateList)
        {
            int topMargin = margin;
            int colLeft = (int)_columnLefts[0];
            int colWidth = _columnWidths.Sum();

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near,
                Trimming = StringTrimming.None
            };

            string info = dateList.NumsToString();
            int rowHeight = _cellHeight + 20;
            e.Graphics.DrawString(dateList.Date.ToShortDateString(), PrintPens.BoldFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight), stringFormat);
            topMargin += 20;

            e.Graphics.DrawString(info, PrintPens.CellFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, rowHeight), stringFormat);

            return topMargin + newTopMargin - 20;
        }

        private int PrintOperNameInfo(PrintPageEventArgs e, int margin, List<string> operators)
        {
            int topMargin = margin;
            int colLeft = (int)_columnLefts[0];
            int colWidth = _columnWidths.Sum();

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near,
                Trimming = StringTrimming.None
            };

            string info = string.Join(", ", operators);
            int rowHeight = _cellHeight + 20;
            e.Graphics.DrawString("Принял:", PrintPens.BoldFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight), stringFormat);
            topMargin += 20;

            e.Graphics.DrawString(info, PrintPens.CellFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, rowHeight), stringFormat);

            return topMargin;
        }

        private void PrintDate(PrintPageEventArgs e)
        {
            string date = $"Сформировано: {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
            // Печать Даты
            e.Graphics.DrawString(date, PrintPens.DateFont, PrintPens.ForeBrush, e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10);
        }
    }
}
