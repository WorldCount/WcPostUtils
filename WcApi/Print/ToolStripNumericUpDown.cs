using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WcApi.Print
{
	[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
	public class ToolStripNumericUpDown : ToolStripControlHost
	{
		private FlowLayoutPanel _controlPanel = null;
		private NumericUpDown _num = null;
		private Label _txt = null;

		public event EventHandler ValueChanged
		{
			add => _num.ValueChanged += value;
            remove => _num.ValueChanged -= value;
        }

		[DefaultValue(true)]
		public bool TextVisible
		{
			get => _txt.Visible;
            set
			{
				_txt.Visible = value;
				UpdateAutoSize();
			}
		}

		public override string Text
		{
			get => _txt.Text;
            set
			{
				_txt.Text = value;
				UpdateAutoSize();
			}
		}

		public override Size Size
		{
			get => base.Size;
            set
			{
				if (base.Size != value && !this.AutoSize)
				{
					base.Size = value;
					OnSizeChanged();
				}
			}
		}

		[DefaultValue(50)]
		public int NumericWidth
		{
			get => _num.Width;
            set
			{
				_num.Width = value;
				UpdateAutoSize();
			}
		}

		[DefaultValue(typeof(decimal), "100")]
		public decimal Maximum
		{
			get => _num.Maximum;
            set => _num.Maximum = value;
        }

		[DefaultValue(typeof(decimal), "0")]
		public decimal Minimum
		{
			get => this._num.Minimum;
            set => _num.Minimum = value;
        }

		[DefaultValue(typeof(decimal), "0")]
		public decimal Value
		{
			get => _num.Value;
            set => this._num.Value = value;
        }

		[DefaultValue(1)]
		public int DecimalPlaces
		{
			get => _num.DecimalPlaces;
            set => _num.DecimalPlaces = value;
        }

		[DefaultValue(typeof(decimal), "1")]
		public decimal Increment
		{
			get => _num.Increment;
            set => _num.Increment = value;
        }

		[DefaultValue(false)]
		public bool Hexadecimal
		{
			get => _num.Hexadecimal;
            set => _num.Hexadecimal = value;
        }

		[DefaultValue(typeof(HorizontalAlignment), "Center")]
		public HorizontalAlignment NumericTextAlign
		{
			get => _num.TextAlign;
            set => _num.TextAlign = value;
        }
		public Color NumBackColor
		{
			get => _num.BackColor;
            set => _num.BackColor = value;
        }

		public ToolStripNumericUpDown() : base(new FlowLayoutPanel())
		{
			// Set up the FlowLayouPanel.
			_controlPanel = (FlowLayoutPanel)Control;
			_controlPanel.BackColor = Color.Transparent;
			_controlPanel.WrapContents = false;
			_controlPanel.AutoSize = true;
			_controlPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

			// Add child controls.
			_num = new NumericUpDown();
            _num.Width = 50;
            _num.Height = _num.PreferredHeight;
            _num.Margin = new Padding(0, 1, 3, 1);
            _num.Value = 0;
            _num.Minimum = 0;
            _num.Maximum = 100;
            _num.DecimalPlaces = 0;
            _num.Increment = 1;
            _num.Hexadecimal = false;
            _num.TextAlign = HorizontalAlignment.Center;

                _txt = new Label
            {
                Text = "NumericUpDown",
                TextAlign = ContentAlignment.MiddleRight,
                AutoSize = true,
                Dock = DockStyle.Left
            };

            _controlPanel.Controls.Add(_txt);
			_controlPanel.Controls.Add(_num);
		}

		protected void UpdateAutoSize()
		{
			if (!AutoSize) return;
			AutoSize = false;
			AutoSize = true;
		}
		protected void OnSizeChanged()
		{
			if (_num != null && _controlPanel != null && _txt != null)
			{
				_num.Width = _controlPanel.ClientSize.Width - _txt.Width - _controlPanel.Margin.Horizontal - _controlPanel.Margin.Horizontal;
			}
		}
	}
}
