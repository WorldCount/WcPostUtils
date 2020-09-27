using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Forms.TarifForms
{
    public partial class InterParcelTarifForm : Form
    {
        private List<InterParcelTarif> _interParcelTarifs;

        public InterParcelTarifForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Тарифы на заказные МЖД бандероли";

            labelMessage.Text = "";
        }

        private void UpdateData()
        {
            interParcelTarifBindingSource.DataSource = null;
            interParcelTarifBindingSource.DataSource = _interParcelTarifs;
        }

        private async void LoadData()
        {
            _interParcelTarifs = await InterParcelTarifManager.LoadAsync();
            interParcelTarifBindingSource.DataSource = null;
            interParcelTarifBindingSource.DataSource = _interParcelTarifs;
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
            _interParcelTarifs = await InterParcelTarifManager.GetFromServer();
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
            InterParcelTarifManager.Save(_interParcelTarifs);
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
