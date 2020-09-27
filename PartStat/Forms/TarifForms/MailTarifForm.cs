using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Forms.TarifForms
{
    public partial class MailTarifForm : Form
    {
        private List<MailTarif> _mailTarifs;
        
        public MailTarifForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Тарифы на заказные письма";

            labelMessage.Text = "";
        }

        private void UpdateData()
        {
            mailTarifBindingSource.DataSource = null;
            mailTarifBindingSource.DataSource = _mailTarifs;
        }

        private async void LoadData()
        {
            _mailTarifs = await MailTarifManager.LoadAsync();
            mailTarifBindingSource.DataSource = null;
            mailTarifBindingSource.DataSource = _mailTarifs;
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
            _mailTarifs = await MailTarifManager.GetFromServer();
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
            MailTarifManager.Save(_mailTarifs);
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
            TarificatorForm tarificatorForm = new TarificatorForm(TarifType.Mail);
            if (tarificatorForm.ShowDialog(this) == DialogResult.OK)
            {
                _mailTarifs = tarificatorForm.MailTarifs;
                UpdateData();
            }
        }
    }
}
