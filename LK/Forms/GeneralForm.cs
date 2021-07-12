using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Threading.Tasks;
using AutoUpdaterDotNET;
using LK.Core;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.PrintDocuments;
using LK.Core.Libs.ServerRequest;
using LK.Core.Libs.Stat;
using LK.Core.Libs.Widget;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Models.Filters;
using LK.Core.Models.Types;
using LK.Core.Store;
using LK.Forms.ConfigForms;
using LK.Forms.DataForms;
using LK.Forms.ReportForms;
using LK.Forms.TarifForms;
using LK.Forms.TypeForms;
using Newtonsoft.Json;
using NLog;
using WcApi.Cryptography;
using WcApi.Net;
using WcApi.Win32.Forms;
using License = WcApi.Cryptography.License;

namespace LK.Forms
{
    public partial class GeneralForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #region Настройки

        private Color _warnBackColor;
        private Color _warnForeColor;
        private Color _errBackColor;
        private Color _errForeColor;

        private bool _isAdmin;

        private bool _checkAllFlag = true;

        private string _key;

        readonly string _appVersion = $"{Application.ProductName} {Application.ProductVersion}";
        readonly string _appText = "Личный кабинет";

        #endregion


        #region Объекты данных

        private List<MailType> _mailTypes;
        private List<MailCategory> _mailCategories;
        private List<Firm> _firms;
        private List<FirmList> _firmLists;
        private List<Operator> _operators;

        private List<MailType> _mailTypesDataGrid;
        private List<MailCategory> _mailCategoriesDataGrid;
        private FirmListStatCollector _collector;

        private Auth _auth;
        private ServerAuth _serverAuth;

        #endregion

        #region Конфиги

        private Config _defaultPrinterConfig;

        #endregion

