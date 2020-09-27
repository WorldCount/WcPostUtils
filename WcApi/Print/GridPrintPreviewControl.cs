using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WcApi.Print.Base;

namespace WcApi.Print
{
    public enum ZoomMode
    {
        ActualSize,
        FullPage,
        PageWidth,
        TwoPages,
        Custom
    }

    public partial class GridPrintPreviewControl : UserControl
    {
        private TablePrintDocument _document;
        private ZoomMode _zoomMode;
        private double _zoom;
        private int _startPage;
        private Brush _backBrush;
        private Point _ptLast;
        private PointF _himm2Pix = new PointF(-1, -1);
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private PageImageList _img = new PageImageList();
        private bool _cancel;
        private bool _rendering;

        public event EventHandler StartPageChanged;
        public event EventHandler PageCountChanged;
        public event EventHandler ZoomModeChanged;

        // ReSharper disable once InconsistentNaming
        private const int MARGIN = 4;
        
        public GridPrintPreviewControl()
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            BackColor = SystemColors.AppWorkspace;
            ZoomMode = ZoomMode.FullPage;
            StartPage = 0;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public TablePrintDocument Document
        {
            get => _document;
            set
            {
                if (value != _document)
                {
                    _document = value;
                    RefreshPreview();
                }
            }
        }

        [DefaultValue(ZoomMode.FullPage)]
        public ZoomMode ZoomMode
        {
            get => _zoomMode;
            set
            {
                if (value != _zoomMode)
                {
                    _zoomMode = value;
                    UpdateScrollBars();
                    OnZoomModeChanged(EventArgs.Empty);
                }
            }
        }

