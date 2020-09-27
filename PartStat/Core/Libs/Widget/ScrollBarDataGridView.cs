using System;
using System.Drawing;
using System.Windows.Forms;

namespace PartStat.Core.Libs.Widget
{
    public class ScrollBarDataGridView : DataGridView
    {
        private const int CaptionHeight = 21;
        private const int BorderWidth = 2;

        public ScrollBarDataGridView() : base()
        {
            VerticalScrollBar.Visible = true;
            VerticalScrollBar.VisibleChanged += VerticalScrollBar_VisibleChanged;
        }

        private void VerticalScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            if (!VerticalScrollBar.Visible)
            {
                int width = VerticalScrollBar.Width;

                VerticalScrollBar.Location = new Point(ClientRectangle.Width - width - BorderWidth, CaptionHeight);
                VerticalScrollBar.Size = new Size(width, ClientRectangle.Height - CaptionHeight - BorderWidth);

                VerticalScrollBar.Show();
            }
        }
    }
}
