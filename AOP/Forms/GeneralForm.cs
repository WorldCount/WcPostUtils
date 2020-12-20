using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOP.Core;
using AOP.Core.Models.DB;
using NLog;
using NPOI.SS.UserModel;
using WcApi.Cryptography;
using WcPostApi.Types;
using WcApi.Win32.Forms;

namespace AOP.Forms
{
    public partial class GeneralForm : Form
    {

        private bool _isAdmin;
        private readonly string _key;
        private readonly Database _database = new Database();

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private List<MailCategory> _mailCategories;
        private List<MailType> _mailTypes;

        private bool _checkAllFlag = true;

        public GeneralForm()
        {
            InitializeComponent();

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";

            _key = LicenseKey.GetKey(WcApi.Net.Host.GetIp(), AuthKey.Key, Application.ProductName);

            // Пробная лицензия на 30 дней
            GetTrialLicense();

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridViewList);

            InitTable();
        }

        #region Лицензия

        private async void CheckLicense()
        {
            string license = Properties.Settings.Default.License;
            labelLicense.Text = License.GetLicenseExpiresString(license, _key);

            if (_isAdmin)
                return;

            if (!License.CheckLicense(license, _key))
            {
                await Utils.Telegram.SendMessage("Лицензия истекла.");

                LicenseForm licenseForm = new LicenseForm(license, _key, Application.ProductName, Application.ProductVersion, Properties.Settings.Default.MailLicense, Icon);
                if (licenseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.License = licenseForm.LicenseKey;
                    labelLicense.Text = License.GetLicenseExpiresString(licenseForm.LicenseKey, _key);
                    Properties.Settings.Default.Save();
                }
                else
                    Close();
            }
        }

