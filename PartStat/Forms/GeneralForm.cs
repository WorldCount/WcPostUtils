using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using NLog;
using PartStat.Core;
using PartStat.Core.Libs;
using PartStat.Core.Libs.DataBase;
using PartStat.Core.Libs.DataBase.Queries;
using PartStat.Core.Libs.DataBase.Queries.RequestObject;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Libs.Print;
using PartStat.Core.Libs.Stats;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.License;
using PartStat.Core.Models;
using PartStat.Core.Models.DataReports;
using PartStat.Core.Models.DB;
using PartStat.Core.Models.PostTypes;
using PartStat.Core.Models.Tarifs;
using PartStat.Forms.TarifForms;
using WcApi.Print;
using WcApi.Win32.Forms;

namespace PartStat.Forms
{
    public partial class GeneralForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private List<Firm> _firms;
        private List<MailType> _mailTypes;
        private List<MailCategory> _mailCategories;
        private List<ListStatus> _listStatuses;
        private List<FirmList> _firmLists;

        private FirmListStatCollector _collector;

        private Config _ndsConfig;
        private Config _valueConfig;
        private Config _lastLoadConfig;

        private Connect _connect;

        private Color _warnBackColor;
        private Color _warnForeColor;
        private Color _errBackColor;
        private Color _errForeColor;

        private int _printPagesCount;

        private bool _isAdmin;

        private bool _checkAllFlag = true;

        private readonly string _key = LicenseKey.Key;

        private readonly int[] _ignoreCols = { 0, 10 };
        private readonly int[] _columnWidth = { 0, 70, 60, 150, 50, 50, 90, 80, 60, 60, 0, 40, 60 };

        // Очередь отчетов для печати
        private readonly ReportQueue<SingleReportData> _reportsQueue = new ReportQueue<SingleReportData>();

        public GeneralForm()
        {
            InitializeComponent();

            Logger.Info("Запуск программы.");

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";

            // Пробная лицензия на 30 дней
            GetTrialLicense();

            _connect = DataBase.GetConnect(PathManager.ConnectPath);

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridViewList);

            // Инициализация начальных данных
            InitialData();

            // Загрузка данных для фильтров
            LoadAllData();
            // Настройка таблицы
            InitDataGridView();

            // Подсказки
            InitTooltips();

            _reportsQueue.AddedObject += _reportsQueue_AddedObject;

