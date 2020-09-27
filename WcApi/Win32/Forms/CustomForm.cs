using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WcApi.Win32.Forms
{
    public partial class CustomForm : Form
    {
        // ReSharper disable once InconsistentNaming
        const UInt32 WM_NCHITTEST = 0x0084;
        // ReSharper disable once InconsistentNaming
        const UInt32 WM_MOUSEMOVE = 0x0200;

        // ReSharper disable once InconsistentNaming
        const UInt32 HTLEFT = 10;
        // ReSharper disable once InconsistentNaming
        const UInt32 HTRIGHT = 11;
        // ReSharper disable once InconsistentNaming
        const UInt32 HTBOTTOMRIGHT = 17;
        // ReSharper disable once InconsistentNaming
        const UInt32 HTBOTTOM = 15;
        // ReSharper disable once InconsistentNaming
        const UInt32 HTBOTTOMLEFT = 16;
        // ReSharper disable once InconsistentNaming
        const UInt32 HTTOP = 12;
        // ReSharper disable once InconsistentNaming
        const UInt32 HTTOPLEFT = 13;
        // ReSharper disable once InconsistentNaming
        const UInt32 HTTOPRIGHT = 14;

        // ReSharper disable once InconsistentNaming
        const int RESIZE_HANDLE_SIZE = 10;

        public Color BorderColor { get; set; } = Color.FromArgb(37, 37, 38);

        public CustomForm()
        {
            InitializeComponent();
            CheckWinState();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void WndProc(ref Message m)
        {
            
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
            {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
        };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        private void CustomForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(BorderColor), 2), 1, 1, Width - 2, Height - 2);
        }

        private void CheckWinState()
        {
            btnState.Image = WindowState == FormWindowState.Maximized ? Properties.Resources.fullscreen_exit : Properties.Resources.fullscreen_enter;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                btnState.PerformClick();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            CheckWinState();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(new SolidBrush(BorderColor), 4), 0, panelTop.Height, panelTop.Width, panelTop.Height);
        }
    }
}
