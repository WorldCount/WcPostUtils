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
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models;

namespace PartStat.Forms
{
    public partial class SelectPrinterForm : Form
    {
        private readonly Config _printerConfig;
        private readonly PrinterSettings.StringCollection _printers = PrinterSettings.InstalledPrinters;

        public SelectPrinterForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Выбор принтера";
            _printerConfig = ConfigManager.GetConfigByName(ConfigName.DefaultPrinterName) ?? ConfigManager.CreateDefaultPrinterName();
        }

        private void SelectPrinterForm_Load(object sender, EventArgs e)
        {
            foreach (string installedPrinter in _printers)
            {
                comboBoxPrinter.Items.Add(installedPrinter);
            }

            int ind;

            if (_printerConfig != null)
            {
                ind = comboBoxPrinter.FindString(_printerConfig.Value);
            }
            else
            {
                PrinterSettings settings = new PrinterSettings();
                ind = comboBoxPrinter.FindString(settings.PrinterName);
            }

            if (ind != -1)
            {
                comboBoxPrinter.SelectedIndex = ind;
            }
        }

        private void SelectPrinterForm_KeyDown(object sender, KeyEventArgs e)
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
            DialogResult = DialogResult.OK;
            _printerConfig.Value = _printers[comboBoxPrinter.SelectedIndex];

            ConfigManager.Update(ConfigName.DefaultPrinterName, _printerConfig);
            Close();
        }
    }
}