        // ReSharper disable once UnusedMember.Global
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Zoom
        {
            get => _zoom;
            set
            {
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (value != _zoom || ZoomMode != ZoomMode.Custom)
                {
                    ZoomMode = ZoomMode.Custom;
                    _zoom = value;
                    UpdateScrollBars();
                    OnZoomModeChanged(EventArgs.Empty);
                }
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int StartPage
        {
            get => _startPage;
            set
            {
                // validate new setting
                if (value > PageCount - 1) value = PageCount - 1;
                if (value < 0) value = 0;

                // apply new setting
                if (value != _startPage)
                {
                    _startPage = value;
                    UpdateScrollBars();
                    OnStartPageChanged(EventArgs.Empty);
                }
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PageCount => _img.Count;

        [DefaultValue(typeof(Color), "AppWorkspace")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                _backBrush = new SolidBrush(value);
            }
        }

        [Browsable(false)]
        public PageImageList PageImages => _img;

        // ReSharper disable once UnusedMember.Global
        public void Cancel()
        {
            _cancel = true;
        }

        // ReSharper disable once UnusedMember.Global
        public void Print()
        {
            // select pages to print
            PrinterSettings ps = _document.PrinterSettings;
            int first = ps.MinimumPage - 1;
            int last = ps.MaximumPage - 1;
            switch (ps.PrintRange)
            {
                case PrintRange.AllPages:
                    Document.Print();
                    return;
                case PrintRange.CurrentPage:
                    first = last = StartPage;
                    break;
                case PrintRange.Selection:
                    first = last = StartPage;
                    if (ZoomMode == ZoomMode.TwoPages)
                    {
                        last = Math.Min(first + 1, PageCount - 1);
                    }
                    break;
                case PrintRange.SomePages:
                    first = ps.FromPage - 1;
                    last = ps.ToPage - 1;
                    break;
            }

            DocumentPrinter dp = new DocumentPrinter(this, first, last);
            dp.Print();
        }

        public void RefreshPreview()
        {
            if (_document != null)
            {
                _img.Clear();
                PrintController savePrintController = _document.PrintController;

                try
                {
                    _cancel = false;
                    _rendering = true;
                    _document.PrintController = new PreviewPrintController();
                    _document.PrintPage += _document_PrintPage;
                    _document.EndPrint += _document_EndPrint;
                    _document.Print();
                }
                finally
                {
                    _cancel = false;
                    _rendering = false;
                    _document.PrintPage -= _document_PrintPage;
                    _document.EndPrint -= _document_EndPrint;
                    _document.PrintController = savePrintController;
                }
            }

            OnPageCountChanged(EventArgs.Empty);
            UpdatePreview();
            UpdateScrollBars();
        }

        // ReSharper disable once UnusedMember.Global
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsRendering => _rendering;

        protected void OnStartPageChanged(EventArgs e)
        {
            StartPageChanged?.Invoke(this, e);
        }

        protected void OnPageCountChanged(EventArgs e)
        {
            PageCountChanged?.Invoke(this, e);
        }

        protected void OnZoomModeChanged(EventArgs e)
        {
            ZoomModeChanged?.Invoke(this, e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // we're painting it all, so don't call base class
            //base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Image img = GetImage(StartPage);
            if (img != null)
            {
                Rectangle rc = GetImageRectangle(img);
                if (rc.Width > 2 && rc.Height > 2)
                {
                    // adjust for scrollbars
                    rc.Offset(AutoScrollPosition);

                    // render single page
                    if (_zoomMode != ZoomMode.TwoPages)
                    {
                        RenderPage(e.Graphics, img, rc);
                    }
                    else // render two pages
                    {
                        // render first page
                        rc.Width = (rc.Width - MARGIN) / 2;
                        RenderPage(e.Graphics, img, rc);

                        // render second page
                        img = GetImage(StartPage + 1);
                        if (img != null)
                        {
                            // update bounds in case orientation changed
                            rc = GetImageRectangle(img);
                            rc.Width = (rc.Width - MARGIN) / 2;

                            // render second page
                            rc.Offset(rc.Width + MARGIN, 0);
                            RenderPage(e.Graphics, img, rc);
                        }
                    }
                }
            }

            // paint background
            e.Graphics.FillRectangle(_backBrush, ClientRectangle);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            UpdateScrollBars();
            base.OnSizeChanged(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left && AutoScrollMinSize != Size.Empty)
            {
                Cursor = Cursors.NoMove2D;
                _ptLast = new Point(e.X, e.Y);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left && Cursor == Cursors.NoMove2D)
                Cursor = Cursors.Default;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Cursor == Cursors.NoMove2D)
            {
                int dx = e.X - _ptLast.X;
                int dy = e.Y - _ptLast.Y;
                if (dx != 0 || dy != 0)
                {
                    Point pt = AutoScrollPosition;
                    AutoScrollPosition = new Point(-(pt.X + dx), -(pt.Y + dy));
                    _ptLast = new Point(e.X, e.Y);
                }
            }
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Right:
                case Keys.Down:
                case Keys.PageUp:
                case Keys.PageDown:
                case Keys.Home:
                case Keys.End:
                    return true;
            }
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Handled)
                return;

            switch (e.KeyCode)
            {
                // arrow keys scroll or browse, depending on ZoomMode
                case Keys.Left:
                case Keys.Up:
                case Keys.Right:
                case Keys.Down:

                    // browse
                    if (ZoomMode == ZoomMode.FullPage || ZoomMode == ZoomMode.TwoPages)
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.Left:
                            case Keys.Up:
                                StartPage--;
                                break;
                            case Keys.Right:
                            case Keys.Down:
                                StartPage++;
                                break;
                        }
                        break;
                    }

                    // scroll
                    Point pt = AutoScrollPosition;
                    switch (e.KeyCode)
                    {
                        case Keys.Left: pt.X += 20; break;
                        case Keys.Right: pt.X -= 20; break;
                        case Keys.Up: pt.Y += 20; break;
                        case Keys.Down: pt.Y -= 20; break;
                    }
                    AutoScrollPosition = new Point(-pt.X, -pt.Y);
                    break;

                // page up/down browse pages
                case Keys.PageUp:
                    StartPage--;
                    break;
                case Keys.PageDown:
                    StartPage++;
                    break;

                // home/end 
                case Keys.Home:
                    AutoScrollPosition = Point.Empty;
                    StartPage = 0;
                    break;
                case Keys.End:
                    AutoScrollPosition = Point.Empty;
                    StartPage = PageCount - 1;
                    break;

                default:
                    return;
            }

            // if we got here, the event was handled
            e.Handled = true;
        }



        private void _document_PrintPage(object sender, PrintPageEventArgs e)
        {
            SyncPageImages(false);
            if (_cancel)
            {
                e.Cancel = true;
            }
        }

        private void _document_EndPrint(object sender, PrintEventArgs e)
        {
            SyncPageImages(true);
        }

