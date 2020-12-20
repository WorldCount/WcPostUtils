using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;
using LK.Core;
using WcApi.Net;

namespace LK.Forms
{
    public partial class LoginForm : Form
    {

        #region Private Members

        private string _pin;
        private int _errorCount;
        private string _appText = "Welcome!";

        private Color _windowBorderColor = Color.SeaGreen;

        private bool _focusNum1;
        private bool _focusNum2;
        private bool _focusNum3;
        private bool _focusNum4;

        #endregion


        #region Publuc Member

        public string Secret { set; private get; } = "0000";
        public string AppVersion { set ; private get; }
        public Icon AppIcon { set; get; }
        public Color ControlBorderColor { get; set; } = Color.FromArgb(53, 56, 58);
        public int ControlBorderWidth { get; set; } = 2;
        public int WindowBorderWidth { get; set; } = 2;
        public ButtonBorderStyle WindowsBorderStyle { get; set; } = ButtonBorderStyle.Solid;
        public ButtonBorderStyle ControlBorderStyle { get; set; } = ButtonBorderStyle.Solid;
        public bool Verbose { get; set; }
        public bool LockMode { get; set; } = false;

        public Color WindowBorderColor
        {
            set
            {
                _windowBorderColor = value;
                labelApp.BackColor = value;
            }
            get => _windowBorderColor;
        }

        public string AppText
        {
            get => _appText;
            set
            {
                _appText = value;
                Text = value;
            }
        }

        #endregion

        public LoginForm()
        {
            InitializeComponent();

            labelError.Hide();
            num1.Focus();
        }

        #region Methods

        private async void SendMessage(string msg)
        {
            string host = Dns.GetHostName();
            string user = WindowsIdentity.GetCurrent().Name;
            string ip = Host.GetIp();
            string req = AppVersion != null ? $"<b>{_appText}:</b>  {msg}<pre>Дата: {DateTime.Now} | ПО: {AppVersion} | Хост: {host} | Пользователь: {user} | IP: {ip}</pre>" : $"<b>{_appText}:</b>  {msg}<pre>Дата: {DateTime.Now} | Хост: {host} | Пользователь: {user} | IP: {ip}</pre>";
            await Utils.Telegram.SendMessage(req, ParseMode.HTML);
        }

        private void CheckArgs()
        {

            string[] args = Environment.GetCommandLineArgs();

            if (args.Contains("-noverbose"))
                Verbose = false;

            if (args.Contains("-admin"))
            {
                DialogResult = DialogResult.OK;
                
                if(Verbose)
                    SendMessage("Вход под администратором.");

                Close();
            }
        }

        private void DrawBorder(TextBox tb, Graphics g, bool focus = false)
        {
            tb.BorderStyle = BorderStyle.None;

            Rectangle rect = new Rectangle(tb.Location.X - ControlBorderWidth, tb.Location.Y - ControlBorderWidth,
                tb.Width + ControlBorderWidth * 2, tb.Height + ControlBorderWidth * 2);

            Color color = focus ? _windowBorderColor : ControlBorderColor;

            ControlPaint.DrawBorder(g, rect,
                color, ControlBorderWidth, ControlBorderStyle,
                color, ControlBorderWidth, ControlBorderStyle,
                color, ControlBorderWidth, ControlBorderStyle,
                color, ControlBorderWidth, ControlBorderStyle);
        }

        #endregion

        
        #region Other Handlers

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            if (Verbose)
                SendMessage("Закрытие окна авторизации.");

            Close();
        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            labelError.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(!LockMode)
                CheckArgs();

            labelApp.Text = _appText;
            Icon = AppIcon;

            if (Verbose)
                SendMessage("Запуск программы.");

            Activate();
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(num1, e.Graphics, _focusNum1);
            DrawBorder(num2, e.Graphics, _focusNum2);
            DrawBorder(num3, e.Graphics, _focusNum3);
            DrawBorder(num4, e.Graphics, _focusNum4);


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle);
        }

        #endregion

        
        #region TextBox Handlers

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            labelError.Hide();

            if (num1.Text.Length > 0)
            {
                _pin += num1.Text.Trim();
                num2.Focus();
            }
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            if (num2.Text.Length > 0)
            {
                _pin += num2.Text.Trim();
                num3.Focus();
            }
        }

        private void num3_TextChanged(object sender, EventArgs e)
        {
            if (num3.Text.Length > 0)
            {
                _pin += num3.Text.Trim();
                num4.Focus();
            }
        }

        private void num4_TextChanged(object sender, EventArgs e)
        {
            if (num4.Text.Length > 0)
            {
                _pin += num4.Text.Trim();

                if (_pin == Secret)
                {
                    DialogResult = DialogResult.OK;

                    if (Verbose)
                        SendMessage($"Удачный вход, ПИН: {_pin}");

                    Close();
                }
                else
                {
                    _errorCount += 1;

                    if (_errorCount >= 3)
                    {
                        DialogResult = DialogResult.Cancel;

                        if (Verbose)
                            SendMessage($"Закрытие приложения после 3х неудачных попыток ввода ПИН: {_pin}.");

                        Close();
                    }

                    if (Verbose)
                        SendMessage($"Неудачная попытка входа, ПИН: {_pin}.");

                    num1.Text = num2.Text = num3.Text = num4.Text = "";
                    _pin = "";

                    labelError.Text = $"Неверный ПИН! Попытка {_errorCount} из 3.";
                    labelError.Show();
                    num1.Focus();
                }
            }
        }

        private void num1_Enter(object sender, EventArgs e)
        {
            _focusNum1 = true;
            Refresh();
        }

        private void num1_Leave(object sender, EventArgs e)
        {
            _focusNum1 = false;
            Refresh();
        }

        private void num2_Enter(object sender, EventArgs e)
        {
            _focusNum2 = true;
            Refresh();
        }

        private void num2_Leave(object sender, EventArgs e)
        {
            _focusNum2 = false;
            Refresh();
        }

        private void num3_Enter(object sender, EventArgs e)
        {
            _focusNum3 = true;
            Refresh();
        }

        private void num3_Leave(object sender, EventArgs e)
        {
            _focusNum3 = false;
            Refresh();
        }

        private void num4_Enter(object sender, EventArgs e)
        {
            _focusNum4 = true;
            Refresh();
        }

        private void num4_Leave(object sender, EventArgs e)
        {
            _focusNum4 = false;
            Refresh();
        }

        #endregion

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(255, 0, 223, 223);
            ButtonBorderStyle border = ButtonBorderStyle.Dashed;

            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, panelInfo.ClientRectangle,
                borderColor, 1, ButtonBorderStyle.None,
                borderColor, 1, border,
                borderColor, 1, ButtonBorderStyle.None,
                borderColor, 1, border);
        }
    }
}
