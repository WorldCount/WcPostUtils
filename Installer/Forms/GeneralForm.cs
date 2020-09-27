using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Installer.Models;
using IWshRuntimeLibrary;

namespace Installer.Forms
{
    public partial class GeneralForm : Form
    {
        public readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        public readonly string AppDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.RepoDir);
        public readonly Token Token = new Token(Properties.Settings.Default.Token);
        private readonly Color _defaultStatusColor;
        private bool _isAdmin;

        public GeneralForm()
        {
            InitializeComponent();

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            if (!Directory.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            if (!Directory.Exists(AppDir))
                Directory.CreateDirectory(AppDir);

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";
            _defaultStatusColor = statusText.ForeColor;
            // Загрузка данных о ПО с сервера
            bgWorkerGetRepo.DoWork += BgWorkerGetRepo_DoWork;
            bgWorkerGetRepo.RunWorkerCompleted += BgWorkerGetRepo_RunWorkerCompleted;
            bgWorkerGetRepo.RunWorkerAsync();
        }

        private AppInfo GetAppFromTable(DataGridView dataGridView, int rowIndex)
        {
            BindingSource source = (BindingSource) dataGridView.DataSource;
            List<AppInfo> appInfos = (List<AppInfo>)source.DataSource;
            AppInfo appInfo = appInfos[rowIndex];
            return appInfo;
        }

        // Ищет установленные приложения
        private List<AppInfo> FindInstallApp()
        {
            List<AppInfo> appInfos = new List<AppInfo>();

            if (!string.IsNullOrEmpty(AppDir))
            {
                string[] files = Directory.GetFiles(AppDir, "*.exe", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    AppInfo appInfo = new AppInfo();
                    FileInfo fileInfo = new FileInfo(file);
                    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(fileInfo.FullName);
                    string company = fileVersionInfo.CompanyName;
                    if (!string.IsNullOrEmpty(company) && company.ToUpper() == "WORLDCOUNT")
                    {
                        appInfo.AppId = fileInfo.Name.Split('.')[0];
                        appInfo.RunFile = fileInfo.Name;
                        appInfo.Name = fileVersionInfo.ProductName;
                        appInfo.Version = fileVersionInfo.FileVersion;
                        appInfo.Description = fileVersionInfo.Comments;
                        appInfo.DirectoryInstall = fileInfo.DirectoryName;
                        appInfo.Install = true;
                        appInfos.Add(appInfo);
                    }
                }
            }

            return appInfos;
        }

        private void LoadSettings()
        {
            tbInstallDir.Text = AppDir;
            if (_isAdmin == false)
                appMenuItem.Visible = false;
        }

        #region Настройки окна

        // Перенос настроек предыдущей сборки в новую
        private void UpgradeSettings()
        {
            Properties.Settings.Default.Upgrade();
            WinConf.Default.Upgrade();
            Properties.Settings.Default.NeedUpgrade = false;
            Properties.Settings.Default.Save();
        }

        // Сохранение настроек
        private void SavePos()
        {
            WinConf.Default.GeneralFormState = WindowState;

            if (WindowState == FormWindowState.Normal)
            {
                WinConf.Default.GeneralFormLocation = Location;
                WinConf.Default.GeneralFormSize = Size;
            }
            else
            {
                // Если форма свернута или развернута
                WinConf.Default.GeneralFormLocation = RestoreBounds.Location;
                WinConf.Default.GeneralFormSize = RestoreBounds.Size;
            }

            WinConf.Default.Save();
        }

        // Загрузка настроек
        private void LoadPos()
        {
            int width = WinConf.Default.GeneralFormSize.Width;
            int height = WinConf.Default.GeneralFormSize.Height;

            if (width == 0 || height == 0)
            {
                // Первый старт
            }
            else
            {
                WindowState = WinConf.Default.GeneralFormState;

                // Нам не нужно свернутое окно при запуске
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;

                Location = WinConf.Default.GeneralFormLocation;
                Size = WinConf.Default.GeneralFormSize;
            }

            // Восстановление положения окна
            string[] args = Environment.GetCommandLineArgs();
            if (args.Contains("-restore"))
                CenterToScreen();
            if (args.Contains("-a"))
                _isAdmin = true;
        }

        #endregion

        #region Сообщения

        /// <summary>
        /// Отправляет сообщение в статус
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        public void SendStatucMessage(string message, Color color)
        {
            timerStatus.Stop();
            statusText.ForeColor = color;
            statusText.Text = message;
            timerStatus.Start();
        }

        // Сообщение: обычное
        // ReSharper disable once UnusedMember.Global
        public void NormalMessage(string message)
        {
            SendStatucMessage(message, _defaultStatusColor);
        }

        // Сообщение: успех
        // ReSharper disable once UnusedMember.Global
        public void SuccessStatusMessage(string message)
        {
            SendStatucMessage(message, Color.Green);
        }

        // Сообщение: ошибка
        // ReSharper disable once UnusedMember.Global
        public void ErrorStatusMessage(string message)
        {
            SendStatucMessage(message, Color.Red);
        }

        // Сообщение: предупреждение
        // ReSharper disable once UnusedMember.Global
        public void WarningMessage(string message)
        {
            SendStatucMessage(message, Color.DarkOrange);
        }

        // Сообщение: информация
        // ReSharper disable once UnusedMember.Global
        public void InfoMessage(string message)
        {
            SendStatucMessage(message, Color.DodgerBlue);
        }

        #endregion

        #region Обработчики

        // Воркер: Работа
        private void BgWorkerGetRepo_DoWork(object sender, DoWorkEventArgs e)
        {
            List<AppInfo> repoAppInfos = new List<AppInfo>();
            Uri uri = new Uri(Properties.Settings.Default.AppRepoUrl);
            AppPackage appPackage =  AppPackage.Load(uri);
            //AppPackage appPackage = AppPackage.Load(Token, "/AppPackage.xml").Result;
            List<AppInfo> installAppinfos = FindInstallApp();

            if (appPackage != null)
            {
                foreach (AppInfo repoApp in appPackage.Repo)
                {
                    AppInfo installApp = installAppinfos.FirstOrDefault(i => i.AppId == repoApp.AppId);
                    if (installApp != null)
                    {
                        repoApp.Install = true;
                        repoApp.DirectoryInstall = installApp.DirectoryInstall;
                        installApp.Info = repoApp.Info;
                        if (new Version(installApp.Version) < new Version(repoApp.Version))
                        {
                            installApp.NeedUpdate = true;
                            installApp.Distr = repoApp.Distr;
                            installApp.Md5 = repoApp.Md5;   
                        }
                    }

                    repoAppInfos.Add(repoApp);
                }
            }

            e.Result = new AppData {RepoAppInfos = repoAppInfos, InstallAppInfos = installAppinfos};
        }

        // Воркер: Работа завершена
        private void BgWorkerGetRepo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AppData appData = (AppData) e.Result;
            if (appData == null)
            {
                ErrorStatusMessage("Произошла ошибка при получении списка приложений.");
                return;
            }

            appInfoRepoBindingSource.DataSource = appData.RepoAppInfos;
            dataGridViewRepo.DataSource = appInfoRepoBindingSource;

            appInfoInstallBindingSource.DataSource = appData.InstallAppInfos;
            dataGridViewInstall.DataSource = appInfoInstallBindingSource;
            SuccessStatusMessage("Список приложений обновлен.");
        }

