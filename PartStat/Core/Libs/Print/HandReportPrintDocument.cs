using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;
using NLog;
using WcApi.Print.Base;

namespace PartStat.Core.Libs.Print
{
    public class HandReportPrintDocument : TablePrintDocument
    {
        private readonly DataGridView _dataGridView;
        private readonly int[] _columnWidths;

        private readonly bool _clear;

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

        // Отображать номера страниц
        public bool PrintNumPageInfo { get; set; }
        public int PagesCount { get; set; } = 0;

        public HandReportPrintDocument(DataGridView dataGridView, int[] columnWidths, bool clear = false)
        {
            _dataGridView = dataGridView;
            _columnWidths = columnWidths;
            _clear = clear;

            DefaultPageSettings.Margins = new Margins(30, 30, 40, 40);
        }

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
                }

                e.HasMorePages = morePagesToPrint;
            }
            catch (Exception ex)
            {
                Logger.Error($"Ошибка: {ex.Message}");
                Logger.Error($"{ex}");
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

            e.Graphics.DrawString("Отчет по ручным спискам", PrintPens.HeaderBoldFont, PrintPens.ForeBrush, rect, stringFormat);
            marginTop += offset;

            return marginTop + 10;
        }

        private void PrintDate(PrintPageEventArgs e)
        {
            string date = $"Сформировано: {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
            // Печать Даты
            e.Graphics.DrawString(date, PrintPens.DateFont, PrintPens.ForeBrush, e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10);
        }
    }
}
