using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LK.Core.Libs.Configs;
using LK.Core.Libs.Extension;
using LK.Core.Store.Manager.FileManager;

namespace LK.Forms.ConfigForms
{
    public partial class DataFieldForm : Form
    {
        private readonly ConfigDataFieldManager _configDataFieldManager;

        public DataFieldForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Парсинг данных";

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _configDataFieldManager = new ConfigDataFieldManager();
            _configDataFieldManager.Load();

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
            _configDataFieldManager.Save();
        }

        public void UpdateData()
        {
            dataFieldBindingSource.DataSource = null;
            dataFieldBindingSource.DataSource = _configDataFieldManager.ConfigDataFields;
            lblCount.Text = $"{_configDataFieldManager.ConfigDataFields.Count} шт";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _configDataFieldManager.Load();
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
                List<ConfigDataField> filtered = _configDataFieldManager.ConfigDataFields.Where(c => c.Desc.Contains(q, StringComparison.OrdinalIgnoreCase) || c.NumColumn.ToString().Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
                dataFieldBindingSource.DataSource = filtered;
                lblCount.Text = $"{filtered.Count} шт";
            }
            else
            {
                dataFieldBindingSource.DataSource = _configDataFieldManager.ConfigDataFields;
                lblCount.Text = $"{_configDataFieldManager.ConfigDataFields.Count} шт";
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
