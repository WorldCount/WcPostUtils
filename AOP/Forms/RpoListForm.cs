using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOP.Models;

namespace AOP.Forms
{
    public partial class RpoListForm : Form
    {
        private readonly RpoList _rpoList;

        public RpoList RpoList => _rpoList;

        public RpoListForm(RpoList rpoList, bool readOnly = false)
        {
            InitializeComponent();
            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"Список {rpoList.Name} от {rpoList.Date.ToShortDateString()}";
            _rpoList = rpoList;
            if (readOnly)
                dataGridView.ReadOnly = true;
        }

        private void RpoListForm_Load(object sender, EventArgs e)
        {
            rpoBindingSource.DataSource = _rpoList.Rpos;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void RpoListForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnAccept.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            FilteredTable();
        }

        private void FilteredTable()
        {
            string com = tbComment.Text.ToUpper();
            string rcpn = tbRcpn.Text.ToUpper();
            string mass = tbMass.Text;

            List<Rpo> newList = _rpoList.Rpos.Where(r => r.Comment.ToUpper().Contains(com))
                .Where(r => r.Rcpn.ToUpper().Contains(rcpn)).ToList();
            rpoBindingSource.DataSource = !string.IsNullOrEmpty(mass) ? newList.Where(r => r.Mass == Convert.ToInt32(mass)).ToList() : newList;
        }

        private void rpoBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            lblCount.Text = rpoBindingSource.Count.ToString();
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= Control_KeyPress;
            if (dataGridView.CurrentCell.ColumnIndex == 4)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                    textBox.KeyPress += Control_KeyPress;
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            FilteredTable();
        }
    }
}
