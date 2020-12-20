using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcPostApi.Tafirs;
using WcPostApi.Types;

namespace TestingApp.Forms
{
    public partial class TarificatorForm : Form
    {
        private static readonly HttpClient Client = new HttpClient();

        public TarificatorForm()
        {
            InitializeComponent();

            InitComboBox();

            WebRequest.DefaultWebProxy = null;
        }

        public static async Task<string> Request(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string data = await response.Content.ReadAsStringAsync();
                    return data;
                }
                catch
                {
                    return null;
                }

            }

            return null;
        }

        public void InitComboBox()
        {
            cbQuery.Items.Add("https://tariff.pochta.ru/tariff/v2/calculate?easy&object=2010&weight=16&from=125993");
            cbQuery.Items.Add("https://tariff.pochta.ru/tariff/v2/calculate?easy&object=16010&from=125993&to=101000&weight=20");
            cbQuery.Items.Add("https://tariff.pochta.ru/tariff/v2/calculate?easy&object=2011&from=125993&country=895&weight=20&isavia=2");
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            string q = cbQuery.Text;
            string raw = await Request(q);

            double pay = ParseRawData(raw);

            richTextBoxResult.Text = pay.ToString("F");

        }

        public double ParseRawData(string raw)
        {
            string[] data = raw.Split(',');

            try
            {
                return double.Parse(data[0].Replace('-', ','));
            }
            catch
            {
                return 0;
            }
        }
    }
}
