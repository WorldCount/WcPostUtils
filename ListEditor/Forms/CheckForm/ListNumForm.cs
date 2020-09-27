using System;
using System.Windows.Forms;

namespace ListEditor.Forms.CheckForm
{
    public partial class ListNumForm : Form
    {
        private int _num = 1;
        private bool _add;

        public int Num => _num;
        public bool Add => _add;

        public ListNumForm()
        {
            InitializeComponent();
        }

        private void ListNumForm_Load(object sender, EventArgs e)
        {

        }

        private void ListNumForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            _add = radioAdd.Checked;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _num = (int) numericUpDown.Value;
        }
    }
}
