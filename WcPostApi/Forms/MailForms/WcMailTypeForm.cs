using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WcPostApi.Types;

namespace WcPostApi.Forms.MailForms
{
    public partial class WcMailTypeForm : Form
    {
        public List<MailType> MailTypes;

        public WcMailTypeForm()
        {
            InitializeComponent();

            InitTable();
        }

        public void InitTable()
        {
            enableDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            enableDataGridViewCheckBoxColumn.Width = 40;

            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idDataGridViewTextBoxColumn.Width = 60;

            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            shortNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            shortNameDataGridViewTextBoxColumn.Width = 260;
        }

        public virtual List<MailType> LoadData()
        {
            return new List<MailType>();
        }

        public virtual List<MailType> LoadDataServer()
        {
            return new List<MailType>();
        }

        public virtual void SaveData()
        {
            return;
        }

        public MailType GetMailTypeByRowIndex(int rowIndex)
        {
            try
            {
                List<MailType> mailTypes = (List<MailType>) mailTypeBindingSource.DataSource;

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
            mailTypeBindingSource.DataSource = MailTypes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MailTypes = LoadData();
            UpdateData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MailTypes = LoadDataServer();
            UpdateData();
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

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MailType mailType in MailTypes)
            {
                mailType.Enable = true;
            }

            UpdateData();
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MailType mailType in MailTypes)
            {
                mailType.Enable = false;
            }

            UpdateData();
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
    }
}
