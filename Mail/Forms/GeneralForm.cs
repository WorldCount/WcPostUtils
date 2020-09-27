using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Mail.Libs;
using Mail.Libs.Models;
using Mail.Libs.Objects;
using Mail.Libs.Picture;
using Mail.Libs.Views;
using Mail.Widgets;
using Microsoft.Exchange.WebServices.Data;
using ServiceStack.OrmLite;
using Settings;
using Task = System.Threading.Tasks.Task;

namespace Mail.Forms
{
    public partial class GeneralForm : Form
    {
        public static string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        public string AuthFile;
        // ReSharper disable once InconsistentNaming
        private Auth auth;
        private ExchangeService _service;
        private readonly OrmLiteConnectionFactory _dbFactory;
        private List<WcButton> _wcButtons = new List<WcButton>();
        private bool _isAdmin;
        private readonly string _key = LicenseKey.Key;
        private readonly IWebProxy _proxy = null;

        [DllImport("kernel32.dll")]
        // ReSharper disable once UnusedMember.Local
        static extern bool AttachConsole(int dwProcessId);
        // ReSharper disable once InconsistentNaming
        private const int ATTACH_PARENT_PROCESS = -1;

        public GeneralForm()
        {
            InitializeComponent();

            ServicePointManager.UseNagleAlgorithm = true;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.CheckCertificateRevocationList = false;
            ServicePointManager.DefaultConnectionLimit = 10;

            #pragma warning disable 618
            GlobalProxySelection.Select = _proxy;
            #pragma warning restore 618

            WebRequest.DefaultWebProxy = _proxy;

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            if (!Directory.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            AuthFile = Path.Combine(DataDir, "Auth.xml");

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} v{Application.ProductVersion}";

            // Пробная лицензия на 30 дней
            GetTrialLicense();

            // Создание подключения к БД
            _dbFactory = DbFarctory.Create();

            // Инициализация Exchange
            InitExchange();

            // Создание кнопок фильтров
            CreateButtons();
        }

        private void CheckLicense()
        {
            string license = Properties.Settings.Default.License;
            labelLicense.Text = WcApi.Cryptography.License.GetLicenseExpiresString(license, _key);

            if (_isAdmin)
                return;

            if (!WcApi.Cryptography.License.CheckLicense(license, _key))
            {
                WcApi.Win32.Forms.LicenseForm licenseForm = new WcApi.Win32.Forms.LicenseForm(license, _key, Application.ProductName, Application.ProductVersion, Properties.Settings.Default.MailLicense);
                if (licenseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.License = licenseForm.LicenseKey;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Close();
                }
            }
        }

        private void GetTrialLicense()
        {
            if (Properties.Settings.Default.FirstRun)
            {
                DateTime licenseExp = DateTime.Today.AddDays(30);
                string licenseKey = WcApi.Cryptography.License.GetLicenseKey(licenseExp, _key);
                Properties.Settings.Default.License = licenseKey;
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
            }
        }

        #region Настройки окна

        /// <summary>
        /// Обновление настроек
        /// </summary>
        private void UpgradeSettings()
        {
            // Перенос настроек предыдущей сборки в новую
            Properties.Settings.Default.Upgrade();
            WinConf.Default.Upgrade();
            Properties.Settings.Default.NeedUpgrade = false;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Проверка параметров запуска приложения
        /// </summary>
        private async void CheckArgs()
        {
            
            string[] args = Environment.GetCommandLineArgs();

            // Восстановление положения окна
            if (args.Contains("-restore"))
                CenterToScreen();

            if (args.Contains("-admin"))
                _isAdmin = true;

            if (args.Contains("-license"))
            {
                if (args.Count() > 2)
                {
                    DateTime licenseDate;

                    try
                    {
                        licenseDate = DateTime.Parse(args[2]);
                    }
                    catch
                    {
                        licenseDate = DateTime.Today.AddYears(1);
                    }

                    string license = WcApi.Cryptography.License.GetLicenseKey(licenseDate, _key);
                    Properties.Settings.Default.License = license;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.License = "";
                    Properties.Settings.Default.Save();
                }
            }

            if (args.Contains("-exchange"))
            {
                await SendAuth();
            }
        }

        /// <summary>
        /// Сохранение позиции окна
        /// </summary>
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

        /// <summary>
        /// Загрузка позиции окна
        /// </summary>
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

            // Параметры запуска приложения
            CheckArgs();
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
            statusText.ForeColor = color;
            statusText.Text = message;
            timerStatus.Start();
        }

