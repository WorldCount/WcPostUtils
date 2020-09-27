using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace WcApi.Win32.Forms
{
    public partial class LicenseForm : Form
    {
        private readonly string _key;
        private string _licenseKey;
        private readonly string _appName;
        private readonly string _appVersion;
        private readonly string _email;
        private Outlook.Application _outlookApp;

        public string LicenseKey => _licenseKey;

        public LicenseForm(string licenseKey, string key, string appName, string appVersion, string email, Icon icon = null)
        {
            InitializeComponent();

            _licenseKey = licenseKey;
            _key = key;
            _appName = appName;
            _appVersion = appVersion;
            _email = email;

            labelTitle.Text = $"{_appName} {_appVersion}";
            linkLabelMail.Text = _email;
            //textBoxLicenseKey.Text = _licenseKey;

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{_appName} : Лицензия";

            if(icon != null)
                Icon = icon;
        }

        public void LicenseText(string text)
        {
            labelInfo.Text = text;
        }

        public void LicensePicture(Bitmap image)
        {
            pictureBox.Image = image;
        }

        private Outlook.Application GetOutlookApp()
        {
            Outlook.Application app = null;
            
            try
            {
                app = new Outlook.Application();
            }
            catch
            {
                // Пропуск
            }

            return app;
        }

        private string CreateMailBody(string s = "\n")
        {
            string host = Dns.GetHostName();
            string user = WindowsIdentity.GetCurrent().Name;
            string text = $"Прошу предоставить ключ лицензии на ПО '{_appName} {_appVersion}' для личного пользования.{s}Мой App ID: {_key}{s}{s}";
            string info = $"{text}{s}Данные для лицензии:{s}------------------{s}Дата: {DateTime.Now:dd.MM.yyyy в HH:mm:ss}{s}Хост: {host}{s}Пользователь: {user}{s}Ip-адрес: {Net.Host.GetIp()}{s}-------------------{s}{s}";
            return info;
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            WebRequest.DefaultWebProxy = null;

            textBoxId.Text = _key;
            labelToday.Text = DateTime.Today.ToString("dd.MM.yyyy");

            DateTime licenseExp = Cryptography.License.GetLicenseExpires(_licenseKey, _key);

            try
            {
                labelLicenseTo.Text = licenseExp.ToString("dd.MM.yyyy");
            }
            catch
            {
                labelLicenseTo.Text = "Нет данных";
            }

            _outlookApp = GetOutlookApp();
            buttonMail.Enabled = _outlookApp != null;
        }

        private void LicenseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = Cryptography.License.CheckLicense(_licenseKey, _key) ? DialogResult.OK : DialogResult.No;
        }

        private void notifyIcon_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            DialogResult = Cryptography.License.CheckLicense(_licenseKey, _key) ? DialogResult.OK : DialogResult.No;
            Close();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBoxId.Text);

            notifyIcon.BalloonTipText = "Код скопирован в буфер обмена";
            notifyIcon.BalloonTipTitle = "Уведомление";
            notifyIcon.Icon = Icon;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(500);
        }

        private void linkLabelMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string info = CreateMailBody("%0d");
            Process.Start($"mailto:{_email}?subject=Лицензия на {_appName}&body={info}%0d%0d");
        }

        private void buttonMail_Click(object sender, EventArgs e)
        {
            if (_outlookApp != null)
            {
                try
                {
                    string info = CreateMailBody();
                    Outlook.MailItem mailItem = _outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                    mailItem.To = _email;
                    mailItem.Subject = $"Лицензия на {_appName}";
                    mailItem.Body = info;
                    mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
                    mailItem.Display(false);
                }
                catch
                {
                    // Пропуск
                }            
            }
        }

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            string licenseKey = textBoxLicenseKey.Text.Trim();
            bool check = Cryptography.License.CheckLicense(licenseKey, _key);
            if (check)
            {
                labelLicenseTo.Text = Cryptography.License.GetLicenseExpiresString(licenseKey, _key);
                textBoxLicenseKey.Text = "";
                _licenseKey = licenseKey;
            }
        }
    }
}
