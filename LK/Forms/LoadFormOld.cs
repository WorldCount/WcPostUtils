using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core;
using LK.Core.Libs.Auth;
using LK.Core.Libs.Auth.Model;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.TarifManager;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Libs.TarifManager.Tarif;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Models.Raw;
using LK.Core.Store;
using LK.Core.Store.Manager;
using LK.Core.Store.Parsers;
using NLog;
using WcApi.Cryptography;
using WcApi.Finance;

namespace LK.Forms
{
    public partial class LoadFormOld : Form
    {

        #region Private Fields

        private LkAuth _lkAuth;
        private Token _token;
        private string _filePath;

        private string _error;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly bool _loggingMode = Properties.Settings.Default.LoggingMode;

        private readonly Color _windowBorderColor = Color.Teal;
        public int WindowBorderWidth { get; set; } = 2;
        public ButtonBorderStyle WindowsBorderStyle { get; set; } = ButtonBorderStyle.Dashed;

        private Auth _auth;

        #region Данные

        private readonly DateTime _reportInDate;
        private readonly DateTime _reportOutDate;

        private List<int> _recountFirmListIds;

        #endregion

        #region Менеджеры

        private readonly StatusManager _statusManager = new StatusManager();
        private readonly MailCategoryManager _mailCategoryManager = new MailCategoryManager();
        private readonly MailTypeManager _mailTypeManager = new MailTypeManager();
        private readonly FirmManager _firmManager = new FirmManager();
        private readonly OperatorManager _operatorManager = new OperatorManager();
        private readonly ConfigFirmFieldManager _configFirmFieldManager;
        private readonly ConfigRpoFieldManager _configRpoFieldManager;

        #endregion

        #endregion

        #region Public Properties

        public string Error => _error;

        #endregion



        public LoadFormOld(DateTime inDate, DateTime outDate, Auth auth, string filePath = null)
        {
            InitializeComponent();

            _auth = auth;

            _reportInDate = inDate;
            _reportOutDate = outDate;

            _configFirmFieldManager = new ConfigFirmFieldManager();
            _configRpoFieldManager = new ConfigRpoFieldManager();

            _filePath = filePath;

            string inD = _reportInDate.ToString("dd.MM.yyyy");
            string outD = _reportOutDate.ToString("dd.MM.yyyy");

            labelDate.Text = inD == outD ? $"Синхронизация за {_reportInDate.ToShortDateString()}" : $"Синхронизация с {inD} по {outD}";
            labelInfo.Text = "";
            coloredProgressBar.Value = 0;
        }

        #region Private Methods

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

        private async void Work()
        {
            if (_filePath == null)
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
            }

            #region Загрузка файла

            if (_filePath == null)
            {
                SetInfo("Загрузка файла...", 0);

                string filePath = "";

                try
                {
                    filePath = await _lkAuth.ReportResponse(_token, _reportInDate, _reportOutDate);
                }
                catch (Exception e)
                {
                    _error = "Ошибка доступа к файлу с отчетом";
                    DialogResult = DialogResult.Cancel;

                    if (_loggingMode)
                        Logger.Error($"{_error}: {e}");
                    return;
                }


                if (string.IsNullOrEmpty(filePath))
                {
                    _error = "Ошибка загрузки файла";
                    DialogResult = DialogResult.Cancel;

                    if (_loggingMode)
                        Logger.Error(_error);
                    return;
                }
                else
                {
                    SetInfo("Загрузка файла...   Ok!", 100);
                    _filePath = filePath;
                }
            }

            #endregion

            #region Загрузка данных из файла

            SetInfo("Загрузка данных из файла...", 0);
            List<RawData> data = LoadFile(_filePath);
            SetInfo("Загрузка данных из файла...   Ok!", 100);

            #endregion

            #region Парсинг РПО

            SetInfo("Парсинг РПО...", 0);

            try
            {
                await Parse(data);
                SetInfo("Парсинг РПО...   Ok!", 100);
            }
            catch (Exception exception)
            {
                _error = exception.Message;
                if (_loggingMode)
                    Logger.Error(exception);
                DialogResult = DialogResult.Cancel;
                Close();
            }

            #endregion

            Close();
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

        private List<RawData> LoadFile(string filePath)
        {
            LkReportParser parser = new LkReportParser(filePath);
            List<RawData> data = parser.Parse();
            return data;
        }


