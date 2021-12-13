using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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
using LK.Core.Models.Raw;
using LK.Core.Store.Manager;
using LK.Core.Store.Manager.DatabaseManager;
using LK.Core.Store.Manager.FileManager;
using LK.Core.Store.Parsers;
using LK.Forms.Params;
using NLog;
using WcApi.Cryptography;
using WcApi.Finance;

namespace LK.Forms
{
    public partial class LoadFileForm : Form
    {
        #region System

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeigthEllipse);

        #endregion

        #region Private Fields

        #region Логирование

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly bool _loggingMode = Properties.Settings.Default.LoggingMode;

        #endregion

        #region Данные

        private readonly DateTime _startDate;
        private readonly DateTime _endDate;
        private Auth _auth;
        private string _filePath;

        #endregion

        #region Авторизация

        private LkAuth _lkAuth;
        private Token _token;

        #endregion

        #region Менеджеры

        private readonly StatusManager _statusManager = new StatusManager();
        private readonly MailCategoryManager _mailCategoryManager = new MailCategoryManager();
        private readonly MailTypeManager _mailTypeManager = new MailTypeManager();
        private readonly FirmManager _firmManager = new FirmManager();
        private readonly OperatorManager _operatorManager = new OperatorManager();
        private readonly ConfigDataFieldManager _configDataFieldManager;

        #endregion

        private List<int> _recountFirmListIds;
        private string _error;

        #endregion

        #region Public Properties

        public string Error => _error;

        #endregion


        public LoadFileForm(LoadFileFormParams loadParams)
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));

            _auth = loadParams.Auth;
            _startDate = loadParams.StartDate;
            _endDate = loadParams.EndDate;
            _filePath = loadParams.FilePath;
                
            //SetInfo("Начинаю работу :)", 0);

            _configDataFieldManager = new ConfigDataFieldManager();

        }

        #region Private Methods

        private async void Work()
        {
            if (_filePath == null)
            {

                #region Авторизация

                await GetToken();

                #endregion

                #region Удаление старых отчетов

                SetInfo("Удаляю старые отчеты...", style: ProgressBarStyle.Marquee);
                await RemoveTempReports();
                SetInfo("Удаляю старые отчеты...   Ok!", 100);

                #endregion

                #region Загрузка файла из LK

                await GetReportFile();

                #endregion
            }

            #region Загрузка данных из файла

            SetInfo("Загрузка данных из файла...", style: ProgressBarStyle.Marquee);
            List<RawData> data = await LoadFile(_filePath);
            SetInfo("Загрузка данных из файла...   Ok!", 100);

            #endregion

            #region Парсинг РПО

            SetInfo("Загрузка данных из файла...", style: ProgressBarStyle.Marquee);
            await Parse(data);
            SetInfo("Загрузка данных из файла...   Ok!", 100);

            #endregion

            Close();
        }

        private async Task GetToken()
        {
            SetInfo("Авторизация в ЛК...", style:ProgressBarStyle.Marquee);

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
        }

        private async Task GetReportFile()
        {
            SetInfo("Загрузка файла из ЛК...", style: ProgressBarStyle.Marquee);

            string filePath = "";

            try
            {
                filePath = await _lkAuth.ReportResponse(_token, _startDate, _endDate);
            }
            catch (Exception e)
            {
                _error = "Ошибка доступа к файлу с отчетом";

                if (_loggingMode)
                    Logger.Error($"{_error}: {e}");

                DialogResult = DialogResult.Cancel;
                return;
            }


            if (string.IsNullOrEmpty(filePath))
            {
                _error = "Ошибка загрузки файла";

                if (_loggingMode)
                    Logger.Error(_error);
                DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                SetInfo("Загрузка файла...   Ok!", 100);
                _filePath = filePath;
            }
        }

        private async Task RemoveTempReports()
        {
            await Task.Run(() =>
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
            });
            
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

        private async Task<List<RawData>> LoadFile(string filePath)
        {
            List<RawData> data = new List<RawData>();

            await Task.Run(() =>
            {
                LkReportParser parser = new LkReportParser(filePath);
                data = parser.Parse();
                return data;
            });

            return data;
        }

        private async Task Parse(List<RawData> data)
        {
            Config configNds = ConfigManager.GetConfigByName(ConfigName.Nds);
            Config configValue = ConfigManager.GetConfigByName(ConfigName.Value);

            Nds ndsCalc = new Nds(configNds.GetIntValue());
            double fullValue = (double)configValue.GetIntValue() / 100;

            int max = data.Count - 1;

            _recountFirmListIds = new List<int>();

            FirmListManager firmListManager = new FirmListManager(new DateTime(1986, 9, 2));
            RpoManager rpoManager = new RpoManager();

            Firm firm = null;
            FirmList firmList = null;
            List<Rpo> rpos = new List<Rpo>();

            for (int i = 0; i <= max; i++)
            {
                SetInfo($"Парсинг РПО... {i + 1} из {max}", i, max);

                RawData d = data[i];

                if (firm != null)
                    if (firm.Name != d.FirmName || firm.Inn != d.Inn || firm.Kpp != d.Kpp ||
                        firm.Contract != d.Contract)
                        firm = null;

                if (firm == null)
                {
                    firm = _firmManager.GetOrCreateFirm(d.Inn, d.Kpp, d.FirmName, d.Contract);
                }

                if(firmList != null)
                    if (firmList.Num != d.ListNum || firmList.Date != d.Date || firmList.ReceptionDate != d.ReceptDate)
                        firmList = null;

                if (firmList == null)
                {
                    firmListManager.Update(d.Date);
                    firmList = firmListManager.GetFirmList(firm.Id, d.ListNum, d.ReceptDate);


                }
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

        private void SetInfo(string text, int value = 25, int max = 100, 
            string progressText = "", ProgressBarStyle style = ProgressBarStyle.Continuous)
        {
            labelInfo.Text = text;
            labelInfo.Refresh();

            circularProgressBar.Text = progressText;

            circularProgressBar.Style = style;
            circularProgressBar.Maximum = max;
            circularProgressBar.Value = value;

            circularProgressBar.Refresh();
        }

        private void ContinuousProgress()
        {
            circularProgressBar.Style = ProgressBarStyle.Continuous;
            circularProgressBar.Refresh();
        }

        private void MarqueeProgress()
        {
            circularProgressBar.Value = 50;
            circularProgressBar.Maximum = 100;
            circularProgressBar.Style = ProgressBarStyle.Marquee;
            circularProgressBar.Refresh();
        }

        #endregion

        #region Form Event

        private void LoadFileForm_Load(object sender, EventArgs e)
        {
            _configDataFieldManager.Load();
            _configDataFieldManager.DecrementRowNum();

            Work();
        }

        private void LoadFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        #endregion


    }
}
