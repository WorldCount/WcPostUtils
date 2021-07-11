using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LK.Core.Models.DB;
using LK.Core.Store;

namespace LK.Forms.DataForms
{
    public partial class FirmsForm : Form
    {
        private List<Firm> _firms;

        public FirmsForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Организации";

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _firms = LoadData();
            UpdateData();
        }

        public void InitTable()
        {
            shortNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            shortNameDataGridViewTextBoxColumn.Width = 320;

            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            innDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            innDataGridViewTextBoxColumn.Width = 160;

            kppDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            kppDataGridViewTextBoxColumn.Width = 160;

            contractDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            contractDataGridViewTextBoxColumn.Width = 220;
        }

        public List<Firm> LoadData()
        {
            return Database.GetFirms();
        }

        public void SaveData()
        {
            Database.UpdateFirms(_firms);
        }

        public void UpdateData()
        {
            firmBindingSource.DataSource = null;
            firmBindingSource.DataSource = _firms;
            lblCount.Text = $"{_firms.Count} шт";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _firms = LoadData();
            UpdateData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FirmsForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string q = tbFilter.Text.ToUpper();

            if (!string.IsNullOrEmpty(q))
            {
                List<Firm> filtered = _firms.Where(f => f.Name.Contains(q) || f.ShortName.Contains(q) || f.Inn.Contains(q) || f.Kpp.Contains(q) || f.Contract.Contains(q)).ToList();
                firmBindingSource.DataSource = filtered;
                lblCount.Text = $"{filtered.Count} шт";
            }
            else
            {
                firmBindingSource.DataSource = _firms;
                lblCount.Text = $"{_firms.Count} шт";
            }
        }

        private void FirmsForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FirmsForm_SizeChanged(object sender, EventArgs e)
        {
            tbFilter.Refresh();
        }
    }
}
