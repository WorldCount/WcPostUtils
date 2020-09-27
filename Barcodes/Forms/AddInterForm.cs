using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Barcodes.Libs;
using Barcodes.Libs.Models;

namespace Barcodes.Forms
{
    public partial class AddInterForm : Form
    {

        private readonly string _path;
        private List<InternalType> _internalTypes;

        public AddInterForm(string path)
        {
            InitializeComponent();

            _path = path;

            _internalTypes = InternalTypeManager.Load(_path);
            internalTypeBindingSource.DataSource = _internalTypes;

            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        private void UpdateData()
        {
            internalTypeBindingSource.DataSource = null;
            internalTypeBindingSource.DataSource = _internalTypes;
        }

        private void tbType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }

        private void tbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbType.Text) && tbType.Text.Trim().Length == 2)
            {
                InternalType internalType = new InternalType(tbType.Text.Trim());
                _internalTypes.Add(internalType);

               UpdateData();
               tbType.Clear();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = lbType.SelectedIndex;
            if (index >= 0)
            {
                _internalTypes.RemoveAt(index);
                UpdateData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _internalTypes = new List<InternalType>();
            UpdateData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InternalTypeManager.Save(_internalTypes, _path);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddInterForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            _internalTypes.Sort(delegate(InternalType x, InternalType y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return String.Compare(x.Name, y.Name, StringComparison.Ordinal);
            });

            UpdateData();
        }
    }
}
