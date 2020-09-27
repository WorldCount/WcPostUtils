using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;
using WcApi.Print.Base;

namespace WcApi.Print
{
    public class GridPrintDocument : TablePrintDocument
    {
        private readonly DataGridView _dataGridView;
        private readonly int[] _columnWidths;
        private readonly string[] _infos;

        private readonly StringFormat _stringFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter
        };

        private readonly ArrayList _columnLefts = new ArrayList();
        private int _cellHeight;
        private int _row;
        private bool _firstPage;
        private bool _newPage;
        private int _headerHeight = 40;

        public GridPrintDocument(DataGridView dataGridView, int[] columnWidths, string[] infos = null)
        {
            _dataGridView = dataGridView;
            _columnWidths = columnWidths;
            _infos = infos;

            DefaultPageSettings.Margins = new Margins(10, 10, 40, 40);
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            base.OnBeginPrint(e);

            try
            {
                _columnLefts.Clear();
                _row = 0;
                _firstPage = true;
                _newPage = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Отступ после информации
                int infoTopMargin = 0;
                // Цвет таблицы и основного текста
                SolidBrush headBrush = new SolidBrush(Color.White);
                SolidBrush borderBrush = new SolidBrush(Color.Black);

                Font boldFont = new Font("Segoe Ui", 10, FontStyle.Bold);
                Font fontCell = new Font("Segoe Ui", 9, FontStyle.Regular);

                if (_firstPage)
                {
                    foreach (int width in _columnWidths)
                    {
                        _columnLefts.Add(leftMargin);
                        leftMargin += width;
                    }

                    string date = $"Сформировано: {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";

                    if (_infos != null)
                    {
                        foreach (string dataInfo in _infos)
                        {
                            e.Graphics.DrawString(dataInfo, fontCell, borderBrush, e.MarginBounds.Left, e.MarginBounds.Top - CheckHeight(e, fontCell, dataInfo) + infoTopMargin);
                            infoTopMargin += 20;
                        }
                    }

                    // Печать Даты
                    e.Graphics.DrawString(date, fontCell, borderBrush, e.MarginBounds.Left + CheckWidth(e, fontCell, date) - 50, e.MarginBounds.Top - CheckHeight(e, fontCell, date));
                }

                while (_row <= _dataGridView.Rows.Count - 1)
                {
                    DataGridViewRow gridRow = _dataGridView.Rows[_row];
                    // Высота ячейки
                    _cellHeight = gridRow.Height + 5;

                    int count = 0;
                    // Проверка, позволяет ли текущая страница напечатать эту строку
                    if (topMargin + _cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        _newPage = true;
                        _firstPage = false;
                        morePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (_newPage)
                        {
                            // Заголовок таблицы
                            if (_firstPage)
                            {
                                topMargin = e.MarginBounds.Top + infoTopMargin + 10;
                            }
                            else
                                topMargin = e.MarginBounds.Top;

                            foreach (DataGridViewColumn gridCol in _dataGridView.Columns)
                            {

                                int colLeft = (int)_columnLefts[count];
                                int colWidth = _columnWidths[count];

                                e.Graphics.FillRectangle(headBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight));
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(colLeft, topMargin, colWidth, _headerHeight));
                                e.Graphics.DrawString(gridCol.HeaderText, boldFont, borderBrush, new RectangleF(colLeft, topMargin, colWidth, _headerHeight), _stringFormat);
                                count++;
                            }

                            _newPage = false;
                            topMargin += _headerHeight;
                        }

                        count = 0;

                        // Отрисовка ячеек
                        foreach (DataGridViewCell cell in gridRow.Cells)
                        {
                            int colLeft = (int)_columnLefts[count];
                            int colWidth = _columnWidths[count];

                            // Значение
                            if (cell?.Value != null)
                                e.Graphics.DrawString(cell.Value.ToString(), fontCell, borderBrush, new RectangleF(colLeft, topMargin, colWidth, _cellHeight), _stringFormat);
                            // Границы
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(colLeft, topMargin, colWidth, _cellHeight));
                            count++;
                        }
                    }

                    _row++;
                    topMargin += _cellHeight;
                }

                e.HasMorePages = morePagesToPrint;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
