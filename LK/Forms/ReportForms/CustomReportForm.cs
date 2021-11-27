using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.PrintDocuments;
using LK.Core.Libs.Stat;
using LK.Core.Libs.Stat.StatObject;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Models.Filters;
using LK.Core.Models.Reports;
using LK.Core.Store;
using LK.Core.Store.Manager;

namespace LK.Forms.ReportForms
{
    public partial class CustomReportForm : Form
    {

        #region Private Fields

        private readonly Report _report;
        private readonly Config _defaultPrinterConfig;

        private List<MailCategory> _mailCategories;
        private List<MailType> _mailTypes;

        #endregion

        public CustomReportForm(int reportId)
        {
            InitializeComponent();

            _defaultPrinterConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName) ?? ConfigManager.CreateDefaultPrinterName();

            _report = ReportManager.GetById(reportId);

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = _report.Name;
            lblReportName.Text = _report.Name;
        }

        #region Private Methods

        private ReportPrintDocument GetPrintDocument()
        {
            int[] columnWidth = new[] { 280, 120, 80, 100, 80, 80 };
            PrintController printController = new StandardPrintController();
            ReportPrintDocument document = new ReportPrintDocument(dataGridView, columnWidth, true)
            {
                PrintController = printController,
                PrintNumPageInfo = true,
                Title = _report.Name,
                SubTitle = "ДАТА: ",
                ReportTitle = "ЛК",
                CellHeight = 50
            };

            DateTime inDate = dateTimePickerIn.Value;
            DateTime outDate = dateTimePickerOut.Value;
            document.SubTitle += inDate != outDate ? $" {inDate.ToShortDateString()} - {outDate.ToShortDateString()}" : $" {inDate.ToShortDateString()}";

            return document;
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

        private void AddStatRow(string name, int count, double pay)
        {
            int index = dataGridView.Rows.Add("", name, count.ToString(), pay.ToString("F"), "", "");

            DataGridViewCell cell = dataGridView.Rows[index].Cells[0];
            cell.Style.ForeColor = Color.WhiteSmoke;
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

        #endregion

        #region Form Events

        private void CustomReportForm_Load(object sender, EventArgs e)
        {
            _mailCategories = Database.GetMailCategories();
            _mailTypes = Database.GetEnabledMailTypes();
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

        #endregion

        #region Button Events

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            if(_report == null)
                return;

            List<Firm> firms = _report.Firms;

            if (firms.Count > 0)
            {
                FirmListFilter filter = new FirmListFilter
                {
                    StartDate = dateTimePickerIn.Value,
                    EndDate = dateTimePickerOut.Value.AddDays(1),
                    FirmsIds = firms.Select(f => f.Id).ToArray()
                };

                List<FirmList> firmLists = await Database.GetFirmsListManualAsync(filter);
                List<IGrouping<string, FirmList>> data = firmLists.GroupBy(f => f.FirmName).ToList();

                int allCount = 0;
                double allPay = 0;

                foreach (IGrouping<string, FirmList> grouping in data)
                {
                    List<FirmList> temp = grouping.ToList();
                    string firmName = grouping.Key;

                    int count = 0;
                    double pay = 0;

                    CustomReportStatCollector collector = new CustomReportStatCollector(temp, _mailTypes, _mailCategories);

                    bool printName = true;

                    List<ServiceData> services = collector.Services;

                    if (collector.Data.ContainsKey("2-1"))
                    {
                        CustomReportStatData customMail = collector.Data["2-1"];
                        printName = AddRow(services, true, firmName, customMail);

                        count += customMail.Count;
                        pay += customMail.PaySum;

                        allCount += customMail.Count;
                        allPay += customMail.PaySum;
                    }

                    if (collector.Data.ContainsKey("3-1"))
                    {
                        CustomReportStatData customParsel = collector.Data["3-1"];
                        printName = AddRow(services, printName, firmName, customParsel);

                        count += customParsel.Count;
                        pay += customParsel.PaySum;

                        allCount += customParsel.Count;
                        allPay += customParsel.PaySum;
                    }

                    foreach (KeyValuePair<string, CustomReportStatData> customReportStatData in collector.Data)
                    {
                        if (customReportStatData.Key != "2-1" && customReportStatData.Key != "3-1")
                        {
                            CustomReportStatData custom = customReportStatData.Value;
                            printName = AddRow(services, printName, firmName, custom);

                            count += custom.Count;
                            pay += custom.PaySum;

                            allCount += custom.Count;
                            allPay += custom.PaySum;
                        }
                    }

                    if (services.Count > 0)
                    {
                        foreach (ServiceData service in services)
                        {
                            dataGridView.Rows.Add("", "", "", "", service.Name, service.ValueString);
                        }
                    }

                    AddClearRow();
                    AddStatRow("ВСЕГО", count, pay);
                    AddClearRow(true);
                }

                if(allCount > 0)
                    AddStatRow("ОБЩЕЕ", allCount, allPay);
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount > 0)
            {
                ReportPrintDocument document = GetPrintDocument();
                document.PrinterSettings.PrinterName = _defaultPrinterConfig.Value;
                document.PrinterSettings.Copies = (short)numericUpDownCopy.Value;
                document.Print();

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        #endregion

        #region DateTimePicker Events
        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerOut.Value = dateTimePickerIn.Value;
        }

        #endregion

    }
}
