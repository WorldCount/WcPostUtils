using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models.DB;
using PartStat.Core.Models.DB.Queries;

namespace PartStat.Forms
{
    public partial class MailTypeForm : Form
    {
        private List<MailType> _mailTypes;
        private readonly Connect _connect;

        public MailTypeForm(Connect connect)
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Виды отправлений";

            _connect = connect;

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _mailTypes = MailTypeManager.Load();
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
            shortNameDataGridViewTextBoxColumn.Width = 220;
        }

        private MailType GetMailTypeByRowIndex(int rowIndex)
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

        private void UpdateData()
        {
            mailTypeBindingSource.DataSource = null;
            mailTypeBindingSource.DataSource = _mailTypes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _mailTypes = MailTypeManager.Load();
            UpdateData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MailTypeQuery mailTypeQuery = new MailTypeQuery(_connect);
            _mailTypes = mailTypeQuery.Run();
            mailTypeQuery.Dispose();
            UpdateData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MailTypeManager.Save(_mailTypes);
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
