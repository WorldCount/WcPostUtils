using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core;
using LK.Core.Libs.Auth;
using LK.Core.Libs.Auth.Model;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.TarifManager;
using LK.Core.Libs.TarifManager.Tarif;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Models.Raw;
using LK.Core.Store;
using LK.Core.Store.Manager;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NLog;
using WcApi.Cryptography;
using WcApi.Ext;
using WcApi.Finance;

namespace LK.Forms
{
    public partial class SyncForm : Form
    {
        private LkAuth _lkAuth;
        private Token _token;

        #region Данные
        private readonly DateTime _reportInDate;
        private readonly DateTime _reportOutDate;

        private List<int> _recountFirmListIds;
        #endregion

        private string _error;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly bool _loggingMode = Properties.Settings.Default.LoggingMode;

        private readonly Color _windowBorderColor = Color.Teal;
        public int WindowBorderWidth { get; set; } = 2;
        public ButtonBorderStyle WindowsBorderStyle { get; set; } = ButtonBorderStyle.Dashed;

        private Auth _auth;

        #region Менеджеры

        private readonly StatusManager _statusManager = new StatusManager();
        private readonly MailCategoryManager _mailCategoryManager = new MailCategoryManager();
        private readonly MailTypeManager _mailTypeManager = new MailTypeManager();
        private readonly FirmManager _firmManager = new FirmManager();
        private readonly OperatorManager _operatorManager = new OperatorManager();
        private readonly ConfigFirmFieldManager _configFirmFieldManager;
        private readonly ConfigRpoFieldManager _configRpoFieldManager;

        #endregion

        public string Error => _error;

        public SyncForm(DateTime inDate, DateTime outDate, Auth auth)
        {
            InitializeComponent();

            _auth = auth;

            _reportInDate = inDate;
            _reportOutDate = outDate;

            _configFirmFieldManager = new ConfigFirmFieldManager();
            _configRpoFieldManager = new ConfigRpoFieldManager();

            string inD = _reportInDate.ToString("dd.MM.yyyy");
            string outD = _reportOutDate.ToString("dd.MM.yyyy");

            labelDate.Text = inD == outD ? $"Синхронизация за {_reportInDate.ToShortDateString()}" : $"Синхронизация с {inD} по {outD}";
            labelInfo.Text = "";
            coloredProgressBar.Value = 0;
        }

