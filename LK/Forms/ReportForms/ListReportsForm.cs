using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LK.Core.Models.Reports;
using LK.Core.Store.Manager.FileManager;

namespace LK.Forms.ReportForms
{
    public partial class ListReportsForm : Form
    {
        #region Private Fields

        private readonly SolidBrush _enableBrush = new SolidBrush(Color.FromArgb(255, 53, 56, 58));
        private readonly SolidBrush _disableBrush = new SolidBrush(Color.Firebrick);
        private readonly SolidBrush _foreBrush = new SolidBrush(Color.White);
        private readonly SolidBrush _selectBrush = new SolidBrush(Color.FromKnownColor(KnownColor.Highlight));

        private List<Report> _reports;

        #endregion

        public ListReportsForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Редкатирование отчетов";
        }

        #region Private Methods

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

        #endregion

        #region Form Events

        private void ListReportsForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void ListReportsForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }


        #endregion

        #region Button Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateEditReportForm createEditReportForm = new CreateEditReportForm(new Report());
            if (createEditReportForm.ShowDialog(this) == DialogResult.OK)
            {
                _reports.Add(createEditReportForm.Report);
                UpdateReports();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Report report = (Report)listBoxReport.SelectedItem;

            if (report != null)
            {
                CreateEditReportForm createEditReportForm = new CreateEditReportForm(report);
                if (createEditReportForm.ShowDialog(this) == DialogResult.OK)
                {
                    Report updReport = createEditReportForm.Report;
                    int ind = _reports.FindIndex(r => r.Id == updReport.Id);

                    _reports[ind] = updReport;
                    UpdateReports();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReportManager.Save(_reports);
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion

        #region Listbox Events

        private void listBoxReport_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            int index = e.Index;
            if (index >= 0 && index < listBoxReport.Items.Count)
            {
                Report report = (Report)listBoxReport.Items[index];
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

        #endregion
        
    }
}
