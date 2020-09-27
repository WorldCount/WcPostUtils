using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using NLog;
using PartStat.Core.Libs.Stats;
using PartStat.Core.Models.DB;
using WcApi.Print.Base;

namespace PartStat.Core.Libs.Print
{
    public class ListFirmPrintDocument : TablePrintDocument
    {
        private readonly DataGridView _dataGridView;
        private readonly List<FirmList> _firmLists;
        private readonly int[] _columnWidths;
        private readonly int[] _ignoreCols;

        private List<StatData> _statDatas;
        private DataGridView _dataGridViewStat;

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
        private int _currentPageCount;

        // Кисти
        private SolidBrush BackBrush { get; set; } = new SolidBrush(Color.White);
        private SolidBrush ForeBrush { get; set; } = new SolidBrush(Color.Black);
        private Pen BorderBrush { get; set; } = Pens.Black;

        // Шрифты
        private Font BoldFont { get; set; } = new Font("Segoe Ui", 10, FontStyle.Bold);
        private Font DateFont { get; set; } = new Font("Segoe Ui", 9, FontStyle.Regular);
        private Font CellFont { get; set; } = new Font("Segoe Ui", 8, FontStyle.Regular);
        // Заголовок
        private Font HeaderFont { get; set; } = new Font("Segoe Ui", 10, FontStyle.Regular, GraphicsUnit.Point);
        private Font HeaderBoldFont { get; set; } = new Font("Segoe Ui", 12, FontStyle.Bold, GraphicsUnit.Point);


        // Отображать номера страниц
        public bool PrintNumPageInfo { get; set; }
        public int PagesCount { get; set; } = 0;

        public ListFirmPrintDocument(DataGridView dataGridView, List<FirmList> firmLists, int[] columnWidths, int[] ignoreCols = null)
        {
            _dataGridView = dataGridView;
            _firmLists = firmLists;
            _columnWidths = columnWidths;
            _ignoreCols = ignoreCols;

            DefaultPageSettings.Margins = new Margins(10, 10, 40, 40);
        }

        public void SetMargin(Margins margins)
        {
            DefaultPageSettings.Margins = margins;
        }

        public void SetStat(DataGridView dataGridViewStat = null, List<StatData> statDatas = null)
        {
            _statDatas = statDatas;
            _dataGridViewStat = dataGridViewStat;
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

                string pageNumString = "Страница 1";
                if (PagesCount > 0)
                    pageNumString = "Страница 1 из 1";

                int pageNumHeight = (int) CheckHeight(e, BoldFont, pageNumString);

                if (_firstPage)
                {
                    int countWidth = 0;
                    while (countWidth < _columnWidths.Length)
                    {
                        _columnLefts.Add(leftMargin);
                        leftMargin += _columnWidths[countWidth];
                        countWidth++;
                    }

                    // Название отчета
                    if (!string.IsNullOrEmpty(DocumentName))
                        topMargin = PrintReportInfo(e, topMargin, pageWidth);

                    PrintDate(e);
                }

                while (_rowCount < _firmLists.Count)
                {
                    DataGridViewRow gridRow = _dataGridView.Rows[_rowCount];

                    // Высота ячейки
                    _cellHeight = gridRow.Height + 5;

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

                        PrintRow(e, _rowCount, topMargin);
                    }

                    _rowCount++;
                    topMargin += _cellHeight;
                }

                #region Статистика
                if (!morePagesToPrint && _dataGridViewStat != null && _statDatas != null)
                { 
                    morePagesToPrint = StatPrint(e, topMargin, pageNumHeight);
                }
                #endregion


