using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcPostApi.Barcodes;

namespace TestingApp.Forms
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();

            tbBarcode.Text = "6922*74501646*";
        }

        private void btnTarificator_Click(object sender, EventArgs e)
        {
            TarificatorForm tarificatorForm = new TarificatorForm();
            tarificatorForm.ShowDialog(this);
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            string b = tbBarcode.Text.Trim();

            richTextBox.Clear();

            // MessageBox.Show(b.Count(c => c == '*').ToString());
            List<string> barcodes = BarcodeGenerator.GenValidBarcode(b);

            //richTextBox.AppendText($"{b.GetType() == typeof(string)}");

            richTextBox.AppendText($"Количество: {barcodes.Count}\n");
            foreach (string barcode in barcodes)
            {
                richTextBox.AppendText($"{barcode}\n");
            }
        }

        private void btnSerializer_Click(object sender, EventArgs e)
        {
            SerializerForm serializerForm = new SerializerForm();
            serializerForm.ShowDialog(this);
        }
    }
}
