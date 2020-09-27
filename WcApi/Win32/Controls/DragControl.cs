using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WcApi.Win32.Controls
{
    class DragControl : Component
    {
        private Control _handleControl;

        public Control SelectControl
        {
            get { return _handleControl; }
            set
            {
                _handleControl = value;
                _handleControl.MouseDown += DragForm_MouseDown;
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if (flag && e.Clicks != 2)
            {
                ReleaseCapture();
                // ReSharper disable once PossibleNullReferenceException
                SendMessage(SelectControl.FindForm().Handle, msg: 161, wParam: 2, lParam: 0);
            }
        }
    }
}