        private async Task Parse(List<RawData> data)
        {
            Config configNds = ConfigManager.GetConfigByName(ConfigName.Nds);
            Config configValue = ConfigManager.GetConfigByName(ConfigName.Value);

            Nds ndsCalc = new Nds(configNds.GetIntValue());
            double fullValue = (double)configValue.GetIntValue() / 100;

            int max = data.Count;

            _recountFirmListIds = new List<int>();

            FirmListManager firmListManager = new FirmListManager(new DateTime(1986, 9, 2));
            RpoManager rpoManager = new RpoManager();

            Firm firm = null;
            FirmList firmList = null;
            List<Rpo> rpos = new List<Rpo>();

            for (int i = 1; i <= max; i++)
            {

                SetInfo($"Парсинг РПО... {i} из {max}", i, max);

                RawData d = data[i];

                //if (firm != null)
                //    if (firm.Name != d.FirmName || firm.Inn != d.Inn || firm.Kpp != d.Kpp || firm.Contract != d.Contract)
                //        firm = null;

                //if (firm == null)
                //{
                //    firm = _firmManager.GetOrCreateFirm(d.Inn, d.Kpp, d.FirmName, d.Contract);
                //}

                //if(firmList != null)
                //    if (firmList.Num != d.ListNum || firmList.Date != d.Date || firmList.ReceptionDate != d.ReceptDate)
                //        firmList = null;

                //if (firmList == null)
                //{
                //    firmListManager.Update(d.Date);
                //    firmList = firmListManager.GetFirmList(firm.Id, d.ListNum, d.ReceptDate);

                //    if (firmList == null)
                //    {
                //        Operator oper = _operatorManager.GetOrCreateOperator(d.Operator);

                //        firmList = new FirmList
                //        {
                //            FirmId = firm.Id, Num = d.ListNum, Date = d.Date,
                //            ReceptionDate = d.ReceptDate, OperatorId = oper.Id, MailClass = d.GetMailClass(),
                //            Inventory = d.IsInventory(), Notice = GetNotice(d.ServiceRate, d.Value)
                //        };

                //        MailType mailType = _mailTypeManager.GetMailType(d.Type);
                //        if (mailType != null)
                //            firmList.MailType = mailType.Id;

                //        MailCategory mailCategory = _mailCategoryManager.GetMailCategory(d.Category);
                //        if (mailCategory != null)
                //            firmList.MailCategory = mailCategory.Id;
                        
                //        firmList.Id = await Database.SaveFirmListAsync(firmList);

                //        if (!_recountFirmListIds.Contains(firmList.Id))
                //            _recountFirmListIds.Add(firmList.Id);
                //    }
                //}

                //Rpo rpo = d.ToRpo();
                //rpo.FirmListId = firmList.Id;
                //rpo.OperatorId = firmList.OperatorId;

                //rpo.ValueRate = rpo.Value * fullValue;
                //rpo.MassRate = ndsCalc.Minus(rpo.MassRate) + rpo.ValueRate;

                //rpo.Notice = firmList.Notice;
                //rpo.MailType = firmList.MailType;
                //rpo.MailCategory = firmList.MailCategory;

                //Status status = _statusManager.GetStatus(d.Status);
                //if (status != null)
                //{
                //    rpo.StatusId = status.Id;

                //    if (string.IsNullOrEmpty(rpo.Reason))
                //        rpo.Reason = status.Name;
                //}

                //rpos.Add(rpo);
            }
        }

        private int GetNotice(double rate, double value)
        {
            ServiceTarif serviceTarif = ServiceTarifManager.GetServiceTarifByRateNds(rate);
            if (serviceTarif != null)
                return serviceTarif.Code;
            else
            {
                if (value > 0)
                {
                    ServiceTarif inventoryTarif = ServiceTarifManager.GetServiceTarifByType(ServiceType.Опись);
                    double pay = rate - inventoryTarif.RateNds;

                    if (pay > 0)
                    {
                        ServiceTarif noticeTarif = ServiceTarifManager.GetServiceTarifByRateNds(pay);
                        if (noticeTarif != null)
                            return noticeTarif.Code;
                    }
                }

                return 0;
            }
        }

        private void SetInfo(string text, int value, int max = 100)
        {
            labelInfo.Text = text;
            labelInfo.Refresh();

            coloredProgressBar.Maximum = max;
            coloredProgressBar.Value = value;
            coloredProgressBar.Refresh();
        }

        #endregion

        #region Ovverrides Methods

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


        #region Form Events

        private void SyncForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void SyncForm_Load(object sender, EventArgs e)
        {
            _configFirmFieldManager.Load();
            _configFirmFieldManager.DecrementRowNum();

            _configRpoFieldManager.Load();
            _configRpoFieldManager.DecrementRowNum();

            Work();
        }

        #endregion


    }
}
