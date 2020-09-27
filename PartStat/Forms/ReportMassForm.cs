using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using PartStat.Core.Libs.Print;
using PartStat.Core.Libs.Stats;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models.PostTypes;
using PartStat.Core.Models.Reports;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Forms
{
    public partial class ReportMassForm : Form
    {
        private readonly SingleReportData _singleReport;

        private int _allCount;
        private double _allSumRate;

        private NoticeTarif _simpleNoticeTarif;
        private NoticeTarif _customNoticeTarif;
        private NoticeTarif _electronicNoticeTarif;
        private NoticeTarif _interNoticeTarif;

        public int NumList { get; private set; }

        public ReportMassForm(SingleReportData singleReport)
        {
            InitializeComponent();

            _singleReport = singleReport;

            string title = $"{Properties.Settings.Default.AppName}: Отчет по {_singleReport.Name}";
            if (_singleReport.NumsList.Count == 1)
            {
                NumList = _singleReport.NumsList[0].NumsList[0];
                title = $"{title} | ДАТА: {_singleReport.DateList[0].ToShortDateString()} | СП {NumList}";
            }

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = title;

            // Загрузка тарифов на уведомления
            LoadTarif();

            // Загрузка данных по индексам
            LoadIndexStat();

            // Таблица
            InitTable();
            FillTable();
        }

        private void LoadTarif()
        {
            _simpleNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Простое);
            _customNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Заказное);
            _electronicNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Электронное);
            _interNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Международное);
        }

        private void LoadIndexStat()
        {
            labelIndex.Text = $"Индексы ({_singleReport.CityCollector.SumCount} шт)";
            lblMoscowCount.Text = _singleReport.CityCollector.MoscowCount.ToString();
            lblCityCount.Text = _singleReport.CityCollector.CityCount.ToString();
            lblUnkownCount.Text = _singleReport.CityCollector.UnkownCount.ToString();
            lblInterCount.Text = _singleReport.CityCollector.InterCount.ToString();
        }

        private void InitTable()
        {
            MailTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MailTypeDataGridViewTextBoxColumn.Width = 240;
        }

        private void FillTable()
        {
            // Статистика
            AddPostMark();

            // ЗП
            AddCutomMail();

            // ЗБ
            AddCustomParcel();

            // Мжд ЗП без ув.
            AddInterMail();

            // Мжд ЗП с ув.
            AddInterNoticeMail();

            // Мжд ЗБ без ув.
            AddInterParcel();

            // Мжд ЗБ с ув.
            AddInterNoticeParcel();

            // ЗП 1 кл
            AddFirstMail();

            // ЗБ 1 кл
            AddFirstParcel();

            // ЗП с ОЦ
            AddValueMail();

            // ЗБ с ОЦ
            AddValueParcel();

            // ЗП 1 кл с ОЦ
            AddValueFirstMail();

            // ЗБ 1 кл с ОЦ
            AddValueFirstParcel();

            // Остальные
            AddOther();

            // Итоговая статистика
            AddFullStat();
        }

        private void AddPostMark()
        {
            int count = _singleReport.RpoCollector.SimpleNoticeCount +
                        _singleReport.RpoCollector.CustomNoticeCount +
                        _singleReport.RpoCollector.ElectronicNoticeCount +
                        _singleReport.RpoCollector.InterNoticeCount +
                        _singleReport.RpoCollector.InventoryCount +
                        _singleReport.RpoCollector.ManualCount;

            if (_singleReport.RpoCollector.SimpleNoticeCount > 0)
                dataGridView.Rows.Add("Пр.Увед", "", _singleReport.RpoCollector.SimpleNoticeCount.ToString(), 
                    _simpleNoticeTarif.Rate.ToString("F"), 
                    (_singleReport.RpoCollector.SimpleNoticeCount * _simpleNoticeTarif.Rate).ToString("F"));

            if (_singleReport.RpoCollector.CustomNoticeCount > 0)
                dataGridView.Rows.Add("Зак.Увед", "", _singleReport.RpoCollector.CustomNoticeCount.ToString(), 
                    _customNoticeTarif.Rate.ToString("F"), (_singleReport.RpoCollector.CustomNoticeCount * _customNoticeTarif.Rate).ToString("F"));

            if (_singleReport.RpoCollector.ElectronicNoticeCount > 0)
                dataGridView.Rows.Add("Эл.Увед", "", _singleReport.RpoCollector.ElectronicNoticeCount.ToString(),
                    _electronicNoticeTarif.Rate.ToString("F"), (_singleReport.RpoCollector.ElectronicNoticeCount * _electronicNoticeTarif.Rate).ToString("F"));

            if (_singleReport.RpoCollector.InterNoticeCount > 0)
                dataGridView.Rows.Add("Мжд.Увед", "", _singleReport.RpoCollector.InterNoticeCount.ToString(),
                    _interNoticeTarif.Rate.ToString("F"), (_singleReport.RpoCollector.InterNoticeCount * _interNoticeTarif.Rate).ToString("F"));

            if (_singleReport.RpoCollector.InventoryCount > 0)
                dataGridView.Rows.Add("Опись", "", _singleReport.RpoCollector.InventoryCount.ToString(), "", "");

            if (_singleReport.RpoCollector.ManualCount > 0)
                dataGridView.Rows.Add("Ручка", "", _singleReport.RpoCollector.ManualCount.ToString(), "", "");

            if (count > 0)
            {
                AddClearRow(true);
            }
        }

        private void AddCutomMail()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetMailStatExcept();
            AddCustom(mails);
        }

        private void AddCustomParcel()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetParcelStatExcept();
            AddCustom(mails);
        }

        private void AddInterMail()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetInterMailStatExcept();
            AddCustom(mails.OrderByDescending(m => m.TransType).ToArray());
        }

        private void AddInterNoticeMail()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetInterMailNoticeStatExcept();
            AddCustom(mails.OrderByDescending(m => m.TransType).ToArray());
        }

        private void AddInterParcel()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetInterParcelStatExcept();
            AddCustom(mails.OrderByDescending(m => m.TransType).ToArray());
        }

        private void AddInterNoticeParcel()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetInterParcelNoticeStatExcept();
            AddCustom(mails.OrderByDescending(m => m.TransType).ToArray());
        }

        private void AddFirstMail()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetFirstMailStatExcept().OrderBy(m => m.TransType).ToArray();
            AddCustom(mails);
        }

        private void AddFirstParcel()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetFirstParcelStatExept().OrderBy(m => m.TransType).ToArray();
            AddCustom(mails);
        }

        private void AddValueMail()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetMailValueStatExcept();
            AddCustom(mails);
        }

        private void AddValueParcel()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetParcelValueStatExcept();
            AddCustom(mails);
        }

        private void AddValueFirstMail()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetFirstMailValueStatExcept();
            AddCustom(mails);
        }

        private void AddValueFirstParcel()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.GetFirstParcelValueStatExcept();
            AddCustom(mails);
        }

        private void AddOther()
        {
            RpoStatData[] mails = _singleReport.RpoCollector.Data.ToArray();
            AddCustom(mails);
        }

        private void AddCustom(RpoStatData[] mails)
        {
            int count = 0;
            double summ = 0;

            if(mails.Length == 0)
                return;

            string currentName = "";

            int mailCount = 0;
            while (mailCount < mails.Length)
            {
                RpoStatData data = mails[mailCount];

                string n = "";

                if (currentName != data.Name)
                {
                    n = data.Name;
                    currentName = data.Name;
                }

                string mass = data.Mass;
                if (!string.IsNullOrEmpty(data.SubName))
                    mass = data.SubName;

                if (mass == "0")
                    mass = "";

                dataGridView.Rows.Add(n, mass, data.Count.ToString(), data.Rate.ToString("F"),
                    (data.Rate * data.Count).ToString("F"));

                count += data.Count;
                summ += data.Rate * data.Count;

                mailCount++;
            }

            _allCount += count;
            _allSumRate += summ;

            AddClearRow();
            dataGridView.Rows.Add("", "Итого", count.ToString(), "", summ.ToString("F"));

            AddClearRow(true);
        }

        private void AddClearRow(bool clear = false)
        {
            if (clear)
            {
                int index = dataGridView.Rows.Add("Clear", "", "", "", "");
                dataGridView.Rows[index].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                dataGridView.Rows[index].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            }
            else
            {
                dataGridView.Rows.Add("", "", "", "", "");
            }
        }

        private void AddFullStat()
        {
            dataGridView.Rows.Add("", "Всего", _allCount.ToString(), "", _allSumRate.ToString("F"));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public MassReportPrintDocument GetPrintDocument()
        {
            int[] columnWidth = new[]
            {
                270, 140, 100, 100, 160
            };

            PrintController printController = new StandardPrintController();

            MassReportPrintDocument document = new MassReportPrintDocument(dataGridView, _singleReport, columnWidth, true)
            {
                PrintController = printController, PrintNumPageInfo = true
            };

            return document;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            MassReportPrintDocument document = GetPrintDocument();
            document.Print();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ReportMassForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + P
            if (e.KeyCode == Keys.P && e.Control)
                btnPrint.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }
    }
}
