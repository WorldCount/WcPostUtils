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
using LK.Core.Libs.Stat;
using LK.Core.Libs.Widget;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Models.Filters;
using LK.Core.Models.Reports;
using LK.Core.Models.Types;
using LK.Core.Store;
using LK.Core.Store.ExportFile;
using LK.Core.Store.Manager;
using LK.Forms.ConfigForms;
using LK.Forms.DataForms;
using LK.Forms.ReportForms;
using LK.Forms.TarifForms;
using LK.Forms.TypeForms;
using Newtonsoft.Json;
using NLog;
using Wc32Api.Messages;
using Wc32Api.Widgets.Buttons;
using WcApi.Cryptography;
using WcApi.Net;

namespace LK.Forms
{
    public partial class GeneralForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private bool _loggingMode = Properties.Settings.Default.LoggingMode;
        private readonly StatusMessage _message;

        #region Настройки

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

        // Очередь отчетов для печати
        private readonly ReportQueue<SingleReportData> _reportsQueue = new ReportQueue<SingleReportData>();

        #region Выгрузка

        private List<int> _exportIdFirms = new List<int>();
        private List<Rpo> _exportRpos = new List<Rpo>();

        #endregion

        #endregion

        #region Конфиги

        private Config _defaultPrinterConfig;
        private Config _exportPathConfig;

        #endregion

        public GeneralForm()
        {
            InitializeComponent();

            WebRequest.DefaultWebProxy = null;

            if(_loggingMode)
                Logger.Info("Запуск программы.");

            _message = new StatusMessage(statusText);

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

            // Загрузка меню с отчетами
            LoadReportMenu();

            _reportsQueue.AddedObject += _reportsQueue_AddedObject;

            AutoUpdater.Proxy = null;
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdater_ParseUpdateInfoEvent;
        }

        #region Настройка формы

        private void LoadSettings()
        {
            checkBoxPrintPreview.Checked = Properties.Settings.Default.PrintPreviewFlag;
            checkBoxAutoLoad.Checked = Properties.Settings.Default.AutoLoadFlag;
            wcToggleButtonClear.Checked = Properties.Settings.Default.AutoClearFlag;
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
        }

        private async void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadSettings();

            await CreateDirs();

            // Параметры запуска приложения
            await Task.Run(CheckArgs);

            await CreateDb();

            // Загрузка данных для фильтров
            await LoadAllData();

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

        #region Загрузка данных

        private void InitialData()
        {
        }

        private async Task LoadAllData()
        {
            bool clear = wcToggleButtonClear.Checked;

            if(clear || comboBoxListClass.DataSource == null)
                comboBoxListClass.DataSource = Enum.GetNames(typeof(MailClass));

            if(clear || comboBoxErrorList.DataSource == null)
                comboBoxErrorList.DataSource = Enum.GetNames(typeof(ErrorType));

            _auth = Auth.Load(PathManager.AuthPath);

            if (clear)
            {
                await LoadOperator();
                await LoadFirms();
                await LoadMailTypes();
                await LoadMailCategories();
            }
            else
            {
                await LoadOperator(GetOperator());
                await LoadFirms(GetFirm());
                await LoadMailTypes(GetMailType());
                await LoadMailCategories(GetMailCategory());
            }

            await LoadMailTypesDataGrid();
            await LoadMailCategoriesDataGrid();
            await LoadConfigs();
        }

        private void LoadFirmLists()
        {
            Firm firm = GetFirm();
            MailType mailType = GetMailType();
            MailCategory mailCategory = GetMailCategory();
            Operator oper = GetOperator();
            int startNum = GetStartNumList();
            int endNum = GetEndNumList();

            if(firm == null)
                return;

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

                MailClass = GetMailClass(),
                ErrorType = GetErrorType()
            };

