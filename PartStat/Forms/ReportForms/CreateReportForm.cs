using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PartStat.Core.Libs.DataBase;
using PartStat.Core.Libs.DataBase.Queries;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models.DB;
using PartStat.Core.Models.Report;

namespace PartStat.Forms.ReportForms
{
    public partial class CreateReportForm : Form
    {
        private Report _report;
        private readonly Connect _connect;
        private List<Firm> _firms;
        private List<Firm> _allFirms;

        public Report Report => _report;

        public CreateReportForm(Connect connect, Report report)
        {
            InitializeComponent();

            _report = report;
            _connect = connect;

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = _report.Id > 0 ? $"{Properties.Settings.Default.AppName}: Редактирование отчета" : $"{Properties.Settings.Default.AppName}: Создание отчета";
        }

        private void CreateReportForm_Load(object sender, EventArgs e)
        {
            if (_report.Id <= 0)
            {
                _report.Id = ReportManager.GetLastId() + 1;
                checkBoxEnabled.Checked = true;
            }
            else
            {
                checkBoxEnabled.Checked = _report.Enable;
                textBoxReportName.Text = _report.Name;
            }

            labelId.Text = _report.Id.ToString();

            // Загружаем организации
            LoadFirms();
        }

        private void LoadFirms()
        {
            _firms = new List<Firm>();
            FirmQuery firmQuery = new FirmQuery(_connect);
            _allFirms = firmQuery.Run();
            firmQuery.Dispose();
            FilterFirms();
            UpdateFirms();
        }

        private void FilterFirms()
        {
            _firms = new List<Firm>();

            foreach (Firm firm in _allFirms)
            {
                if(!_report.Firms.Contains(firm))
                    _firms.Add(firm);
            }

            UpdateReportFirms();
        }

        private void UpdateReportFirms()
        {
            firmBindingSourceReportOrgs.DataSource = null;
            firmBindingSourceReportOrgs.DataSource = _report.Firms;

            labelReportOrgCount.Text = _report.Firms.Count.ToString();
        }

        private void UpdateFirms()
        {
            firmBindingSourceOrgs.DataSource = null;
            firmBindingSourceOrgs.DataSource = _firms;

            labelOrgCount.Text = _firms.Count.ToString();
        }

        private void FilterOrgs()
        {
            string text = textBoxFilter.Text.Trim();
            FilterFirms();
            _firms = _firms.Where(f => f.Name.Contains(text)).ToList();
            UpdateFirms();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            listBoxOrgs.BeginUpdate();
            FilterOrgs();
            listBoxOrgs.EndUpdate();
        }

        private void listBoxOrgs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ind = listBoxOrgs.SelectedIndex;

            if (ind >= 0)
            {
                listBoxOrgs.BeginUpdate();

                Firm firm = _firms[ind];
                _report.Firms.Add(firm);
                _report.Firms = _report.Firms.OrderBy(f => f.Name).ToList();
                
                FilterFirms();

                FilterOrgs();

                UpdateFirms();
                UpdateReportFirms();

                listBoxOrgs.EndUpdate();

                try
                {
                    listBoxOrgs.SelectedIndex = ind;
                }
                catch
                {
                    listBoxOrgs.SelectedIndex = -1;
                }
                
            }
        }

        private void listBoxReportOrg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ind = listBoxReportOrg.SelectedIndex;

            if (ind >= 0)
            {
                listBoxReportOrg.BeginUpdate();

                Firm firm = _report.Firms[ind]; 
                _firms.Add(firm);

                _report.Firms.Remove(firm);

                FilterFirms();

                UpdateFirms();
                UpdateReportFirms();

                listBoxReportOrg.EndUpdate();

                try
                {
                    listBoxReportOrg.SelectedIndex = ind;
                }
                catch
                {
                    listBoxReportOrg.SelectedIndex = -1;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFilter.Clear();
        }

        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _report.Name = textBoxReportName.Text.Trim();
            _report.Enable = checkBoxEnabled.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CreateReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }
    }
}