        // Сообщение: обычное
        // ReSharper disable once UnusedMember.Global
        public void NormalMessage(string message)
        {
            SendStatucMessage(message, Color.White);
        }

        // Сообщение: успех
        public void SuccessStatusMessage(string message)
        {
            SendStatucMessage(message, Color.ForestGreen);
        }

        // Сообщение: ошибка
        public void ErrorStatusMessage(string message)
        {
            SendStatucMessage(message, Color.Firebrick);
        }

        // Сообщение: предупреждение
        public void WarningMessage(string message)
        {
            SendStatucMessage(message, Color.OrangeRed);
        }

        // Сообщение: информация
        public void InfoMessage(string message)
        {
            SendStatucMessage(message, Color.DodgerBlue);
        }

        #endregion

        #region Методы

        // Загрузка данных авторизации
        private void LoadAuth()
        {
            auth = Auth.Load(AuthFile);
            if (auth == null)
            {
                ErrorStatusMessage("Ошибка загрузки данных авторизации.");
            }
        }

        //
        private void InitExchange()
        {
            if (auth == null)
                LoadAuth();

            if (auth == null)
            {
                ErrorStatusMessage("Ошибка загрузки данных авторизации.");
                return;
            }

            _service = new ExchangeService(ExchangeVersion.Exchange2010_SP2)
            {
                Credentials = new WebCredentials(auth.Login, auth.Password),
                WebProxy = _proxy,
                UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0",
                SendClientLatencies = false,
                TraceFlags = TraceFlags.None,
                TraceEnabled = false,
                PreAuthenticate = true,
                EnableScpLookup = false
            };

            if (!string.IsNullOrEmpty(auth.ExchangeUrl))
                _service.Url = new Uri(auth.ExchangeUrl);

            _service.HttpHeaders.Add("X-AnchorMailbox", auth.Email);
            _service.HttpHeaders.Add("X-PublicFolderMailbox", auth.Email);
        }

        // Колбек для функции авторизации Exchange
        private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            bool result = false;
            Uri redirectionUri = new Uri(redirectionUrl);
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }

