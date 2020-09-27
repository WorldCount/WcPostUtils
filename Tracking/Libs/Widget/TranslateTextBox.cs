using System;
using System.Drawing;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tracking.Libs.Widget
{
    public class TranslateTextBox : TextBox
    {
        // ReSharper disable once InconsistentNaming
        const int WM_NCPAINT = 0x85;
        // ReSharper disable once InconsistentNaming
        const uint RDW_INVALIDATE = 0x1;
        // ReSharper disable once InconsistentNaming
        const uint RDW_IUPDATENOW = 0x100;
        // ReSharper disable once InconsistentNaming
        const uint RDW_FRAME = 0x400;

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        // ReSharper disable once InconsistentNaming
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
        // ReSharper disable once InconsistentNaming
        private Color borderColor = Color.DimGray;
        // ReSharper disable once InconsistentNaming
        private readonly Dictionary<string, string> Chars = new Dictionary<string, string>
        {
            {"А", "F"}, {"Б", "<"}, {"В", "D"}, {"Г", "U"}, {"Д", "L"}, {"Е", "T"},
            {"Ё", "~"}, {"Ж", ":"}, {"З", "P"}, {"И", "B"}, {"Й", "Q"}, {"К", "R"},
            {"Л", "K"}, {"М", "V"}, {"Н", "Y"}, {"О", "J"}, {"П", "G"}, {"Р", "H"},
            {"С", "C"}, {"Т", "N"}, {"У", "E"}, {"Ф", "A"}, {"Х", "{"}, {"Ц", "W"},
            {"Ч", "X"}, {"Ш", "I"}, {"Щ", "O"}, {"Ъ", "}"}, {"Ы", "S"}, {"Ь", "M"},
            {"Э", "'"}, {"Ю", ">"}, {"Я", "Z"}
         };

        public TranslateTextBox()
        {
            TextChanged += TranslateTextBox_TextChanged;
            Enter += TranslateTextBox_Enter;
        }

        private void TranslateTextBox_Enter(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void TranslateTextBox_TextChanged(object sender, EventArgs e)
        {
            int pos = SelectionStart;
            string source = Text;
          
            foreach (KeyValuePair<string, string> pair in Chars)
            {
                source = source.Replace(pair.Key, pair.Value);
            }
            Text = source;
            SelectionStart = pos;
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero, RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent && BorderStyle == BorderStyle.Fixed3D)
            {
                var hdc = GetWindowDC(Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(BorderColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                ReleaseDC(Handle, hdc);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero, RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
        }
    }
}
