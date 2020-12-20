using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LK.Core.Models.DB.Types;
using LK.Core.Store;

namespace LK.Forms.TypeForms
{
    public partial class MailTypeForm : Form
    {
        private List<MailType> _mailTypes;

        public MailTypeForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Виды отправлений";

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _mailTypes = LoadData();
            UpdateData();
        }

        public void InitTable()
        {
            enableDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            enableDataGridViewCheckBoxColumn.Width = 40;

            codeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codeDataGridViewTextBoxColumn.Width = 60;

            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            shortNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            shortNameDataGridViewTextBoxColumn.Width = 260;
        }

        public List<MailType> LoadData()
        {
            return Database.GetMailTypes();
        }

        public void SaveData()
        {
            Database.UpdateMailTypes(_mailTypes);
        }

        public MailType GetMailTypeByRowIndex(int rowIndex)
        {
            try
            {
                List<MailType> mailTypes = (List<MailType>)mailTypeBindingSource.DataSource;

                if (mailTypes != null && mailTypes.Count > 0)
                {
                    MailType mailType = mailTypes[rowIndex];
                    return mailType;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        public void UpdateData()
        {
            mailTypeBindingSource.DataSource = null;
            mailTypeBindingSource.DataSource = _mailTypes;
            lblCount.Text = $"{_mailTypes.Count} шт";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _mailTypes = LoadData();
            UpdateData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MailTypeForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == enableDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            {
                MailType mailType = GetMailTypeByRowIndex(e.RowIndex);

                if (mailType != null)
                    mailType.Enable = !mailType.Enable;
            }
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == enableDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            {
                bool value = (bool)e.FormattedValue;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                Bitmap img = value ? Properties.Resources.checked_32 : Properties.Resources.unchecked_32;
                Size size = img.Size;
                Point loc = new Point((e.CellBounds.Width - size.Width) / 2, (e.CellBounds.Height - size.Height) / 2);
                loc.Offset(e.CellBounds.Location);
                e.Graphics.DrawImage(img, loc);
                e.Handled = true;
            }
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == enableDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                dataGridView.EndEdit();
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MailType mailType in _mailTypes)
            {
                mailType.Enable = true;
            }

            UpdateData();
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MailType mailType in _mailTypes)
            {
                mailType.Enable = false;
            }

            UpdateData();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string q = tbFilter.Text.ToUpper();

            if (!string.IsNullOrEmpty(q))
            {
                List<MailType> filtered = _mailTypes.Where(m => m.Name.ToUpper().Contains(q) || m.ShortName.ToUpper().Contains(q) || m.Code.ToString().Contains(q)).ToList();
                mailTypeBindingSource.DataSource = filtered;
                lblCount.Text = $"{filtered.Count} шт";
            }
            else
            {
                mailTypeBindingSource.DataSource = _mailTypes;
                lblCount.Text = $"{_mailTypes.Count} шт";
            }
        }
    }
}
