using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using PartStat.Core.Libs.DataBase;
using PartStat.Core.Libs.DataBase.Queries;
using PartStat.Core.Libs.DataBase.Queries.Report;
using PartStat.Core.Libs.DataBase.Queries.RequestObject;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Libs.Print;
using PartStat.Core.Libs.Stats;
using PartStat.Core.Libs.Stats.StatObject;
using PartStat.Core.Models;
using PartStat.Core.Models.DB;
using PartStat.Core.Models.Report;

namespace PartStat.Forms.ReportForms
{
    public partial class OrgReportForm : Form
    {
        private readonly Connect _connect;
        private readonly Config _defaultPrinterConfig;
        private List<Firm> _firms;

        private readonly int _nds;
        private readonly int _value;
        private readonly double _interNoticeRate;


        public OrgReportForm(Connect connect, int nds, int value, double interNoticeRate = 0)
        {
            InitializeComponent();

            _connect = connect;
            _defaultPrinterConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName);

            _nds = nds;
            _value = value;
            _interNoticeRate = interNoticeRate;

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = "Отчет по организации";
        }

        public ReportPrintDocument GetPrintDocument()
        {
            int[] columnWidth = new[] { 280, 120, 80, 100, 80, 80 };
            PrintController printController = new StandardPrintController();
            ReportPrintDocument document = new ReportPrintDocument(dataGridView, columnWidth, true)
            {
                PrintController = printController,
                PrintNumPageInfo = true,
                Title = "Отчет по организации",
                CellHeight = 50
            };

            Firm firm = (Firm)comboBoxOrgs.SelectedItem;
            if (firm != null)
                document.Title += $": {firm.Name}";

            DateTime inDate = dateTimePickerIn.Value;
            DateTime outDate = dateTimePickerOut.Value;
            document.Title += inDate != outDate ? $" ({inDate.ToShortDateString()} - {outDate.ToShortDateString()})" : $" ({inDate.ToShortDateString()})";

            return document;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount > 0)
            {
                ReportPrintDocument document = GetPrintDocument();
                document.PrinterSettings.PrinterName = _defaultPrinterConfig.Value;
                document.PrinterSettings.Copies = (short) numericUpDownCopy.Value;
                document.Print();

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            Firm firm = (Firm) comboBoxOrgs.SelectedItem ?? new Firm { Inn = "", Name = "ВСЕ" };

            
            CustomReportRequest request = new CustomReportRequest
            {
                InDate = dateTimePickerIn.Value,
                OutDate = dateTimePickerOut.Value,
                Firms = new List<Firm> { firm }
            };

            CustomReportQuery query = new CustomReportQuery(_connect, request);
            List<FirmList> firmLists = query.Run(_nds, _value, _interNoticeRate);

            List<IGrouping<string, FirmList>> data = firmLists.GroupBy(f => f.FirmName).ToList();
            foreach (IGrouping<string, FirmList> grouping in data)
            {
                List<FirmList> temp = grouping.ToList();
                string firmName = grouping.Key;

                CustomReportStatCollector collector = new CustomReportStatCollector(temp);

                if (collector.PayMark)
                    firmName += " (марки)";

                bool printName = true;

                List<ServiceData> services = collector.Services;

                if (collector.Data.ContainsKey("2-1"))
                {
                    CustomReportStatData customMail = collector.Data["2-1"];
                    printName = AddRow(services, true, firmName, customMail);
                }

                if (collector.Data.ContainsKey("3-1"))
                {
                    CustomReportStatData customParsel = collector.Data["3-1"];
                    printName = AddRow(services, printName, firmName, customParsel);
                }

                foreach (KeyValuePair<string, CustomReportStatData> customReportStatData in collector.Data)
                {
                    if (customReportStatData.Key != "2-1" && customReportStatData.Key != "3-1")
                    {
                        CustomReportStatData custom = customReportStatData.Value;
                        printName = AddRow(services, printName, firmName, custom);
                    }
                }

                if (services.Count > 0)
                {
                    foreach (ServiceData service in services)
                    {
                        dataGridView.Rows.Add("", "", "", "", service.Name, service.ValueString);
                    }
                }

                AddClearRow(true);
            }
        }

        private void AddClearRow(bool clear = false)
        {
            if (clear)
            {
                int index = dataGridView.Rows.Add("Clear", "", "", "", "", "");
                dataGridView.Rows[index].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                dataGridView.Rows[index].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            }
            else
            {
                dataGridView.Rows.Add("", "", "", "", "", "");
            }
        }

        private bool AddRow(List<ServiceData> services, bool printName, string firmName, CustomReportStatData custom)
        {
            string value = "";
            string name = "";


            if (services.Count > 0)
            {
                name = services[0].Name;
                value = services[0].ValueString;
                services.RemoveAt(0);
            }

            if (printName)
            {
                dataGridView.Rows.Add(firmName, custom.MailName, custom.Count, custom.PaySum.ToString("F"), name, value);
                return false;
            }
            else
            {
                dataGridView.Rows.Add("", custom.MailName, custom.Count, custom.PaySum.ToString("F"), name, value);
            }

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            return printName;
        }

        private void CustomReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + P
            if (e.KeyCode == Keys.P && e.Control)
                btnPrint.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();

            // Нажатие Ctrl + Q
            if (e.KeyCode == Keys.Q && e.Control)
                btnLoad.PerformClick();
        }

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerOut.Value = dateTimePickerIn.Value;
        }

        private void LoadFirms()
        {
            Firm firm = new Firm { Inn = "", Name = "ВСЕ" };

            FirmQuery firmQuery = new FirmQuery(_connect);
            _firms = firmQuery.Run();
            firmQuery.Dispose();

            if (_firms != null)
                _firms.Insert(0, firm);
            else
            {
                _firms = new List<Firm>();
                _firms.Insert(0, firm);
            }

            UpdateFirms();
        }

        private void UpdateFirms()
        {
            firmBindingSource.DataSource = null;
            firmBindingSource.DataSource = _firms;
        }

        private void OrgReportForm_Load(object sender, EventArgs e)
        {
            LoadFirms();
        }
    }
}
