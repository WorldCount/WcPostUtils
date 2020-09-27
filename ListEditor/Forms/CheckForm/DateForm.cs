using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListEditor.Forms.CheckForm
{
    public partial class DateForm : Form
    {
        private DateTime _date;

        public DateTime Date => _date;

        public DateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _date = dateTimePicker.Value;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void DateForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
        }
    }
}
