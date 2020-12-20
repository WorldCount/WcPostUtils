using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Newtonsoft.Json;

namespace TestUpdater
{
    public partial class GeneralForm : Form
    {
        private readonly string _updaterConfig = Path.Combine(Environment.CurrentDirectory, "settings.json");

        public GeneralForm()
        {
            InitializeComponent();

            WebRequest.DefaultWebProxy = null;

            lvlVersion.Text = Application.ProductVersion;
            AutoUpdater.PersistenceProvider = new JsonFilePersistenceProvider(_updaterConfig);
            AutoUpdater.Proxy = null;
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdater_ParseUpdateInfoEvent;
        }

        private void AutoUpdater_ParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json.version,
                ChangelogURL = json.changelog,
                DownloadURL = json.url,
                Mandatory = new Mandatory
                {
                    Value = json.mandatory.value
                },
                CheckSum = new CheckSum
                {
                    Value = json.checksum.value,
                    HashingAlgorithm = json.checksum.hashingAlgorithm
                }
            };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.ReportErrors = true;
            //AutoUpdater.Start("https://worldcount.ru/updates/repo/TestUpdater/update.xml");
            //AutoUpdater.Start("https://worldcount.ru/updates/repo/TestUpdater/update.json");
            AutoUpdater.Start("http://127.0.0.1:3000/programs/5fc5664659d2063658f7f98d");
        }
    }
}
