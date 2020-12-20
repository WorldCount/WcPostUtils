using System;
using System.Drawing;
using System.Windows.Forms;

namespace LK.Core.Libs.Widget
{
    public class BorderTextBox : TextBox
    {

        public int BorderHeight
        {
            get => Controls[0].Height;
            set => Controls[0].Height = value;
        }

        public Color EnterColor { get; set; } = Color.Firebrick;
        public Color LeaveColor { get; set; } = Color.SteelBlue;

        public BorderTextBox()
        {
            Wc32Api.Win32.DrawingControl.SetDoubleBuffered(this);

            BorderStyle = BorderStyle.None;
            Controls.Add(new Label { Dock = DockStyle.Bottom });

            Controls[0].BackColor = LeaveColor;
            BorderHeight = 2;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Controls[0].BackColor = LeaveColor;
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Controls[0].BackColor = EnterColor;
        }
    }
}
