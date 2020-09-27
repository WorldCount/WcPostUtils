using System;
using System.Globalization;
using System.Windows.Forms;

namespace ListEditor.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            numericNDS.Text = (Properties.Settings.Default.NDS * 100).ToString(CultureInfo.InvariantCulture);
            numericOps.Text = Properties.Settings.Default.IndexOps;
            tbIndexFile.Text = Properties.Settings.Default.IndexUrl;
            checkBoxCheckIndex.Checked = Properties.Settings.Default.CheckIndex;
            checkBoxRecount.Checked = Properties.Settings.Default.RecountValue;
            checkBoxCheckPostMark.Checked = Properties.Settings.Default.CheckPostMark;
            checkBoxAllIndex.Checked = Properties.Settings.Default.CheckAllIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double nds = Convert.ToDouble(numericNDS.Text) / 100;
            Properties.Settings.Default.NDS = nds;
            Properties.Settings.Default.IndexOps = numericOps.Text;
            Properties.Settings.Default.IndexUrl = tbIndexFile.Text;
            Properties.Settings.Default.CheckIndex = checkBoxCheckIndex.Checked;
            Properties.Settings.Default.RecountValue = checkBoxRecount.Checked;
            Properties.Settings.Default.CheckPostMark = checkBoxCheckPostMark.Checked;
            Properties.Settings.Default.CheckAllIndex = checkBoxAllIndex.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
        }
    }
}