            // TODO: Тестовая дата для отладки
            //dateTimePickerIn.Value = new DateTime(2020, 07, 28);
        }

        private void InitTooltips()
        {
            ToolTip toolTipLoad = new ToolTip();
            ToolTip toolTipPrint = new ToolTip();
            ToolTip toolTipClear = new ToolTip();
            ToolTip toolTipReport = new ToolTip();
            ToolTip toolTipPrintReport = new ToolTip();
            ToolTip toolTipLock = new ToolTip();

            toolTipLoad.SetToolTip(btnLoad, "Загрузить [Ctrl + Q]");
            toolTipPrint.SetToolTip(btnTablePrint, "Печать таблицы [Ctrl + P]");
            toolTipClear.SetToolTip(btnClearFilter, "Очистить фильтры [Ctrl + Shift + C]");
            toolTipReport.SetToolTip(btnReport, "Отчет по весу [Ctrl + O]");
            toolTipPrintReport.SetToolTip(btnPrintReport, "Печать отчета по весу [Ctrl + R]");
            toolTipLock.SetToolTip(btnLock, "Блокировать приложение [Ctrl + L]");
        }

        #region Лицензия

        private async void CheckLicense()
        {
            string license = Properties.Settings.Default.License;
            labelLicense.Text = WcApi.Cryptography.License.GetLicenseExpiresString(license, _key);

            if (_isAdmin)
                return;

            if (!WcApi.Cryptography.License.CheckLicense(license, _key))
            {
                await Utils.Telegram.SendMessage("Лицензия истекла.");
                
                LicenseForm licenseForm = new LicenseForm(license, _key, Application.ProductName, Application.ProductVersion, Properties.Settings.Default.MailLicense, Icon);
                if (licenseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.License = licenseForm.LicenseKey;
                    Properties.Settings.Default.Save();
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
                string licenseKey = WcApi.Cryptography.License.GetLicenseKey(licenseExp, _key);
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

            // Параметры запуска приложения
            CheckArgs();
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
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadPos();
            LoadSettings();
            // Проверка лицензии
            CheckLicense();
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

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.Text = "";
        }

        #endregion

        #region Загрузка данных

        private void InitialData()
        {
            if (!File.Exists(PathManager.MailCategoryPath))
            {
                MailCategoryQuery mailCategoryQuery = new MailCategoryQuery(_connect);
                List<MailCategory> mailCategories = mailCategoryQuery.Run();
                mailCategoryQuery.Dispose();
                if(mailCategories != null)
                    MailCategoryManager.Save(mailCategories);
            }

            if (!File.Exists(PathManager.MailTypePath))
            {
                MailTypeQuery mailTypeQuery = new MailTypeQuery(_connect);
                List<MailType> mailTypes = mailTypeQuery.Run();
                mailTypeQuery.Dispose();
                if(mailTypes != null)
                    MailTypeManager.Save(mailTypes);
            }

            if (!File.Exists(PathManager.ListStatusPath))
            {
                ListStatusQuery listStatusQuery = new ListStatusQuery(_connect);
                List<ListStatus> listStatuses = listStatusQuery.Run();
                listStatusQuery.Dispose();
                if(listStatuses != null)
                    ListStatusManager.Save(listStatuses);
            }

            btnRevise.Checked = false;
            btnRevise.Text = "Сверка: Выкл";
        }

        private void LoadAllData()
        {
            LoadFirms();
            LoadMailTypes();
            LoadMailCategories();
            LoadListStatuses();
            LoadColors();
            LoadConfigs();

            errorListBindingSource.DataSource = null;
            errorListBindingSource.DataSource = ErrorListManager.ErrorLists;

            interTypeBindingSource.DataSource = null;
            interTypeBindingSource.DataSource = InterTypeManager.InterTypes;

            createListBindingSource.DataSource = null;
            createListBindingSource.DataSource = CreateListManager.CreateLists;
        }

        private void LoadColors()
        {
            _errBackColor = DataColorManager.GetDataColorByName(ColorName.ErrorBack).GetColor();
            _errForeColor = DataColorManager.GetDataColorByName(ColorName.ErrorFore).GetColor();
            _warnBackColor = DataColorManager.GetDataColorByName(ColorName.WarnBack).GetColor();
            _warnForeColor = DataColorManager.GetDataColorByName(ColorName.WarnFore).GetColor();
        }

        private void LoadFirmList()
        {
            Firm firm =  (Firm) comboBoxOrgs.SelectedItem;
            MailType mailType = (MailType) comboBoxMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory) comboBoxMailCategory.SelectedItem;
            ListStatus listStatus = (ListStatus) comboBoxListStatus.SelectedItem;
            ErrorList errorList = (ErrorList) comboBoxErrorList.SelectedItem;
            InterType interType = (InterType) comboBoxListClass.SelectedItem;
            CreateList createList = (CreateList) comboBoxCreateList.SelectedItem;
            NoticeTarif interNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Международное);

            if(firm == null)
                firm = new Firm { Inn = "", Name = "ВСЕ" };

            FirmRequest queryObject = new FirmRequest
            {
                InDate = dateTimePickerIn.Value,
                OutDate = dateTimePickerOut.Value,
                Inn = firm.Inn,
                Kpp = firm.Kpp,
                DepCode = firm.DepCode,
                MailType = mailType.Id,
                MailCategory = mailCategory.Id,
                Status = listStatus.Id,
                StartNum = textBoxListIn.Text,
                EndNum = textBoxListOut.Text,
                InterCode = interType.Code,
                CreateListType = createList.Type
            };

            FirmListQuery firmListQuery = new FirmListQuery(_connect, queryObject);

            //ErrorForm errorForm = new ErrorForm(query.GetQuery(), "Запрос");
            //errorForm.ShowDialog(this);

            _firmLists = firmListQuery.Run(_ndsConfig.GetIntValue(), _valueConfig.GetIntValue(), errorList.ErrorType, interNoticeTarif.Rate);

            UpdateFirmList();

            _collector = new FirmListStatCollector(_firmLists);
            UpdateStat();

            _checkAllFlag = true;

            btnRevise.Checked = false;
            if (_firmLists != null)
                btnRevise.Enabled = true;
        }

        private void UpdateStat()
        {
            if (_collector != null)
            {
                statDataBindingSource.DataSource = null;
                statDataBindingSource.DataSource = _collector.GetListStat();
            }
        }

        private void LoadConfigs()
        {
            _ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);
            _valueConfig = ConfigManager.GetConfigByName(ConfigName.Value);
            _lastLoadConfig = ConfigManager.GetConfigByName(ConfigName.LastLoadReportDate);

            if (_lastLoadConfig == null)
            {
                _lastLoadConfig = new Config(ConfigName.LastLoadReportDate, DateTime.Today.ToString(CultureInfo.InvariantCulture));
                ConfigManager.Update(ConfigName.LastLoadReportDate, _lastLoadConfig);
            }

            if (_lastLoadConfig.GetDateTimeValue() < DateTime.Today)
            {
                _lastLoadConfig.Value = DateTime.Today.ToString(CultureInfo.InvariantCulture);
                ConfigManager.Update(ConfigName.LastLoadReportDate, _lastLoadConfig);
            }

        }

        private void LoadFirms()
        {
            Firm firm = new Firm {Inn = "", Name = "ВСЕ"};

            FirmQuery firmQuery = new FirmQuery(_connect);
            _firms = firmQuery.Run();
            firmQuery.Dispose();

            if(_firms != null)
                _firms.Insert(0, firm);
            else
            {
                _firms = new List<Firm>();
                _firms.Insert(0, firm);
                WarningMessage("Список организаций не загружен.");
            }

            UpdateFirms();

            SuccessMessage("Список организаций успешно загружен.");
        }

        private void LoadMailTypes()
        {
            MailType mailType = new MailType {Enable = true, Id = 0, Name = "ВСЕ", ShortName = "ВСЕ"};

            _mailTypes = MailTypeManager.GetEnabled();
            _mailTypes.Insert(0, mailType);

            UpdateMailTypes();
        }

        private void LoadMailCategories()
        {
            MailCategory mailCategory = new MailCategory {Enable = true, Id = 0, Name = "ВСЕ", ShortName = "ВСЕ"};

            _mailCategories = MailCategoryManager.GetEnabled();
            _mailCategories.Insert(0, mailCategory);

            UpdateMailCategories();
        }

        private void LoadListStatuses()
        {
            ListStatus listStatus = new ListStatus {Enable = true, Id = 'A', Name = "ВСЕ"};

            _listStatuses = ListStatusManager.GetEnabled();
            _listStatuses.Insert(0, listStatus);

            UpdateListStatuses();
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

        private void UpdateListStatuses()
        {
            listStatusBindingSource.DataSource = null;
            listStatusBindingSource.DataSource = _listStatuses;
        }

        private void UpdateFirmList()
        {
            firmListBindingSource.DataSource = null;
            firmListBindingSource.DataSource = _firmLists;
        }

        #endregion

        #region Методы

        private async Task<int> GetPrintPagesCount()
        {
            Firm firm = new Firm { Inn = "", Name = "ВСЕ" };
            string reportName = $"Отчет по файлам: {firm.Name}".ToUpper();

            int count = 0;

            List<FirmList> checkedFirmList = new List<FirmList>();
            if (_firmLists != null)
                checkedFirmList = _firmLists.Where(f => f.Check).ToList();

            if (checkedFirmList.Count > 0)
            {
                ListFirmPrintDocument document =
                    new ListFirmPrintDocument(dataGridViewList, checkedFirmList, _columnWidth, _ignoreCols)
                    {
                        DocumentName = reportName,
                        PrintNumPageInfo = true,
                        PrintController = new PreviewPrintController(),
                    };

                document.PrintPage += (s, ev) => count++;
                document.SetStat(dataGridViewStat, _collector.GetListStat());

                Task task = Task.Run(() =>
                {
                    document.Print();
                });
                await task;
            }

            return count;
        }

        private FirmList GetFirmListByRowIndex(int rowIndex)
        {
            try
            {
                List<FirmList> firmLists = (List<FirmList>) firmListBindingSource.DataSource;

                if (firmLists != null && firmLists.Count > 0)
                {
                    FirmList firm = firmLists[rowIndex];
                    return firm;
                }
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при выборке списка по индексу в таблице: {e.Message}");
                Logger.Error($"{e}");
                return null;
            }

            return null;
        }

        private Firm GetSelectFirm()
        {
            return (Firm) comboBoxOrgs.SelectedItem;
        }

        private Firm GetFirmByName(string name)
        {
            return _firms.FirstOrDefault(f => f.Name == name);
        }

        private FirmList GetFirmListByNameAndNumList(string name, int numList)
        {
            return _firmLists.Where(f => f.FirmName == name).FirstOrDefault(f => f.Num == numList);
        }

        private void CheckAll(string firmName = null)
        {
            foreach (FirmList firmList in _firmLists)
            {
                if (firmName != null)
                {
                    if (firmName == firmList.FirmName)
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

            dataGridViewList.Update();
            dataGridViewList.Refresh();
        }

        private void UncheckAll(string firmName = null)
        {
            foreach (FirmList firmList in _firmLists)
            {
                if (firmName != null)
                {
                    if (firmName == firmList.FirmName)
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

            dataGridViewList.Update();
            dataGridViewList.Refresh();
        }

        private void InverseCheck()
        {
            foreach (FirmList firmList in _firmLists)
            {
                firmList.Check = !firmList.Check;
            }

            _collector = new FirmListStatCollector(_firmLists);
            UpdateStat();

            dataGridViewList.Update();
            dataGridViewList.Refresh();
        }

        private List<FirmList> GetCheckedFirmLists()
        {
            return _firmLists?.Where(f => f.Check).ToList();
        }

        private async void ShowReportMassAsync(SingleReportData singleReport)
        {
            await Task.Factory.StartNew(() =>
            {
                if (singleReport == null)
                    return;

                singleReport.RpoCollector = new RpoStatCollector(singleReport.Rpos);
                singleReport.CityCollector = new CityStatCollector(singleReport.Rpos);

                ReportMassForm reportMassForm = new ReportMassForm(singleReport);

                PrintController printController = new StandardPrintController();

                MassReportPrintDocument document = reportMassForm.GetPrintDocument();
                document.PrintController = printController;
                document.Print();
            });
            // await t;
            //await Task.Run(() => );
        }

        private void ShowReportMass(SingleReportData singleReport, bool fastPrint = false, bool revise = false)
        {
            if (singleReport == null)
                return;

            singleReport.RpoCollector = new RpoStatCollector(singleReport.Rpos);
            singleReport.CityCollector = new CityStatCollector(singleReport.Rpos);

            ReportMassForm reportMassForm = new ReportMassForm(singleReport);

            if (!fastPrint)
            {
                reportMassForm.ShowDialog(this);
                if (revise)
                {
                    FirmList firmList = GetFirmListByNameAndNumList(singleReport.Name, reportMassForm.NumList);
                    if (firmList != null)
                        firmList.Check = true;

                    _collector = new FirmListStatCollector(_firmLists);
                    UpdateStat();

                    dataGridViewList.Update();
                    dataGridViewList.Refresh();
                }
            }
            else
            {
                PrintController printController = new StandardPrintController();

                MassReportPrintDocument document = reportMassForm.GetPrintDocument();
                document.PrintController = printController;
                document.Print();
            }
        }

        private SingleReportData GetRpoByFirm(List<FirmList> checkedFirmLists, Firm firm)
        {
            MailType mailType = (MailType)comboBoxMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory)comboBoxMailCategory.SelectedItem;
            ListStatus listStatus = (ListStatus)comboBoxListStatus.SelectedItem;
            InterType interType = (InterType)comboBoxListClass.SelectedItem;
            CreateList createList = (CreateList)comboBoxCreateList.SelectedItem;

            List<DateTime> dates = checkedFirmLists.Select(d => d.Date).ToList();

            SingleReportData singleReport = new SingleReportData
            {
                Name = firm.Name,
                NumDog = firm.NumDog,
                Inn = firm.Inn,
                DateList = dates.GroupBy(x => x.Date).Select(y => y.FirstOrDefault()).ToList(),
                NumsList = new List<DateList>()
            };

            foreach (DateTime dateTime in singleReport.DateList)
            {
                List<FirmList> firmListToDate = checkedFirmLists.Where(f => f.Date == dateTime).ToList();
                singleReport.NumsList.Add(new DateList(firmListToDate));

                if (singleReport.NumsList.Count == 0)
                    continue;

                RpoRequest queryObject = new RpoRequest
                {
                    Inn = firm.Inn,
                    Kpp = firm.Kpp,
                    DepCode = firm.DepCode,
                    MailCategory = mailCategory.Id,
                    MailType = mailType.Id,
                    Status = listStatus.Id,
                    InterCode = interType.Code,
                    CreateListType = createList.Type,
                    Date = dateTime,
                    NumsList = singleReport.NumsList[singleReport.NumsList.Count - 1].NumsToString()
                };

                RpoFirmsQuery rpoFirmsQuery = new RpoFirmsQuery(_connect, queryObject);

                List<Rpo> rpos = rpoFirmsQuery.Run(_ndsConfig.GetIntValue(), _valueConfig.GetIntValue());
                rpoFirmsQuery.Dispose();
                singleReport.Rpos.AddRange(rpos);
            }

            return singleReport;
        }

        #endregion

        #region Меню

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm(PathManager.ConnectPath);
            if (connectForm.ShowDialog(this) == DialogResult.OK)
            {
                _connect = DataBase.GetConnect(PathManager.ConnectPath);
                InitialData();
                LoadAllData();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailCategoryForm mailCategoryForm = new MailCategoryForm(_connect);
            if(mailCategoryForm.ShowDialog(this) == DialogResult.OK)
                LoadMailCategories();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailTypeForm mailTypeForm = new MailTypeForm(_connect);
            if(mailTypeForm.ShowDialog(this) == DialogResult.OK)
                LoadMailTypes();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm(_connect);
            if(statusForm.ShowDialog(this) == DialogResult.OK)
                LoadListStatuses();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorForm colorForm = new ColorForm();
            if (colorForm.ShowDialog(this) == DialogResult.OK)
                LoadColors();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            if(configForm.ShowDialog(this) == DialogResult.OK)
                LoadConfigs();
        }

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailTarifForm mailTarifForm = new MailTarifForm();
            mailTarifForm.ShowDialog(this);
        }

        private void parcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcelTarifForm parcelTarifForm = new ParcelTarifForm();
            parcelTarifForm.ShowDialog(this);
        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoticeTarifForm noticeTarifForm = new NoticeTarifForm();
            noticeTarifForm.ShowDialog(this);
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
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
                Properties.Settings.Default.Save();
            }
        }

        private void firstMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstMailTarifForm firstMailTarifForm = new FirstMailTarifForm();
            firstMailTarifForm.ShowDialog(this);
        }

        private void firstParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstParcelTarifForm firstParcelTarifForm = new FirstParcelTarifForm();
            firstParcelTarifForm.ShowDialog(this);
        }

        private void interMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterMailTarifForm interMailTarifForm = new InterMailTarifForm();
            interMailTarifForm.ShowDialog(this);
        }

        private void interParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterParcelTarifForm interParcelTarifForm = new InterParcelTarifForm();
            interParcelTarifForm.ShowDialog(this);
        }

        #endregion

        #region Контекстное меню

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_firmLists == null || _firmLists.Count == 0)
            {
                checkAllToolStripMenuItem.Enabled = false;
                uncheckAllToolStripMenuItem.Enabled = false;
            }
            else
            {
                checkAllToolStripMenuItem.Enabled = true;
                uncheckAllToolStripMenuItem.Enabled = true;

                if (_isAdmin)
                    setHandToolStripMenuItem.Enabled = true;
            }
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
            ToolStripMenuItem item = (ToolStripMenuItem) sender;
            FirmList firmList = (FirmList) item.Tag;

            if (firmList != null)
            {
                firmList.SetManual(!firmList.Manual, _connect);
                btnLoad.PerformClick();
            }
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

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerIn.Value;
            dateTimePickerOut.Value = date;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFirmList();
            ColoredDataGridView();

            _printPagesCount = 0;
            _printPagesCount = await GetPrintPagesCount();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            List<FirmList> checkedFirmLists = GetCheckedFirmLists();
            if(checkedFirmLists == null || checkedFirmLists.Count == 0)
                return;

            // Firm firm = (Firm)comboBoxOrgs.SelectedItem ?? new Firm { Inn = "", Name = "ВСЕ" };
            Firm firm = GetSelectFirm();
            if(firm == null)
                return;

            SingleReportData singleReport = GetRpoByFirm(checkedFirmLists, firm);
            ShowReportMass(singleReport);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            List<FirmList> checkedFirmLists = GetCheckedFirmLists();
            if (checkedFirmLists == null || checkedFirmLists.Count == 0)
                return;

            Firm firm = GetSelectFirm();
            if (firm == null)
                return;

            SingleReportData singleReport = GetRpoByFirm(checkedFirmLists, firm);

            //await Task.Run(() =>
            //{
            //    ShowReportMass(singleReport, true);
            //});
            _reportsQueue.Enqueue(singleReport);
            //comboBoxOrgs.Focus();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm
            {
                WindowBorderColor = Color.SeaGreen,
                LockMode = true,
                WindowsBorderStyle = ButtonBorderStyle.Dashed,
                AppIcon = Icon,
                AppText = "PartStat 4",
                AppVersion = $"{Application.ProductName} {Application.ProductVersion}",
                Verbose = false,
                Secret = "6022"
            };

            if (loginForm.ShowDialog(this) == DialogResult.Cancel)
                Close();
        }

        // TODO: Временный костыль. Переделать статистику для всех рпо
        private void comboBoxOrgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Firm firm = (Firm)comboBoxOrgs.SelectedItem;
            if (firm == null || string.IsNullOrEmpty(firm.Inn))
            {
                btnReport.Enabled = false;
                btnPrintReport.Enabled = false;
            }
            else
            {
                btnReport.Enabled = true;
                btnPrintReport.Enabled = true;
            }
        }

        private void dataGridViewList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewList.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = dataGridViewList.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverCol >= 0)
                {
                    dataGridViewList.ClearSelection();
                    dataGridViewList.Rows[currentMouseOverRow].Cells[currentMouseOverCol].Selected = true;

                    FirmList firmList = GetFirmListByRowIndex(currentMouseOverRow);

                    if (firmList != null)
                    {
                        checkFirmListStripMenuItem.Text = $"Отметить {firmList.FirmName}";
                        checkFirmListStripMenuItem.Tag = firmList.FirmName;
                        checkFirmListStripMenuItem.Enabled = true;

                        uncheckFirmListStripMenuItem.Text = $"Убрать отметки с {firmList.FirmName}";
                        uncheckFirmListStripMenuItem.Tag = firmList.FirmName;
                        uncheckFirmListStripMenuItem.Enabled = true;

                        setHandToolStripMenuItem.Text = firmList.Manual ? "Сделать обычным списком" : "Сделать ручным списком";
                        setHandToolStripMenuItem.Tag = firmList;
                    }
                    else
                    {
                        checkFirmListStripMenuItem.Text = "Отметить организацию";
                        checkFirmListStripMenuItem.Tag = "";
                        checkFirmListStripMenuItem.Enabled = false;

                        uncheckFirmListStripMenuItem.Text = "Убрать отметки с организации";
                        uncheckFirmListStripMenuItem.Tag = "";
                        uncheckFirmListStripMenuItem.Enabled = false;
                    }

                    contextMenuStrip.Show(dataGridViewList, new Point(e.X, e.Y));
                }

            }
        }

        private void dataGridViewList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int currentMouseOverRow = dataGridViewList.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = dataGridViewList.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverCol >= 0 && currentMouseOverCol != checkDataGridViewCheckBoxColumn.Index)
                {
                    FirmList firmList = GetFirmListByRowIndex(currentMouseOverRow);
                    Firm firm = GetFirmByName(firmList.FirmName);
                    SingleReportData singleReport = GetRpoByFirm(new List<FirmList> { firmList }, firm);
                    ShowReportMass(singleReport);
                }
            }
        }

        private void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbBarcode.Text.Trim().Length >= 13)
            {

                Firm firm = (Firm)comboBoxOrgs.SelectedItem;
                DateTime inDate = dateTimePickerIn.Value;
                DateTime outDate = dateTimePickerOut.Value;

                BarcodeRequest queryObject = new BarcodeRequest
                {
                    Barcode = tbBarcode.Text.Trim(),
                    Inn = firm.Inn,
                    Kpp = firm.Kpp,
                    DepCode = firm.DepCode,
                    InDate = inDate,
                    OutDate = outDate
                };

                NoticeTarif interNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Международное);

                BarcodeQuery barcodeQuery = new BarcodeQuery(_connect, queryObject);
                FirmList firmList = barcodeQuery.Run(_ndsConfig.GetIntValue(), _valueConfig.GetIntValue(), interNoticeRate: interNoticeTarif.Rate);


                if (firmList != null)
                {
                    Firm newFirm = new Firm
                    {
                        DepCode = firmList.DepCode,
                        Inn = firmList.Inn,
                        Kpp = firmList.Kpp,
                        NumDog = "1",
                        Name = firmList.FirmName
                    };

                    SingleReportData singleReport = GetRpoByFirm(new List<FirmList>{firmList}, newFirm);

                    if (singleReport.Rpos.Count > 0)
                    {
                        ShowReportMass(singleReport, revise: btnRevise.Checked);
                    }

                    tbBarcode.Clear();
                }
            }
        }

        private void btnTablePrint_Click(object sender, EventArgs e)
        {
            List<FirmList> checkedFirmList = new List<FirmList>();

            Firm firm = (Firm)comboBoxOrgs.SelectedItem ?? new Firm { Inn = "", Name = "ВСЕ" };

            string reportName = $"Отчет по файлам: {firm.Name}".ToUpper();

            if (_firmLists != null)
                checkedFirmList = _firmLists.Where(f => f.Check).ToList();

            if (checkedFirmList.Count > 0)
            {
                ListFirmPrintDocument document =
                    new ListFirmPrintDocument(dataGridViewList, checkedFirmList, _columnWidth, _ignoreCols)
                    {
                        DocumentName = reportName,
                        PrintNumPageInfo = true,
                        PagesCount = _printPagesCount
                    };

                document.SetStat(dataGridViewStat, _collector.GetListStat());

                if (checkBoxPrintPreview.Checked)
                {
                    using (GridPrintPreviewDialog printPreviewDialog = new GridPrintPreviewDialog())
                    {
                        printPreviewDialog.Text = reportName;
                        printPreviewDialog.Document = document;
                        printPreviewDialog.ShowDialog(this);
                    }
                }
                else
                {
                    document.Print();
                }
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            comboBoxErrorList.SelectedIndex = 0;
            comboBoxMailType.SelectedIndex = 0;
            comboBoxMailCategory.SelectedIndex = 0;
            comboBoxListStatus.SelectedIndex = 0;

            comboBoxOrgs.SelectedIndex = 0;

            comboBoxListClass.SelectedIndex = 0;
            comboBoxCreateList.SelectedIndex = 0;

            textBoxListIn.Clear();
            textBoxListOut.Clear();
            tbBarcode.Clear();

            dateTimePickerIn.Value = DateTime.Today;
            dateTimePickerOut.Value = DateTime.Today;
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
                btnLock.PerformClick();

            // Нажатие Ctrl + F
            if (e.KeyCode == Keys.F && e.Control)
                tbBarcode.Focus();

            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                comboBoxOrgs.Focus();
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            if(_firmLists != null && _firmLists.Count > 0)
                CheckAll();
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            if (_firmLists != null && _firmLists.Count > 0)
                UncheckAll();
        }

        private void checkBoxPrintPreview_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPrintPreview.Image = checkBoxPrintPreview.Checked ? Properties.Resources.white_checked_32 : Properties.Resources.white_unchecked_32;
        }

        private void btnRevise_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRevise.Checked)
            {
                btnRevise.Text = "Сверка: Вкл";
                UncheckAll();
                tbBarcode.Focus();
            }
            else
            {
                btnRevise.Text = "Сверка: Выкл";
            }
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
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Столбец с номером списка
            numDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numDataGridViewTextBoxColumn.Width = 80;
            // Столбец с типом отправления
            mailTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mailTypeDataGridViewTextBoxColumn.Width = 210;
            // Столбец с категорией отправления
            MailCategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MailCategoryName.Width = 120;
            // Столбец с классом отправления
            interNameGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            interNameGridViewTextBoxColumn.Width = 70;
            //
            manualNameGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            manualNameGridViewTextBoxColumn.Width = 60;
            // Столбец с количеством отправлений
            countDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            countDataGridViewTextBoxColumn.Width = 80;
            // Столбец с отметками
            postMarkNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            postMarkNameDataGridViewTextBoxColumn.Width = 160;
            // Столбец с замечаниями
            warnCountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            warnCountDataGridViewTextBoxColumn.Width = 60;
            // Столбец с выбывшими
            errCountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            errCountDataGridViewTextBoxColumn.Width = 60;
            // Столбец со сбором
            massRateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            massRateDataGridViewTextBoxColumn.Width = 100;
        }

        private void ColoredDataGridView()
        {
            for (int index = 0; index <= dataGridViewList.RowCount - 1; index++)
            {
                DataGridViewRow row = dataGridViewList.Rows[index];
                FirmList firmList = _firmLists[index];

                if (firmList.WarnCount > 0)
                {
                    row.DefaultCellStyle.BackColor = _warnBackColor;
                    row.DefaultCellStyle.ForeColor = _warnForeColor;
                }

                if (firmList.ErrCount > 0)
                {
                    row.DefaultCellStyle.BackColor = _errBackColor;
                    row.DefaultCellStyle.ForeColor = _errForeColor;
                }
            }
        }

        private void dataGridViewList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
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
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                FirmList firm = GetFirmListByRowIndex(e.RowIndex);

                if (firm != null)
                {
                    firm.Check = !firm.Check;

                    if (firm.Check)
                        _collector.Add(firm);
                    else
                        _collector.Remove(firm);

                    UpdateStat();
                }
            }
        }

        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex !=  -1)
            {
                FirmList firm = GetFirmListByRowIndex(e.RowIndex);

                if (firm != null)
                {
                    firm.Check = !firm.Check;

                    if (firm.Check)
                        _collector.Add(firm);
                    else
                        _collector.Remove(firm);

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
                if (_checkAllFlag)
                    UncheckAll();
                else
                    CheckAll();
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

        private void comboBoxOrgs_DropDown(object sender, EventArgs e)
        {
        }

        private void comboBoxOrgs_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            
        }
    }
}
