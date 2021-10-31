using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LK.Core.Models.DB;
using LK.Core.Models.Reports;
using LK.Core.Store;
using LK.Core.Store.Manager;

namespace LK.Forms.ReportForms
{
    public partial class CreateEditReportForm : Form
    {
        
        #region Private Fields

        private readonly Report _report;
        private List<Firm> _firms;
        private List<Firm> _allFirms;

        #endregion

        #region Public Properties

        public Report Report => _report;

        #endregion

        public CreateEditReportForm(Report report)
        {
            InitializeComponent();

            _report = report;

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = _report.Id > 0 ? $"{Properties.Settings.Default.AppName}: Редактирование отчета" : $"{Properties.Settings.Default.AppName}: Создание отчета";
        }

        #region Private Methods

        private async void LoadFirms()
        {
            _firms = new List<Firm>();
            _allFirms = await Database.GetFirmsAsync();
            FilterFirms();
            UpdateFirms();
        }

        private void FilterFirms()
        {
            _firms = new List<Firm>();

            foreach (Firm firm in _allFirms)
            {
                if (_report.Firms.FirstOrDefault(f => f.Id == firm.Id) == null)
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
            string text = textBoxFilter.Text.ToUpper().Trim();
            FilterFirms();
            _firms = _firms.Where(f => f.Name.ToUpper().Contains(text) || f.ShortName.ToUpper().Contains(text)).ToList();
            UpdateFirms();
        }

        #endregion

        #region Form Events

        private void CreateEditReportForm_Load(object sender, System.EventArgs e)
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

        private void CreateEditReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        #endregion

        #region ListBox Events

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

        #endregion

        #region TextBox Events

        private void textBoxFilter_TextChanged(object sender, System.EventArgs e)
        {
            listBoxOrgs.BeginUpdate();
            FilterOrgs();
            listBoxOrgs.EndUpdate();
        }

        #endregion

        #region Button Events

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            textBoxFilter.Clear();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _report.Name = textBoxReportName.Text.Trim();
            _report.Enable = checkBoxEnabled.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion
    }
}
