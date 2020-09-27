using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WcApi.Win32.Controls
{
    public class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        public float Angle { get; set; } = 90F;

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle,
                ColorTop,
                ColorBottom, Angle
            );
            e.Graphics.FillRectangle(brush, ClientRectangle);
            base.OnPaint(e);
        }
    }
}
