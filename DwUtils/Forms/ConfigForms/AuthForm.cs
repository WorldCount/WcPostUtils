using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DwUtils.Core;
using DwUtils.Core.Libs.PostApi;

namespace DwUtils.Forms.ConfigForms
{
    public partial class AuthForm : Form
    {
        private readonly PostApiAuth _auth;
        

        public PostApiAuth Auth => _auth;

        public AuthForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Авторизация";

            _auth = PostApiAuth.Load(PathManager.AuthPath);

            connectWidget.CheckStatus = CheckStatus;
            connectWidget.SuccessStatusColor = Color.FromArgb(255, 140, 193, 82);
            connectWidget.ErrorStatusColor = Color.FromArgb(255, 233, 87, 63);
        }

        private async Task<bool> CheckStatus()
        {
            if (await Auth.TestAuthAsync())
                return true;
            return false;
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            tbLogin.DataBindings.Add("Text", _auth, "Login", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPassword.DataBindings.Add("Text", _auth, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AuthForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _auth.Save(PathManager.AuthPath);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