        // Форма: Загружена
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadPos();
            WebRequest.DefaultWebProxy = null;
            LoadSettings();
        }

        // Форма: Закрыта
        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePos();
        }

        // Форма: Нажатие клавиш
        private void GeneralForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        // Таймер
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.Text = "";
            statusText.ForeColor = _defaultStatusColor;
        }

        // Таблица доступного ПО: Форматирование ячейки
        private void dataGridViewNotInstall_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataGridViewRepo.Rows[e.RowIndex];
            DataGridViewCell cellInstall = row.Cells[row.Cells.Count - 1];
            string value = cellInstall.Value.ToString().Trim().ToUpper();

            Color foreColor = Color.FromArgb(255, 53, 56, 58);
            Color installColor = Color.FromArgb(255, 224, 238, 224);

            row.DefaultCellStyle.ForeColor = foreColor;
            row.DefaultCellStyle.SelectionForeColor = foreColor;

            if (value == "ДА")
            {
                row.DefaultCellStyle.BackColor = installColor;
                row.DefaultCellStyle.SelectionBackColor = installColor;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.SelectionBackColor = Color.White;
            }
        }

        // Таблица установленного ПО: Форматирование ячейки
        private void dataGridViewInstall_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataGridViewInstall.Rows[e.RowIndex];
            DataGridViewCell cellInstall = row.Cells[row.Cells.Count - 1];
            string value = cellInstall.Value.ToString().Trim().ToUpper();

            Color foreColor = Color.FromArgb(255, 53, 56, 58);
            Color updateColor = Color.FromArgb(255, 238, 232, 170);

            row.DefaultCellStyle.ForeColor = foreColor;
            row.DefaultCellStyle.SelectionForeColor = foreColor;

            if (value == "ДА")
            {
                row.DefaultCellStyle.BackColor = updateColor;
                row.DefaultCellStyle.SelectionBackColor = updateColor;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.SelectionBackColor = Color.White;
            }
        }

        // Контекстное меню доступных приложений
        private void dataGridViewRepo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewRepo.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    dataGridViewRepo.ClearSelection();
                    dataGridViewRepo.Rows[currentMouseOverRow].Selected = true;

                    AppInfo appInfo = GetAppFromTable(dataGridViewRepo, currentMouseOverRow);

                    if (appInfo.AppIcon != null)
                        infoRepoMenuItem.Image = appInfo.AppIcon;
                    infoRepoMenuItem.Text = $"{appInfo.Name} v{appInfo.Version}";
                    infoRepoMenuItem.ToolTipText = appInfo.Description;

                    uninstallRepoMenuItem.Text = $"Удалить {appInfo.Name}";
                    installRepoMenuItem.Text = $"Установить {appInfo.Name}";
                    updateRepoMenuItem.Text = $"Обновить {appInfo.Name}";

                    if (appInfo.Install == false)
                    {
                        installRepoMenuItem.Enabled = !string.IsNullOrEmpty(tbInstallDir.Text);
                        updateRepoMenuItem.Enabled = false;
                        uninstallRepoMenuItem.Enabled = false;
                    }
                    else
                    {
                        installRepoMenuItem.Enabled = false;
                        updateRepoMenuItem.Enabled = true;
                        uninstallRepoMenuItem.Enabled = true;
                    }

                    contextMenuRepo.Show(dataGridViewRepo, new Point(e.X, e.Y));
                }
            }
        }

        // Контекстное меню таблицы установленных приложений
        private void dataGridViewInstall_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewInstall.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    dataGridViewInstall.ClearSelection();
                    dataGridViewInstall.Rows[currentMouseOverRow].Selected = true;
                    AppInfo appInfo = GetAppFromTable(dataGridViewInstall, currentMouseOverRow);

                    if (appInfo.AppIcon != null)
                        infoInstallMenuItem.Image = appInfo.AppIcon;
                    infoInstallMenuItem.Text = $"{appInfo.Name} v{appInfo.Version}";
                    infoInstallMenuItem.ToolTipText = appInfo.Description;

                    runInstallMenuItem.Text = $"Запустить {appInfo.Name}";
                    uninstallInstallMenuItem.Text = $"Удалить {appInfo.Name}";
                    updateInstallMenuItem.Text = $"Обновить {appInfo.Name}";

                    updateInstallMenuItem.Enabled = appInfo.NeedUpdate;

                    contextMenuInstall.Show(dataGridViewInstall, new Point(e.X, e.Y));
                }
            }
        }

        #endregion

        #region Кнопки

        #endregion

        #region Меню

        // Меню: Приложения
        private void appMenuItem_Click(object sender, EventArgs e)
        {
            AppAddForm appAddForm = new AppAddForm();
            appAddForm.ShowDialog(this);
        }

        // Обновить список приложений
        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            bgWorkerGetRepo.RunWorkerAsync();
        }

        // Создать ярлык
        private void createLinkInstallMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewInstall.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewInstall, rowIndex);
            string desktopLink = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), $"{appInfo.Name}.lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut) shell.CreateShortcut(desktopLink);
            shortcut.TargetPath = Path.Combine(appInfo.DirectoryInstall, appInfo.RunFile);
            shortcut.WorkingDirectory = appInfo.DirectoryInstall;
            shortcut.Description = appInfo.Description;
            shortcut.Save();
        }

        // Запустить приложение
        private void runInstallMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewInstall.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewInstall, rowIndex);
            Process.Start(Path.Combine(appInfo.DirectoryInstall, appInfo.RunFile));
        }

        // Удалить приложение
        private void uninstallRepoMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewRepo.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewRepo, rowIndex);
            if (MessageBox.Show($"Вы точно хотите удалить {appInfo.Name} v{appInfo.Version}?",
                    $"Удаление {appInfo.Name}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Directory.Delete(appInfo.DirectoryInstall, true);
                bgWorkerGetRepo.RunWorkerAsync();
            }
        }

        // Удалить приложение
        private void uninstallInstallMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewInstall.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewInstall, rowIndex);
            if (MessageBox.Show($"Вы точно хотите удалить {appInfo.Name} v{appInfo.Version}?",
                    $"Удаление {appInfo.Name}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Directory.Delete(appInfo.DirectoryInstall, true);
                bgWorkerGetRepo.RunWorkerAsync();
            }
        }

        // Открыть папку
        private void openDirInstallMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewInstall.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewInstall, rowIndex);
            Process.Start(appInfo.DirectoryInstall);
        }

        // Установить приложение
        private void installRepoMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewRepo.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewRepo, rowIndex);
            DownloadForm downloadForm = new DownloadForm(appInfo);
            DialogResult result = downloadForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                SuccessStatusMessage($"Установка {appInfo.Name} v{appInfo.Version} завершена.");
                bgWorkerGetRepo.RunWorkerAsync();
            }
            else if (result == DialogResult.Abort)
            {
                ErrorStatusMessage($"Установка {appInfo.Name} v{appInfo.Version} прервана.");
            }
            else
            {
                MessageBox.Show($"Произошла ошибка:\n{downloadForm.Error}", "Что-то пошло не так...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateInstallMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewInstall.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewInstall, rowIndex);
            DownloadForm downloadForm = new DownloadForm(appInfo);
            DialogResult result = downloadForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                SuccessStatusMessage($"Установка {appInfo.Name} v{appInfo.Version} завершена.");
                bgWorkerGetRepo.RunWorkerAsync();
            }
            else if (result == DialogResult.Abort)
            {
                ErrorStatusMessage($"Установка {appInfo.Name} v{appInfo.Version} прервана.");
            }
            else
            {
                MessageBox.Show($"Произошла ошибка:\n{downloadForm.Error}", "Что-то пошло не так...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            if(settingForm.ShowDialog(this) == DialogResult.OK)
                SuccessStatusMessage("Настройки сохранены.");
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updInfoInstallMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewInstall.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewInstall, rowIndex);
            InfoForm infoForm = new InfoForm(appInfo);
            infoForm.ShowDialog(this);
        }

        private void updInfoRepoMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewRepo.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            AppInfo appInfo = GetAppFromTable(dataGridViewRepo, rowIndex);
            InfoForm infoForm = new InfoForm(appInfo);
            infoForm.ShowDialog(this);
        }

        #endregion
    }
}
