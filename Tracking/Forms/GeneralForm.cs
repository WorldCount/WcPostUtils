using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Settings;
using WcApi.Post.Barcodes;
using WcApi.Print;
using Tracking.Libs.Object;
using Tracking.PostApi;

namespace Tracking.Forms
{
    public partial class GeneralForm : Form
    {
        public string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        public string AuthFile;
        public OperationHistory12 Client = new OperationHistory12Client();
        // ReSharper disable once InconsistentNaming
        private Auth auth;
        // ReSharper disable once InconsistentNaming
        private List<OperInfo> operInfos;
        private readonly int[] _columnWidths = {80, 90, 130, 60, 130, 40, 40, 60, 130};
        private int _dayToPath;

        public GeneralForm()
        {
            InitializeComponent();

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            if (!Directory.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            AuthFile = Path.Combine(DataDir, "Auth.xml");

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} v{Application.ProductVersion}";
            tbBarcode.BorderColor = Color.FromArgb(255, 53, 56, 58);
            
        }

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
            SendStatucMessage(message, Color.LimeGreen);
        }

        // Сообщение: ошибка
        public void ErrorStatusMessage(string message)
        {
            SendStatucMessage(message, Color.IndianRed);
        }

        // Сообщение: предупреждение
        public void WarningMessage(string message)
        {
            SendStatucMessage(message, Color.Orange);
        }

        // Сообщение: информация
        public void InfoMessage(string message)
        {
            SendStatucMessage(message, Color.DodgerBlue);
        }

        #endregion

        private void ClearData()
        {
            lblMail.Text = "";
            lblMark.Text = "";
            lblBarcode.Text = "";
            lblSender.Text = "Нет данных";
            lblReception.Text = "Нет данных";
            lblHanding.Text = "Нет данных";
            lblMass.Text = "НД";
            lblValue.Text = "НД";
            dataGridView.Rows.Clear();
        }

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

