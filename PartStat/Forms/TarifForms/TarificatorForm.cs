using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Forms.TarifForms
{
    public enum TarifType
    {
        Mail,
        Parcel
    }

    public partial class TarificatorForm : Form
    {
        private Config _configStartWeight;
        private Config _configEndWeight;
        private Config _configStep;

        private readonly TarifType _tarifType;

        public List<MailTarif> MailTarifs { get; private set; } = new List<MailTarif>();
        public List<ParcelTarif> ParcelTarifs { get; private set; } = new List<ParcelTarif>();

        public TarificatorForm(TarifType type)
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Тарификатор";

            _tarifType = type;

            InitConfig(_tarifType);

            InitData();
        }

        private void InitConfig(TarifType type)
        {
            if(type == TarifType.Mail)
                LoadMailConfig();

            if(type == TarifType.Parcel)
                LoadParcelConfig();

            _configStep = ConfigManager.GetConfigByName(ConfigName.Step);
        }

        private void InitData()
        {
            if(_configStep != null)
                tbStep.Text = _configStep.Value;

            if (_configStartWeight != null)
                tbStartWeight.Text = _configStartWeight.Value;

            if (_configEndWeight != null)
                tbEndWeight.Text = _configEndWeight.Value;

            if (_tarifType == TarifType.Mail)
                tbCost.Text = "54.00";

            if (_tarifType == TarifType.Parcel)
                tbCost.Text = "70.00";

            tbStepCost.Text = "3.00";
        }

        private void LoadMailConfig()
        {
            _configStartWeight = ConfigManager.GetConfigByName(ConfigName.MailStartWeight);
            _configEndWeight = ConfigManager.GetConfigByName(ConfigName.MailEndWeight);
        }

        private void LoadParcelConfig()
        {
            _configStartWeight = ConfigManager.GetConfigByName(ConfigName.ParcelStartWeight);
            _configEndWeight = ConfigManager.GetConfigByName(ConfigName.ParcelEndWeight);
        }

        private void UpdateTarifs()
        {
            double startCost = 0;
            int startWeight = 0;
            int endWeight = 0;
            int step = 0;
            double stepCost = 0;

            if (!string.IsNullOrEmpty(tbCost.Text.Trim()))
                startCost = double.Parse(tbCost.Text.Trim().Replace('.', ','));

            if (!string.IsNullOrEmpty(tbStartWeight.Text.Trim()))
                startWeight = int.Parse(tbStartWeight.Text.Trim());

            if (!string.IsNullOrEmpty(tbEndWeight.Text.Trim()))
                endWeight = int.Parse(tbEndWeight.Text.Trim());

            if (!string.IsNullOrEmpty(tbStep.Text.Trim()))
                step = int.Parse(tbStep.Text.Trim());

            if (!string.IsNullOrEmpty(tbStepCost.Text.Trim()))
                stepCost = double.Parse(tbStepCost.Text.Trim().Replace('.', ','));

            if (_tarifType == TarifType.Parcel)
                ParcelTarifs = Tarificator.ParcelTarificate(startCost, stepCost, startWeight, endWeight, step);

            if (_tarifType == TarifType.Mail)
                MailTarifs = Tarificator.MailTarificate(startCost, stepCost, startWeight, endWeight, step);
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_KeyPressNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateTarifs();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TarificatorForm_KeyDown(object sender, KeyEventArgs e)
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
