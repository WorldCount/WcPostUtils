using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wc32Api.Widgets.Buttons
{
    public class WcButton : Button
    {
        #region Fields

        private int _borderSize = 0;
        private float _borderRadius = 6;

        private Color _borderColor = Color.Silver;
        private Color _enableBackColor = Color.SeaGreen;

        private Color _disableBorderColor = Color.Silver;
        private Color _disableBackColor = Color.DimGray;

        private SmoothingMode _smoothingMode = SmoothingMode.AntiAlias;

        #endregion


        public WcButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            // ReSharper disable once VirtualMemberCallInConstructor
            BackColor = _enableBackColor;
            // ReSharper disable once VirtualMemberCallInConstructor
            ForeColor = Color.White;
            MouseOverBackColor = Color.FromArgb(53, 56, 58);

            Padding = new Padding(3, 0, 3, 0);

            Resize += WcButton_Resize;
        }

        #region Public Properties

        [Category("WcButton")]
        public SmoothingMode SmoothingMode
        {
            get => _smoothingMode;
            set
            {
                _smoothingMode = value;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = value;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public float BorderRadius
        {
            get => _borderRadius;
            set
            {
                if (value <= Height)
                    _borderRadius = value;
                else
                    _borderRadius = Height;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public Color DisableBorderColor
        {
            get => _disableBorderColor;
            set
            {
                _disableBorderColor = value;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public Color BackgroundColor
        {
            get => BackColor;
            set
            {
                BackColor = value;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public Color DisableBackgroundColor
        {
            get => _disableBackColor;
            set
            {
                _disableBackColor = value;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public Color TextColor
        {
            get => ForeColor;
            set
            {
                ForeColor = value;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public Color MouseOverBackColor
        {
            get => FlatAppearance.MouseOverBackColor;
            set
            {
                FlatAppearance.MouseOverBackColor = value;
                Invalidate();
            }
        }

        [Category("WcButton")]
        public Color MouseDownBackColor
        {
            get => FlatAppearance.MouseDownBackColor;
            set
            {
                FlatAppearance.MouseDownBackColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Methods

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = _smoothingMode;

            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBorder = new RectangleF(1, 1, Width - 0.8F, Height - 1);

            if (_borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - 1F))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Button surface
                    Region = new Region(pathSurface);
                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    // Button border
                    if (_borderSize >= 1)
                        // Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            // Normal button
            else
            {
                Region = new Region(rectSurface);
                if (_borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(_borderColor, _borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        #endregion

        #region Events

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += Container_BackColorChanged;
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                Invalidate();
        }

        private void WcButton_Resize(object sender, EventArgs e)
        {
            if (_borderRadius > Height)
                BorderRadius = Height;
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (!Enabled)
            {
                _enableBackColor = BackColor;
                _borderColor = BorderColor;
            }

            if (Enabled)
            {
                BackgroundColor = _enableBackColor;
                BorderColor = _borderColor;
            }
            else
            {
                BackgroundColor = _disableBackColor;
                BorderColor = _disableBorderColor;
            }
        }

        #endregion

    }
}
