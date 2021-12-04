using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.PrintDocuments;
using LK.Core.Models.DB;
using LK.Core.Models.Reports;
using LK.Core.Store;

namespace LK.Forms.ReportForms
{
    public partial class OperatorReportForm : Form
    {
        private readonly Config _defaultPrinterConfig;
        private List<OperStatInfo> _stat;
        private List<Firm> _firms;

        public OperatorReportForm()
        {
            InitializeComponent();

            string title = $"{Properties.Settings.Default.AppName}: Отчет по операторам";

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = title;

            _defaultPrinterConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName);
            _stat = new List<OperStatInfo>();
        }

        public ReportPrintDocument GetPrintDocument()
        {
            int[] columnWidth = new[] { 210, 110, 110, 110, 120, 80 };
            PrintController printController = new StandardPrintController();
            ReportPrintDocument document = new ReportPrintDocument(dataGridView, columnWidth, true)
            {
                PrintController = printController,
                PrintNumPageInfo = true,
                Title = "Отчет по операторам",
                CellHeight = 40,
                ReportTitle = "LK"
            };

            Firm firm = (Firm)comboBoxOrgs.SelectedItem;
            if (firm != null)
                document.Title += $": {firm.Name}";

            DateTime s = dateTimePickerIn.Value;
            DateTime e = dateTimePickerOut.Value;

            string date = "";
            if(s == e)
                date = $" ({s:dd.MM.yyyy})";
            else
                date = $" (с {s:dd.MM.yyyy} по {e:dd.MM.yyyy})";

            document.Title += date.ToUpper();

            return document;
        }

        private void AddClearRow(bool clear = false)
        {
            if (clear)
            {
                int index = dataGridView.Rows.Add("Clear", "", "");
                dataGridView.Rows[index].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                dataGridView.Rows[index].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            }
            else
            {
                dataGridView.Rows.Add("", "", "");
            }
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

        private void UpdateFirms()
        {
            firmBindingSource.DataSource = null;
            firmBindingSource.DataSource = _firms;
        }

        private void ValueReportForm_KeyDown(object sender, KeyEventArgs e)
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            DateTime date = dateTimePickerIn.Value;
            DateTime first = dateTimePickerIn.Value;
            DateTime last = dateTimePickerOut.Value.AddDays(1);

            Firm firm = (Firm)comboBoxOrgs.SelectedItem ?? new Firm { Inn = "", Name = "ВСЕ", ShortName = "ВСЕ" };

            _stat = Database.GetOperStat(first, last, firm);

            int firmCount = 0;
            int listCount = 0;
            int rpoCount = 0;
            int scanCount = 0;

            foreach (OperStatInfo stat in _stat)
            {
                dataGridView.Rows.Add(stat.ShortName, stat.FirmCount, stat.ListCount, stat.RpoCount, stat.ScanCount, $"{stat.ScanPercent}%");

                firmCount += stat.FirmCount;
                listCount += stat.ListCount;
                rpoCount += stat.RpoCount;
                scanCount += stat.ScanCount;
            }

            if (_stat != null && _stat.Count > 0)
            {
                AddClearRow(true);

                double percent = Math.Round(((double)scanCount / rpoCount) * 100, 0);

                dataGridView.Rows.Add("Всего", firmCount, listCount, rpoCount, scanCount, $"{percent}%");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_stat != null && _stat.Count > 0)
            {
                ReportPrintDocument document = GetPrintDocument();
                document.PrinterSettings.PrinterName = _defaultPrinterConfig.Value;
                document.PrinterSettings.Copies = (short) numericUpDownCopy.Value;
                document.Print();

                DialogResult = DialogResult.OK;
                Close();
            }

            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void ValueReportForm_Load(object sender, EventArgs e)
        {
            await LoadFirms();
        }

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerOut.Value = dateTimePickerIn.Value;
        }
    }
}
