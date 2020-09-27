using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Barcodes.Libs.DB;

namespace Barcodes.Forms
{
    public partial class ConnectForm : Form
    {
        private readonly Connect _connect;
        private readonly string _path;

        public ConnectForm(string path)
        {
            InitializeComponent();

            _path = path;
            _connect = DataBase.GetConnect(_path);

            if (string.IsNullOrEmpty(_connect.Login))
                _connect.Login = "SYSDBA";

            if (string.IsNullOrEmpty(_connect.Password))
                _connect.Password = "masterkey";

            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        private void SaveConnect()
        {
            DataBase.SaveConnect(_connect, _path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SaveConnect();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGetHost_Click(object sender, EventArgs e)
        {
            string host = Dns.GetHostName();
            // ИП адресса
            List<IPAddress> ipAddresses = Dns.GetHostAddresses(host).Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToList();
            tbHost.Text = ipAddresses.Count > 0 ? ipAddresses[0].ToString() : @"localhost";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = @"PARTPOST.IB|PARTPOST.IB" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    tbPath.Text = openFileDialog.FileName;
                }
            }
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            tbStatus.ForeColor = Color.DimGray;
            tbStatus.Text = "";

            bool status = await _connect.TestConnectAsync();
            if (status)
            {
                tbStatus.ForeColor = Color.SeaGreen;
                tbStatus.Text = "Подключено";
            }
            else
            {
                tbStatus.ForeColor = Color.Firebrick;
                tbStatus.Text = "Не подключено";
            }
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            cbType.Items.Add("Стандартный");
            cbType.Items.Add("Встроенный");
            tbUser.CharacterCasing = CharacterCasing.Upper;

            tbHost.DataBindings.Add("Text", _connect, "Host", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPass.DataBindings.Add("Text", _connect, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
            tbUser.DataBindings.Add("Text", _connect, "Login", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPath.DataBindings.Add("Text", _connect, "Path", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPort.DataBindings.Add("Text", _connect, "Port", false, DataSourceUpdateMode.OnPropertyChanged);
            cbType.DataBindings.Add("SelectedIndex", _connect, "ServerType", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void tbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ConnectForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }
    }
}
