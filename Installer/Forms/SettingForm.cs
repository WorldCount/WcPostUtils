using System;
using System.Windows.Forms;

namespace Installer.Forms
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            tbRepoUrl.Text = Properties.Settings.Default.AppRepoUrl;
            tbPassword.Text = Properties.Settings.Default.Password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AppRepoUrl = tbRepoUrl.Text.Trim();
            Properties.Settings.Default.Password = tbPassword.Text.Trim();
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SettingForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnAccept.PerformClick();
            }
        }
    }
}
