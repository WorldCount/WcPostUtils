using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using DwUtils.Core;
using DwUtils.Core.Libs.Database.Firebird;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries;
using DwUtils.Core.Libs.Database.Firebird.Queries.Params;
using DwUtils.Core.Libs.ServerRequest;
using DwUtils.Core.Models.Firebird;
using DwUtils.Core.Services.Firebird;
using DwUtils.Forms.ConfigForms;
using DwUtils.Forms.WorkForms;
using NLog;
using WcApi.Cryptography;
using WcApi.Net;
using WcApi.Win32.Forms;
using License = WcApi.Cryptography.License;

namespace DwUtils.Forms
{
    public partial class GeneralForm : Form
    {

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private PostUnitConnect _postUnitConnect;
        private PostItemConnect _postItemConnect;

        #region Репозитории

        private UserRepository _userRepository;
        private ConnectUserRepository _connectUserRepository;

        #endregion


        #region Настройки

        private bool _isAdmin;

        private bool _checkAllFlag = true;

        private string _key;

        readonly string _appVersion = $"{Application.ProductName} {Application.ProductVersion}";
        readonly string _appText = "DwUtils";

        private ServerAuth _serverAuth;

        #endregion

        public GeneralForm()
        {
            InitializeComponent();

            WebRequest.DefaultWebProxy = null;

            Logger.Info("Запуск программы.");

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            // ReSharper disable once VirtualMemberCallInConstructor
            // ReSharper disable once LocalizableElement
            Text = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";

            LoadPos();

            // Загрузка настроек
            LoadSettings();
            // Загрузка подключений
            LoadConnect();
            // Загрузка пользователей
            LoadUsers();

            // Настройка таблиц
            InitDataGridViews();
        }

        #region Лицензия

        private async void CheckLicense()
        {
            string license = Properties.Settings.Default.License;
            string exp = await Task.Run(() => License.GetLicenseExpiresString(license, _key));


            if (labelInfoLicense.InvokeRequired)
                Invoke(new Action(() =>
                {
                    labelLicense.Text = string.IsNullOrEmpty(exp) ? "Ошибка" : exp;
                }));

            _serverAuth = await ServerManager.GetServerAuth();
            if (!_serverAuth.Work)
            {
                MessageBox.Show(_serverAuth.Message, "Ошибка");
                Close();
            }

            if (_isAdmin)
                return;

            if (!License.CheckLicense(license, _key))
            {
                await SendMessage($"Лицензия истекла [{_key}]");

                LicenseForm licenseForm = new LicenseForm(license, _key, Application.ProductName, Application.ProductVersion, Properties.Settings.Default.MailLicense, Icon);
                if (licenseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.License = licenseForm.LicenseKey;
                    Properties.Settings.Default.Save();
                    labelLicense.Text = await Task.Run(() => License.GetLicenseExpiresString(licenseForm.LicenseKey, _key));
                }
                else
                    Close();
            }
        }

        private void GetTrialLicense()
        {
            if (Properties.Settings.Default.FirstRun)
            {
                DateTime licenseExp = DateTime.Today.AddDays(30);
                string licenseKey = License.GetLicenseKey(licenseExp, _key);

                Properties.Settings.Default.License = licenseKey;
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        #region Настройки формы

        private void LoadSettings()
        {
            try
            {
                tabsControl.SelectedIndex = Properties.Settings.Default.ActiveTab;
            }
            catch
            {
                tabsControl.SelectedIndex = 0;
            }
        }

        private void SaveSettings()
        {
            int tabIndex = tabsControl.SelectedIndex;
            Properties.Settings.Default.ActiveTab = tabIndex;
        }

        // Перенос настроек предыдущей сборки в новую
        private void UpgradeSettings()
        {
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.NeedUpgrade = false;
            Properties.Settings.Default.Save();
        }

        // Сохранение настроек
        private void SavePos()
        {
            Properties.Settings.Default.GeneralFormState = WindowState;

            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.GeneralFormLocation = Location;
                Properties.Settings.Default.GeneralFormSize = Size;
            }
            else
            {
                // Если форма свернута или развернута
                Properties.Settings.Default.GeneralFormLocation = RestoreBounds.Location;
                Properties.Settings.Default.GeneralFormSize = RestoreBounds.Size;
            }

            Properties.Settings.Default.Save();
        }

        // Загрузка настроек
        private void LoadPos()
        {
            int width = Properties.Settings.Default.GeneralFormSize.Width;
            int height = Properties.Settings.Default.GeneralFormSize.Height;

            if (width == 0 || height == 0)
            {
                // Первый старт
            }
            else
            {
                WindowState = Properties.Settings.Default.GeneralFormState;

                // Нам не нужно свернутое окно при запуске
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;

                Location = Properties.Settings.Default.GeneralFormLocation;
                Size = Properties.Settings.Default.GeneralFormSize;
            }
        }

        private void CheckArgs()
        {

            string[] args = Environment.GetCommandLineArgs();

            // Восстановление положения окна
            if (args.Contains("-restore"))
                CenterToScreen();

            if (args.Contains("-admin"))
                _isAdmin = true;

            if (args.Contains("-license"))
            {
                if (args.Length > 2)
                {
                    DateTime licenseDate;

                    try
                    {
                        licenseDate = DateTime.Parse(args[2]);
                    }
                    catch (Exception e)
                    {
                        Logger.Error(e);
                        licenseDate = DateTime.Today.AddYears(1);
                    }

                    string license = License.GetLicenseKey(licenseDate, _key);
                    Properties.Settings.Default.License = license;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.License = "";
                    Properties.Settings.Default.Save();
                }
            }
        }

        #endregion

        #region Сообщения

        /// <summary>
        /// Отправляет сообщение в статус
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        private void SendStatucMessage(string message, Color color)
        {
            statusText.ForeColor = color;
            statusText.Text = message;
            timerStatus.Start();
        }

        // Сообщение: обычное
        // ReSharper disable once UnusedMember.Global
        public void NormalMessage(string message)
        {
            SendStatucMessage(message, Color.DimGray);
        }

        // Сообщение: успех
        public void SuccessMessage(string message)
        {
            SendStatucMessage(message, Color.Green);
        }

        // Сообщение: ошибка
        public void ErrorMessage(string message)
        {
            SendStatucMessage(message, Color.Firebrick);
        }

        // Сообщение: предупреждение
        public void WarningMessage(string message)
        {
            SendStatucMessage(message, Color.DarkOrange);
        }

        // Сообщение: информация
        public void InfoMessage(string message)
        {
            SendStatucMessage(message, Color.DodgerBlue);
        }

        private async Task SendMessage(string msg)
        {
            string req = await Task.Run(() =>
            {
                string host = Dns.GetHostName();
                string user = WindowsIdentity.GetCurrent().Name;
                string ip = Host.GetIp();
                return _appVersion != null ? $"<b>{_appText}:</b>  {msg}<pre>Дата: {DateTime.Now} | ПО: {_appVersion} | Хост: {host} | Пользователь: {user} | IP: {ip}</pre>" : $"<b>{_appText}:</b>  {msg}<pre>Дата: {DateTime.Now} | Хост: {host} | Пользователь: {user} | IP: {ip}</pre>";
            });

            await Utils.Telegram.SendMessageAsync(req, ParseMode.HTML);
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.Text = "";
        }

        #endregion

        #region События

        private async void GeneralForm_Load(object sender, EventArgs e)
        {
            await CreateDirsAsync();

            _key = await Task.Run(() => LicenseKey.GetKey(Host.GetIp(), AuthKey.Key, Application.ProductName));

            // Пробная лицензия на 30 дней
            await Task.Run(GetTrialLicense);

            // Параметры запуска приложения
            await Task.Run(CheckArgs);

            // Проверка лицензии
            CheckLicense();
        }

        private void GeneralForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Info("Закрытие программы");
            SaveSettings();
            SavePos();
        }

