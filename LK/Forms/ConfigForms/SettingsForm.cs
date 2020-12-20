using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;

namespace LK.Forms.ConfigForms
{
    public partial class SettingsForm : Form
    {

        private Config _ndsConfig;
        private Config _valueConfig;
        private Config _stepConfig;
        private Config _mailStartWeightConfig;
        private Config _mailEndWeightConfig;
        private Config _parcelStartWeightConfig;
        private Config _parcelEndWeightConfig;

        public SettingsForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Настройки";

            LoadConfigs();
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Bindings()
        {
            tbNds.DataBindings.Add("Text", _ndsConfig, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbValue.DataBindings.Add("Text", _valueConfig, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbStep.DataBindings.Add("Text", _stepConfig, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbMailStartWeight.DataBindings.Add("Text", _mailStartWeightConfig, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbMailEndWeight.DataBindings.Add("Text", _mailEndWeightConfig, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbParcelStartWeight.DataBindings.Add("Text", _parcelStartWeightConfig, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            tbParcelEndWeight.DataBindings.Add("Text", _parcelEndWeightConfig, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadConfigs()
        {
            _ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);
            _valueConfig = ConfigManager.GetConfigByName(ConfigName.Value);
            _stepConfig = ConfigManager.GetConfigByName(ConfigName.Step);
            _mailStartWeightConfig = ConfigManager.GetConfigByName(ConfigName.MailStartWeight);
            _mailEndWeightConfig = ConfigManager.GetConfigByName(ConfigName.MailEndWeight);
            _parcelStartWeightConfig = ConfigManager.GetConfigByName(ConfigName.ParcelStartWeight);
            _parcelEndWeightConfig = ConfigManager.GetConfigByName(ConfigName.ParcelEndWeight);
        }

        private void SaveConfigs()
        {
            List<Config> configs = new List<Config>
            {
                _ndsConfig,
                _valueConfig,
                _stepConfig,
                _mailStartWeightConfig,
                _mailEndWeightConfig,
                _parcelStartWeightConfig,
                _parcelEndWeightConfig
            };

            ConfigManager.Save(configs);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Bindings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConfigs();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
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