        private void SyncPageImages(bool lastPageReady)
        {
            var pv = (PreviewPrintController) _document.PrintController;
            if (pv != null)
            {
                var pageInfo = pv.GetPreviewPageInfo();
                int count = lastPageReady ? pageInfo.Length : pageInfo.Length - 1;
                for (int i = _img.Count; i < count; i++)
                {
                    var img = pageInfo[i].Image;
                    _img.Add(img);

                    OnPageCountChanged(EventArgs.Empty);

                    if (StartPage < 0) StartPage = 0;
                    if (i == StartPage || i == StartPage + 1)
                    {
                        Refresh();
                    }
                    Application.DoEvents();
                }
            }
        }

        private Image GetImage(int page)
        {
            return page > -1 && page < PageCount ? _img[page] : null;
        }

        private Rectangle GetImageRectangle(Image img)
        {
            // start with regular image rectangle
            Size sz = GetImageSizeInPixels(img);
            Rectangle rc = new Rectangle(0, 0, sz.Width, sz.Height);

            // calculate zoom
            Rectangle rcCli = ClientRectangle;
            switch (_zoomMode)
            {
                case ZoomMode.ActualSize:
                    _zoom = 1;
                    break;
                case ZoomMode.TwoPages:
                    rc.Width *= 2; // << two pages side-by-side
                    goto case ZoomMode.FullPage;
                case ZoomMode.FullPage:
                    double zoomX = (rc.Width > 0) ? rcCli.Width / (double)rc.Width : 0;
                    double zoomY = (rc.Height > 0) ? rcCli.Height / (double)rc.Height : 0;
                    _zoom = Math.Min(zoomX, zoomY);
                    break;
                case ZoomMode.PageWidth:
                    _zoom = (rc.Width > 0) ? rcCli.Width / (double)rc.Width : 0;
                    break;
            }

            // apply zoom factor
            rc.Width = (int)(rc.Width * _zoom);
            rc.Height = (int)(rc.Height * _zoom);

            // center image
            int dx = (rcCli.Width - rc.Width) / 2;
            if (dx > 0) rc.X += dx;
            int dy = (rcCli.Height - rc.Height) / 2;
            if (dy > 0) rc.Y += dy;

            // add some extra space
            rc.Inflate(-MARGIN, -MARGIN);
            if (_zoomMode == ZoomMode.TwoPages)
            {
                rc.Inflate(-MARGIN / 2, 0);
            }

            // done
            return rc;
        }

        private Size GetImageSizeInPixels(Image img)
        {
            // get image size
            SizeF szf = img.PhysicalDimension;

            // if it is a metafile, convert to pixels
            if (img is Metafile)
            {
                // get screen resolution
                if (_himm2Pix.X < 0)
                {
                    using (Graphics g = CreateGraphics())
                    {
                        _himm2Pix.X = g.DpiX / 2540f;
                        _himm2Pix.Y = g.DpiY / 2540f;
                    }
                }

                // convert himetric to pixels
                szf.Width *= _himm2Pix.X;
                szf.Height *= _himm2Pix.Y;
            }

            // done
            return Size.Truncate(szf);
        }

        private void RenderPage(Graphics g, Image img, Rectangle rc)
        {
            // draw the page
            rc.Offset(1, 1);
            g.DrawRectangle(Pens.Black, rc);
            rc.Offset(-1, -1);
            g.FillRectangle(Brushes.White, rc);
            g.DrawImage(img, rc);
            g.DrawRectangle(Pens.Black, rc);

            // exclude cliprect to paint background later
            rc.Width++;
            rc.Height++;
            g.ExcludeClip(rc);
            rc.Offset(1, 1);
            g.ExcludeClip(rc);
        }

        private void UpdateScrollBars()
        {
            Rectangle rc = Rectangle.Empty;
            Image img = GetImage(StartPage);
            if (img != null)
            {
                rc = GetImageRectangle(img);
            }

            Size scrollSize = new Size(0, 0);
            switch (_zoomMode)
            {
                case ZoomMode.PageWidth:
                    scrollSize = new Size(0, rc.Height + 2 * MARGIN);
                    break;
                case ZoomMode.ActualSize:
                case ZoomMode.Custom:
                    scrollSize = new Size(rc.Width + 2 * MARGIN, rc.Height + 2 * MARGIN);
                    break;
            }

            // ReSharper disable once RedundantCheckBeforeAssignment
            if (scrollSize != AutoScrollMinSize)
            {
                AutoScrollMinSize = scrollSize;
            }

            // ready to update
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            // validate current page
            if (_startPage < 0) _startPage = 0;
            if (_startPage > PageCount - 1) _startPage = PageCount - 1;

            // repaint
            Invalidate();
        }
    }
}
