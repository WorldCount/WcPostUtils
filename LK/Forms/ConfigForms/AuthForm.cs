using System;
using System.Windows.Forms;
using LK.Core;
using WcApi.Cryptography;

namespace LK.Forms.ConfigForms
{
    public partial class AuthForm : Form
    {
        private readonly Auth _auth;

        public Auth Auth => _auth;

        public AuthForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Авторизация";

            _auth = Auth.Load(PathManager.AuthPath);
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