        #endregion

        #region Методы

        private Task CreateDirsAsync()
        {
            return Task.Run(() =>
            {
                if (!Directory.Exists(PathManager.DataDir))
                    Directory.CreateDirectory(PathManager.DataDir);
            });
        }

        private void LoadConnect()
        {
            _postUnitConnect = FbDataBase.PostUnit.GetConnect();
            _postItemConnect = FbDataBase.PostItem.GetConnect();

            _userRepository = new UserRepository(_postUnitConnect);
            _connectUserRepository = new ConnectUserRepository(_postUnitConnect);
        }

        private void LoadUsers()
        {
            userBindingSource.DataSource = null;
            List<User> users = _userRepository.GetAll().ToList();
            users.Insert(0, new User
            {
                Id = 0,
                IsValid = false,
                Name = "ВСЕ"
            });
            userBindingSource.DataSource = users;
        }

        private void InitDataGridViews()
        {

            // Вкладка Подключенные пользователи
            placeNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            placeNameDataGridViewTextBoxColumn.Width = 300;

            connectDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            connectDateDataGridViewTextBoxColumn.Width = 140;

            workDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            workDateDataGridViewTextBoxColumn.Width = 140;

            adminStatusDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            adminStatusDataGridViewTextBoxColumn.Width = 100;
        }

        #endregion

        #region События Меню

        private void authMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog(this);
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectsForm connectsForm = new ConnectsForm();
            if (connectsForm.ShowDialog(this) == DialogResult.OK)
            {
                LoadConnect();
                LoadUsers();
            }
        }

        private void createDbMenuItem_Click(object sender, EventArgs e)
        {
            CreateDbForm createDbForm = new CreateDbForm();
            createDbForm.ShowDialog(this);
        }

        #endregion

        #region Кнопки Кладки

        #region Вкладка Активные пользователи

        private void btnActiveUserLoad_Click(object sender, EventArgs e)
        {
            connectUserBindingSource.DataSource = null;
            connectUserBindingSource.DataSource = _connectUserRepository.GetAll();
        }

        #endregion

        #endregion

        #region События Разное

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            receiveDateTimePickerEnd.Value = receiveDateTimePickerStart.Value;
        }

        private void orgDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            orgDateTimePickerEnd.Value = orgDateTimePickerStart.Value;
        }

        #endregion

        private void btnReceiveDocLoad_Click(object sender, EventArgs e)
        {
            receiveReestrBindingSource.DataSource = null;

            GetReestrParams param = new GetReestrParams
            {
                StartCreateDate = receiveDateTimePickerStart.Value,
                EndCreateDate = receiveDateTimePickerEnd.Value,
                ReestrType = 11
            };

            User selectUser = (User) cbUsers.SelectedItem;
            param.UserId = selectUser.Id;

            GetReestr q = new GetReestr(_postItemConnect, param);
            var data = q.Run();

            receiveReestrBindingSource.DataSource = data;
        }

        private void btnOrgDocLoad_Click(object sender, EventArgs e)
        {
            orgReestrBindingSource.DataSource = null;

            GetReestrParams param = new GetReestrParams
            {
                StartCreateDate = orgDateTimePickerStart.Value,
                EndCreateDate = orgDateTimePickerEnd.Value,
                ReestrType = 7
            };

            User selectUser = (User)cbUsers.SelectedItem;
            param.UserId = selectUser.Id;

            GetReestr q = new GetReestr(_postItemConnect, param);
            var data = q.Run();

            orgReestrBindingSource.DataSource = data;
        }
    }
}
