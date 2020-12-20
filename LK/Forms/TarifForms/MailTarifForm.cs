using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.TarifManager;
using LK.Core.Libs.TarifManager.Tarif;
using WcApi.Finance;

namespace LK.Forms.TarifForms
{
    public partial class MailTarifForm : Form
    {
        private List<MailTarif> _tarifs;
        private readonly Nds _nds;

        public MailTarifForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Тарифы на заказные письма";

            labelMessage.Text = "";

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            var configNds = ConfigManager.GetConfigByName(ConfigName.Nds);
            _nds = new Nds(configNds.GetIntValue());
        }

        private void UpdateData()
        {
            tarifBindingSource.DataSource = null;
            tarifBindingSource.DataSource = _tarifs;

            lblCount.Text = $"{_tarifs.Count} шт";
        }

        private async void LoadData()
        {
            _tarifs = await MailTarifManager.LoadAsync();

            tarifBindingSource.DataSource = null;
            tarifBindingSource.DataSource = _tarifs;

            lblCount.Text = $"{_tarifs.Count} шт";
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

        #region Обрабочики

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == rateDataGridViewTextBoxColumn.Index && e.RowIndex >= 0)
            {
                MailTarif tarif = GetModelByRowIndex<MailTarif>(e.RowIndex);

                if (tarif != null)
                {
                    tarif.RateNds = _nds.Plus(tarif.Rate);
                }
            }
        }

        private void MailTarifForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MailTarifForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Нажатие Ctrl + Q
            if (e.KeyCode == Keys.Q && e.Control)
                btnSave.PerformClick();

            // Нажатие Ctrl + L
            if (e.KeyCode == Keys.S && e.Control)
                btnLoad.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
            SendMessage("Данные обновлены!");
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            _tarifs = await MailTarifManager.GetFromServer();
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
            MailTarifManager.Save(_tarifs);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void timerMessage_Tick(object sender, EventArgs e)
        {
            labelMessage.Text = "";
        }

        private void tarificateMenuItem_Click(object sender, EventArgs e)
        {
            TarificatorForm tarificatorForm = new TarificatorForm(TarifType.Mail);
            if (tarificatorForm.ShowDialog(this) == DialogResult.OK)
            {
                _tarifs = tarificatorForm.MailTarifs;
                UpdateData();
            }
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.PerformClick();
        }

        private void loadServerMenuItem_Click(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string q = tbFilter.Text.ToUpper();

            if (!string.IsNullOrEmpty(q))
            {
                List<MailTarif> filtered = _tarifs.Where(m => m.Rate.ToString("N2").Contains(q) || m.RateNds.ToString("N2").Contains(q) || m.Mass.ToString().Contains(q)).ToList();
                tarifBindingSource.DataSource = filtered;
                lblCount.Text = $"{filtered.Count} шт";
            }
            else
            {
                tarifBindingSource.DataSource = _tarifs;
                lblCount.Text = $"{_tarifs.Count} шт";
            }
        }

        #endregion

    }
}
