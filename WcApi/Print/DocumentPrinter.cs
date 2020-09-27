using System.Drawing;
using System.Drawing.Printing;

namespace WcApi.Print
{
    public class DocumentPrinter : PrintDocument
    {
        private readonly int _first;
        private readonly int _last;
        private int _index;
        private readonly PageImageList _imgList;

        public DocumentPrinter(GridPrintPreviewControl preview, int first, int last)
        {
            // save page range and image list
            _first = first;
            _last = last;
            _imgList = preview.PageImages;

            // copy page and printer settings from original document
            DefaultPageSettings = preview.Document.DefaultPageSettings;
            PrinterSettings = preview.Document.PrinterSettings;
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            _index = _first;
        }
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Display;
            e.Graphics.DrawImage(_imgList[_index++], e.PageBounds);
            e.HasMorePages = _index <= _last;
        }
    }
}
