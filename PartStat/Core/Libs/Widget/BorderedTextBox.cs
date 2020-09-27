using System;
using System.Drawing;
using System.Windows.Forms;

namespace PartStat.Core.Libs.Widget
{
    public partial class BorderedTextBox : UserControl
    {
        readonly TextBox _textBox;

        public Color DefaultBorderColor { get; set; }
        public Color FocusedBorderColor { get; set; }

        public BorderedTextBox()
        {
            _textBox = new TextBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(-1, -1),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            Control container = new ContainerControl()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(-1)
            };

            container.Controls.Add(_textBox);
            Controls.Add(container);


        }

        public override string Text
        {
            get => _textBox.Text;
            set => _textBox.Text = value;
        }

        protected override void OnEnter(EventArgs e)
        {
            BackColor = FocusedBorderColor;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            BackColor = DefaultBorderColor;
            base.OnLeave(e);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, _textBox.PreferredHeight, specified);
        }
    }
}