                e.HasMorePages = morePagesToPrint;
            }
            catch (Exception exc)
            {
                Logger.Error($"Ошибка: {exc.Message}");
                Logger.Error($"{exc}");
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

            int height = (int) CheckHeight(e, BoldFont, pageNumString);
            Rectangle rect = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10, pageWidth, height);
            e.Graphics.DrawString(pageNumString, BoldFont, ForeBrush, rect, stringFormat);
        }

        private void PrintRow(PrintPageEventArgs e, int rowCount, int topMargin)
        {
            FirmList firmList = _firmLists[rowCount];
            string[] data =
            {
                firmList.Check.ToString(), firmList.Date.ToShortDateString(), firmList.Num.ToString(), firmList.FirmName,
                firmList.InterName,
                firmList.ManualName, firmList.MailTypeName, firmList.MailCategoryName, firmList.PostMarkNamePrint,
                firmList.Count.ToString(), firmList.WarnCount.ToString(), firmList.ErrCount.ToString(),
                firmList.MassRate.ToString("N2")
            };

            // Отрисовка ячеек
            int cellCount = 0;
            while (cellCount < data.Length)
            {
                if (_ignoreCols != null && _ignoreCols.Contains(cellCount))
                {
                    cellCount++;
                    continue;
                }

                int colLeft = (int) _columnLefts[cellCount];
                int colWidth = _columnWidths[cellCount];

                // Значение
                e.Graphics.DrawString(data[cellCount], CellFont, ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight), _stringFormat);
                // Границы
                e.Graphics.DrawRectangle(BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight));

                cellCount++;
            }
        }

        private int PrintReportInfo(PrintPageEventArgs e, int margin, int pageWidth)
        {
            int offset = 20;
            int marginTop = margin - offset;

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle rect = new Rectangle(e.MarginBounds.Left, marginTop, pageWidth, offset);

            e.Graphics.DrawString(DocumentName, HeaderBoldFont, ForeBrush, rect, stringFormat);

            return marginTop + offset + 10;
        }

        private void PrintDate(PrintPageEventArgs e)
        {
            string date = $"Сформировано: {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
            // Печать Даты
            e.Graphics.DrawString(date, DateFont, ForeBrush, e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10);
        }

        private void PrintTableHeader(PrintPageEventArgs e, int topMargin)
        {
            int colCount = 0;
            while (colCount < _dataGridView.Columns.Count)
            {
                if (_ignoreCols != null && _ignoreCols.Contains(colCount))
                {
                    colCount++;
                    continue;
                }

                DataGridViewColumn gridCol = _dataGridView.Columns[colCount];

                int colLeft = (int)_columnLefts[colCount];
                int colWidth = _columnWidths[colCount];

                e.Graphics.DrawRectangle(BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight));
                e.Graphics.DrawString(gridCol.HeaderText, BoldFont, ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight), _stringFormat);
                colCount++;
            }
        }

        private bool StatPrint(PrintPageEventArgs e, int topMargin, int pageNumHeight)
        {
            topMargin += 10;
            int cellHeight = _dataGridViewStat.Rows[0].Height + 5;
            bool morePagesToPrint = false;

            // Левый отступ
            int leftMargin = e.MarginBounds.Left;
            int[] columnWidths = {270, 90, 90, 90, 90, 140};
            List<int> columnLefts = new List<int>();

            int countWidth = 0;
            while (countWidth < columnWidths.Length)
            {
                columnLefts.Add(leftMargin);
                leftMargin += columnWidths[countWidth];
                countWidth++;
            }

            int needSize = _headerHeight + topMargin + _dataGridViewStat.RowCount * cellHeight;
            if (PrintNumPageInfo)
                needSize += pageNumHeight;

            if (needSize >= e.MarginBounds.Height + e.MarginBounds.Top)
            {
                _newPage = true;
                _firstPage = false;
                morePagesToPrint = true;
                _currentPageCount += 1;
            }
            else
            {
                // Заголовок таблицы
                int colCount = 0;
                while (colCount < _dataGridViewStat.Columns.Count)
                {
                    DataGridViewColumn gridCol = _dataGridViewStat.Columns[colCount];

                    int colLeft = columnLefts[colCount];
                    int colWidth = columnWidths[colCount];

                    e.Graphics.DrawRectangle(BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight));
                    e.Graphics.DrawString(gridCol.HeaderText, BoldFont, ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight), _stringFormat);

                    colCount++;
                }

                topMargin += _headerHeight;

                int row = 0;
                while (row < _statDatas.Count)
                {
                    DataGridViewRow gridRow = _dataGridViewStat.Rows[row];

                    // Высота ячейки
                    cellHeight = gridRow.Height + 5;

                    StatData statData = _statDatas[row];
                    string[] data =
                    {
                        statData.Name, statData.ListCount.ToString(), statData.Warn.ToString(),
                        statData.Error.ToString(), statData.Count.ToString(), statData.Rate.ToString("N2")
                    };


                    // Отрисовка ячеек
                    int cellCount = 0;
                    while (cellCount < gridRow.Cells.Count)
                    {
                        int colLeft = columnLefts[cellCount];
                        int colWidth = columnWidths[cellCount];

                        // Значение
                        e.Graphics.DrawString(data[cellCount], CellFont, ForeBrush, new Rectangle(colLeft, topMargin, colWidth, cellHeight), _stringFormat);
                        // Границы
                        e.Graphics.DrawRectangle(BorderBrush, new Rectangle(colLeft, topMargin, colWidth, cellHeight));
                        cellCount++;
                    }

                    row++;
                    topMargin += cellHeight;
                }

            }

            return morePagesToPrint;
        }
    }
}
