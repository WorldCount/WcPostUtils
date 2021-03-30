using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wc32Api.Widgets.Nets
{
    public partial class ConnectWidget : UserControl
    {
        private Color _defaultStatusColor = Color.FromArgb(255, 170, 178, 189);

        public delegate Task<bool> CallBack();

        public Color BorderColor { get; set; } = Color.Gray;
        public int BorderWidth { get; set; } = 1;
        public new ButtonBorderStyle BorderStyle { get; set; } = ButtonBorderStyle.Dashed;

        public Color StatusBorderColor { get; set; } = Color.FromArgb(255, 101, 112, 128);
        public int StatusBorderWidth { get; set; } = 1;
        public ButtonBorderStyle StatusBorderStyle { get; set; } = ButtonBorderStyle.Solid;

        
        public Color SuccessStatusColor { get; set; } = Color.SeaGreen;
        public Color ErrorStatusColor { get; set; } = Color.Firebrick;

        public Color StatusBackColor
        {
            get => labelStatus.BackColor;
            set
            {
                _defaultStatusColor = value;
                labelStatus.BackColor = value;
            }
        }

        public string Message
        {
            get => labelMessage.Text;
            set => labelMessage.Text = value;
        }

        public Color MessageColor
        {
            get => labelMessage.ForeColor;
            set => labelMessage.ForeColor = value;
        }

        public CallBack CheckStatus = null;

        public ConnectWidget()
        {
            InitializeComponent();

            Win32.DrawingControl.SetDoubleBuffered(this);
        }

        private void labelStatus_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, labelStatus.ClientRectangle,
                StatusBorderColor, StatusBorderWidth, StatusBorderStyle,
                StatusBorderColor, StatusBorderWidth, StatusBorderStyle,
                StatusBorderColor, StatusBorderWidth, StatusBorderStyle,
                StatusBorderColor, StatusBorderWidth, StatusBorderStyle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                BorderColor, BorderWidth, BorderStyle,
                BorderColor, BorderWidth, BorderStyle,
                BorderColor, BorderWidth, BorderStyle,
                BorderColor, BorderWidth, BorderStyle);
        }

        private async void btnCheck_Click(object sender, System.EventArgs e)
        {
            btnCheck.Enabled = false;

            if (CheckStatus != null)
            {
                labelStatus.BackColor = _defaultStatusColor;

                bool res = await CheckStatus();
                labelStatus.BackColor = res ? SuccessStatusColor : ErrorStatusColor;
            }

            btnCheck.Enabled = true;
        }
    }
}
