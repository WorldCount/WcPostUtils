using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using PartStat.Core.Libs.DataBase;
using PartStat.Core.Libs.DataBase.Queries;
using PartStat.Core.Libs.DataBase.Queries.RequestObject;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Libs.Print;
using PartStat.Core.Models;
using PartStat.Core.Models.DataReports;

namespace PartStat.Forms.ReportForms
{
    public partial class HandReportForm : Form
    {
        private readonly Config _defaultPrinterConfig;
        private readonly Connect _connect;
        private HandReportList _handReportList;


        public HandReportForm(Connect connect)
        {
            InitializeComponent();

            string title = $"{Properties.Settings.Default.AppName}: Отчет по ручным спискам";

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = title;

            _connect = connect;
            _defaultPrinterConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName);
        }

        public HandReportPrintDocument GetPrintDocument()
        {
            int[] columnWidth = new[] { 200, 160, 160, 160 };
            PrintController printController = new StandardPrintController();
            HandReportPrintDocument document = new HandReportPrintDocument(dataGridView, columnWidth, true)
            {
                PrintController = printController,
                PrintNumPageInfo = true
            };

            return document;
        }

        private void HandReportForm_KeyDown(object sender, KeyEventArgs e)
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
            
            if (_handReportList.Count > 0)
            {
                HandReportPrintDocument document = GetPrintDocument();
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

            HandReportRequest request = new HandReportRequest { InDate = first, OutDate = last};
            HandReportQuery query = new HandReportQuery(_connect, request);
            _handReportList = query.Run();

            int allCount = 0;
            int handCount = 0;
            int normalCount = 0;

            foreach (HandReport handReport in _handReportList)
            {
                dataGridView.Rows.Add(handReport.Date.ToShortDateString(), handReport.AllCount, handReport.NormalCount, handReport.HandCount);

                allCount += handReport.AllCount;
                handCount += handReport.HandCount;
                normalCount += handReport.NormalCount;
            }

            if (_handReportList.Count > 0)
            {
                AddClearRow(true);
                dataGridView.Rows.Add("Всего", allCount, normalCount, handCount);
            }
        }

        private void AddClearRow(bool clear = false)
        {
            if (clear)
            {
                int index = dataGridView.Rows.Add("Clear", "", "", "");
                dataGridView.Rows[index].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                dataGridView.Rows[index].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            }
            else
            {
                dataGridView.Rows.Add("", "", "", "");
            }
        }
    }
}
