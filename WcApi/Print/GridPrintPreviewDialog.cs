using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;
using WcApi.Print.Base;

namespace WcApi.Print
{
    public partial class GridPrintPreviewDialog : Form
    {
        private TablePrintDocument _document;

        public GridPrintPreviewDialog() : this(null)
        {
        }

        public GridPrintPreviewDialog(Control parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
                Size = parentForm.Size;
        }

        public TablePrintDocument Document
        {
            get => _document;
            set
            {
                if (_document != null)
                {
                    _document.BeginPrint -= _document_BeginPrint;
                    _document.EndPrint -= _document_EndPrint;
                }

                _document = value;

                if (_document != null)
                {
                    _document.BeginPrint += _document_BeginPrint;
                    _document.EndPrint += _document_EndPrint;
                }

                if (Visible)
                    preview.Document = Document;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            preview.Document = Document;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (preview.IsRendering && !e.Cancel)
            {
                preview.Cancel();
            }
        }

        private void _document_EndPrint(object sender, PrintEventArgs e)
        {
            btnCancel.Text = "Закрыть";
            btnPrint.Enabled = btnPageSetup.Enabled = true;
        }

        private void _document_BeginPrint(object sender, PrintEventArgs e)
        {
            btnCancel.Text = "Отмена";
            btnPrint.Enabled = btnPageSetup.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.AllowSomePages = true;
                printDialog.AllowSelection = true;
                printDialog.UseEXDialog = true;
                printDialog.Document = Document;

                PrinterSettings ps = printDialog.PrinterSettings;
                ps.MinimumPage = ps.FromPage = 1;
                ps.MaximumPage = ps.ToPage = preview.PageCount;

                if(printDialog.ShowDialog(this) == DialogResult.OK)
                    preview.Print();
            }
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            using (PageSetupDialog pageSetupDialog = new PageSetupDialog())
            {
                pageSetupDialog.Document = Document;
                if (pageSetupDialog.ShowDialog(this) == DialogResult.OK)
                    preview.RefreshPreview();
            }
        }

        private void btnZoom_ButtonClick(object sender, EventArgs e)
        {
            preview.ZoomMode = preview.ZoomMode == ZoomMode.ActualSize ? ZoomMode.FullPage : ZoomMode.ActualSize;
        }

        private void btnZoom_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == itemActualSize)
            {
                preview.ZoomMode = ZoomMode.ActualSize;
            }
            else if (e.ClickedItem == itemFullPage)
            {
                preview.ZoomMode = ZoomMode.FullPage;
            }
            else if (e.ClickedItem == itemPageWidth)
            {
                preview.ZoomMode = ZoomMode.PageWidth;
            }
            else if (e.ClickedItem == itemTwoPages)
            {
                preview.ZoomMode = ZoomMode.TwoPages;
            }
            if (e.ClickedItem == item10)
            {
                preview.Zoom = .1;
            }
            else if (e.ClickedItem == item100)
            {
                preview.Zoom = 1;
            }
            else if (e.ClickedItem == item150)
            {
                preview.Zoom = 1.5;
            }
            else if (e.ClickedItem == item200)
            {
                preview.Zoom = 2;
            }
            else if (e.ClickedItem == item25)
            {
                preview.Zoom = .25;
            }
            else if (e.ClickedItem == item50)
            {
                preview.Zoom = .5;
            }
            else if (e.ClickedItem == item500)
            {
                preview.Zoom = 5;
            }
            else if (e.ClickedItem == item75)
            {
                preview.Zoom = .75;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            preview.StartPage = 0;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            preview.StartPage--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            preview.StartPage++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            preview.StartPage = preview.PageCount - 1;
        }

        private void txtStartPage_Enter(object sender, EventArgs e)
        {
            txtStartPage.SelectAll();
        }

        private void txtStartPage_Validating(object sender, CancelEventArgs e)
        {
            CommitPageNumber();
        }

        private void txtStartPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == (char)13)
            {
                CommitPageNumber();
                e.Handled = true;
            }
            else if (c > ' ' && !char.IsDigit(c))
            {
                e.Handled = true;
            }
        }

        private void CommitPageNumber()
        {
            int page;
            if (int.TryParse(txtStartPage.Text, out page))
            {
                preview.StartPage = page - 1;
            }
        }

        private void preview_StartPageChanged(object sender, EventArgs e)
        {
            int page = preview.StartPage + 1;
            txtStartPage.Text = page.ToString();
        }

        private void preview_PageCountChanged(object sender, EventArgs e)
        {
            Update();
            Application.DoEvents();
            lblPageCount.Text = $"из {preview.PageCount}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(preview.IsRendering)
                preview.Cancel();
            else
                Close();
        }
    }
}
