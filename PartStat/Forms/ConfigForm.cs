using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models;

namespace PartStat.Forms
{
    public partial class ConfigForm : Form
    {
        private Config _ndsConfig;
        private Config _valueConfig;
        private Config _stepConfig;
        private Config _mailStartWeightConfig;
        private Config _mailEndWeightConfig;
        private Config _parcelStartWeightConfig;
        private Config _parcelEndWeightConfig;

        public ConfigForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Настройки";

            LoadConfigs();
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

            if (_ndsConfig != null)
                tbNds.Text = _ndsConfig.Value;

            if (_valueConfig != null)
                tbValue.Text = _valueConfig.Value;

            if (_stepConfig != null)
                tbStep.Text = _stepConfig.Value;

            if (_mailStartWeightConfig != null)
                tbMailStartWeight.Text = _mailStartWeightConfig.Value;

            if (_mailEndWeightConfig != null)
                tbMailEndWeight.Text = _mailEndWeightConfig.Value;

            if (_parcelStartWeightConfig != null)
                tbParcelStartWeight.Text = _parcelStartWeightConfig.Value;

            if (_parcelEndWeightConfig != null)
                tbParcelEndWeight.Text = _parcelEndWeightConfig.Value;
        }

        private void SaveConfig()
        {
            List<Config> configs = new List<Config>();

            string nds = tbNds.Text.Trim();
            string value = tbValue.Text.Trim();
            string step = tbStep.Text.Trim();
            string mailStartWeight = tbMailStartWeight.Text.Trim();
            string mailEndWeight = tbMailEndWeight.Text.Trim();
            string parcelStartWeight = tbParcelStartWeight.Text.Trim();
            string parcelEndWeight = tbParcelEndWeight.Text.Trim();

            if (!string.IsNullOrEmpty(nds))
            {
                if(_ndsConfig == null)
                    _ndsConfig = new Config(ConfigName.Nds);

                _ndsConfig.Value = nds;
                configs.Add(_ndsConfig);
            }

            
            if (!string.IsNullOrEmpty(value))
            {
                if(_valueConfig == null)
                    _valueConfig = new Config(ConfigName.Value);
                _valueConfig.Value = value;
                configs.Add(_valueConfig);
            }

           
            if (!string.IsNullOrEmpty(step))
            {
                if (_stepConfig == null)
                    _stepConfig = new Config(ConfigName.Step);
                _stepConfig.Value = step;
                configs.Add(_stepConfig);
            }

            if (!string.IsNullOrEmpty(mailStartWeight))
            {
                if(_mailStartWeightConfig == null)
                    _mailStartWeightConfig = new Config(ConfigName.MailStartWeight);
                _mailStartWeightConfig.Value = mailStartWeight;
                configs.Add(_mailStartWeightConfig);
            }

            if (!string.IsNullOrEmpty(mailEndWeight))
            {
                if (_mailEndWeightConfig == null)
                    _mailEndWeightConfig = new Config(ConfigName.MailEndWeight);
                _mailEndWeightConfig.Value = mailEndWeight;
                configs.Add(_mailEndWeightConfig);
            }

            if (!string.IsNullOrEmpty(parcelStartWeight))
            {
                if (_parcelStartWeightConfig == null)
                    _parcelStartWeightConfig = new Config(ConfigName.ParcelStartWeight);
                _parcelStartWeightConfig.Value = parcelStartWeight;
                configs.Add(_parcelStartWeightConfig);
            }

            if (!string.IsNullOrEmpty(parcelEndWeight))
            {
                if (_parcelEndWeightConfig == null)
                    _parcelEndWeightConfig = new Config(ConfigName.ParcelEndWeight);
                _parcelEndWeightConfig.Value = parcelEndWeight;
                configs.Add(_parcelEndWeightConfig);
            }

            ConfigManager.Save(configs);
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ConfigForm_KeyDown(object sender, KeyEventArgs e)
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
