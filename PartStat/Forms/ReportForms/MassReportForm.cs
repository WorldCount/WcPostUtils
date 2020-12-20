using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using PartStat.Core.Libs.DataBase;
using PartStat.Core.Libs.DataBase.Queries;
using PartStat.Core.Libs.DataBase.Queries.Report;
using PartStat.Core.Libs.DataBase.Queries.RequestObject;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Libs.Print;
using PartStat.Core.Models;
using PartStat.Core.Models.DataReports;
using PartStat.Core.Models.DB;

namespace PartStat.Forms.ReportForms
{
    public partial class MassReportForm : Form
    {
        private readonly Config _defaultPrinterConfig;
        private readonly Connect _connect;
        private List<MassReport> _massReports;
        private List<Firm> _firms;


        public MassReportForm(Connect connect)
        {
            InitializeComponent();

            string title = $"{Properties.Settings.Default.AppName}: Отчет по весу";

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = title;

            _connect = connect;
            _defaultPrinterConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName);
        }

        public ReportPrintDocument GetPrintDocument()
        {
            int[] columnWidth = new[] { 240, 60, 220, 220 };
            PrintController printController = new StandardPrintController();
            ReportPrintDocument document = new ReportPrintDocument(dataGridView, columnWidth, true)
            {
                PrintController = printController,
                PrintNumPageInfo = true,
                Title = "Отчет по весу",
                CellHeight = 40
            };

            Firm firm = (Firm)comboBoxOrgs.SelectedItem;
            if (firm != null)
                document.Title += $": {firm.Name}";

            return document;
        }

        private void MassReportForm_KeyDown(object sender, KeyEventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            if (_massReports.Count > 0)
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            DateTime date = dateTimePicker.Value;
            int days = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime first = new DateTime(date.Year, date.Month, 1);
            DateTime last = new DateTime(date.Year, date.Month, days);

            Firm firm = (Firm)comboBoxOrgs.SelectedItem ?? new Firm { Inn = "", Name = "ВСЕ" };

            MassReportRequest request = new MassReportRequest { InDate = first, OutDate = last, Firm = firm};
            MassReportQuery query = new MassReportQuery(_connect, request);

            _massReports = query.Run();

            int allCount = 0;
            double allMass = 0.0;

            foreach (MassReport massReport in _massReports)
            {
                dataGridView.Rows.Add($"{massReport.Date.ToShortDateString()}", $"{massReport.Date:ddd}", massReport.Count, massReport.Mass.ToString("N3", CultureInfo.CurrentCulture));

                allCount += massReport.Count;
                allMass += massReport.Mass;
            }

            if (_massReports.Count > 0)
            {
                AddClearRow(true);
                dataGridView.Rows.Add("Всего", "", allCount, allMass.ToString("N3", CultureInfo.CurrentCulture));
            }
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

        private void MassReportForm_Load(object sender, EventArgs e)
        {
            LoadFirms();
        }
    }
}
