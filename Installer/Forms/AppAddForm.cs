using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Installer.Models;

namespace Installer.Forms
{
    public partial class AppAddForm : Form
    {
        private AppPackage _appPackage;
        private bool _update = false;

        public AppAddForm()
        {
            InitializeComponent();
            tbDistrUrl.Text = Properties.Settings.Default.AppRepoUrl;
        }

        private void Clear()
        {
            tbName.Clear();
            tbAppId.Clear();
            tbDesc.Clear();
            tbRunFile.Clear();
            tbUri.Clear();
            tbVersion.Clear();
            tbMd5.Clear();
            tbInfo.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "AppPackage.xml", AddExtension = true, DefaultExt = ".xml"
            };

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string path = Path.GetFullPath(saveFileDialog.FileName);
                AppPackage appPackage = new AppPackage {Repo = (List<AppInfo>) appInfoBindingSource.DataSource};
                appPackage.Save(path);
            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            appInfoBindingSource.DataSource = null;
            dataGridView.DataSource = null;

            string uri = tbDistrUrl.Text;
            if (!string.IsNullOrEmpty(uri))
            {
                AppPackage appPackage = await AppPackage.LoadAsync(new Uri(uri));

                if(appPackage != null)
                    _appPackage = appPackage;
            }

            appInfoBindingSource.DataSource = _appPackage.Repo;
            dataGridView.DataSource = appInfoBindingSource;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {Multiselect = false, Filter = "exe (*.exe)|*.exe", InitialDirectory = Properties.Settings.Default.LastSaveDir};

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(fileInfo.FullName);
                string name = fileInfo.Name.Split('.')[0];

                AppInfo appInfo = new AppInfo
                {
                    AppId = name,
                    RunFile = fileInfo.Name,
                    Name = fileVersion.ProductName,
                    Description = fileVersion.Comments,
                    Version = fileVersion.FileVersion
                };

                SetData(appInfo, _update);

                Properties.Settings.Default.LastSaveDir = openFileDialog.InitialDirectory;
                Properties.Settings.Default.Save();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            appInfoBindingSource.DataSource = null;
            dataGridView.DataSource = null;

            
            string appId = tbAppId.Text.Trim();
            string name = tbName.Text.Trim();
            string runFile = tbRunFile.Text.Trim();
            string desc = tbDesc.Text.Trim();
            string uri = tbUri.Text.Trim();
            string version = tbVersion.Text.Trim();
            string md5 = tbMd5.Text.Trim();

            string[] info = tbInfo.Text.Split('\n');

            AppInfo appInfo = _appPackage.GetAppById(appId);
            if (appInfo != null)
            {
                appInfo.AppId = appId;
                appInfo.Name = name;
                appInfo.RunFile = runFile;
                appInfo.Description = desc;
                appInfo.Distr = uri;
                appInfo.Version = version;
                appInfo.Md5 = md5;
                appInfo.Info = new List<string>();

                foreach (string s in info)
                {
                    appInfo.Info.Add(s.TrimEnd());
                }
            }
            
            appInfoBindingSource.DataSource = _appPackage.Repo;
            dataGridView.DataSource = appInfoBindingSource;

            if (_update)
            {
                _update = false;
                btnAdd.Text = "Добавить";
            }
            Clear();
        }

        private void AppAddForm_Load(object sender, EventArgs e)
        {
            _appPackage = new AppPackage();
            appInfoBindingSource.DataSource = _appPackage.Repo;
            dataGridView.DataSource = appInfoBindingSource;
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string appId = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                AppInfo appInfo = _appPackage.GetAppById(appId);
                if (appInfo != null)
                {
                    _update = true;
                    btnAdd.Text = "Обновить";
                    SetData(appInfo);
                }
            }
        }

        private void SetData(AppInfo appInfo, bool upd=false)
        {
            if(!upd)
                Clear();
            tbAppId.Text = appInfo.AppId;
            tbRunFile.Text = appInfo.RunFile;
            tbName.Text = appInfo.Name;
            tbVersion.Text = appInfo.Version;
            tbDesc.Text = appInfo.Description;
            tbUri.Text = appInfo.Distr;
            tbMd5.Text = appInfo.Md5;

            foreach (string s in appInfo.Info)
            {
                tbInfo.AppendText($"{s}\n");
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    changeMenuItem.Enabled = true;
                    deleteMenuItem.Enabled = true;
                    loadMenuItem.Enabled = false;  
                }
                else
                {
                    changeMenuItem.Enabled = false;
                    deleteMenuItem.Enabled = false;
                    loadMenuItem.Enabled = true;
                }

                contextMenu.Show(dataGridView, new Point(e.X, e.Y));
            }
        }
    }
}
