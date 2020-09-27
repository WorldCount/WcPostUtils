using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Forms.TarifForms
{
    public partial class FirstParcelTarifForm : Form
    {
        private List<FirstParcelTarif> _firstMailTarifs;

        public FirstParcelTarifForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Тарифы на заказные бандероли 1 кл";

            labelMessage.Text = "";
        }

        private void UpdateData()
        {
            firstParcelTarifBindingSource.DataSource = null;
            firstParcelTarifBindingSource.DataSource = _firstMailTarifs;
        }

        private async void LoadData()
        {
            _firstMailTarifs = await FirstParcelTarifManager.LoadAsync();
            firstParcelTarifBindingSource.DataSource = null;
            firstParcelTarifBindingSource.DataSource = _firstMailTarifs;
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
            _firstMailTarifs = await FirstParcelTarifManager.GetFromServer();
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
            FirstParcelTarifManager.Save(_firstMailTarifs);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void timerMessage_Tick(object sender, EventArgs e)
        {
            labelMessage.Text = "";
        }

        private void NoticeForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void NoticeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
