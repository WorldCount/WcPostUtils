using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LK.Core.Libs.Configs;
using LK.Core.Libs.Extension;
using LK.Core.Store.Manager.FileManager;

namespace LK.Forms.ConfigForms
{
    public partial class FirmRowForm : Form
    {
        private readonly ConfigFirmFieldManager _configFirmFieldManager;

        public FirmRowForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Парсинг организаций";

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _configFirmFieldManager = new ConfigFirmFieldManager();
            _configFirmFieldManager.Load();

            UpdateData();
        }

        public void InitTable()
        {
            descDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            numColumnDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numColumnDataGridViewTextBoxColumn.Width = 160;
        }

        public void SaveData()
        {
            _configFirmFieldManager.Save();
        }

        public void UpdateData()
        {
            configFirmFieldBindingSource.DataSource = null;
            configFirmFieldBindingSource.DataSource = _configFirmFieldManager.ConfigFirmFields;
            lblCount.Text = $"{_configFirmFieldManager.ConfigFirmFields.Count} шт";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _configFirmFieldManager.Load();
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
                List<ConfigFirmField> filtered = _configFirmFieldManager.ConfigFirmFields.Where(c => c.Desc.Contains(q, StringComparison.OrdinalIgnoreCase) || c.NumColumn.ToString().Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
                configFirmFieldBindingSource.DataSource = filtered;
                lblCount.Text = $"{filtered.Count} шт";
            }
            else
            {
                configFirmFieldBindingSource.DataSource = _configFirmFieldManager.ConfigFirmFields;
                lblCount.Text = $"{_configFirmFieldManager.ConfigFirmFields.Count} шт";
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