        // Очередь отчетов для печати
        private readonly ReportQueue<SingleReportData> _reportsQueue = new ReportQueue<SingleReportData>();


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

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridViewList);

            LoadPos();

            // Настройка таблицы
            InitDataGridView();

            // Подсказки
            InitTooltips();

            _reportsQueue.AddedObject += _reportsQueue_AddedObject;

            AutoUpdater.Proxy = null;
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdater_ParseUpdateInfoEvent;
        }

        private void InitTooltips()
        {
            ToolTip toolTipLoad = new ToolTip();
            ToolTip toolTipPrint = new ToolTip();
            ToolTip toolTipClear = new ToolTip();
            ToolTip toolTipReport = new ToolTip();
            ToolTip toolTipPrintReport = new ToolTip();
            ToolTip toolTipSync = new ToolTip();

            toolTipLoad.SetToolTip(btnLoad, "Загрузить [Ctrl + Q]");
            toolTipPrint.SetToolTip(btnTablePrint, "Печать таблицы [Ctrl + P]");
            toolTipClear.SetToolTip(btnClearFilter, "Очистить фильтры [Ctrl + Shift + C]");
            toolTipReport.SetToolTip(btnReport, "Отчет по весу [Ctrl + O]");
            toolTipPrintReport.SetToolTip(btnPrintReport, "Печать отчета по весу [Ctrl + R]");
            toolTipSync.SetToolTip(btnSync, "Синхронизация ЛК [Ctrl + L]");
        }

        #region Лицензия

        private async void CheckLicense()
        {
            string license = Properties.Settings.Default.License;
            string exp = await Task.Run(() => License.GetLicenseExpiresString(license, _key));

            labelLicense.Text = string.IsNullOrEmpty(exp) ? "Ошибка" : exp;

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

        #region Настройка формы

        private void LoadSettings()
        {
            checkBoxPrintPreview.Checked = Properties.Settings.Default.PrintPreviewFlag;
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
                    catch(Exception e)
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

        private async void GeneralForm_Load(object sender, EventArgs e)
        {

            await CreateDirs();

            _key = await Task.Run(() => LicenseKey.GetKey(WcApi.Net.Host.GetIp(), AuthKey.Key, Application.ProductName));

            // Пробная лицензия на 30 дней
            await Task.Run(GetTrialLicense);

            // Параметры запуска приложения
            await Task.Run(CheckArgs);

            await CreateDb();

            // Загрузка данных для фильтров
            await LoadAllData();

            await Task.Run(LoadSettings);

            // Проверка лицензии
            CheckLicense();

            // Инициализация начальных данных
            InitialData();

            // Загрузка меню с отчетами
            LoadReportMenu();
        }

        private static async Task CreateDb()
        {
            await Task.Run(() =>
            {
                if (!File.Exists(PathManager.DbPath))
                {
                    CreateDbForm createDbForm = new CreateDbForm();
                    createDbForm.ShowDialog();
                }
            });
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePos();
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

        public async Task SendMessage(string msg)
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

        #region Загрузка данных

        private void InitialData()
        {
        }

        private async Task LoadAllData()
        {
            comboBoxListClass.DataSource = Enum.GetNames(typeof(MailClass));
            comboBoxErrorList.DataSource = Enum.GetNames(typeof(ErrorType));

            _auth = Auth.Load(PathManager.AuthPath);
            //_serverAuth = await ServerManager.GetServerAuth();

            await LoadOperator();

            await LoadFirms();
            
            await LoadMailTypes(); 
            
            await LoadMailTypesDataGrid();
            
            await LoadMailCategories();

            await LoadMailCategoriesDataGrid();

            //await LoadColors();
            await LoadConfigs();
        }

        private void LoadColors()
        {
        }

        private void LoadFirmLists()
        {
            Firm firm = (Firm) comboBoxOrgs.SelectedItem;
            MailType mailType = (MailType) comboBoxMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory) comboBoxMailCategory.SelectedItem;

            string mailClass = (string) comboBoxListClass.SelectedItem;
            string errorType = (string) comboBoxErrorList.SelectedItem;

            Operator oper = (Operator) comboBoxOperator.SelectedItem;

            string sNum = textBoxListIn.Text.Trim();
            string eNum = textBoxListOut.Text.Trim();

            int startNum = 0;
            int endNum = 0;

            if(!string.IsNullOrEmpty(sNum))
                startNum = int.Parse(sNum);

            if (!string.IsNullOrEmpty(eNum))
                endNum = int.Parse(eNum);

            FirmListFilter firmListFilter = new FirmListFilter
            {
                StartDate = dateTimePickerIn.Value,
                EndDate = dateTimePickerOut.Value.AddDays(1),
                FirmId = firm.Id,

                StartNum = startNum,
                EndNum = endNum,

                MailCategoryId = mailCategory.Id,
                MailTypeId = mailType.Id,
                OperatorId = oper.Id,

                MailClass = (MailClass) Enum.Parse(typeof(MailClass), mailClass),
                ErrorType = (ErrorType) Enum.Parse(typeof(ErrorType), errorType),

            };

            //_firmLists = Database.GetFirmsList(firmListFilter);
            //_firmLists = new List<FirmList>();
            _firmLists = Database.GetFirmsListManual(firmListFilter);
            //var d = Database.GetFirmsListManual(firmListFilter);

            _checkAllFlag = true;

            UpdateFirmList();

            _collector = new FirmListStatCollector(_firmLists);
            UpdateStat();
        }

        private void UpdateStat()
        {
            if (_collector != null)
            {
                statDataBindingSource.DataSource = null;
                statDataBindingSource.DataSource = _collector.GetListStat();
            }
        }

        private async Task LoadConfigs()
        {
            await Task.Run(() =>
            {
                _defaultPrinterConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName) ?? ConfigManager.CreateDefaultPrinterName();
            });
            
        }

        private async Task LoadOperator()
        {
            await Task.Run(() =>
            {
                _operators = Database.GetAllOperator();
                _operators.Insert(0, new Operator { LastName = "ВСЕ", Id = 0});
            });

            UpdateOperators();
        }

        private async Task LoadFirms()
        {
            await Task.Run(() =>
            {
                _firms = Database.GetFirms();
                _firms.Insert(0, new Firm { Inn = "", Name = "ВСЕ", ShortName = "ВСЕ" });
            });
            
            UpdateFirms();
        }

        private async Task LoadMailTypes()
        {
            await Task.Run(() =>
            {
                _mailTypes = Database.GetEnabledMailTypes();
                _mailTypes.Insert(0, new MailType { Id = 0, ShortName = "ВСЕ" });
            });

            UpdateMailTypes();
        }

        private async Task LoadMailTypesDataGrid()
        {
            await Task.Run(() =>
            {
                _mailTypesDataGrid = Database.GetMailTypes();
            });

            dataGridMailTypeBindingSource.DataSource = null;
            dataGridMailTypeBindingSource.DataSource = _mailTypesDataGrid;
        }

        private async Task LoadMailCategories()
        {
            await Task.Run(() =>
            {
                _mailCategories = Database.GetEnabledMailCategories();
                _mailCategories.Insert(0, new MailCategory { Id = 0, ShortName = "ВСЕ" });
                
            });

            UpdateMailCategories();
        }

        private async Task LoadMailCategoriesDataGrid()
        {
            await Task.Run(() =>
            {
                _mailCategoriesDataGrid = Database.GetMailCategories();
            });

            dataGridMailCategoryBindingSource.DataSource = null;
            dataGridMailCategoryBindingSource.DataSource = _mailCategoriesDataGrid;
        }

        #region Обновление биндингов

        private void UpdateOperators()
        {
            operatorBindingSource.DataSource = null;
            operatorBindingSource.DataSource = _operators;
        }

        private void UpdateFirms()
        {
            firmBindingSource.DataSource = null;
            firmBindingSource.DataSource = _firms;
        }

        private void UpdateMailTypes()
        {
            mailTypeBindingSource.DataSource = null;
            mailTypeBindingSource.DataSource = _mailTypes;
        }

        private void UpdateMailCategories()
        {
            mailCategoryBindingSource.DataSource = null;
            mailCategoryBindingSource.DataSource = _mailCategories;
        }

        private void UpdateFirmList()
        {
            firmListBindingSource.DataSource = null;
            firmListBindingSource.DataSource = _firmLists.ToSortableBindingList();

            dataGridViewList.Sort(receptionDateDataGridViewTextBoxColumn, ListSortDirection.Ascending);
        }

        #endregion

        #endregion

        #region Методы

        private Task CreateDirs()
        {
            return Task.Run(() =>
            {
                if (!Directory.Exists(PathManager.DataDir))
                    Directory.CreateDirectory(PathManager.DataDir);

                if (!Directory.Exists(PathManager.ReportPath))
                    Directory.CreateDirectory(PathManager.ReportPath);
            });
        }

        private void GetPrintPagesCount()
        {

        }

        private SingleReportData GetSingleReportData()
        {
            List<FirmList> checkedFirmLists = GetCheckedFirmLists();
            if (checkedFirmLists == null || checkedFirmLists.Count == 0)
                return null;

            Firm firm = GetSelectFirm();
            if (firm == null)
                return null;

            int[] ids = checkedFirmLists.Select(checkedFirmList => checkedFirmList.Id).ToArray();
            List<Rpo> rpos = Database.GetRposByListsIds(ids);

            if (rpos.Count == 0)
                return null;

            List<DateTime> dates = checkedFirmLists.Select(d => d.Date).ToList();

            SingleReportData singleReport = new SingleReportData(firm, rpos)
            {
                DateList = dates.GroupBy(x => x.Date).Select(y => y.FirstOrDefault()).ToList(),
                NumsList = new List<DateList>()
            };

            foreach (DateTime dateTime in singleReport.DateList)
            {
                List<FirmList> firmListToDate = checkedFirmLists.Where(f => f.Date == dateTime).ToList();
                singleReport.NumsList.Add(new DateList(firmListToDate));
            }

            return singleReport;
        }

        private List<FirmList> GetCheckedFirmLists()
        {
            return _firmLists?.Where(f => f.Check).ToList();
        }

        private Firm GetSelectFirm()
        {
            return (Firm)comboBoxOrgs.SelectedItem;
        }

        private void CheckReverse()
        {
            foreach (FirmList firmList in _firmLists)
            {
                firmList.Check = !firmList.Check;
            }

            _collector = new FirmListStatCollector(_firmLists);
            UpdateStat();

            UpdateFirmList();
        }

        private void CheckAll(string firmName = null)
        {
            if (_firmLists == null)
                return;

            foreach (FirmList firmList in _firmLists)
            {
                if (firmName != null)
                {
                    if (firmName == firmList.Firm.ShortName)
                        firmList.Check = true;
                }
                else
                {
                    firmList.Check = true;
                    _checkAllFlag = true;
                }
            }

            _collector = new FirmListStatCollector(_firmLists);
            UpdateStat();

            UpdateFirmList();
        }

        private void UncheckAll(string firmName = null)
        {
            if(_firmLists == null)
                return;

            foreach (FirmList firmList in _firmLists)
            {
                if (firmName != null)
                {
                    if (firmName == firmList.Firm.ShortName)
                        firmList.Check = false;
                }
                else
                {
                    firmList.Check = false;
                    _checkAllFlag = false;
                }
            }

            _collector = new FirmListStatCollector(_firmLists);
            UpdateStat();

            UpdateFirmList();
        }

        private void InverseCheck()
        {
            foreach (FirmList firmList in _firmLists)
            {
                firmList.Check = !firmList.Check;
            }

            _collector = new FirmListStatCollector(_firmLists);
            UpdateStat();

            UpdateFirmList();
        }

        public FirmList GetFirmListByRowIndex(int rowIndex)
        {
            SortableBindingList<FirmList> firmLists = (SortableBindingList<FirmList>)firmListBindingSource.DataSource;

            try
            {
                if (firmLists != null && firmLists.Count > 0)
                {
                    FirmList firmList = firmLists[rowIndex];
                    return firmList;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        private async void ShowReportMassAsync(SingleReportData singleReport)
        {
            await Task.Factory.StartNew(() =>
            {
                if (singleReport == null)
                    return;

                OrgMassReportForm reportMassForm = new OrgMassReportForm(singleReport);
                PrintController printController = new StandardPrintController();

                MassReportPrintDocument document = reportMassForm.GetPrintDocument();
                document.PrinterSettings.PrinterName = _defaultPrinterConfig.Value;
                document.PrintController = printController;
                document.Print();
            });
        }

        #endregion

        #region Меню

        #region Меню - Настройки

        private async void createDbMenuItem_Click(object sender, EventArgs e)
        {
            CreateDbForm createDbForm = new CreateDbForm();
            createDbForm.ShowDialog(this);

            await LoadAllData();
        }

        #endregion

        #region Меню - Отправления

        private async void typeMenuItem_Click(object sender, EventArgs e)
        {
            MailTypeForm mailTypeForm = new MailTypeForm();
            if (mailTypeForm.ShowDialog(this) == DialogResult.OK)
            {
                await LoadMailTypes();
            }
        }

        private async void categoryMenuItem_Click(object sender, EventArgs e)
        {
            MailCategoryForm mailCategoryForm = new MailCategoryForm();
            if (mailCategoryForm.ShowDialog(this) == DialogResult.OK)
            {
                await LoadMailCategories();
            }
        }

        #endregion

        #region Меню - Данные
        private async void editOrgsMenuItem_Click(object sender, EventArgs e)
        {
            FirmsForm firmsForm = new FirmsForm();
            if (firmsForm.ShowDialog(this) == DialogResult.OK)
            {
                await LoadFirms();
            }
        }

        private async void editOperMenuItem_Click(object sender, EventArgs e)
        {
            OperatorsForm operatorsForm = new OperatorsForm();
            if (operatorsForm.ShowDialog(this) == DialogResult.OK)
            {
                await LoadOperator();
            }
        }

        #endregion

        #region Меню - Тарифы

        private void tarifNoticeMenuItem_Click(object sender, EventArgs e)
        {
            NoticeTarifForm noticeTarifForm = new NoticeTarifForm();
            noticeTarifForm.ShowDialog(this);
        }

        private void mailMenuItem_Click(object sender, EventArgs e)
        {
            MailTarifForm mailTarifForm = new MailTarifForm();
            if (mailTarifForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void parcelMenuItem_Click(object sender, EventArgs e)
        {
            ParcelTarifForm parcelTarifForm = new ParcelTarifForm();
            if (parcelTarifForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void firstMailMenuItem_Click(object sender, EventArgs e)
        {
            FirstMailTarifForm firstMailTarifForm = new FirstMailTarifForm();
            if (firstMailTarifForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void firstParcelMenuItem_Click(object sender, EventArgs e)
        {
            FirstParcelTarifForm firstParcelTarifForm = new FirstParcelTarifForm();
            if (firstParcelTarifForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void interMailMenuItem_Click(object sender, EventArgs e)
        {
            InterMailTarifForm interMailTarifForm = new InterMailTarifForm();
            if (interMailTarifForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void interParcelMenuItem_Click(object sender, EventArgs e)
        {
            InterParcelTarifForm interParcelTarifForm = new InterParcelTarifForm();
            if (interParcelTarifForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        #endregion

        #region Меню - Инфо
        private void licenseMenuItem_Click(object sender, EventArgs e)
        {
            string license = Properties.Settings.Default.License;

            LicenseForm licenseForm = new LicenseForm(license, _key, Application.ProductName, Application.ProductVersion, Properties.Settings.Default.MailLicense, Icon);

            if (WcApi.Cryptography.License.CheckLicense(license, _key))
            {
                licenseForm.LicenseText("Поздравляю, ваша лицензия пока еще работает :)");
                licenseForm.LicensePicture(Properties.Resources.cat_license);
            }

            if (licenseForm.ShowDialog(this) == DialogResult.OK)
            {

                Properties.Settings.Default.License = licenseForm.LicenseKey;
                labelLicense.Text = License.GetLicenseExpiresString(licenseForm.LicenseKey, _key);
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        #endregion

        #region Контекстное меню

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAll();
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void setHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void checkFirmListStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Tag != null)
                CheckAll(item.Tag.ToString());
        }

        private void uncheckFirmListStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Tag != null)
                UncheckAll(item.Tag.ToString());
        }

        private void inverseCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InverseCheck();
        }

        #endregion

        #region Обработчики

        #region Updater

        private void AutoUpdater_ParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json.version,
                ChangelogURL = json.changelog,
                DownloadURL = json.url,
                Mandatory = new Mandatory
                {
                    Value = json.mandatory.value
                },
                CheckSum = new CheckSum
                {
                    Value = json.checksum.value,
                    HashingAlgorithm = json.checksum.hashingAlgorithm
                }
            };
        }

        #endregion

        #region Панель

        private void panelType_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(255, 0, 223, 223);
            ButtonBorderStyle border = ButtonBorderStyle.Dashed;

            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, panelType.ClientRectangle,
                borderColor, 1, border,
                borderColor, 1, border,
                borderColor, 1, border,
                borderColor, 1, border);
        }

        private void GeneralForm_SizeChanged(object sender, EventArgs e)
        {
            panelType.Refresh();
        }

        #endregion

        #region Кнопки

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFirmLists();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SingleReportData singleReport = GetSingleReportData();

            if(singleReport == null)
                return;

            OrgMassReportForm orgMassReportForm = new OrgMassReportForm(singleReport);
            if (orgMassReportForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            SingleReportData singleReport = GetSingleReportData();

            if (singleReport == null)
                return;

            _reportsQueue.Enqueue(singleReport);
        }

        private void btnTablePrint_Click(object sender, EventArgs e)
        {

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            comboBoxOrgs.SelectedIndex = 0;
            comboBoxErrorList.SelectedIndex = 0;
            comboBoxOperator.SelectedIndex = 0;
            comboBoxMailType.SelectedIndex = 0;
            comboBoxMailCategory.SelectedIndex = 0;
            comboBoxListClass.SelectedIndex = 0;

            textBoxListIn.Clear();
            textBoxListOut.Clear();
            tbBarcode.Clear();

            dateTimePickerIn.Value = DateTime.Today;
            dateTimePickerOut.Value = DateTime.Today;
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            UncheckAll();
        }

        private async void btnSync_Click(object sender, EventArgs e)
        {
            SyncForm syncForm = new SyncForm(dateTimePickerIn.Value, dateTimePickerOut.Value, _auth);
            syncForm.ShowDialog(this);

            await LoadAllData();
        }

        #endregion

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerIn.Value;
            dateTimePickerOut.Value = date;
        }

        private void comboBoxOrgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewList_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridViewList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int currentMouseOverRow = dataGridViewList.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = dataGridViewList.HitTest(e.X, e.Y).ColumnIndex;

            }
        }

        private void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbBarcode.Text.Trim().Length >= 13)
            {

            }
        }

        private void tbNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxOrgs_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }

        private void checkBoxPrintPreview_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrintPreviewFlag = checkBoxPrintPreview.Checked;
            Properties.Settings.Default.Save();
        }

        private void GeneralForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + Shift + C
            if (e.KeyCode == Keys.C && e.Shift && e.Control)
                btnClearFilter.PerformClick();

            // Нажатие Ctrl + Q
            if (e.KeyCode == Keys.Q && e.Control)
                btnLoad.PerformClick();

            // Нажатие Ctrl + Shift + Esc
            if (e.KeyCode == Keys.Escape && e.Shift && e.Control)
                exitMenuItem.PerformClick();

            // Нажатие Ctrl + P
            if (e.KeyCode == Keys.P && e.Control)
                btnTablePrint.PerformClick();

            // Нажатие Ctrl + R
            if (e.KeyCode == Keys.R && e.Control)
                btnPrintReport.PerformClick();

            // Нажатие Ctrl + O
            if (e.KeyCode == Keys.O && e.Control)
                btnReport.PerformClick();

            // Нажатие Ctrl + L
            if (e.KeyCode == Keys.L && e.Control)
                btnSync.PerformClick();

            // Нажатие Ctrl + F
            if (e.KeyCode == Keys.F && e.Control)
                tbBarcode.Focus();

            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                comboBoxOrgs.Focus();
        }

        private void checkBoxPrintPreview_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPrintPreview.Image = checkBoxPrintPreview.Checked ? Properties.Resources.white_checked_32 : Properties.Resources.white_unchecked_32;
        }

        private void tbBarcode_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        #endregion

        #region Таблица

        private void InitDataGridView()
        {
            // Столбец с значком
            checkDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkDataGridViewCheckBoxColumn.Width = 40;
            checkDataGridViewCheckBoxColumn.CellTemplate.Style.BackColor = Color.FromArgb(53,56,58);
            checkDataGridViewCheckBoxColumn.CellTemplate.Style.SelectionBackColor = Color.FromArgb(53, 56, 58);
            // Столбец с датой
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dateDataGridViewTextBoxColumn.Width = 100;

            // Столбец с именем организации
            firmDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Столбец с номером списка
            numDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numDataGridViewTextBoxColumn.Width = 80;

            // Столбец с типом отправления
            mailTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mailTypeDataGridViewTextBoxColumn.Width = 180;

            // Столбец с категорией отправления
            mailCategoryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mailCategoryDataGridViewTextBoxColumn.Width = 100;

            mailClassDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mailClassDataGridViewTextBoxColumn.Width = 60;

            // Столбец с классом отправления
            //interNameGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //interNameGridViewTextBoxColumn.Width = 70;

            //manualNameGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //manualNameGridViewTextBoxColumn.Width = 60;

            // Столбец с количеством отправлений
            //countDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //countDataGridViewTextBoxColumn.Width = 80;

            // Столбец с количеством принятых отправлений
            countFactDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            countFactDataGridViewTextBoxColumn.Width = 80;

            // Столбец с количеством пропущенных отправлений
            countMissDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            countMissDataGridViewTextBoxColumn.Width = 80;

            // Столбец с количеством отправлений на возврат
            countReturnDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            countReturnDataGridViewTextBoxColumn.Width = 80;

            // Столбец с отметками
            postMarkNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            postMarkNameDataGridViewTextBoxColumn.Width = 120;

            //// Столбец с замечаниями
            //warnCountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //warnCountDataGridViewTextBoxColumn.Width = 60;

            //// Столбец с выбывшими
            //errCountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //errCountDataGridViewTextBoxColumn.Width = 60;

            // Столбец со сбором
            rateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rateDataGridViewTextBoxColumn.Width = 100;

            // Столбец с датой приемы
            receptionDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            receptionDateDataGridViewTextBoxColumn.Width = 140;

            operatorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            operatorDataGridViewTextBoxColumn.Width = 140;
        }

        private void ColoredDataGridView()
        {
            
        }

        private void dataGridViewList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = (DataGridView) sender;
            var sortIconColor = Color.Gray;

            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
               bool value = (bool) e.FormattedValue;
               e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
               Bitmap img = value ? Properties.Resources.gray_checked_32 : Properties.Resources.gray_unchecked_32;
               Size size = img.Size;
               Point loc = new Point((e.CellBounds.Width - size.Width) / 2, (e.CellBounds.Height - size.Height) / 2);
               loc.Offset(e.CellBounds.Location);
               e.Graphics.DrawImage(img, loc);
               e.Handled = true;
            }

            // Отрисовка флага сортировки
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.PaintBackground(e.CellBounds, false);
                TextRenderer.DrawText(e.Graphics, $"{e.FormattedValue}", e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                if (grid.SortedColumn?.Index == e.ColumnIndex)
                {
                    var sortIcon = grid.SortOrder == SortOrder.Ascending ? "▲" : "▼";
                    TextRenderer.DrawText(e.Graphics, sortIcon, e.CellStyle.Font, e.CellBounds, sortIconColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
                }

                e.Handled = true;
            }
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            {
                FirmList firmList = GetFirmListByRowIndex(e.RowIndex);

                if (firmList != null)
                {
                    firmList.Check = !firmList.Check;

                    if (firmList.Check)
                        _collector.Add(firmList);
                    else
                        _collector.Remove(firmList);

                    UpdateStat();
                }
            }
        }

        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                FirmList firmList = GetFirmListByRowIndex(e.RowIndex);

                if (firmList != null)
                {
                    firmList.Check = !firmList.Check;

                    if (firmList.Check)
                        _collector.Add(firmList);
                    else
                        _collector.Remove(firmList);

                    UpdateStat();
                }
            }
        }

        private void dataGridViewList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                dataGridViewList.EndEdit();
            }
        }

        private void dataGridViewList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index)
            {
                CheckReverse();
                dataGridViewList.EndEdit();
            }
        }

        #endregion

        #region Очередь отчетов на печать

        private void _reportsQueue_AddedObject(object sender, EventArgs e)
        {
            if (_reportsQueue.Count > 0)
            {
                SingleReportData s = _reportsQueue.Dequeue();
                ShowReportMassAsync(s);
            }
        }

        #endregion

        private void LoadReportMenu()
        {
            
        }

        private void dataGridViewList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void GeneralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Info("Завершение программы.");
        }

        private void authMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            if (authForm.ShowDialog(this) == DialogResult.OK)
            {
                _auth = authForm.Auth;
            }
        }

        private async void printerMenuItem_Click(object sender, EventArgs e)
        {
            PrinterForm printerForm = new PrinterForm();
            if (printerForm.ShowDialog(this) == DialogResult.OK)
            {
                await LoadConfigs();
            }
        }

        private async void configMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog(this) == DialogResult.OK)
            {
                await LoadConfigs();
            }
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.ReportErrors = true;
            AutoUpdater.Start("https://worldcount.ru/updates/repo/LK/update.json");
        }

        private void valueReportMenuItem_Click(object sender, EventArgs e)
        {
            ValueReportForm valueReportForm = new ValueReportForm();
            if (valueReportForm.ShowDialog(this) == DialogResult.OK)
            {

            }

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void parseOrgConfigMenuItem_Click(object sender, EventArgs e)
        {
            FirmRowForm firmRowForm = new FirmRowForm();
            firmRowForm.ShowDialog(this);
        }

        private void parseRpoConfigMenuItem_Click(object sender, EventArgs e)
        {
            RpoRowForm rpoRowForm = new RpoRowForm();
            rpoRowForm.ShowDialog(this);
        }
    }
}
