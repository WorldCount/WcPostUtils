using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PartStat.Core.Libs.DataBase;
using PartStat.Core.Libs.DataBase.Queries;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models.DB;

namespace PartStat.Forms
{
    public partial class StatusForm : Form
    {
        private List<ListStatus> _listStatuses;
        private readonly Connect _connect;

        public StatusForm(Connect connect)
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Статусы списков";

            _connect = connect;

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _listStatuses = ListStatusManager.Load();
            UpdateData();
        }

        private void InitTable()
        {
            enableDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            enableDataGridViewCheckBoxColumn.Width = 40;

            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idDataGridViewTextBoxColumn.Width = 60;

            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private ListStatus GetListStatusByRowIndex(int rowIndex)
        {
            try
            {
                List<ListStatus> listStatuses = (List<ListStatus>) listStatusBindingSource.DataSource;

                if (listStatuses != null && listStatuses.Count > 0)
                {
                    ListStatus listStatus = listStatuses[rowIndex];
                    return listStatus;
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
            listStatusBindingSource.DataSource = null;
            listStatusBindingSource.DataSource = _listStatuses;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _listStatuses = ListStatusManager.Load();
            UpdateData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ListStatusQuery listStatusQuery = new ListStatusQuery(_connect);
            _listStatuses = listStatusQuery.Run();
            listStatusQuery.Dispose();
            UpdateData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListStatusManager.Save(_listStatuses);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void StatusForm_KeyDown(object sender, KeyEventArgs e)
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
            foreach (ListStatus listStatus in _listStatuses)
            {
                listStatus.Enable = true;
            }

            UpdateData();
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListStatus listStatus in _listStatuses)
            {
                listStatus.Enable = false;
            }

            UpdateData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == enableDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            {
                ListStatus listStatus = GetListStatusByRowIndex(e.RowIndex);

                if (listStatus != null)
                    listStatus.Enable = !listStatus.Enable;
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