        private void GetTrialLicense()
        {
            if (Properties.Settings.Default.FirstRun)
            {
                DateTime licenseExp = DateTime.Today.AddDays(30);
                string licenseKey = License.GetLicenseKey(licenseExp, _key);
                Properties.Settings.Default.License = licenseKey;
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        #region Настройка формы

        private void LoadSettings()
        {
            LoadMailCategory();
            LoadMailType();

            textBoxSavePath.Text = Properties.Settings.Default.LastSaveDir;
        }

        // Перенос настроек предыдущей сборки в новую
        private void UpgradeSettings()
        {
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.NeedUpgrade = false;
            Properties.Settings.Default.Save();
        }

        // Сохранение настроек
        private void SavePos()
        {
            Properties.Settings.Default.GeneralFormState = WindowState;

            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.GeneralFormLocation = Location;
                Properties.Settings.Default.GeneralFormSize = Size;
            }
            else
            {
                // Если форма свернута или развернута
                Properties.Settings.Default.GeneralFormLocation = RestoreBounds.Location;
                Properties.Settings.Default.GeneralFormSize = RestoreBounds.Size;
            }

            Properties.Settings.Default.Save();
        }

        // Загрузка настроек
        private void LoadPos()
        {
            int width = Properties.Settings.Default.GeneralFormSize.Width;
            int height = Properties.Settings.Default.GeneralFormSize.Height;

            if (width == 0 || height == 0)
            {
                // Первый старт
            }
            else
            {
                WindowState = Properties.Settings.Default.GeneralFormState;

                // Нам не нужно свернутое окно при запуске
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;

                Location = Properties.Settings.Default.GeneralFormLocation;
                Size = Properties.Settings.Default.GeneralFormSize;
            }

            // Параметры запуска приложения
            CheckArgs();
        }

        private void CheckArgs()
        {

            string[] args = Environment.GetCommandLineArgs();

            // Восстановление положения окна
            if (args.Contains("-restore"))
                CenterToScreen();

            if (args.Contains("-admin"))
                _isAdmin = true;

            if (args.Contains("-license"))
            {
                if (args.Length > 2)
                {
                    DateTime licenseDate;

                    try
                    {
                        licenseDate = DateTime.Parse(args[2]);
                    }
                    catch
                    {
                        licenseDate = DateTime.Today.AddYears(1);
                    }

                    string license = License.GetLicenseKey(licenseDate, _key);
                    Properties.Settings.Default.License = license;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.License = "";
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            Logger.Info("Запуск приложения");
            LoadPos();
            LoadSettings();
            // Проверка лицензии
            CheckLicense();

            InitDb();
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePos();
        }

        private void InitTable()
        {
            checkDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkDataGridViewCheckBoxColumn.Width = 40;
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
            statusText.ForeColor = color;
            statusText.Text = message;
            timerStatus.Start();
        }

        // Сообщение: обычное
        // ReSharper disable once UnusedMember.Global
        public void NormalMessage(string message)
        {
            SendStatucMessage(message, Color.DimGray);
        }

        // Сообщение: успех
        public void SuccessMessage(string message)
        {
            SendStatucMessage(message, Color.Green);
        }

        // Сообщение: ошибка
        public void ErrorMessage(string message)
        {
            SendStatucMessage(message, Color.Firebrick);
        }

        // Сообщение: предупреждение
        public void WarningMessage(string message)
        {
            SendStatucMessage(message, Color.DarkOrange);
        }

        // Сообщение: информация
        public void InfoMessage(string message)
        {
            SendStatucMessage(message, Color.DodgerBlue);
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.Text = "";
        }

        #endregion

        #region Данные

        private async void InitDb()
        {
            await _database.CreateDbAsync();
        }

        private async void LoadMailCategory()
        {
            mailCategoryBindingSource.DataSource = null;
            _mailCategories = await DataManager.MailCategoryManager.GetEnabledAsync();
            mailCategoryBindingSource.DataSource = _mailCategories;
        }

        private async void LoadMailType()
        {
            mailTypeBindingSource.DataSource = null;
            _mailTypes = await DataManager.MailTypeManager.GetEnabledAsync();
            mailTypeBindingSource.DataSource = _mailTypes;
        }

        #endregion


        #region Методы

        private RpoList GetRpoListByIndex(int rowIndex)
        {
            try
            {
                List<RpoList> rpoLists = (List<RpoList>)rpoListBindingSource.DataSource;
                if (rpoLists != null && rpoLists.Count > 0)
                    return rpoLists[rowIndex];
                return null;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return null;
            }

        }

        private void UncheckAll()
        {
            List<RpoList> rpoLists = (List<RpoList>) rpoListBindingSource.DataSource;
            if (rpoLists != null)
            {
                foreach (RpoList rpoList in rpoLists)
                {
                    rpoList.Check = false;
                    _checkAllFlag = false;
                }

                dataGridViewList.Update();
                dataGridViewList.Refresh();
            }
        }

        private void CheckAll()
        {
            List<RpoList> rpoLists = (List<RpoList>)rpoListBindingSource.DataSource;
            if (rpoLists != null)
            {
                foreach (RpoList rpoList in rpoLists)
                {
                    rpoList.Check = true;
                    _checkAllFlag = true;
                }

                dataGridViewList.Update();
                dataGridViewList.Refresh();
            }
        }

        private string ChooseSaveDir()
        {
            string dir = Properties.Settings.Default.LastSaveDir;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (!string.IsNullOrEmpty(dir))
                folderBrowserDialog.SelectedPath = dir;

            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                Properties.Settings.Default.LastSaveDir = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
                textBoxSavePath.Text = folderBrowserDialog.SelectedPath;
                return folderBrowserDialog.SelectedPath;
            }

            return null;
        }

        private void ExportExcel(RpoList rpoList, string dir)
        {
            if (rpoList != null)
            {
                string path = Path.Combine(dir, rpoList.GetFileNameExcel());

                try
                {
                    if (File.Exists(path))
                        File.Delete(path);
                }
                catch (Exception e)
                {
                    Logger.Error(e.Message);
                    ErrorMessage(e.Message);
                    return;
                }

                try
                {
                    File.Copy(PathManager.ExcelTemplate, path, true);
                }
                catch (Exception exception)
                {
                    Logger.Error(exception.Message);
                    return;
                }

                try
                {
                    List<Rpo> rpos = _database.GetRposByRpoList(rpoList);
                    bool res = ExcelWriter.Write(path, rpos);
                    if (res)
                    {
                        SuccessMessage($"Файл {rpoList.GetFileNameExcel()} - экспортирован!");
                    }
                    else
                    {
                        ErrorMessage($"Ошибка экспорта файла {rpoList.GetFileName()} !");
                    }
                }
                catch (Exception exception)
                {
                    Logger.Error(exception.Message);
                    return;
                }
            }
        }

        private void ExportWord(RpoList rpoList, string dir, string template, string format = "C5")
        {
            if (rpoList != null)
            {
                string path = Path.Combine(dir, rpoList.GetFileNameWord(format));

                try
                {
                    if (File.Exists(path))
                        File.Delete(path);
                }
                catch (Exception e)
                {
                    Logger.Error(e.Message);
                    ErrorMessage(e.Message);
                    return;
                }
                

                try
                {
                    List<Rpo> rpos = _database.GetRposByRpoList(rpoList);
                    bool res = WordWriter.Write(path, rpos, template, rpoList.CategoryName.ToUpper());
                    if (res)
                    {
                        SuccessMessage($"Файл {rpoList.GetFileName()} - экспортирован!");
                    }
                    else
                    {
                        ErrorMessage($"Ошибка экспорта файла {rpoList.GetFileNameWord(format)} !");
                    }
                }
                catch (Exception exception)
                {
                    Logger.Error(exception.Message);
                    return;
                }
            }
        }

        #endregion


        #region Обработчики


        #region Остальное

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerIn.Value;
            dateTimePickerOut.Value = date;
        }

        private void tbNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Кнопки

        private void btnLoad_Click(object sender, EventArgs e)
        {
            rpoListBindingSource.DataSource = null;

            string sNum = textBoxListIn.Text;
            string eNum = textBoxListOut.Text;

            int startNum = 0;
            int endNum = 0;

            if (!string.IsNullOrEmpty(sNum))
                startNum = int.Parse(sNum);

            if (!string.IsNullOrEmpty(eNum))
                endNum = int.Parse(eNum);

            DateTime startDate = dateTimePickerIn.Value;
            startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day);

            DateTime endDate = dateTimePickerOut.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);