            _firmLists = Database.GetFirmsListManual(firmListFilter);
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
                _exportPathConfig = ConfigManager.GetConfigByName(ConfigName.ExportPath) ?? ConfigManager.CreateDefaultExportPath();
            });
            
        }

        private async Task LoadOperator(Operator oper = null)
        {
            await Task.Run(() =>
            {
                _operators = Database.GetAllOperator();
                _operators.Insert(0, new Operator { LastName = "ВСЕ", Id = 0});
            });

            UpdateOperators();

            if (oper != null)
            {
                int ind = comboBoxOperator.FindString(oper.ShortName);
                if (ind != -1)
                    comboBoxOperator.SelectedIndex = ind;
            }
        }

        private async Task LoadFirms(Firm firm = null)
        {
            await Task.Run(() =>
            {
                _firms = Database.GetFirms();
                _firms.Insert(0, new Firm { Inn = "", Name = "ВСЕ", ShortName = "ВСЕ" });
            });
            
            UpdateFirms();

            if (firm != null)
            {
                int ind = comboBoxOrgs.FindString(firm.ShortName);
                if (ind != -1)
                    comboBoxOrgs.SelectedIndex = ind;
            }
        }

        private async Task LoadMailTypes(MailType mailType = null)
        {
            await Task.Run(() =>
            {
                _mailTypes = Database.GetEnabledMailTypes();
                _mailTypes.Insert(0, new MailType { Id = 0, ShortName = "ВСЕ" });
            });

            UpdateMailTypes();

            if (mailType != null)
            {
                int ind = comboBoxMailType.FindString(mailType.ShortName);
                if (ind != -1)
                    comboBoxMailType.SelectedIndex = ind;
            }
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

        private async Task LoadMailCategories(MailCategory mailCategory = null)
        {
            await Task.Run(() =>
            {
                _mailCategories = Database.GetEnabledMailCategories();
                _mailCategories.Insert(0, new MailCategory { Id = 0, ShortName = "ВСЕ" });
                
            });

            UpdateMailCategories();

            if (mailCategory != null)
            {
                int ind = comboBoxMailCategory.FindString(mailCategory.ShortName);
                if (ind != -1)
                    comboBoxMailCategory.SelectedIndex = ind;
            }
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

        private void UpdateFirmList(List<FirmList> firmLists = null, DataGridViewColumn column = null, ListSortDirection sort = ListSortDirection.Ascending)
        {
            firmListBindingSource.DataSource = null;
            firmListBindingSource.DataSource = firmLists != null ? firmLists.ToSortableBindingList() : _firmLists.ToSortableBindingList();

            dataGridViewList.Sort(column ?? receptionDateDataGridViewTextBoxColumn, sort);
        }

        #endregion

        #endregion

        #region Методы

        #region Получение данных

        /// <summary>Оператор</summary>
        private Operator GetOperator()
        {
            try
            {
                return (Operator)comboBoxOperator.SelectedItem;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>Организация</summary>
        private Firm GetFirm()
        {
            try
            {
                return (Firm)comboBoxOrgs.SelectedItem;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>Тип отправления</summary>
        private MailType GetMailType()
        {
            try
            {
                return (MailType)comboBoxMailType.SelectedItem;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>Категория отправления</summary>
        private MailCategory GetMailCategory()
        {
            try
            {
                return (MailCategory)comboBoxMailCategory.SelectedItem;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>Класс отправления</summary>
        private MailClass GetMailClass()
        {
            try
            {
                string mailClass = (string)comboBoxListClass.SelectedItem;
                return (MailClass) Enum.Parse(typeof(MailClass), mailClass);
            }
            catch
            {
                return MailClass.ВСЕ;
            }
        }

        /// <summary>Ошибки с отправлениями</summary>
        private ErrorType GetErrorType()
        {
            try
            {
                string errorType = (string)comboBoxErrorList.SelectedItem;
                return (ErrorType) Enum.Parse(typeof(ErrorType), errorType);
            }
            catch
            {
                return ErrorType.ВСЕ;
            }
        }

        /// <summary>Начальный номер списка</summary>
        private int GetStartNumList()
        {
            try
            {
                string num = textBoxListIn.Text.Trim();
                return int.Parse(num);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>Конечный номер списка</summary>
        private int GetEndNumList()
        {
            try
            {
                string num = textBoxListOut.Text.Trim();
                return int.Parse(num);
            }
            catch
            {
                return 0;
            }
        }

        private FirmList GetFirmListByRowIndex(int rowIndex)
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

        private List<FirmList> GetCheckedFirmLists()
        {
            return GetFirmListsBySource()?.Where(f => f.Check).ToList();
        }

        private List<FirmList> GetFirmListsBySource()
        {
            SortableBindingList<FirmList> firmLists = (SortableBindingList<FirmList>)firmListBindingSource.DataSource;
            return firmLists?.ToList();
        }

        private Firm GetSelectFirm()
        {
            return (Firm)comboBoxOrgs.SelectedItem;
        }

        #endregion

        #region Init

        private void CreateButtonToolTip(WcButton button, string message)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button, message);
        }

        private void InitTooltips()
        {
            CreateButtonToolTip(btnLoad, "Загрузить [Ctrl + Q]");
            CreateButtonToolTip(btnTablePrint, "Печать таблицы [Ctrl + P]");
            CreateButtonToolTip(btnClearFilter, "Очистить фильтры [Ctrl + Shift + C]");
            CreateButtonToolTip(btnReport, "Отчет по весу [Ctrl + O]");
            CreateButtonToolTip(btnPrintReport, "Печать отчета по весу [Ctrl + R]");
            CreateButtonToolTip(btnSync, "Синхронизация ЛК [Ctrl + L]");

            CreateButtonToolTip(btnCheckAll, "Отметить все списки");
            CreateButtonToolTip(btnUncheckAll, "Снять отметки со всех списков");

            CreateButtonToolTip(btnAddRpo, "Добавить РПО [Ctrl + NumPlus]");
            CreateButtonToolTip(btnDelRpo, "Удалить РПО [Ctrl + NumMinus]");
            CreateButtonToolTip(btnClearRpo, "Очистить все РПО");
            CreateButtonToolTip(btnExportToFile, "Выгрузить в файл [Ctrl + S]");
        }

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

        private void InitDataGridView()
        {
            // Столбец с значком
            checkDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkDataGridViewCheckBoxColumn.Width = 40;
            checkDataGridViewCheckBoxColumn.CellTemplate.Style.BackColor = Color.FromArgb(53, 56, 58);
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

            // Столбец со сбором
            rateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rateDataGridViewTextBoxColumn.Width = 100;

            // Столбец с датой приемы
            receptionDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            receptionDateDataGridViewTextBoxColumn.Width = 140;

            operatorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            operatorDataGridViewTextBoxColumn.Width = 140;
        }

        #endregion

        #region Отметки

        private void CheckReverse()
        {
            List<FirmList> firmLists = GetFirmListsBySource();
            DataGridViewColumn col = dataGridViewList.SortedColumn;
            ListSortDirection sort = SortOrderToListSortDirection(dataGridViewList.SortOrder);

            if (firmLists == null)
                return;

            foreach (FirmList firmList in firmLists)
            {
                firmList.Check = !firmList.Check;
            }

            _collector = new FirmListStatCollector(firmLists);
            UpdateStat();

            UpdateFirmList(firmLists, col, sort);
        }

        private void CheckAll(string firmName = null)
        {
            List<FirmList> firmLists = GetFirmListsBySource();
            DataGridViewColumn col = dataGridViewList.SortedColumn;
            ListSortDirection sort = SortOrderToListSortDirection(dataGridViewList.SortOrder);

            if (firmLists == null)
                return;

            foreach (FirmList firmList in firmLists)
            {
                if (firmName != null)
                {
                    if (firmName == firmList.Firm.ShortName)
                        firmList.Check = true;
                }
                else
                {
                    firmList.Check = true;
                }
            }

            _collector = new FirmListStatCollector(firmLists);
            UpdateStat();

            UpdateFirmList(firmLists, col, sort);
        }

        private void UncheckAll(string firmName = null)
        {
            List<FirmList> firmLists = GetFirmListsBySource();
            DataGridViewColumn col = dataGridViewList.SortedColumn;
            ListSortDirection sort = SortOrderToListSortDirection(dataGridViewList.SortOrder);

            if (firmLists == null)
                return;

            foreach (FirmList firmList in firmLists)
            {
                if (firmName != null)
                {
                    if (firmName == firmList.Firm.ShortName)
                        firmList.Check = false;
                }
                else
                {
                    firmList.Check = false;
                }
            }

            _collector = new FirmListStatCollector(firmLists);
            UpdateStat();

            UpdateFirmList(firmLists, col, sort);
        }

        private void InverseCheck()
        {
            List<FirmList> firmLists = GetFirmListsBySource();
            DataGridViewColumn col = dataGridViewList.SortedColumn;
            ListSortDirection sort = SortOrderToListSortDirection(dataGridViewList.SortOrder);

            if (firmLists == null)
                return;

            foreach (FirmList firmList in firmLists)
            {
                firmList.Check = !firmList.Check;
            }

            _collector = new FirmListStatCollector(firmLists);
            UpdateStat();

            UpdateFirmList(firmLists, col, sort);
        }

        #endregion

        #region Sort

        private ListSortDirection SortOrderToListSortDirection(SortOrder order)
        {
            if (order == SortOrder.Descending)
                return ListSortDirection.Descending;
            return ListSortDirection.Ascending;
        }

        #endregion

        #region Reports

        private SingleReportData GetSingleReportData()
        {
            List<FirmList> checkedFirmLists = GetCheckedFirmLists();
            if (checkedFirmLists == null || checkedFirmLists.Count == 0)
                return null;

            Firm firm = GetSelectFirm();
            if (firm == null)
                return null;

            List<string> operators = new List<string>();
            List<int> firmIds = new List<int>();
            List<string> firmsNames = new List<string>();

            foreach (FirmList firmList in checkedFirmLists)
            {
                if (!operators.Contains(firmList.OperatorName))
                    operators.Add(firmList.OperatorName);

                if (!firmsNames.Contains(firmList.FirmName))
                    firmsNames.Add(firmList.FirmName);

                firmIds.Add(firmList.Id);
            }

            if (firmsNames.Count == 1)
                firm = _firms.FirstOrDefault(f => f.ShortName == firmsNames[0]);

            List<Rpo> rpos = Database.GetRposByListsIds(firmIds.ToArray());

            if (rpos.Count == 0)
                return null;

            List<DateTime> dates = checkedFirmLists.Select(d => d.Date).ToList();

            SingleReportData singleReport = new SingleReportData(firm, rpos)
            {
                DateList = dates.GroupBy(x => x.Date).Select(y => y.FirstOrDefault()).ToList(),
                NumsList = new List<DateList>(),
                Operators = operators
            };

            foreach (DateTime dateTime in singleReport.DateList)
            {
                List<FirmList> firmListToDate = checkedFirmLists.Where(f => f.Date == dateTime).ToList();
                singleReport.NumsList.Add(new DateList(firmListToDate));
            }

            return singleReport;
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

        #endregion

        #region Меню

        #region Меню - Настройки

        private async void createDbMenuItem_Click(object sender, EventArgs e)
        {
            CreateDbForm createDbForm = new CreateDbForm();
            createDbForm.ShowDialog(this);

            await LoadAllData();
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

                _loggingMode = Properties.Settings.Default.LoggingMode;
            }
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

        #endregion

        #region Меню - Тарифы

        private void serviceMenuItem_Click(object sender, EventArgs e)
        {
            ServiceTarifForm serviceTarifForm = new ServiceTarifForm();
            serviceTarifForm.ShowDialog(this);
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
        
        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.ReportErrors = true;
            AutoUpdater.Start("https://worldcount.ru/updates/repo/LK/update.json");
        }

        #endregion

        #region Меню - Отчеты

        private void editReportMenuItem_Click(object sender, EventArgs e)
        {
            ListReportsForm listReportsForm = new ListReportsForm();
            listReportsForm.ShowDialog(this);
            LoadReportMenu();
        }

        private void LoadReportMenu()
        {
            List<Report> reports = ReportManager.GetEnabled();
            allReportMenuItem.DropDownItems.Clear();

            foreach (Report report in reports)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(report.Name, Properties.Resources.Notebook_2, runCustomReportMenuItem_Click)
                {
                    Tag = report.Id,
                    ForeColor = Color.FromArgb(255, 53, 58, 66)
                };

                allReportMenuItem.DropDownItems.Add(item);
            }
        }

        private void runCustomReportMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int reportId = (int)item.Tag;

            CustomReportForm customReportForm = new CustomReportForm(reportId);
            customReportForm.ShowDialog(this);
        }

        private void valueReportMenuItem_Click(object sender, EventArgs e)
        {
            ValueReportForm valueReportForm = new ValueReportForm();
            if (valueReportForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void operReportMenuItem_Click(object sender, EventArgs e)
        {
            OperatorReportForm operatorReportForm = new OperatorReportForm();
            if (operatorReportForm.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        #endregion

        #region Меню - Файл

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #endregion

        #region Контекстное меню

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAll();
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAll();
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
            //TODO: Доделать печать таблицы
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
            _firmLists = new List<FirmList>();
            UpdateFirmList();

            SyncForm syncForm = new SyncForm(dateTimePickerIn.Value, dateTimePickerOut.Value, _auth);
            syncForm.ShowDialog(this);

            await LoadAllData();

            if(checkBoxAutoLoad.Checked)
                btnLoad.PerformClick();

            tbFilter.Clear();
        }

        private void btnExportToFile_Click(object sender, EventArgs e)
        {
            btnExportToFile.Enabled = false;
            btnAddRpo.Enabled = false;
            btnDelRpo.Enabled = false;
            btnClearRpo.Enabled = false;

            if (_exportRpos.Count == 0)
            {
                btnExportToFile.Enabled = true;
                btnAddRpo.Enabled = true;
                btnDelRpo.Enabled = true;
                btnClearRpo.Enabled = true;
                return;
            }

            ExportPartPostFile exportFile = new ExportPartPostFile();
            foreach (Rpo rpo in _exportRpos)
            {
                ExportFileString exportFileString = rpo.ToExportFileString();
                MailCategory c = _mailCategories.FirstOrDefault(d => d.Id == rpo.MailCategory);
                if (c != null)
                {
                    exportFileString.MailCtg = c.Code.ToString();
                    if (c.Code == 0)
                        continue;
                }

                MailType t = _mailTypes.FirstOrDefault(d => d.Id == rpo.MailType);
                if (t != null)
                    exportFileString.MailType = t.Code.ToString();

                exportFile.Add(exportFileString);
            }

            exportFile.ExportToFile(_exportPathConfig.Value);

            btnExportToFile.Enabled = true;
            btnAddRpo.Enabled = true;
            btnDelRpo.Enabled = true;
            btnClearRpo.Enabled = true;

            _exportRpos = new List<Rpo>();
            _exportIdFirms = new List<int>();
            lblRpoCount.Text = _exportRpos.Count.ToString();

            _message.SuccessMessage("Выгрузка завершена!");

            tbFilter.Focus();
            tbFilter.SelectAll();
        }

        private void btnAddRpo_Click(object sender, EventArgs e)
        {
            btnAddRpo.Enabled = false;

            List<FirmList> checkedFirmLists = GetCheckedFirmLists();
            if (checkedFirmLists == null || checkedFirmLists.Count == 0)
            {
                btnAddRpo.Enabled = true;
                return;
            }

            int[] ids = checkedFirmLists.Select(checkedFirmList => checkedFirmList.Id).ToArray();
            List<int> filtredIds = new List<int>();
            foreach (int id in ids)
            {
                if (!_exportIdFirms.Contains(id))
                {
                    filtredIds.Add(id);
                    _exportIdFirms.Add(id);
                }
            }

            List<Rpo> rpos = Database.GetRposByListsIds(filtredIds.ToArray());
            _exportRpos.AddRange(rpos);
            lblRpoCount.Text = _exportRpos.Count.ToString();

            btnAddRpo.Enabled = true;
            _message.SuccessMessage($"Добавлено {rpos.Count} РПО");

            tbFilter.Focus();
            tbFilter.SelectAll();
        }

        private void btnDelRpo_Click(object sender, EventArgs e)
        {
            btnDelRpo.Enabled = false;

            List<FirmList> checkedFirmLists = GetCheckedFirmLists();
            if (checkedFirmLists == null || checkedFirmLists.Count == 0)
            {
                btnDelRpo.Enabled = true;
                return;
            }

            int[] ids = checkedFirmLists.Select(checkedFirmList => checkedFirmList.Id).ToArray();
            List<int> filtredIds = new List<int>();
            foreach (int id in ids)
            {
                if (_exportIdFirms.Contains(id))
                {
                    filtredIds.Add(id);
                    _exportIdFirms.Remove(id);
                }
            }

            List<Rpo> rpos = Database.GetRposByListsIds(filtredIds.ToArray());

            int count = 0;

            foreach (Rpo rpo in rpos)
            {
                Rpo selectRpo = _exportRpos.FirstOrDefault(s => s.Id == rpo.Id);
                if (selectRpo != null)
                {
                    _exportRpos.Remove(selectRpo);
                    count++;
                }
            }

            lblRpoCount.Text = _exportRpos.Count.ToString();

            btnDelRpo.Enabled = true;
            _message.SuccessMessage($"Удалено {count} РПО");

            tbFilter.Focus();
            tbFilter.SelectAll();
        }

        private void btnClearRpo_Click(object sender, EventArgs e)
        {
            _exportRpos = new List<Rpo>();
            _exportIdFirms = new List<int>();
            lblRpoCount.Text = _exportRpos.Count.ToString();
            _message.SuccessMessage("Очищено.");
        }

        #endregion

        #region DataGrid Events

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

        private void dataGridViewList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var sortIconColor = Color.Gray;

            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                bool value = (bool)e.FormattedValue;
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

        private void dataGridViewList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        #endregion

        #region TextBox Events

        private async void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            string barcode = tbBarcode.Text.Trim();

            if (e.KeyCode == Keys.Enter && barcode.Length >= 13)
            {
                FirmList firmList = await Database.GetFirmListByBarcodeAsync(barcode);
                if (firmList != null)
                {
                    MessageBox.Show(firmList.Count.ToString());
                }

                tbBarcode.Clear();
            }
        }

        private void tbNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBarcode_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        private void tbFilter_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string q = tbFilter.Text.ToUpper();

            DataGridViewColumn col = dataGridViewList.SortedColumn;
            ListSortDirection sort = SortOrderToListSortDirection(dataGridViewList.SortOrder);

            if (!string.IsNullOrEmpty(q))
            {
                if (_firmLists != null && _firmLists.Count > 0)
                {
                    List<FirmList> filtered = _firmLists.Where(f =>
                        f.FirmName.ToUpper().Contains(q) || f.OperatorName.ToUpper().Contains(q) ||
                        f.Num.ToString().Contains(q)).ToList();

                    //firmListBindingSource.DataSource = filtered.ToSortableBindingList();
                    UpdateFirmList(filtered, col, sort);
                    _collector = new FirmListStatCollector(filtered);
                    UpdateStat();
                }
            }
            else
            {
                if (_firmLists != null && _firmLists.Count > 0)
                {
                    UpdateFirmList(_firmLists, col, sort);
                    //firmListBindingSource.DataSource = _firmLists.ToSortableBindingList();
                    _collector = new FirmListStatCollector(_firmLists);
                    UpdateStat();
                }
            }
        }

        #endregion

        #region Combobox Events

        private void comboBoxOrgs_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }

        #endregion

        #region Checkbox Events

        private void checkBoxPrintPreview_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrintPreviewFlag = checkBoxPrintPreview.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBoxPrintPreview_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPrintPreview.Image = checkBoxPrintPreview.Checked ? Properties.Resources.white_checked_32 : Properties.Resources.white_unchecked_32;
        }

        private void checkBoxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAutoLoad.Image = checkBoxAutoLoad.Checked ? Properties.Resources.white_checked_32 : Properties.Resources.white_unchecked_32;
        }

        private void checkBoxAutoLoad_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoLoadFlag = checkBoxAutoLoad.Checked;
            Properties.Settings.Default.Save();
        }

        private void wcToggleButtonClear_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoClearFlag = wcToggleButtonClear.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Other Events

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
                tbFilter.Focus();

            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnExportToFile.PerformClick();

            // Нажатие Ctrl + NumPlus
            if (e.KeyCode == Keys.Add && e.Control)
                btnAddRpo.PerformClick();

            // Нажатие Ctrl + NumMinus
            if (e.KeyCode == Keys.Subtract && e.Control)
                btnDelRpo.PerformClick();
        }

        private void GeneralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_loggingMode)
                Logger.Info("Завершение программы.");
        }

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerIn.Value;
            dateTimePickerOut.Value = date;
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

        #endregion

        private void testMenuItem_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(_auth);
            testForm.ShowDialog(this);
        }
    }
}
