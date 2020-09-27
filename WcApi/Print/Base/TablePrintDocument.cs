using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WcApi.Print.Base
{
    public class TablePrintDocument : PrintDocument
    {
        private readonly int[] _columnWidths;
        private readonly string[] _infos;
        private readonly int[] _ignoreCols;

        private readonly StringFormat _stringFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter
        };

        // ReSharper disable once CollectionNeverUpdated.Local
        private readonly ArrayList _columnLefts = new ArrayList();
        private int _cellHeight;
        private int _row;
        private bool _firstPage;
        private bool _newPage;
        private int _headerHeight = 40;

        public PreviewPageInfo[] GetPreviewPageInfo()
        {
            return ((PreviewPrintController) PrintController).GetPreviewPageInfo();
        }

        protected internal float CheckWidth(PrintPageEventArgs e, Font font, string text)
        {
            return e.MarginBounds.Width - e.Graphics.MeasureString(text, font, e.MarginBounds.Width).Width;
        }

        protected internal float CheckHeight(PrintPageEventArgs e, Font font, string text)
        {
            return e.MarginBounds.Top - e.Graphics.MeasureString(text, font, e.MarginBounds.Width).Height;
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
        }
    }
}
