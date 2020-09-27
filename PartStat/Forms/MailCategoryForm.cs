using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models.DB;
using PartStat.Core.Models.DB.Queries;

namespace PartStat.Forms
{
    public partial class MailCategoryForm : Form
    {
        private List<MailCategory> _mailCategories;
        private readonly Connect _connect;

        public MailCategoryForm(Connect connect)
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Категории отправлений";

            _connect = connect;

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _mailCategories = MailCategoryManager.Load();
            UpdateData();
        }

        private void InitTable()
        {
            enableDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            enableDataGridViewCheckBoxColumn.Width = 40;

            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idDataGridViewTextBoxColumn.Width = 60;

            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            shortNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            shortNameDataGridViewTextBoxColumn.Width = 200;
        }

        private MailCategory GetMailCategoryByRowIndex(int rowIndex)
        {
            try
            {
                List<MailCategory> mailCategories = (List<MailCategory>) mailCategoryBindingSource.DataSource;

                if (mailCategories != null && mailCategories.Count > 0)
                {
                    MailCategory mailCategory = mailCategories[rowIndex];
                    return mailCategory;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        private void UpdateData()
        {
            mailCategoryBindingSource.DataSource = null;
            mailCategoryBindingSource.DataSource = _mailCategories;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MailCategoryManager.Save(_mailCategories);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MailCategoryQuery mailCategoryQuery = new MailCategoryQuery(_connect);
            _mailCategories = mailCategoryQuery.Run();
            mailCategoryQuery.Dispose();
            UpdateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _mailCategories = MailCategoryManager.Load();
            UpdateData();
        }

        private void MailCategoryForm_KeyDown(object sender, KeyEventArgs e)
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
            foreach (MailCategory mailCategory in _mailCategories)
            {
                mailCategory.Enable = true;
            }

            UpdateData();
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MailCategory mailCategory in _mailCategories)
            {
                mailCategory.Enable = false;
            }

            UpdateData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == enableDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            {
                MailCategory mailCategory = GetMailCategoryByRowIndex(e.RowIndex);

                if (mailCategory != null)
                    mailCategory.Enable = !mailCategory.Enable;
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
