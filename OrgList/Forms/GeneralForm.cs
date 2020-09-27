using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OrgList.Forms
{
    public partial class GeneralForm : Form
    {
        public readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        private readonly Color _defaultStatusColor;

        public GeneralForm()
        {
            InitializeComponent();

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            if (!Directory.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";
            _defaultStatusColor = statusText.ForeColor;
        }

        #region Настройки окна

        // Перенос настроек предыдущей сборки в новую
        private void UpgradeSettings()
        {
            Properties.Settings.Default.Upgrade();
            WinConf.Default.Upgrade();
            Properties.Settings.Default.NeedUpgrade = false;
            Properties.Settings.Default.Save();
        }

        // Сохранение настроек
        private void SavePos()
        {
            WinConf.Default.GeneralFormState = WindowState;

            if (WindowState == FormWindowState.Normal)
            {
                WinConf.Default.GeneralFormLocation = Location;
                WinConf.Default.GeneralFormSize = Size;
            }
            else
            {
                // Если форма свернута или развернута
                WinConf.Default.GeneralFormLocation = RestoreBounds.Location;
                WinConf.Default.GeneralFormSize = RestoreBounds.Size;
            }

            WinConf.Default.Save();
        }

        // Загрузка настроек
        private void LoadPos()
        {
            int width = WinConf.Default.GeneralFormSize.Width;
            int height = WinConf.Default.GeneralFormSize.Height;

            if (width == 0 || height == 0)
            {
                // Первый старт
            }
            else
            {
                WindowState = WinConf.Default.GeneralFormState;

                // Нам не нужно свернутое окно при запуске
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;

                Location = WinConf.Default.GeneralFormLocation;
                Size = WinConf.Default.GeneralFormSize;
            }

            // Восстановление положения окна
            string[] args = Environment.GetCommandLineArgs();
            if (args.Contains("-restore"))
                CenterToScreen();
        }

        #endregion

        #region Сообщения

        /// <summary>
        /// Отправляет сообщение в статус
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        public void SendStatucMessage(string message, Color color)
        {
            timerStatus.Stop();
            statusText.ForeColor = color;
            statusText.Text = message;
            timerStatus.Start();
        }

        // Сообщение: обычное
        // ReSharper disable once UnusedMember.Global
        public void NormalMessage(string message)
        {
            SendStatucMessage(message, _defaultStatusColor);
        }

        // Сообщение: успех
        // ReSharper disable once UnusedMember.Global
        public void SuccessStatusMessage(string message)
        {
            SendStatucMessage(message, Color.Green);
        }

        // Сообщение: ошибка
        // ReSharper disable once UnusedMember.Global
        public void ErrorStatusMessage(string message)
        {
            SendStatucMessage(message, Color.Red);
        }

        // Сообщение: предупреждение
        // ReSharper disable once UnusedMember.Global
        public void WarningMessage(string message)
        {
            SendStatucMessage(message, Color.DarkOrange);
        }

        // Сообщение: информация
        // ReSharper disable once UnusedMember.Global
        public void InfoMessage(string message)
        {
            SendStatucMessage(message, Color.DodgerBlue);
        }

        #endregion

        #region Обработчики

        // Форма: Загружена
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadPos();
        }

        // Форма: Закрыта
        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePos();
        }

        // Форма: Нажатие клавиш
        private void GeneralForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        // Таймер
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.Text = "";
            statusText.ForeColor = _defaultStatusColor;
        }

        #endregion

        
    }
}
