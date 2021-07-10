using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using DwUtils.Core.Libs.Database.Firebird;
using DwUtils.Core.Libs.Database.Firebird.Connect;

namespace DwUtils.Forms.ConfigForms
{
    public partial class ConnectsForm : Form
    {
        private readonly PostUnitConnect _postUnitConnect;
        private readonly PostItemConnect _postItemConnect;

        public ConnectsForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Подключение к БД";

            _postUnitConnect = FbDataBase.PostUnit.GetConnect();
            _postItemConnect = FbDataBase.PostItem.GetConnect();

            connectPostItem.CheckStatus = CheckPostItemConnectAsync;
            connectPostUnit.CheckStatus = CheckPostUnitConnectAsync;

            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        private string GetHost()
        {
            string host = Dns.GetHostName();
            // ИП адресса
            List<IPAddress> ipAddresses = Dns.GetHostAddresses(host).Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToList();
            return ipAddresses.Count > 0 ? ipAddresses[0].ToString() : @"localhost";
        }

        private void SaveConnects()
        {
            FbDataBase.PostItem.SaveConnect(_postItemConnect);
            FbDataBase.PostUnit.SaveConnect(_postUnitConnect);
        }

        private async Task<bool> CheckPostItemConnectAsync()
        {
            if (await _postItemConnect.TestConnectAsync())
                return true;
            return false;
        }

        private async Task<bool> CheckPostUnitConnectAsync()
        {
            if (await _postUnitConnect.TestConnectAsync())
                return true;
            return false;
        }

        private void ConnectsForm_Load(object sender, EventArgs e)
        {
            cbServerTypePostItem.Items.Add("Стандартный");
            cbServerTypePostItem.Items.Add("Встроенный");

            cbServerTypePostUnit.Items.Add("Стандартный");
            cbServerTypePostUnit.Items.Add("Встроенный");

            cbCryptPostItem.Items.Add("Отключено");
            cbCryptPostItem.Items.Add("Включено");
            cbCryptPostItem.Items.Add("Рекомендуется");

            cbCryptPostUnit.Items.Add("Отключено");
            cbCryptPostUnit.Items.Add("Включено");
            cbCryptPostUnit.Items.Add("Рекомендуется");

            #region Биндинги

            // PostItem
            tbHostPostItem.DataBindings.Add("Text", _postItemConnect, "Host", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPasswordPostItem.DataBindings.Add("Text", _postItemConnect, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
            tbLoginPostItem.DataBindings.Add("Text", _postItemConnect, "Login", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPathPostItem.DataBindings.Add("Text", _postItemConnect, "Path", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPortPostItem.DataBindings.Add("Text", _postItemConnect, "Port", false, DataSourceUpdateMode.OnPropertyChanged);
            tbTimeoutPostItem.DataBindings.Add("Text", _postItemConnect, "ConnectionTimeout", false, DataSourceUpdateMode.OnPropertyChanged);
            cbServerTypePostItem.DataBindings.Add("SelectedIndex", _postItemConnect, "ServerType", false, DataSourceUpdateMode.OnPropertyChanged);
            cbCryptPostItem.DataBindings.Add("SelectedIndex", _postItemConnect, "WireCrypt", false, DataSourceUpdateMode.OnPropertyChanged);

            // PostUnit
            tbHostPostUnit.DataBindings.Add("Text", _postUnitConnect, "Host", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPasswordPostUnit.DataBindings.Add("Text", _postUnitConnect, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
            tbLoginPostUnit.DataBindings.Add("Text", _postUnitConnect, "Login", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPathPostUnit.DataBindings.Add("Text", _postUnitConnect, "Path", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPortPostUnit.DataBindings.Add("Text", _postUnitConnect, "Port", false, DataSourceUpdateMode.OnPropertyChanged);
            tbTimeoutPostUnit.DataBindings.Add("Text", _postUnitConnect, "ConnectionTimeout", false, DataSourceUpdateMode.OnPropertyChanged);
            cbServerTypePostUnit.DataBindings.Add("SelectedIndex", _postUnitConnect, "ServerType", false, DataSourceUpdateMode.OnPropertyChanged);
            cbCryptPostUnit.DataBindings.Add("SelectedIndex", _postUnitConnect, "WireCrypt", false, DataSourceUpdateMode.OnPropertyChanged);

            #endregion
        }

        private void ConnectsForm_KeyDown(object sender, KeyEventArgs e)
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
            SaveConnects();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAutoPostItem_Click(object sender, EventArgs e)
        {
            tbHostPostItem.Text = GetHost();
        }

        private void btnAutoPostUnit_Click(object sender, EventArgs e)
        {
            tbHostPostUnit.Text = GetHost();
        }

        private void btnChoosePostUnit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = @"POSTUNIT.IB|POSTUNIT.IB" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    tbPathPostUnit.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnChoosePostItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = @"POSTITEM.IB|POSTITEM.IB" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    tbPathPostItem.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
