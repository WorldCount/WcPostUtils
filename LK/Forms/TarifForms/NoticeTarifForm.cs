using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.TarifManager;
using LK.Core.Libs.TarifManager.Tarif;
using WcApi.Finance;

namespace LK.Forms.TarifForms
{
    public partial class NoticeTarifForm : Form
    {
        private List<NoticeTarif> _noticeTarifs;
        private readonly Nds _nds;

        public NoticeTarifForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Тарифы на уведомления";

            labelMessage.Text = "";

            var configNds = ConfigManager.GetConfigByName(ConfigName.Nds);
            _nds = new Nds(configNds.GetIntValue());
        }

        private void UpdateData()
        {
            tarifBindingSource.DataSource = null;
            tarifBindingSource.DataSource = _noticeTarifs;
            lblCount.Text = $"{_noticeTarifs.Count} шт";
        }

        private async void LoadData()
        {
            _noticeTarifs = await NoticeTarifManager.LoadAsync();
            tarifBindingSource.DataSource = null;
            tarifBindingSource.DataSource = _noticeTarifs;
            lblCount.Text = $"{_noticeTarifs.Count} шт";
        }

        private void SendMessage(string msg)
        {
            labelMessage.Text = msg;
            timerMessage.Start();
        }

        public T GetModelByRowIndex<T>(int rowIndex)
        {
            try
            {
                List<T> data = (List<T>)tarifBindingSource.DataSource;

                if (data != null && data.Count > 0)
                {
                    T ob = data[rowIndex];
                    return ob;
                }
            }
            catch
            {
                return default;
            }

            return default;
        }

        #region Обработчики

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == rateDataGridViewTextBoxColumn.Index && e.RowIndex >= 0)
            {
                NoticeTarif tarif = GetModelByRowIndex<NoticeTarif>(e.RowIndex);

                if (tarif != null)
                {
                    tarif.RateNds = _nds.Plus(tarif.Rate);
                }
            }
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

        #endregion

    }
}
