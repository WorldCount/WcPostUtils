using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wc32Api.Widgets.Buttons
{
    public class WcButton : Button
    {
        private int _borderRadius = 4;
        private float _borderThickness = 1;
        private Color _borderColor = Color.Silver;
        private Color _disableBackColor = Color.Gray;
        private Color _enableBackColor;

        public WcButton()
        {
            DoubleBuffered = true;
            _enableBackColor = BackColor;
        }

        [Category("Appearance")]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                if (_borderRadius == value)
                    return;
                _borderRadius = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public float BorderThickness
        {
            get => _borderThickness;
            set
            {
                if (_borderThickness == value)
                    return;
                _borderThickness = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (_borderColor == value)
                    return;
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color DisabledBackColor
        {
            get => _disableBackColor;
            set
            {
                if (_disableBackColor == value)
                    return;
                _disableBackColor = value;
                Invalidate();
            }
        }

        GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath graphPath = new GraphicsPath();

            graphPath.AddArc(rect.X + m, rect.Y + m, radius, radius, 180, 90);
            graphPath.AddLine(rect.X + r2 + m, rect.Y + m, rect.Width - r2 - m, rect.Y + m);
            graphPath.AddArc(rect.X + rect.Width - radius - m, rect.Y + m, radius, radius, 270, 90);
            graphPath.AddLine(rect.Width - m, rect.Y + r2, rect.Width - m, rect.Height - r2 - m);
            graphPath.AddArc(rect.X + rect.Width - radius - m, rect.Y + rect.Height - radius - m, radius, radius, 0, 90);
            graphPath.AddLine(rect.Width - r2 - m, rect.Height - m, rect.X + r2 - m, rect.Height - m);
            graphPath.AddArc(rect.X + m, rect.Y + rect.Height - radius - m, radius, radius, 90, 90);
            graphPath.AddLine(rect.X + m, rect.Height - r2 - m, rect.X + m, rect.Y + r2 + m);

            graphPath.CloseFigure();
            return graphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath graphPath = GetRoundPath(rect, _borderRadius);

            Region = new Region(graphPath);
            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, graphPath);
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (!Enabled)
            {
                _enableBackColor = BackColor;
            }

            BackColor = Enabled ? _enableBackColor : _disableBackColor;
        }
    }
}
