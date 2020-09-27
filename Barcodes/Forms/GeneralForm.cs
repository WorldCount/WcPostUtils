using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Barcodes.Libs;
using Barcodes.Libs.DB;
using Barcodes.Libs.DB.Queryes;
using Barcodes.Libs.Models;
using WcApi.Post.Ranges;

namespace Barcodes.Forms
{
    public partial class GeneralForm : Form
    {
        private Range _range;

        public readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);

        private readonly string _connectPath;
        private readonly string _indexPath;
        private readonly string _internalTypePath;

        private string _lastSaveDir = Properties.Settings.Default.LastSave;

        public GeneralForm()
        {
            InitializeComponent();

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            if (!Directory.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            _connectPath = Path.Combine(DataDir, Properties.Settings.Default.ConnectFile);
            _indexPath = Path.Combine(DataDir, Properties.Settings.Default.IndexFile);
            _internalTypePath = Path.Combine(DataDir, Properties.Settings.Default.IntenalTypeFile);

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";

            _range = new Range();

            segmentBindingSource.DataSource = _range.Segments;
            dataGridView.DataSource = segmentBindingSource;

            List<Index> indices = IndexManager.Load(_indexPath);
            indexBindingSource.DataSource = indices;
            cbIndex.DataSource = indexBindingSource;
        }

        private void UpdateData()
        {
            segmentBindingSource.DataSource = null;
            segmentBindingSource.DataSource = _range.Segments;
        }

        private async void LoadOrg()
        {
            Connect connect = DataBase.GetConnect(_connectPath);
            FirmQuery firmQuery = new FirmQuery(connect);
            List<Firm> firms = await DataBase.GetFirmsAsync(firmQuery);

            cbOrgs.SelectedIndexChanged += CbOrgs_SelectedIndexChanged;
            cbOrgs.DataSource = firms;
            cbOrgs.DisplayMember = "Name";
            cbOrgs.ValueMember = "Inn";
        }

        private void CbOrgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Firm firm = (Firm)cbOrgs.SelectedItem;
            if (firm != null)
            {
                tbInn.Text = firm.Inn;
            }
        }

        #region Настройка формы

        private void LoadSettings()
        {

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

            // Восстановление положения окна
            string[] args = Environment.GetCommandLineArgs();
            if (args.Contains("-restore"))
                CenterToScreen();
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadPos();
            LoadSettings();
            LoadOrg();
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePos();
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSegmentForm addSegmentForm = new AddSegmentForm(_internalTypePath);
            if (addSegmentForm.ShowDialog(this) == DialogResult.OK)
            {
                _range.AddSegment(addSegmentForm.Segment);
                UpdateData();
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm(_connectPath);
            connectForm.ShowDialog(this);
            LoadOrg();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _range = new Range();
            UpdateData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_range.Segments.Count < 1)
                return;

            _range.DateInfo = DateTime.Now;
            try
            {
                _range.IndexFrom = int.Parse(cbIndex.SelectedValue.ToString());
            }
            catch
            {
                MessageBox.Show("Не узакан индекс ОПС.");
                return;
            }
            
            _range.Inn = tbInn.Text;

            
            SaveFileDialog saveFileDialog = new SaveFileDialog {FileName = _range.GetFileName()};
            if (!string.IsNullOrEmpty(_lastSaveDir))
                saveFileDialog.InitialDirectory = _lastSaveDir;

            if(saveFileDialog.ShowDialog() == DialogResult.OK) 
                _range.Save(Path.GetDirectoryName(saveFileDialog.FileName));

            _lastSaveDir = saveFileDialog.InitialDirectory;

            Properties.Settings.Default.LastSave = _lastSaveDir;
            Properties.Settings.Default.Save();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                int index = rows[0].Index;
                if(index >= 0)
                    _range.Segments.Remove(_range.Segments[index]);

                UpdateData();
            }
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIndexsForm addIndexsForm = new AddIndexsForm(_indexPath);
            addIndexsForm.ShowDialog(this);

            List<Index> indices = IndexManager.Load(_indexPath);

            indexBindingSource.DataSource = indices;
            cbIndex.DataSource = indexBindingSource;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void interToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInterForm addInterForm = new AddInterForm(_internalTypePath);
            addInterForm.ShowDialog(this);
        }
    }
}
