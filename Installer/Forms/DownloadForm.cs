using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Installer.Models;
using WcApi.Text;
using WcApi.Cryptography;

namespace Installer.Forms
{
    public partial class DownloadForm : Form
    {
        private readonly WebClient _webClient;
        private readonly string _tempFile;
        private readonly string _tempDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.TempDir);
        private readonly string _appsDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.RepoDir);
        private readonly AppInfo _appInfo;
        private string _error;

        public string Error => _error;

        public DownloadForm(AppInfo appInfo)
        {
            InitializeComponent();

            _appInfo = appInfo;
            Uri uri = new Uri(_appInfo.Distr);

            if (!Directory.Exists(_tempDir))
                Directory.CreateDirectory(_tempDir);

            _tempFile = Path.Combine(_tempDir, _appInfo.DistrName);

            _webClient = new WebClient();
            _webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            _webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;

            try
            {
                _webClient.DownloadFileAsync(uri, _tempFile);
            }
            catch (Exception e)
            {
                _error = e.Message;
                DialogResult = DialogResult.No;
                Close();
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblProgress.Text = $"Загружено {Formating.FormatBytes(e.BytesReceived, 1, true)} из {Formating.FormatBytes(e.TotalBytesToReceive, 1, true)}";
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                _error = e.Error.Message;
                DialogResult = DialogResult.No;
                Close();
            }
            else if (e.Cancelled)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
            else
            {
                lblProgress.Text = "Установка приложения...";
                progressBar.Style = ProgressBarStyle.Marquee;

                backgroundWorker.RunWorkerAsync(new InstallAppData {AppInfo = _appInfo, TempFile = _tempFile});
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallAppData installApp = (InstallAppData) e.Argument;

            if (Hasher.HashFile(installApp.TempFile, HashType.MD5) != installApp.AppInfo.Md5.ToUpper())
            {
                _error = "Неверная MD5 сумма файла";
                e.Result = DialogResult.No;
            }
            else
            {
                string unzipPath = Path.Combine(_appsDir, installApp.AppInfo.AppId); 
                e.Result = ExtractFile(installApp.TempFile, unzipPath, Properties.Settings.Default.Password);

                if(File.Exists(_tempFile))
                    File.Delete(_tempFile);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = (DialogResult) e.Result;
            Close();
        }

        private void DownloadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_webClient.IsBusy)
            {
                _webClient.CancelAsync();
                DialogResult = DialogResult.Abort;
            }

            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
                DialogResult = DialogResult.Abort;
            }
        }

        private DialogResult ExtractFile(string source, string destination, string password = "")
        {
            string zPath = Path.Combine(Application.StartupPath, "7z", "7za.exe");
            try
            {
                ProcessStartInfo processStart = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = zPath,
                    Arguments = string.IsNullOrEmpty(password)
                        ? $"x \"{source}\" -o\"{destination}\" -y -aoa"
                        : $"x \"{source}\" -o\"{destination}\" -y -p{password} -aoa",
                };

                //ErrorMessageBox.Show($"\"{processStart.FileName}\" {processStart.Arguments}", "Test");
                Process process = Process.Start(processStart);
                process?.WaitForExit();
                return DialogResult.OK;
            }
            catch (Exception e)
            {
                _error = e.Message;
                return DialogResult.No;
            }
        }
    }
}
