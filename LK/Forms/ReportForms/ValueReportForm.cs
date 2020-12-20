using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.DataReports;
using LK.Core.Libs.PrintDocuments;
using LK.Core.Models.DB;
using LK.Core.Store;

namespace LK.Forms.ReportForms
{
    public partial class ValueReportForm : Form
    {
        private readonly Config _defaultPrinterConfig;
        private List<ValueReport> _valueReports;
        private List<Firm> _firms;

        public ValueReportForm()
        {
            InitializeComponent();

            string title = $"{Properties.Settings.Default.AppName}: Отчет по ценным";

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = title;

            _defaultPrinterConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName);
        }

        public ReportPrintDocument GetPrintDocument()
        {
            int[] columnWidth = new[] { 300, 60, 300 };
            PrintController printController = new StandardPrintController();
            ReportPrintDocument document = new ReportPrintDocument(dataGridView, columnWidth, true)
            {
                PrintController = printController,
                PrintNumPageInfo = true,
                Title = "Отчет по ценным",
                CellHeight = 40
            };

            Firm firm = (Firm)comboBoxOrgs.SelectedItem;
            if (firm != null)
                document.Title += $": {firm.Name}";

            DateTime date = dateTimePicker.Value;
            document.Title += $" ({CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month)} {date.Year})".ToUpper();

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

            // Нажатие Ctrl + F
            if (e.KeyCode == Keys.F && e.Control)
                dateTimePicker.Focus();

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

            DateTime date = dateTimePicker.Value;
            int days = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime first = new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            DateTime last = new DateTime(date.Year, date.Month, days, 23, 59, 59);

            Firm firm = (Firm)comboBoxOrgs.SelectedItem ?? new Firm { Inn = "", Name = "ВСЕ", ShortName = "ВСЕ" };

            List<Rpo> rpos = Database.GetValueRpos(first, last);

            _valueReports = rpos.GroupBy(r => r.ReceptionDateTrim).Select(group => new ValueReport
            {
                Date = group.Key,
                Count = group.Count()
            }).OrderBy(x => x.Date).ToList();

            int allCount = 0;

            foreach (ValueReport report in _valueReports)
            {
                dataGridView.Rows.Add(report.Date.ToShortDateString(), $"{report.Date:ddd}", report.Count);
                allCount += report.Count;
            }

            if (_valueReports != null && _valueReports.Count > 0)
            {
                AddClearRow(true);
                dataGridView.Rows.Add("Всего", "", allCount);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_valueReports != null && _valueReports.Count > 0)
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
    }
}