            // Восстановление положения окна
            string[] args = Environment.GetCommandLineArgs();
            if (args.Contains("-restore"))
                CenterToScreen();
        }

        /// <summary>
        /// Проверка ШПИ
        /// </summary>
        /// <returns></returns>
        private bool CheckBarcode(string barcode)
        {
            if (barcode.Length > 14 || barcode.Length < 13)
            {
                ErrorStatusMessage("Неверная длина ШПИ");
                return false;
            }

            string newBarcode = ControlRank.GenBarcode(barcode);
            if (barcode != newBarcode)
            {
                ErrorStatusMessage($"Неверный контрольный разряд. Должен быть - [{ControlRank.GenControlRank(barcode)}]");
                return false;
            }

            return true;
        }

        private void SetPay(string pay)
        {
            try
            {
                if (pay == null)
                    pay = "0000";
                string formatPay = (double.Parse(pay) / 100).ToString("F2").Replace(',', '-');
                statusPay.Text = $"Плата: {formatPay}";
            }
            catch
            {
                statusPay.Text = "Плата: НД";
            }
            
        }

        private OperInfo ParseRecord(OperationHistoryRecord record)
        {
            OperInfo oper = new OperInfo();

            try {  oper.Name = record.ItemParameters.ComplexItemName;  }
            catch { oper.Name = ""; }

            try { oper.PostMark = record.ItemParameters.PostMark.Name; }
            catch { oper.PostMark = ""; }

            try { oper.MassRate = record.FinanceParameters.MassRate; }
            catch { oper.MassRate = ""; }

            try { oper.Barcode = record.ItemParameters.Barcode; }
            catch { oper.Barcode = ""; }

            try { oper.Sndr = record.UserParameters.Sndr; }
            catch { oper.Sndr = ""; }

            try { oper.Rcpn = record.UserParameters.Rcpn; }
            catch { oper.Rcpn = ""; }

            try { oper.Mass = record.ItemParameters.Mass; }
            catch { oper.Mass = ""; }

            try { oper.Value = (Convert.ToInt16(record.FinanceParameters.Value) / 100).ToString(); }
            catch { oper.Value = ""; }

            try { oper.Date = record.OperationParameters.OperDate.ToString("dd.MM.yyyy HH:mm:ss"); }
            catch { oper.Date = ""; }

            try { oper.Type = record.OperationParameters.OperType.Name; }
            catch { oper.Type = ""; }

            try { oper.TypeId = record.OperationParameters.OperType.Id; }
            catch { oper.TypeId = 0; }

            try { oper.Attr = record.OperationParameters.OperAttr.Name.Replace("сортировочный центр", "СЦ"); }
            catch { oper.Attr = ""; }

            try { oper.AttrId = record.OperationParameters.OperAttr.Id; }
            catch { oper.AttrId = 0; }

            try { oper.Rank = record.ItemParameters.MailRank.Name; }
            catch { oper.Rank = ""; }

            try { oper.RankId = record.ItemParameters.MailRank.Id; }
            catch { oper.RankId = 0; }

            try { oper.IndexFrom = record.AddressParameters.OperationAddress.Index; }
            catch { oper.IndexFrom = ""; }

            try { oper.DescFrom = record.AddressParameters.OperationAddress.Description; }
            catch { oper.DescFrom = ""; }

            try { oper.IndexTo = record.AddressParameters.DestinationAddress.Index; }
            catch { oper.IndexTo = ""; }

            try { oper.DescTo = record.AddressParameters.DestinationAddress.Description; }
            catch { oper.DescTo = ""; }

            return oper;
        }

        private void LoadAuth()
        {
            auth = Auth.Load(AuthFile);
            if (auth == null)
            {
                ErrorStatusMessage("Ошибка загрузки данных авторизации.");
            }
        }

        private async Task SendAuth()
        {
            if(auth == null)
                LoadAuth();

            if (auth == null)
            {
                ErrorStatusMessage("Ошибка загрузки данных авторизации.");
                return;
            }

            AuthorizationHeader authHead = new AuthorizationHeader { login = auth.Login, password = auth.Password };
            await Task.Run(() =>
            {
                Client.getLanguages(new getLanguagesRequest(authHead));
            });

            InfoMessage("Авторизация завершена.");
        }

        private async Task SendRequest(string barcode)
        {
            operInfos = new List<OperInfo>();

            if (auth == null)
                LoadAuth();

            if (auth == null)
            {
                ErrorStatusMessage("Ошибка загрузки данных авторизации.");
                return;
            }

            AuthorizationHeader authHead = new AuthorizationHeader { login = auth.Login, password = auth.Password };
            OperationHistoryRequest operationRequest = new OperationHistoryRequest {Barcode = barcode};
            getOperationHistoryRequest request = new getOperationHistoryRequest(operationRequest, authHead);
            getOperationHistoryResponse response = await Task.Run(() => Client.getOperationHistory(request));

            if (response == null)
            {
                ErrorStatusMessage("Ошибка получения данных от сервера отслеживания.");
                return;
            }

            string name = "";
            string postMark = "";
            string rank = "";
            string massRate = "";
            string b = "";
            string rcpn = "";
            string sndr = "";
            string mass = "";
            string value = "";
            string handing = "";

            List<Task<OperInfo>> tasks = new List<Task<OperInfo>>();

            if (response.OperationHistoryData.Length > 0)
            {
                DateTime first = response.OperationHistoryData[0].OperationParameters.OperDate;
                DateTime last = response.OperationHistoryData[response.OperationHistoryData.Length - 1].OperationParameters.OperDate;
                _dayToPath = (int)(last - first).TotalDays;
            }

            foreach (OperationHistoryRecord record in response.OperationHistoryData)
            {
                // ReSharper disable once AccessToModifiedClosure
                tasks.Add(Task.Run(() => ParseRecord(record)));
            }

            OperInfo[] results = await Task.WhenAll(tasks);
            operInfos = results.ToList();

            foreach (OperInfo oper in results)
            {
                if (String.IsNullOrEmpty(name))
                    name = oper.Name;

                if (String.IsNullOrEmpty(postMark))
                    postMark = oper.PostMark;

                if (String.IsNullOrEmpty(rank))
                    rank = oper.Rank;

                if (String.IsNullOrEmpty(massRate))
                    massRate = oper.MassRate;

                if (String.IsNullOrEmpty(b))
                    b = oper.Barcode;

                if (String.IsNullOrEmpty(sndr))
                    sndr = oper.Sndr;

                if (String.IsNullOrEmpty(rcpn))
                    rcpn = oper.Rcpn;

                if (String.IsNullOrEmpty(mass))
                    mass = oper.Mass;

                if (String.IsNullOrEmpty(value))
                    value = oper.Value;

                // ReSharper disable once EmptyGeneralCatchClause
                try
                {
                    if (oper.TypeId == 2)
                    {
                        handing = oper.AttrId == 2 ? $"{oper.Attr} {oper.Sndr}" : $"{oper.Attr} {oper.Rcpn}";
                    }
                }
                catch { }

                dataGridView.Rows.Add(oper.Date, oper.Type, oper.Attr, oper.IndexFrom, oper.DescFrom,
                    oper.Mass, oper.Value, oper.IndexTo, oper.DescTo);
            }

            lblMail.Text = !String.IsNullOrEmpty(name) ? name : "Нет данных";

            if (String.IsNullOrEmpty(postMark))
                postMark = "Нет данных";

            if (String.IsNullOrEmpty(rank))
                rank = "Нет данных";

            lblMark.Text = $"{postMark} | {rank}";
            lblBarcode.Text = !String.IsNullOrEmpty(b) ? b : "Нет данных";
            lblSender.Text = !String.IsNullOrEmpty(sndr) ? sndr : "Нет данных";
            lblReception.Text = !String.IsNullOrEmpty(rcpn) ? rcpn : "Нет данных";
            lblMass.Text = !String.IsNullOrEmpty(mass) ? $"{mass} гр" : "НД";
            lblValue.Text = !String.IsNullOrEmpty(value) ? $"{value} руб" : "НД";
            lblHanding.Text = !String.IsNullOrEmpty(handing) ? handing : "Нет данных";

            SetPay(massRate);
            SuccessStatusMessage("Готово!");
        }
        #region Обработчики

        // Форма: перетаскивание окна
        protected override void WndProc(ref Message m)
        {
            #region Прозрачность при перетаскивании окна
            if (m.Msg == 0x00A1)
                Opacity = 1.0;

            if (m.Msg == 0x00A0)
                Opacity = 1.0;
            #endregion

            base.WndProc(ref m);
        }

        // Форма: загрузилась
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadPos();
            LoadAuth();
            WebRequest.DefaultWebProxy = null;
            ClearData();
            #pragma warning disable 4014
            SendAuth();
            #pragma warning restore 4014
        }

        // Форма: закрывается
        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePos();
        }

        // Форма: смена языка ввода
        private void GeneralForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {

        }

        // Форма: нажатие клавиш
        private void GeneralForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + F
            if (e.KeyCode == Keys.F && e.Control)
            {
                tbBarcode.Focus();
            }
        }

        // ТБ ШПИ: нажатие клавиш
        private void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind.PerformClick();
            }
        }

        // Кнопка: поиск
        private async void btnFind_Click(object sender, EventArgs e)
        {
            ClearData();
            btnFind.Enabled = false;
            string barcode = tbBarcode.Text;
            if (CheckBarcode(barcode))
            {
                try
                {
                    await SendRequest(barcode);
                }
                catch
                {
                    ErrorStatusMessage("Ошибка авторизации.");
                }          
            }
            btnFind.Enabled = true;
            tbBarcode.SelectAll();
        }

        // Панель: отрисовка
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Panel target = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, target.ClientRectangle,
                Color.FromArgb(255, 69, 73, 75), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(255, 69, 73, 75), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(255, 69, 73, 75), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(255, 69, 73, 75), 0, ButtonBorderStyle.Solid);
        }

        // Панель: изменение размера
        private void panel_Resize(object sender, EventArgs e)
        {
            Panel target = (Panel)sender;
            target.Invalidate();
        }

        // ТБ ШПИ: клик
        private void tbBarcode_Click(object sender, EventArgs e)
        {
            //tbBarcode.SelectAll();
        }

        // Таймер: статус
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.ForeColor = Color.White;
            statusText.Text = "";
            timerStatus.Stop();
        }

        #endregion

        #region Меню

        // Подключение
        private void menuConnect_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm(this);
            authForm.ShowDialog(this);
            LoadAuth();
        }

        // Печать
        private void menuPrint_Click(object sender, EventArgs e)
        {
            if (operInfos != null && operInfos.Count > 0)
            {
                string[] dataInfos =
                {
                    $"ШПИ: {lblBarcode.Text}",
                    $"Отправление: {lblMail.Text}",
                    $"Отметки: {lblMark.Text}",
                    $"Отправитель: {lblSender.Text}",
                    $"Получатель: {lblReception.Text}",
                    $"Дней в пути: {_dayToPath} | Всего операций: {operInfos.Count}"
                };

                GridPrintDocument document = new GridPrintDocument(dataGridView, _columnWidths, dataInfos)
                {
                    DocumentName = $"Отслеживание: {lblBarcode.Text}"
                };

                // ReSharper disable once LocalVariableHidesMember
                using (GridPrintPreviewDialog printPreviewDialog = new GridPrintPreviewDialog())
                {
                    printPreviewDialog.Text = $"Отчет по {lblBarcode.Text}";
                    printPreviewDialog.Document = document;
                    printPreviewDialog.ShowDialog(this);
                }

                document.Dispose();
            }
            else
                WarningMessage("Нет данных для формирования отчета.");
        }

        // Выход
        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
