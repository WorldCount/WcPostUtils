using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PartStat.Core.Libs.DataBase;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models.Report;

namespace PartStat.Forms.ReportForms
{
    public partial class EditReportForm : Form
    {
        private readonly Connect _connect;
        private List<Report> _reports;

        private readonly SolidBrush _enableBrush = new SolidBrush(Color.FromArgb(255, 53,56,58));
        private readonly SolidBrush _disableBrush = new SolidBrush(Color.Firebrick);
        private readonly SolidBrush _foreBrush = new SolidBrush(Color.White);
        private readonly SolidBrush _selectBrush = new SolidBrush(Color.FromKnownColor(KnownColor.Highlight));

        public EditReportForm(Connect connect)
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Редкатирование отчетов";

            _connect = connect;
        }

        private void LoadReports()
        {
            _reports = ReportManager.Load();
            UpdateReports();
        }

        private void UpdateReports()
        {
            reportBindingSource.DataSource = null;
            reportBindingSource.DataSource = _reports;
        }

        private void EditReportForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void EditReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateReportForm createReportForm = new CreateReportForm(_connect, new Report());
            if (createReportForm.ShowDialog(this) == DialogResult.OK)
            {
                _reports.Add(createReportForm.Report);
                UpdateReports();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Report report = (Report) listBoxReport.SelectedItem;

            if (report != null)
            {
                CreateReportForm createReportForm = new CreateReportForm(_connect, report);
                if (createReportForm.ShowDialog(this) == DialogResult.OK)
                {
                    Report updReport = createReportForm.Report;
                    int ind = _reports.FindIndex(r => r.Id == updReport.Id);

                    _reports[ind] = updReport;
                    UpdateReports();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Report report = (Report)listBoxReport.SelectedItem;
            int ind = listBoxReport.SelectedIndex;

            if (report != null)
            {
                listBoxReport.BeginUpdate();

                _reports.Remove(report);
                UpdateReports();

                listBoxReport.EndUpdate();

                try
                {
                    listBoxReport.SelectedIndex = ind;
                }
                catch
                {
                    listBoxReport.SelectedIndex = -1;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReportManager.Save(_reports);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void listBoxReport_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            int index = e.Index;
            if (index >= 0 && index < listBoxReport.Items.Count)
            {
                Report report = (Report) listBoxReport.Items[index];
                Graphics g = e.Graphics;

                //background:
                SolidBrush foreBrush;
                SolidBrush backBrush = new SolidBrush(e.BackColor);
                if (selected)
                {
                    foreBrush = _foreBrush;
                    backBrush = _selectBrush;
                }
                else if (!report.Enable)
                    foreBrush = _disableBrush;
                else
                    foreBrush = _enableBrush;

                g.FillRectangle(backBrush, e.Bounds);

                //text:
                SizeF size = e.Graphics.MeasureString(report.Name, e.Font);
                g.DrawString(report.Name, e.Font, foreBrush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }

            e.DrawFocusRectangle();
        }
    }
}