            List<RpoList> rpoLists = _database.GetRpoLists(startDate, endDate, startNum, endNum);

            rpoListBindingSource.DataSource = rpoLists;
        }

        private void btnSaveDir_Click(object sender, EventArgs e)
        {
            ChooseSaveDir();
        }

        #endregion

        #region Меню

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel|*.xls*",
                Multiselect = true
            };

            if (!string.IsNullOrEmpty(PathManager.LastOpenDir))
                openFileDialog.InitialDirectory = PathManager.LastOpenDir;

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Properties.Settings.Default.LastOpenDir = openFileDialog.InitialDirectory;
                Properties.Settings.Default.Save();

                // Форма по файлам
                ImportForm importForm = new ImportForm(openFileDialog.FileNames, _database);
                if (importForm.ShowDialog(this) == DialogResult.OK)
                {

                }

            }
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailTypeForm mailTypeForm = new MailTypeForm();
            if (mailTypeForm.ShowDialog(this) == DialogResult.OK)
            {
                LoadMailType();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Таблица

        private void dataGridViewList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                bool value = (bool)e.FormattedValue;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                Bitmap img = value ? Properties.Resources.checked_32 : Properties.Resources.unchecked_32;
                Size size = img.Size;
                Point loc = new Point((e.CellBounds.Width - size.Width) / 2, (e.CellBounds.Height - size.Height) / 2);
                loc.Offset(e.CellBounds.Location);
                e.Graphics.DrawImage(img, loc);
                e.Handled = true;
            }
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                RpoList rpoList = GetRpoListByIndex(e.RowIndex);

                if (rpoList != null)
                    rpoList.Check = !rpoList.Check;
            }
        }

        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                RpoList rpoList = GetRpoListByIndex(e.RowIndex);

                if (rpoList != null)
                    rpoList.Check = !rpoList.Check;
            }
        }

        private void dataGridViewList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                dataGridViewList.EndEdit();
            }
        }

        private void dataGridViewList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index)
            {
                if (_checkAllFlag)
                    UncheckAll();
                else
                    CheckAll();
                dataGridViewList.EndEdit();
            }
        }

        private void dataGridViewList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridViewList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewList.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    dataGridViewList.ClearSelection();
                    dataGridViewList.Rows[currentMouseOverRow].Selected = true;

                    RpoList rpoList = GetRpoListByIndex(currentMouseOverRow);

                    excelExportMenuItem.Tag = rpoList;
                    a4exportMenuItem.Tag = rpoList;
                    c5exportMenuItem.Tag = rpoList;

                    contextMenuTable.Show(dataGridViewList, new Point(e.X, e.Y));
                }
            }
        }


        #endregion

        #endregion

        private void a4exportMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Properties.Settings.Default.LastSaveDir;

            if (string.IsNullOrEmpty(dir))
            {
                dir = ChooseSaveDir();

                if (string.IsNullOrEmpty(dir))
                    return;
            }

            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            RpoList rpoList = (RpoList)item.Tag;

            ExportWord(rpoList, dir, PathManager.A4Template, "A4");
        }

        private void c5exportMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Properties.Settings.Default.LastSaveDir;

            if (string.IsNullOrEmpty(dir))
            {
                dir = ChooseSaveDir();

                if (string.IsNullOrEmpty(dir))
                    return;
            }

            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            RpoList rpoList = (RpoList)item.Tag;

            ExportWord(rpoList, dir, PathManager.C5Template);
        }

        private void excelExportMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Properties.Settings.Default.LastSaveDir;

            if (string.IsNullOrEmpty(dir))
            {
                dir = ChooseSaveDir();

                if (string.IsNullOrEmpty(dir))
                    return;
            }

            ToolStripMenuItem item = (ToolStripMenuItem) sender;
            RpoList rpoList = (RpoList) item.Tag;

            ExportExcel(rpoList, dir);
        }

        private void exportAllMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Properties.Settings.Default.LastSaveDir;

            if (string.IsNullOrEmpty(dir))
            {
                dir = ChooseSaveDir();

                if (string.IsNullOrEmpty(dir))
                    return;
            }

            List<RpoList> rpoLists = (List<RpoList>) rpoListBindingSource.DataSource;
            if (rpoLists != null && rpoLists.Count > 0)
            {
                foreach (RpoList rpoList in rpoLists)
                {
                    if (rpoList.Category == 0)
                    {
                        ExportWord(rpoList, dir, PathManager.C5Template);
                        ExportWord(rpoList, dir, PathManager.A4Template, "A4");
                    }
                    else
                    {
                        ExportExcel(rpoList, dir);
                    }
                }
            }

        }
    }
}
