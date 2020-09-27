using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Windows.Forms;
using SQLite;
using WcApi.Database;
using ListEditor.Models;

namespace ListEditor.Forms
{
    public partial class DownloadForm : Form
    {
        // ReSharper disable once InconsistentNaming
        private readonly WebClient webClient;
        // ReSharper disable once InconsistentNaming
        private readonly BackgroundWorker bgWorker;
        // ReSharper disable once InconsistentNaming
        private readonly string _tempFile;

        public string Error { get; set; }

        public DownloadForm(Uri url, string tempFile)
        {
            InitializeComponent();

            _tempFile = tempFile;

            webClient = new WebClient();
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;

            bgWorker = new BackgroundWorker {WorkerSupportsCancellation = true, WorkerReportsProgress = true};
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            try
            {
                webClient.DownloadFileAsync(url, _tempFile);
            }
            catch(Exception ex)
            {
                Error = ex.Message;
                DialogResult = DialogResult.No;
                Close();
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string[] info = { "Загружаю данные", "Создаю БД", "Читаю данные", "Сохраняю БД" };
            int ind = e.ProgressPercentage;
            lblProgress.Text = info[ind];
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = (DialogResult) e.Result;
            Close();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string zipFile = ((string[])e.Argument)[0];

            try
            {
                string extractPath = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
                using (ZipArchive archive = ZipFile.OpenRead(zipFile))
                {
                    if (archive.Entries.Count > 0)
                    {
                        ZipArchiveEntry entry = archive.Entries[0];

                        string indexFile = Path.Combine(extractPath, entry.Name);

                        if(File.Exists(indexFile))
                            File.Delete(indexFile);

                        entry.ExtractToFile(indexFile);

                        bgWorker.ReportProgress(0);
                        DBF dbf = new DBF(extractPath);
                        DataTable data = dbf.GetAll(entry.Name);

                        string dbpath = Path.Combine(extractPath, Properties.Settings.Default.DB);

                        bgWorker.ReportProgress(1);
                        SQLiteConnection db = new SQLiteConnection(dbpath);
                        db.DropTable<Index>();
                        db.CreateTable<Index>();

                        bgWorker.ReportProgress(2);
                        List<Index> dataIndices = new List<Index>();
                        foreach (DataRow row in data.Rows)
                        {
                            Index index = new Index();
                            index.DBFParse(row[0], row[1], row[2], row[3], row[4]);
                            dataIndices.Add(index);
                        }

                        bgWorker.ReportProgress(3);
                        db.InsertAll(dataIndices);

                        File.Delete(indexFile);
                        e.Result = DialogResult.OK;
                    }
                    else
                        e.Result = DialogResult.No;
                }
                File.Delete(zipFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Download: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Result = DialogResult.Abort;
            }  
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Error = e.Error.Message;
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
                lblTitle.Text = "Обновление справочника...";
                lblProgress.Text = "Читаю и загружаю записи";
                progressBar.Style = ProgressBarStyle.Marquee;
                bgWorker.RunWorkerAsync(new [] { _tempFile });
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblProgress.Text = $"Загружено {FormatBytes(e.BytesReceived, 1, true)} из {FormatBytes(e.TotalBytesToReceive, 1, true)}";
        }

        private string FormatBytes(long bytes, int decimalPlaces, bool showByteType)
        {
            double newBytes = bytes;
            string formatString = "{0";
            // ReSharper disable once RedundantAssignment
            string byteType = "Б";

            if (newBytes > 1024 && newBytes < 1048576)
            {
                newBytes /= 1024;
                byteType = "КБ";
            }
            else if (newBytes > 1048576 && newBytes < 1073741824)
            {
                newBytes /= 1048576;
                byteType = "МБ";
            }
            else
            {
                newBytes /= 1073741824;
                byteType = "ГБ";
            }

            if (decimalPlaces > 0)
                formatString += ":0.";

            for (int i = 0; i < decimalPlaces; i++)
                formatString += "0";

            formatString += "}";

            if (showByteType)
                formatString += byteType;

            return string.Format(formatString, newBytes);
        }

        private void DownloadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webClient.IsBusy)
            {
                webClient.CancelAsync();
                DialogResult = DialogResult.Abort;
            }

            if (bgWorker.IsBusy)
            {
                bgWorker.CancelAsync();
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
