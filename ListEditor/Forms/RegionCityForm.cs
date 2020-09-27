using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ListEditor.Models;

namespace ListEditor.Forms
{
    public partial class RegionCityForm : Form
    {
        private readonly string _dataPath = Path.Combine(Properties.Settings.Default.DataDir, Properties.Settings.Default.RegionCityFile);
        private ValidateFields _validateFields;

        public RegionCityForm()
        {
            InitializeComponent();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
        }

        private void RegionCityForm_Load(object sender, EventArgs e)
        {
            _validateFields = ValidateFields.Load(_dataPath);
            validateFieldBindingSource.DataSource = _validateFields.Fields;
            dataGridView.DataSource = validateFieldBindingSource;
        }

        private void RegionCityForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _validateFields.Save(_dataPath);
            Close();
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = (TextBox) e.Control;
            textBox.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
