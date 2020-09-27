using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Forms.Tarifs
{
    public partial class ParcelTarifForm : Form
    {
        private List<ParcelTarif> _parcelTarifs;
        
        public ParcelTarifForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Тарифы на заказные бандероли";

            labelMessage.Text = "";
        }

        private void UpdateData()
        {
            parcelTarifBindingSource.DataSource = null;
            parcelTarifBindingSource.DataSource = _parcelTarifs;
        }

        private async void LoadData()
        {
            _parcelTarifs = await ParcelTarifManager.LoadAsync();
            parcelTarifBindingSource.DataSource = null;
            parcelTarifBindingSource.DataSource = _parcelTarifs;
        }

        private void SendMessage(string msg)
        {
            labelMessage.Text = msg;
            timerMessage.Start();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
            SendMessage("Данные обновлены!");
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            _parcelTarifs = await ParcelTarifManager.GetFromServer();
            UpdateData();
            SendMessage("Данные загружены с сервера!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ParcelTarifManager.Save(_parcelTarifs);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MailTarifForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void timerMessage_Tick(object sender, EventArgs e)
        {
            labelMessage.Text = "";
        }

        private void MailTarifForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.PerformClick();
        }

        private void loadServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
        }

        private void tarificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarificatorForm tarificatorForm = new TarificatorForm(TarifType.Parcel);
            if (tarificatorForm.ShowDialog(this) == DialogResult.OK)
            {
                _parcelTarifs = tarificatorForm.ParcelTarifs;
                UpdateData();
            }
        }
    }
}
