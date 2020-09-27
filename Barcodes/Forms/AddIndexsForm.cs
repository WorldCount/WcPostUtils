using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Barcodes.Libs;
using Barcodes.Libs.Models;

namespace Barcodes.Forms
{
    public partial class AddIndexsForm : Form
    {
        private readonly string _path;
        private List<Index> _indices;

        public AddIndexsForm(string path)
        {
            InitializeComponent();

            _path = path;

            _indices = IndexManager.Load(_path);
            indexBindingSource.DataSource = _indices;
        }

        private void UpdateData()
        {
            indexBindingSource.DataSource = null;
            indexBindingSource.DataSource = _indices;
        }

        private void tbOps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbOps.Text) && tbOps.Text.Trim().Length == 6)
            {
                Index index = new Index(tbOps.Text.Trim());
                _indices.Add(index);

                UpdateData();
                tbOps.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _indices = new List<Index>();
            UpdateData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = lbOps.SelectedIndex;
            if (index >= 0)
            {
                _indices.RemoveAt(index);
                UpdateData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IndexManager.Save(_indices, _path);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tbOps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }

        private void AddIndexsForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if(e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }
    }
}
