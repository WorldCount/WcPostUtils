using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ListEditor.Forms.CheckForm;
using ListEditor.Models.Part;
using ListEditor.Models.Part.Types;

namespace ListEditor.Forms
{
    public partial class GeneralForm : Form
    {
        public string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        private List<PartFile> _partFiles = new List<PartFile>();
        private List<MailType> _mailTypes = MailTypes.GetAllStandart();
        private List<MailCategory> _mailCategories = MailCategories.GetAll();
        private List<PayType> _payTypes = PayTypes.GetAll();
        private List<SenderCategory> _senderCategories = SenderCategories.GetAll();

        public GeneralForm()
        {
            InitializeComponent();

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            if (!Directory.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} v{Application.ProductVersion}";

            tbSaveDir.Text = Properties.Settings.Default.LastSaveDir;
            checkBoxDebug.Checked = Properties.Settings.Default.Debug;
            checkBoxIndex.Checked = Properties.Settings.Default.CheckAllIndex;

            InitTooltip();
        }

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
            SendStatucMessage(message, Color.Black);
        }

        // Сообщение: успех
        public void SuccessStatusMessage(string message)
        {
            SendStatucMessage(message, Color.Green);
        }

        // Сообщение: ошибка
        public void ErrorStatusMessage(string message)
        {
            SendStatucMessage(message, Color.Red);
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

        #endregion

        /// <summary>
        /// Парсит файлы
        /// </summary>
        /// <param name="list">Список файлов</param>
        private void ParseFiles(string[] list)
        {
            List<string> data = new List<string>();

            foreach (string s in list)
            {
                FileInfo file = new FileInfo(s);
                if(file.Extension == ".ini" || file.Extension == ".zip")
                    data.Add(s);
            }

            ParseListForm parseListForm = new ParseListForm(data.ToArray(), _mailTypes, _mailCategories, _payTypes, _senderCategories);
            parseListForm.ShowDialog(this);

            lblFilesCount.Text = "0";
            lblStringCount.Text = "0";

            _partFiles = parseListForm.PartFiles;
            _mailTypes = parseListForm.MailTypes;
            _mailCategories = parseListForm.MailCategories;
            _payTypes = parseListForm.PayTypes;
            _senderCategories = parseListForm.SenderCategories;

            lblFilesCount.Text = parseListForm.PartFiles.Count.ToString();
            lblStringCount.Text = parseListForm.StringCount.ToString();

            mailTypeBindingSource.DataSource = _mailTypes;
            mailCategoryBindingSource.DataSource = _mailCategories;
            payTypeBindingSource.DataSource = _payTypes;
            senderCategoryBindingSource.DataSource = _senderCategories;
            _partFiles = _partFiles.OrderBy(p => p.SendDate).ThenBy(p => p.Sender).ThenBy(p => int.Parse(p.ListNum)).ToList();
            dataGridData.DataSource = _partFiles;

            CheckDataGridView();
            SuccessStatusMessage("Готово!");
        }

        private void CheckDataGridView()
        {
            foreach (DataGridViewRow row in dataGridData.Rows)
            {
                DataGridViewCell cell = row.Cells[9];
                if (Convert.ToDouble(cell.Value) < 0)
                    cell.Style.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Обновление настроек
        /// </summary>
        private void UpgradeSettings()
        {
            // Перенос настроек предыдущей сборки в новую
            Properties.Settings.Default.Upgrade();
            WinConf.Default.Upgrade();
            Properties.Settings.Default.NeedUpgrade = false;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Сохранение позиции окна
        /// </summary>
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

        /// <summary>
        /// Загрузка позиции окна
        /// </summary>
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
        }

        private void InitTooltip()
        {
            ToolTip toolTipOpen = new ToolTip();
            ToolTip toolTipSave = new ToolTip();
            ToolTip toolTipClear = new ToolTip();
            ToolTip toolTipRemove = new ToolTip();

            ToolTip toolTipDate = new ToolTip();
            ToolTip toolTipNum = new ToolTip();
            ToolTip toolTipSndrCat = new ToolTip();
            ToolTip toolTipMailType = new ToolTip();
            ToolTip toolTipMailCat = new ToolTip();
            ToolTip toolTipPostMark = new ToolTip();
            ToolTip toolTipPayType = new ToolTip();

            ToolTip toolTipClearDir = new ToolTip();

            toolTipOpen.SetToolTip(btnOpen, "Открыть файлы [Ctrl + O]");
            toolTipSave.SetToolTip(btnSave, "Сохранить файлы [Ctrl + S]");
            toolTipClear.SetToolTip(btnClear, "Удалить все файлы [Ctrl + C]");
            toolTipRemove.SetToolTip(btnRemove, "Удалить файл [Del]");

            toolTipDate.SetToolTip(btnCheckDate, "Исправить дату списков");
            toolTipNum.SetToolTip(btnCheckNum, "Исправить номера файлов");
            toolTipSndrCat.SetToolTip(btnCheckSndrCat, "Исправить категорию отправителя");
            toolTipMailType.SetToolTip(btnCheckMailType, "Исправить тип отправления");
            toolTipMailCat.SetToolTip(btnCheckMailCat, "Исправить категорию отправления");
            toolTipPostMark.SetToolTip(btnCheckPostMark, "Исправить почтовые отметки");
            toolTipPayType.SetToolTip(btnCheckPayType, "Исправить тип оплаты");

            toolTipClearDir.SetToolTip(btnClearDir, "Очистить исходящую папку [Ctrl+Shift+C]");
        }

        /// <summary>
        /// Удаление выделенных строк из таблицы
        /// </summary>
        private void RemoveRows()
        {
            foreach (DataGridViewRow row in dataGridData.SelectedRows)
            {
                if (row.Index == -1)
                    continue;

                List<PartFile> p = new List<PartFile>(_partFiles);
                p.Remove(((List<PartFile>)dataGridData.DataSource)[row.Index]);
                _partFiles = new List<PartFile>(p);
            }

            dataGridData.DataSource = _partFiles;
        }

        #region Меню
        // Выход
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Индексы
        private void indexMenuItem_Click(object sender, EventArgs e)
        {
            IndexForm indexForm = new IndexForm();
            indexForm.ShowDialog(this);
        }

        // Очистка
        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            lblFilesCount.Text = "0";
            lblStringCount.Text = "0";
            _partFiles = new List<PartFile>();
            _mailTypes = MailTypes.GetAllStandart();
            _mailCategories = MailCategories.GetAll();
            _payTypes = PayTypes.GetAll();
            _senderCategories = SenderCategories.GetAll();
            dataGridData.DataSource = null;
            SuccessStatusMessage("Готово!");
        }

        // Открыть
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            dataGridData.DataSource = null;

            string dir = Properties.Settings.Default.LastOpenDir;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Все файлы (*.*)|*.*|Ini файлы (*.ini)|*.ini|Zip архивы (*.zip)|*.zip",
                RestoreDirectory = false
            };

            if (!string.IsNullOrEmpty(dir))
                openFileDialog.InitialDirectory = Directory.Exists(dir) ? dir : @"C:\";
            else
                openFileDialog.InitialDirectory = @"C:\";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string[] data = openFileDialog.FileNames;

                if (data.Length > 0)
                {
                    Properties.Settings.Default.LastOpenDir = Path.GetDirectoryName(data[0]);
                    Properties.Settings.Default.Save();
                }

                ParseFiles(data);
            }
        }

        // Сохранить
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<PartFile> partFiles = (List<PartFile>)dataGridData.DataSource;
                foreach (PartFile partFile in partFiles)
                {
                    partFile.SaveToRtm(tbSaveDir.Text);
                }
                SuccessStatusMessage("Готово!");
            }
            // ReSharper disable once EmptyGeneralCatchClause
            catch
            {
                ErrorStatusMessage("Ошибка сохранения!");
            }    
        }

        // Очистить исходящую папку
        private void clearDirMenuItem_Click(object sender, EventArgs e)
        {
            string outDir = tbSaveDir.Text.Trim();
            if (!string.IsNullOrEmpty(outDir))
            {
                if (Directory.Exists(outDir))
                {
                    DirectoryInfo di = new DirectoryInfo(outDir);
                    foreach (FileInfo file in di.GetFiles())
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch
                        {
                            // ignored
                        }
                    }
                }
                    
            }
        }

        // Изменить вид оплаты
        private void checkPayTypeMenuItem_Click(object sender, EventArgs e)
        {
            PayTypeForm payTypeForm = new PayTypeForm();
            if (payTypeForm.ShowDialog(this) == DialogResult.OK)
            {
                if (_partFiles.Count > 0)
                {
                    PayType payType = payTypeForm.PayType;
                    List<PartFile> partFiles = (List<PartFile>) dataGridData.DataSource;
                    foreach (PartFile partFile in partFiles)
                    {
                        partFile.PayType = payType.Id;
                    }

                    _partFiles = partFiles;
                    dataGridData.DataSource = null;
                    dataGridData.DataSource = _partFiles;

                    CheckDataGridView();
                }
            }
            SuccessStatusMessage("Готово!");
        }

        // Изменить дату
        private void checkDateMenuItem_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();
            if (dateForm.ShowDialog(this) == DialogResult.OK)
            {
                if (_partFiles.Count > 0)
                {
                    DateTime sendDate = dateForm.Date;
                    List<PartFile> partFiles = (List<PartFile>)dataGridData.DataSource;
                    foreach (PartFile partFile in partFiles)
                    {
                        partFile.SendDate = sendDate;
                    }

                    _partFiles = partFiles;
                    dataGridData.DataSource = null;
                    dataGridData.DataSource = _partFiles;

                    CheckDataGridView();
                }
            }
            SuccessStatusMessage("Готово!");
        }

        // Изменить отметки
        private void checkPostMarkMenuItem_Click(object sender, EventArgs e)
        {
            PostMarkForm postMarkForm = new PostMarkForm("0");
            if (postMarkForm.ShowDialog(this) == DialogResult.OK)
            {
                if (_partFiles.Count > 0)
                {
                    long postMark = postMarkForm.PostMarkMask;
                    List<PartFile> partFiles = (List<PartFile>)dataGridData.DataSource;
                    foreach (PartFile partFile in partFiles)
                    {
                        partFile.PostMark = postMark.ToString();
                    }

                    _partFiles = partFiles;
                    dataGridData.DataSource = null;
                    dataGridData.DataSource = _partFiles;

                    CheckDataGridView();
                }
            }
            SuccessStatusMessage("Готово!");
        }

        // Изменить категорию отправителя
        private void checkSndrCategoryMenuItem_Click(object sender, EventArgs e)
        {
            SndrCategoryForm sndrCategoryForm = new SndrCategoryForm();
            if (sndrCategoryForm.ShowDialog(this) == DialogResult.OK)
            {
                if (_partFiles.Count > 0)
                {
                    SenderCategory senderCategory = sndrCategoryForm.SenderCategory;
                    List<PartFile> partFiles = (List<PartFile>) dataGridData.DataSource;
                    foreach (PartFile partFile in partFiles)
                    {
                        partFile.SendCtg = senderCategory.Id;

                        _partFiles = partFiles;
                        dataGridData.DataSource = null;
                        dataGridData.DataSource = _partFiles;

                        CheckDataGridView();
                    }
                }
            }
            SuccessStatusMessage("Готово!");
        }

        // Исправить тип отправления
        private void checkMailTypeMenuItem_Click(object sender, EventArgs e)
        {
            MailTypeForm mailTypeForm = new MailTypeForm();
            if (mailTypeForm.ShowDialog(this) == DialogResult.OK)
            {
                if (_partFiles.Count > 0)
                {
                    MailType mailType = mailTypeForm.MailType;
                    List<PartFile> partFiles = (List<PartFile>)dataGridData.DataSource;
                    foreach (PartFile partFile in partFiles)
                    {
                        partFile.MailType = mailType.Id;

                        _partFiles = partFiles;
                        dataGridData.DataSource = null;
                        dataGridData.DataSource = _partFiles;

                        CheckDataGridView();
                    }
                }
            }
            SuccessStatusMessage("Готово!");
        }

        // Исправить категорию отправления
        private void checkMailCategoryMenuItem_Click(object sender, EventArgs e)
        {
            MailCategoryForm mailCategoryForm = new MailCategoryForm();
            if (mailCategoryForm.ShowDialog(this) == DialogResult.OK)
            {
                if (_partFiles.Count > 0)
                {
                    MailCategory mailCategory = mailCategoryForm.MailCategory;
                    List<PartFile> partFiles = (List<PartFile>)dataGridData.DataSource;
                    foreach (PartFile partFile in partFiles)
                    {
                        partFile.MailCtg = mailCategory.Id;

                        _partFiles = partFiles;
                        dataGridData.DataSource = null;
                        dataGridData.DataSource = _partFiles;

                        CheckDataGridView();
                    }
                }
            }
            SuccessStatusMessage("Готово!");
        }

        // Исправить номер списка
        private void checkNumListMenuItem_Click(object sender, EventArgs e)
        {
            ListNumForm listNumForm = new ListNumForm();
            if (listNumForm.ShowDialog(this) == DialogResult.OK)
            {
                if (_partFiles.Count > 0)
                {
                    bool add = listNumForm.Add;
                    int num = listNumForm.Num;
                    List<PartFile> partFiles = (List<PartFile>)dataGridData.DataSource;
                    foreach (PartFile partFile in partFiles)
                    {
                        int listNum = Convert.ToInt32(partFile.ListNum);

                        if (add)
                        {
                            if (listNum + num > 99999)
                                num = 0;
                            partFile.ListNum = $"{listNum + num}";
                        }
                        else
                        {
                            partFile.ListNum = num.ToString();
                            num++;
                            if (num > 99999)
                                num = 1;
                        }

                        _partFiles = partFiles;
                        dataGridData.DataSource = null;
                        dataGridData.DataSource = _partFiles;

                        CheckDataGridView();
                    }
                }
            }
            SuccessStatusMessage("Готово!");
        }

        #endregion

        #region Обработчики

        // Форма: Загружена
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadPos();
            WebRequest.DefaultWebProxy = null;
        }

        // Форма: Закрыта
        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePos();
        }

        // Форма: Нажатие клавиш
        private void GeneralForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Del
            if (e.KeyCode == Keys.Delete && dataGridData.SelectedRows.Count > 0)
            {
                btnRemove.PerformClick();
            }
        }

        // Таймер
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.Text = "";
        }

        // Таблица: Начало Drag&Drop
        private void dataGridData_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        // Таблица: Отпускание файлов
        private void dataGridData_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                dataGridData.DataSource = null;

                string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
                ParseFiles(data);
            }
        }

        // Таблица: Ошибка значения
        private void dataGridData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        // Таблица: Двойной клик на ячейке
        private void dataGridData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            // Почтовые отметки
            if (e.ColumnIndex == 8)
            {
                string postMarkId = (string)dataGridData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                PostMarkForm postMarkForm = new PostMarkForm(postMarkId);
                if (postMarkForm.ShowDialog(this) == DialogResult.OK)
                {
                    dataGridData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = postMarkForm.PostMarkMask;
                    partFileBindingSource.DataSource = (List<PartFile>)dataGridData.DataSource;
                }
            }

            // Строки
            if (e.ColumnIndex == 4)
            {
                List<PartFile> partFiles = (List<PartFile>) dataGridData.DataSource;
                PartFile partFile = partFiles[e.RowIndex];
                if (partFile != null)
                {
                    EditListForm editListForm = new EditListForm(partFile.Rows, $"Редактирование списка: №{partFile.ListNum} от {partFile.Sender}");
                    editListForm.ShowDialog(this);
                }
            }

            // Ошибки
            if (e.ColumnIndex == dataGridData.ColumnCount - 1)
            {
                List<PartFile> partFiles = (List<PartFile>)dataGridData.DataSource;
                PartFile partFile = partFiles[e.RowIndex];
                if (partFile != null && partFile.ErrorCount > 0)
                {
                    ErrorForm errorForm = new ErrorForm(partFile.ErrorMessage, $"Ошибки списка: №{partFile.ListNum} от {partFile.Sender}");
                    errorForm.ShowDialog(this);
                }
            }
        }

        #endregion

        #region Кнопки

        // Кнопка: Удалить
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveRows();
        }

        // Кнопка: Выбрать папку
        private void btnChoose_Click(object sender, EventArgs e)
        {
            string dir = Properties.Settings.Default.LastSaveDir;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(dir))
                folderBrowserDialog.SelectedPath = dir;

            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                Properties.Settings.Default.LastSaveDir = folderBrowserDialog.SelectedPath;
                tbSaveDir.Text = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        // Кнопка: Главные
        private void generalMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
            checkBoxIndex.Checked = Properties.Settings.Default.CheckAllIndex;
        }


        #endregion

        private void interFilterMenuItem_Click(object sender, EventArgs e)
        {
            RegionCityForm regionCityForm = new RegionCityForm();
            regionCityForm.ShowDialog(this);
        }

        private void checkBoxDebug_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Debug = checkBoxDebug.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBoxIndex_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckAllIndex = checkBoxIndex.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
