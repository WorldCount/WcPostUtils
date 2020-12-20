using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;

namespace LK.Forms.ConfigForms
{
    public partial class PrinterForm : Form
    {
        private readonly Config _printerConfig;
        private readonly PrinterSettings.StringCollection _printers = PrinterSettings.InstalledPrinters;


        public PrinterForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Выбор принтера";

            PrinterSettings settings = new PrinterSettings();

            _printerConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName) ?? ConfigManager.CreateDefaultPrinterName();
        }

        private void PrinterForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void PrinterForm_Load(object sender, EventArgs e)
        {
            foreach (string installedPrinter in _printers)
            {
                comboBoxPrinter.Items.Add(installedPrinter);
            }

            int index;

            if (_printerConfig != null)
            {
                index = comboBoxPrinter.FindString(_printerConfig.Value);

                if (index == -1)
                    index = 0;
            }
            else
            {
                PrinterSettings settings = new PrinterSettings();
                index = comboBoxPrinter.FindString(settings.PrinterName);
            }

            if (index != -1)
            {
                comboBoxPrinter.SelectedIndex = index;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            int index = comboBoxPrinter.SelectedIndex;

            if (index == -1)
                index = 0;

            _printerConfig.Value = _printers[index];

            ConfigManager.Update(ConfigName.DefaultPrinterName, _printerConfig);
            Close();
        }
    }
}
