using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseGenerator.Forms
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void btnGetHost_Click(object sender, EventArgs e)
        {
            tbHost.Text = GetIp();
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            tbAppName.Text = Application.ProductName;
            tbHost.Text = GetIp();
            tbAuthKey.Text = WcApi.Cryptography.AuthKey.Key;
        }

        private string GetIp()
        {
            string host = Dns.GetHostName();
            // ИП адресса
            List<IPAddress> ipAddresses = Dns.GetHostAddresses(host).Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToList();
            return ipAddresses.Count > 0 ? ipAddresses[0].ToString() : @"localhost";
        }

        private void btnGetId_Click(object sender, EventArgs e)
        {
            tbAppId.Text = WcApi.Cryptography.LicenseKey.GetKey(tbHost.Text.Trim(), tbAuthKey.Text.Trim(), tbAppName.Text.Trim());
        }

        private void btnGenLicense_Click(object sender, EventArgs e)
        {
            string key = tbAppId.Text;
            tbLicenseKey.Text = WcApi.Cryptography.License.GetLicenseKey(dateTimePicker.Value, key);
        }
    }
}
