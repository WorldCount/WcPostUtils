using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wc32Api.Widgets.Buttons
{
    public class WcToggleButton : CheckBox
    {
        #region Private Fields

        private Color _onBackColor = Color.SeaGreen;
        private Color _onToggleColor = Color.WhiteSmoke;
        private Color _offBackColor = Color.Firebrick;
        private Color _offToggleColor = Color.Gainsboro;
        private bool _solidStyle = true;

        private Color _disableBackColor = Color.DimGray;
        private Color _disableToggleColor = Color.Gray;

        #endregion

        public WcToggleButton()
        {
            MinimumSize = new Size(45, 22);
        }

        #region Properties

        [Category("WcToggleButton - Appearance")]
        public Color OnBackColor
        {
            get => _onBackColor;
            set
            {
                _onBackColor = value;
                Invalidate();
            }
        }

        [Category("WcToggleButton - Appearance")]
        public Color OnToggleColor
        {
            get => _onToggleColor;
            set
            {
                _onToggleColor = value;
                Invalidate();
            }
        }

        [Category("WcToggleButton - Appearance")]
        public Color OffBackColor
        {
            get => _offBackColor;
            set
            {
                _offBackColor = value;
                Invalidate();
            }
        }

        [Category("WcToggleButton - Appearance")]
        public Color OffToggleColor
        {
            get => _offToggleColor;
            set
            {
                _offToggleColor = value;
                Invalidate();
            }
        }

        public override string Text
        {
            get => base.Text;
            set
            {

            }
        }

        [Category("WcToggleButton - Appearance")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get => _solidStyle;
            set
            {
                _solidStyle = value;
                Invalidate();
            }
        }

        [Category("WcToggleButton - Appearance Disable")]
        public Color DisableBackColor
        {
            get => _disableBackColor;
            set
            {
                _disableBackColor = value;
                Invalidate();
            }
        }

        [Category("WcToggleButton - Appearance Disable")]
        public Color DisableToggleColor
        {
            get => _disableToggleColor;
            set
            {
                _disableToggleColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Private Methods

        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        #endregion

        #region Overriddes Methods

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = Height - 5;

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(Parent.BackColor);

            Color toggleColor;
            Color backColor;

            if (Checked)
            {
                toggleColor = _onToggleColor;
                backColor = _onBackColor;
            }
            else
            {
                toggleColor = _offToggleColor;
                backColor = _offBackColor;
            }

            if (!Enabled)
            {
                toggleColor = _disableToggleColor;
                backColor = _disableBackColor;
            }

            if (Checked)
            {
                // Draw control surface
                if (_solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(backColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(backColor, 2), GetFigurePath());

                // Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(toggleColor), new Rectangle(Width - Height, 2, toggleSize, toggleSize));
            }
            else
            {
                // Draw control surface
                if (_solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(backColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(backColor, 2), GetFigurePath());

                // Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(toggleColor), new Rectangle(3, 2, toggleSize, toggleSize));
            }
        }

        #endregion
    }
}
