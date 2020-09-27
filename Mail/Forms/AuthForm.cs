using System;
using System.Drawing;
using System.Windows.Forms;
using Mail.Libs.Objects;
using WcApi.Keyboard;

namespace Mail.Forms
{
    public partial class AuthForm : Form
    {
        // ReSharper disable once InconsistentNaming
        private readonly string AuthFile;
        // ReSharper disable once InconsistentNaming
        private Color borderColor = Color.White;

        public AuthForm(GeneralForm parent)
        {
            InitializeComponent();
            AuthFile = parent.AuthFile;
            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} : Авторизация";

            UpdateLangFlag();
            LoadAuth();
        }

        /// <summary>
        /// Обновление флага раскладки
        /// </summary>
        private void UpdateLangFlag()
        {
            string lang = Keyboard.GetKeyboardLayoutName();
            Color backColor;

            if (lang == "RU")
            {
                backColor = Color.FromArgb(255, 139, 131, 134);
                borderColor = Color.DimGray;
            }
            else
            {
                backColor = Color.Firebrick;
                borderColor = Color.FromArgb(255, 128, 0, 0);
            }

            flagLogin.Text = lang;
            flagLogin.BackColor = backColor;
            flagPassword.Text = lang;
            flagPassword.BackColor = backColor;
            flagMail.Text = lang;
            flagMail.BackColor = backColor;
            flagExchange.Text = lang;
            flagExchange.BackColor = backColor;
        }

        /// <summary>
        /// Загрузка данных авторизации
        /// </summary>
        private void LoadAuth()
        {
            Auth auth = Auth.Load(AuthFile);
            if (auth != null)
            {
                tbLogin.Text = auth.Login;
                tbPassword.Text = auth.Password;
                tbMail.Text = auth.Email;
                tbExchange.Text = auth.ExchangeUrl;
            }
        }

        /// <summary>
        /// Сохранение данных авторизации
        /// </summary>
        private void SaveAuth()
        {
            Auth auth = new Auth(tbLogin.Text.Trim(), tbPassword.Text.Trim(), tbMail.Text.Trim(), tbExchange.Text.Trim());

            auth.Save(AuthFile);
        }

        #region Обработчики

        // Кнопка: Отмена
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Кнопка: Сохранить
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAuth();
            Close();
        }

        // Форма: Смена языка ввода
        private void AuthForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            UpdateLangFlag();
        }

        // Форма: нажатие клавиш
        private void AuthForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }

            // Нажатие Esc
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }

        // Флаг: Отрисовка виджета
        private void flag_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Label)sender).DisplayRectangle, borderColor, ButtonBorderStyle.Solid);
        }

        #endregion
    }
}