        private void RemoveOldReport()
        {
            string[] reports = Directory.GetFiles(PathManager.ReportPath);
            foreach (string file in reports)
            {
                try
                {
                    File.Delete(file);
                }
                catch
                {
                    continue;
                }
            }
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

        private Task Auth()
        {
            return Task.Run(() =>
            {
                _lkAuth = new LkAuth(_auth);
                string code = _lkAuth.Auth().Result;
                _token = _lkAuth.GetToken(code).Result;
            });
        }

        private void SyncForm_Load(object sender, EventArgs e)
        {
            _configFirmFieldManager.Load();
            _configFirmFieldManager.DecrementRowNum();

            _configRpoFieldManager.Load();
            _configRpoFieldManager.DecrementRowNum();

            Work();
        }

        private void SetInfo(string text, int value, int max = 100)
        {
            labelInfo.Text = text;
            labelInfo.Refresh();

            coloredProgressBar.Maximum = max;
            coloredProgressBar.Value = value;
            coloredProgressBar.Refresh();
        }

        private async void Work()
        {
            #region Авторизация
            SetInfo("Авторизация в ЛК...", 0);

            await Auth();

            if (_token.IsExist())
            {
                SetInfo("Авторизация в ЛК...   Ok!", 100);
            }
            else
            {
                _error = "Ошибка получения токена";
                DialogResult = DialogResult.Cancel;
                Close();
            }

            #endregion

            #region Удаление старых отчетов

            SetInfo("Удаляю старые отчеты...", 0);
            RemoveOldReport();
            SetInfo("Удаляю старые отчеты...   Ok!", 100);

            #endregion

            #region Загрузка файла


            SetInfo("Загрузка файла...", 0);

            string filePath = "";

            try
            {
                 filePath = await _lkAuth.ReportResponse(_token, _reportInDate, _reportOutDate);
            }
            catch(Exception e)
            {
                _error = "Ошибка доступа к файлу с отчетом";
                DialogResult = DialogResult.Cancel;

                if(_loggingMode)
                    Logger.Error($"{_error}: {e}");
                return;
            }
            

            if (string.IsNullOrEmpty(filePath))
            {
                _error = "Ошибка загрузки файла";
                DialogResult = DialogResult.Cancel;

                if(_loggingMode)
                    Logger.Error(_error);
                return;
            }
            else
                SetInfo("Загрузка файла...   Ok!", 100);

            #endregion


            FileInfo fileInfo = new FileInfo(filePath);
            string ext = fileInfo.Extension;

            #region Парсинг организаций и списков

            SetInfo("Парсинг списков...", 0);

            try
            {
                ParseList(filePath, ext == ".xlsx");
                SetInfo("Парсинг списков...   Ok!", 100);
            }
            catch (Exception exception)
            {
                _error = exception.Message;
                if(_loggingMode)
                    Logger.Error(exception);
                DialogResult = DialogResult.Cancel;
                Close();
            }

            #endregion

            #region Парсинг РПО

            SetInfo("Парсинг РПО...", 0);

            try
            {
                ParseRpo(filePath, ext == ".xlsx");
                SetInfo("Парсинг РПО...   Ok!", 100);
            }
            catch (Exception exception)
            {
                _error = exception.Message;
                if(_loggingMode)
                    Logger.Error(exception);
                DialogResult = DialogResult.Cancel;
                Close();
            }

            #endregion

            Close();
        }

        private void ParseRpo(string link, bool xlsx = false)
        {
            IWorkbook workbook;
            _recountFirmListIds = new List<int>();

            Config configNds = ConfigManager.GetConfigByName(ConfigName.Nds);
            Config configValue = ConfigManager.GetConfigByName(ConfigName.Value);

            Nds ndsCalc = new Nds(configNds.GetIntValue());
            double fullValue = (double) configValue.GetIntValue() / 100;

            using (FileStream fileStream = new FileStream(link, FileMode.Open, FileAccess.Read))
            {
                if (xlsx)
                    workbook = new XSSFWorkbook(fileStream);
                else
                    workbook = new HSSFWorkbook(fileStream);
            }

            List<Rpo> rpos = new List<Rpo>();

            ISheet rpoSheet = workbook.GetSheetAt(1);
            int max = rpoSheet.LastRowNum;

            FirmListManager firmListManager = new FirmListManager(new DateTime(1986, 9, 2));
            RpoManager rpoManager = new RpoManager();

            for (int i = 1; i <= rpoSheet.LastRowNum; i++)
            {
                IRow row = rpoSheet.GetRow(i);

                SetInfo($"Парсинг РПО... {i} из {max}", i, max);

                if (row == null)
                    continue;

                try
                {
                    RawRpoData raw = new RawRpoData(row, _configRpoFieldManager);

                    if (raw.Parse() == false)
                    {
                        if(_loggingMode)
                            Logger.Error($"RawRpoData.Parse, Row [{i}]: {raw.Exception.Message}");
                        continue;
                    }

                    Firm firm = _firmManager.GetFirm(raw.Inn, raw.Kpp, raw.Contract, raw.FirmName);

                    if (firm is null)
                    {
                        if(_loggingMode)
                            Logger.Error($"Не удалось получить данные по организации: Inn = '{raw.Inn}', Kpp = '{raw.Kpp}', Contract = '{raw.Contract}'");
                        continue;
                    }

                    firmListManager.Update(raw.Date);
                    FirmList firmList = firmListManager.GetFirmList(firm.Id, raw.Num, raw.ReceptDate);

                    if (firmList == null)
                        continue;

                    if (raw.ParseNext() == false)
                    {
                        if(_loggingMode)
                            Logger.Error($"RawRpoData.ParseNext, Row [{i}]: {raw.Exception.Message}");
                        continue;
                    }

                    rpoManager.Update(firmList.Id);
                    Rpo rpo = rpoManager.GetRpo(raw.Barcode);

                    if(rpo != null)
                        continue;

                    Operator oper = _operatorManager.GetOrCreateOperator(raw.Operator);

                    rpo = raw.ToRpo();
                    rpo.FirmListId = firmList.Id;
                    rpo.OperatorId = oper.Id;

                    rpo.ValueRate = rpo.Value * fullValue;
                    rpo.MassRate = ndsCalc.Minus(rpo.MassRate) + rpo.ValueRate;

                    if (!_recountFirmListIds.Contains(firmList.Id))
                        _recountFirmListIds.Add(firmList.Id);

                    ServiceTarif noticeTarif = ServiceTarifManager.GetServiceTarifByRateNds(raw.NoticeRate);
                    if (noticeTarif != null)
                    {
                        rpo.Notice = noticeTarif.Code;

                        if (firmList.Notice != noticeTarif.Code)
                        {
                            firmList.Notice = noticeTarif.Code;
                            Database.SaveFirmList(firmList);
                        }
                    }

                    MailType mailType = _mailTypeManager.GetMailType(raw.Type);
                    if (mailType != null)
                        rpo.MailType = mailType.Id;

                    MailCategory mailCategory = _mailCategoryManager.GetMailCategory(raw.Category);
                    if (mailCategory != null)
                        rpo.MailCategory = mailCategory.Id;

                    Status status = _statusManager.GetStatus(raw.Status);
                    if (status != null)
                    {
                        rpo.StatusId = status.Id;

                        if (string.IsNullOrEmpty(rpo.Reason))
                            rpo.Reason = status.Name;
                    }

                    rpos.Add(rpo);
                }
                catch (Exception e)
                {
                    _error = e.Message;
                    if(_loggingMode)
                        Logger.Error(e);
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }

            int count = Database.SaveAllRpo(rpos);

            var data = _recountFirmListIds.Chunk(500);
            foreach (IEnumerable<int> ids in data)
                firmListManager.Recount(ids.ToList());

            workbook = null;
        }

        private void ParseList(string link, bool xlsx = false)
        {
            IWorkbook workbook;

            using (FileStream fileStream = new FileStream(link, FileMode.Open, FileAccess.Read))
            {
                if (xlsx)
                    workbook = new XSSFWorkbook(fileStream);
                else
                    workbook = new HSSFWorkbook(fileStream);
            }

            ISheet orgListSheet = workbook.GetSheetAt(0);

            int max = orgListSheet.LastRowNum;

            List<FirmList> firmLists = new List<FirmList>();
            FirmListManager firmListManager = new FirmListManager(new DateTime(1986, 9, 2), false);

            for (int i = 1; i <= orgListSheet.LastRowNum; i++)
            {
                IRow row = orgListSheet.GetRow(i);

                SetInfo($"Парсинг списков... {i} из {max}", i, max);

                if (row == null)
                    continue;

                try
                {
                    RawListData raw = new RawListData(row, _configFirmFieldManager);

                    if (raw.Parse() == false)
                    {
                        if(_loggingMode)
                            Logger.Error($"RawListData.Parse, Row [{i}]: {raw.Exception.Message}");
                        continue;
                    }

                    Firm firm = _firmManager.GetOrCreateFirm(raw.Inn, raw.Kpp, raw.Name, raw.Contract);

                    firmListManager.Update(raw.Date);
                    FirmList firmList = firmListManager.GetFirmList(firm.Id, raw.Num, raw.ReceptDate);

                    if (firmList != null)
                        continue;

                    if (raw.ParseNext() == false)
                    {
                        if(_loggingMode)
                            Logger.Error($"RawListData.ParseNext, Row [{i}]: {raw.Exception.Message}");
                        continue;
                    }

                    Operator oper = _operatorManager.GetOrCreateOperator(raw.Operator);

                    FirmList rpoList = raw.ToFirmList();
                    rpoList.FirmId = firm.Id;
                    rpoList.OperatorId = oper.Id;

                    MailType mailType = _mailTypeManager.GetMailType(raw.Type);
                    if (mailType != null)
                        rpoList.MailType = mailType.Id;
                    
                    MailCategory mailCategory = _mailCategoryManager.GetMailCategory(raw.Category);
                    if (mailCategory != null)
                        rpoList.MailCategory = mailCategory.Id;

                    firmLists.Add(rpoList);

                }
                catch (Exception e)
                {
                    _error = e.Message;
                    if(_loggingMode)
                        Logger.Error(e);
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }

            if(firmLists.Count > 0)
                Database.SaveAllFirmList(firmLists);

            workbook = null;
        }

        private void SyncForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }
    }
}
