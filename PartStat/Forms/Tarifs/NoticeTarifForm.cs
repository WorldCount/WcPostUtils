using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Forms.Tarifs
{
    public partial class NoticeTarifForm : Form
    {
        private List<NoticeTarif> _noticeTarifs;

        public NoticeTarifForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Тарифы на уведомления";

            labelMessage.Text = "";
        }

        private void UpdateData()
        {
            noticeTarifBindingSource.DataSource = null;
            noticeTarifBindingSource.DataSource = _noticeTarifs;
        }

        private async void LoadData()
        {
            _noticeTarifs = await NoticeTarifManager.LoadAsync();
            noticeTarifBindingSource.DataSource = null;
            noticeTarifBindingSource.DataSource = _noticeTarifs;
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
            _noticeTarifs = await NoticeTarifManager.GetFromServer();
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
            NoticeTarifManager.Save(_noticeTarifs);
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
