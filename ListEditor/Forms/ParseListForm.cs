using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ListEditor.Models.Part;
using ListEditor.Models.Part.Types;

namespace ListEditor.Forms
{
    public partial class ParseListForm : Form
    {
        private readonly string[] _list;
        private readonly List<PartFile> _partFiles = new List<PartFile>();
        private int _stringCount;

        private readonly List<MailType> _mailTypes;
        private readonly List<MailCategory> _mailCategories;
        private readonly List<PayType> _payTypes;
        private readonly List<SenderCategory> _senderCategories;

        public List<PartFile> PartFiles => _partFiles;
        public int StringCount => _stringCount;

        public List<MailType> MailTypes => _mailTypes;
        public List<MailCategory> MailCategories => _mailCategories;
        public List<PayType> PayTypes => _payTypes;
        public List<SenderCategory> SenderCategories => _senderCategories;

        public ParseListForm(string[] list, List<MailType> mailTypes, List<MailCategory> mailCategories, List<PayType> payTypes, List<SenderCategory> senderCategories)
        {
            InitializeComponent();

            _list = list;
            _mailTypes = mailTypes;
            _mailCategories = mailCategories;
            _payTypes = payTypes;
            _senderCategories = senderCategories;
        }

        private void ParseListForm_Load(object sender, EventArgs e)
        {
            progressBar.Maximum = _list.Length;
            progressBar.Value = 0;
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 1;
            foreach (string s in _list)
            {
                backgroundWorker.ReportProgress(i);
                Thread.Sleep(10);
                string ext = Path.GetExtension(s);
                if (ext == ".ini" || ext == ".zip")
                {
                    try
                    {
                        PartFile p = new PartFile(s);
                        p.Parse();

                        _partFiles.Add(p);
                        _stringCount += p.Count;

                        if (_mailTypes.All(t => t.Id != p.MailType))
                            _mailTypes.Add(new MailType(p.MailType, p.MailType));

                        if (_mailCategories.All(c => c.Id != p.MailCtg))
                            _mailCategories.Add(new MailCategory(p.MailCtg, p.MailCtg));

                        if (_payTypes.All(pt => pt.Id != p.PayType))
                            _payTypes.Add(new PayType(p.PayType, p.PayType));

                        if (_senderCategories.All(sc => sc.Id != p.SendCtg))
                            _senderCategories.Add(new SenderCategory(p.SendCtg, p.SendCtg));
                    }
                    catch (Exception eException)
                    {
                        MessageBox.Show(eException.ToString(), "ParseFiles -> ParseFileName: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                i++;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblProgress.Text = $"Файл {e.ProgressPercentage} из {_list.Length}";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}