            return result;
        }

        // Авторизация на сервере Exchange
        private async Task SendAuth()
        { 
            await Task.Run(() =>
            {
                try
                {
                    _service.AutodiscoverUrl(auth.Email, RedirectionUrlValidationCallback);
                }
                catch (Exception)
                {
                    ErrorStatusMessage("Ошибка авторизации.");
                }
            });

            InfoMessage("Авторизация завершена.");
            Console.Write(_service.Url);
        }

        // Загрузка всех фильтров
        private List<Filter> LoadAllFilters()
        {
            using (var db = _dbFactory.Open())
            {
                List<Filter> filters = db.LoadSelect<Filter>().OrderBy(f => f.Name).ToList();
                return filters;
            }
        }

        private void ButtonEnable()
        {
            foreach (WcButton wcButton in _wcButtons)
                wcButton.Enabled = true;
        }

        private void ButtonDisable()
        {    
            foreach (WcButton wcButton in _wcButtons)
                wcButton.Enabled = false;
        }

        // Создание кнопок фильтров
        private void CreateButtons()
        {
            List<Filter> filters = LoadAllFilters();
            ClearButtons();

            foreach(Filter filter in filters)
            {
                WcButton wcButton = new WcButton
                {
                    Id = filter.Id,
                    Text = filter.Name,
                    Font = new Font("Segoe Ui", 8),
                    Width = 120,
                    Height = 40,
                    // FlatStyle = FlatStyle.Flat
                };

                if(_service.Url == null)
                    wcButton.Enabled = false;

                wcButton.Click += WcButton_Click;
                _wcButtons.Add(wcButton);
                tableLayoutButton.Controls.Add(wcButton);
                wcButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }
        }

        // Очистка всех кнопок фильтров
        private void ClearButtons()
        {
            foreach(WcButton wcButton in _wcButtons)
            {
                wcButton.Click -= WcButton_Click;
                tableLayoutButton.Controls.Remove(wcButton);
            }

            _wcButtons = new List<WcButton>();
        }

        private List<Folder> GetAllFolders()
        {
            FolderView folderView = new FolderView(int.MaxValue)
            {
                PropertySet = new PropertySet(BasePropertySet.IdOnly)
            };

            SearchFilter searchFilter = new SearchFilter.IsGreaterThan(FolderSchema.TotalCount, 0);

            folderView.Traversal = FolderTraversal.Deep;

            FindFoldersResults findFolders = _service.FindFolders(WellKnownFolderName.Root, searchFilter, folderView);
            return findFolders.ToList();
        }

        private List<SearchFilter> GetAllFilters(List<Email> emails)
        {
            List<SearchFilter> searchFilters = new List<SearchFilter>();
            foreach (Email email in emails)
                searchFilters.Add(new SearchFilter.ContainsSubstring(EmailMessageSchema.From, email.Text));
            return searchFilters;
        }

        private MailView GetSelectMail()
        {
            DataGridViewSelectedRowCollection rows = dataGridViewMail.SelectedRows;
            int index = rows[0].Index;
            List<MailView> mailViews = (List<MailView>)mailViewBindingSource.DataSource;
            MailView mailView = mailViews[index];
            return mailView;
        }

        private List<Item> GetMail(List<Email> emails)
        {
            List<SearchFilter> searchFilters = GetAllFilters(emails);
            // List<Folder> folders = GetAllFolders();

            #region Фильтр даты

            // ToDo: Изменить на ввод пользователя
            DateTime serachDate = DateTime.Today.AddDays(-3);
            SearchFilter dateFilter = new SearchFilter.IsGreaterThanOrEqualTo(ItemSchema.DateTimeReceived, serachDate);

            #endregion

            #region Фильтр вложений
            SearchFilter attachmentFilter = new SearchFilter.IsEqualTo(ItemSchema.HasAttachments, true);
            
            SearchFilter iniFilter = new SearchFilter.ContainsSubstring(ItemSchema.Attachments, ".ini");
            SearchFilter txtFilter = new SearchFilter.ContainsSubstring(ItemSchema.Attachments, ".txt");
            SearchFilter zipFilter = new SearchFilter.ContainsSubstring(ItemSchema.Attachments, ".zip");
            SearchFilter rarFilter = new SearchFilter.ContainsSubstring(ItemSchema.Attachments, ".rar");
            SearchFilter xlsFilter = new SearchFilter.ContainsSubstring(ItemSchema.Attachments, ".xls");

            SearchFilter extFilter = new SearchFilter.SearchFilterCollection(LogicalOperator.Or, iniFilter, txtFilter, zipFilter, rarFilter, xlsFilter);
            SearchFilter attachFilter = new SearchFilter.SearchFilterCollection(LogicalOperator.And, attachmentFilter, extFilter);
            #endregion

            SearchFilter searchFilter = new SearchFilter.SearchFilterCollection(LogicalOperator.Or, searchFilters);

            searchFilter = new SearchFilter.SearchFilterCollection(LogicalOperator.And, searchFilter, attachFilter);

            searchFilter = new SearchFilter.SearchFilterCollection(LogicalOperator.And, searchFilter, dateFilter);

            ItemView view = new ItemView(50)
            {
                PropertySet = new PropertySet(BasePropertySet.IdOnly, ItemSchema.DateTimeReceived)
            };
            view.OrderBy.Add(ItemSchema.DateTimeReceived, SortDirection.Descending);
            view.Traversal = ItemTraversal.Shallow;

            // List<Item> items = _service.FindItems(WellKnownFolderName.Inbox, searchFilter, view).ToList();
            List<Item> items = new List<Item>();

            //MessageBox.Show($"{folder.DisplayName}");
            FindItemsResults<Item> findResults = _service.FindItems(WellKnownFolderName.Inbox, searchFilter, view);
            items.AddRange(findResults.ToList());

            return items;
        }

        private int AttachCount(EmailMessage email)
        {
            int count = 0;
            foreach (Attachment attach in email.Attachments)
            {
                if (attach.Name.Contains(".zip") || attach.Name.Contains(".ini") || attach.Name.Contains(".rar") || attach.Name.Contains(".xls"))
                    count += 1;
            }
            return count;
        }

        #endregion

        #region Обработчики

        // Форма: загрузилась
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadPos();
            // Проверка лицензии
            CheckLicense();
        }

        // Форма: закрывается
        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePos();
        }

        // Таймер: статус
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.ForeColor = Color.White;
            statusText.Text = "";
            timerStatus.Stop();
        }

        // ТБ Фильтр: Текст изменен
        private void textBoxFIlter_TextChanged(object sender, EventArgs e)
        {
            tableLayoutButton.VerticalScroll.Value = 0;
            string text = textBoxFIlter.Text.ToLower();
            foreach(WcButton wcButton in _wcButtons)
            {
                if(wcButton.Text.ToLower().Contains(text))
                {
                    wcButton.Show();
                }
                else
                {
                    wcButton.Hide();
                }
            }
        }

        // Кнопка Фильтра: Клик
        private void WcButton_Click(object sender, EventArgs e)
        {
            ButtonDisable();
            mailViewBindingSource.DataSource = null;
            attachViewBindingSource.DataSource = null;

            List<MailView> mailViews = new List<MailView>();

            WcButton wcButton = (WcButton)sender;
            List<Email> emails;

            using(var db = _dbFactory.Open())
            {
                emails = db.Select<Email>(m => m.FilterId == wcButton.Id);
            }

            if (emails.Count == 0)
            {
                ButtonEnable();
                return;
            }

            List<Item> items = GetMail(emails);
            foreach(Item item in items)
            {
                EmailMessage emailMessage = EmailMessage.Bind(_service, item.Id, new PropertySet(BasePropertySet.FirstClassProperties, ItemSchema.Attachments, ItemSchema.HasAttachments));
                
                MailView mailView = new MailView { 
                    Date = emailMessage.DateTimeReceived, 
                    Name = emailMessage.From.Name,
                    Email = emailMessage.From.Address,
                    AttachCount = AttachCount(emailMessage),
                    Id = item.Id,
                    IsRead = emailMessage.IsRead
                };

                mailView.Picture = mailView.IsRead ? MailPict.Mail : MailPict.MailNew;

                mailViews.Add(mailView);
            }

            mailViewBindingSource.DataSource = mailViews;
            ButtonEnable();
        }

        private void dataGridViewMail_DoubleClick(object sender, EventArgs e)
        {
            MailView mailView = GetSelectMail();

            if (mailView != null)
            {
                EmailMessage emailMessage = EmailMessage.Bind(_service, mailView.Id);
                emailMessage.IsRead = true;

                List<AttachView> attachViews = new List<AttachView>();

                foreach (Attachment attach in emailMessage.Attachments)
                {
                    if (attach is FileAttachment fileAttachment)
                    {
                        string ext = fileAttachment.Name.Split('.')[1];

                        AttachView attachView = new AttachView()
                        {
                            Ext = ext,
                            Date = fileAttachment.LastModifiedTime,
                            Name = fileAttachment.Name
                        };

                        switch (attachView.Ext)
                        {
                            case "zip":
                                attachView.Picture = ExtPict.Attach;
                                break;
                            case "xls":
                                attachView.Picture = ExtPict.Xls;
                                break;
                            case "txt":
                                attachView.Picture = ExtPict.Txt;
                                break;
                            case "ini":
                                attachView.Picture = ExtPict.Ini;
                                break;
                            case "doc":
                                attachView.Picture = ExtPict.Word;
                                break;
                            default:
                                attachView.Picture = ExtPict.File;
                                break;
                        }

                        attachViews.Add(attachView);
                    }


                }

                _service.UpdateItems(new[] { emailMessage }, WellKnownFolderName.Inbox, ConflictResolutionMode.AutoResolve,
                    MessageDisposition.SaveOnly, null);

                attachViewBindingSource.DataSource = attachViews;
            }

        }

        #endregion

        #region Меню

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm(this);
            authForm.ShowDialog(this);
            LoadAuth();
            InitExchange();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm();
            filterForm.ShowDialog(this);
            CreateButtons();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        

    }
}
