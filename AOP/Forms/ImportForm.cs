using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AOP.Core;
using AOP.Core.Models.DB;
using NLog;
using SQLiteNetExtensions.Extensions;
using WcApi.Post.Types;

namespace AOP.Forms
{
    public partial class ImportForm : Form
    {
        private readonly string[] _links;
        private readonly List<RpoList> _rpoLists = new List<RpoList>();

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly Database _database;

        private List<MailCategory> _mailCategories;
        private List<MailType> _mailTypes;

        public ImportForm(string[] links, Database database)
        {
            InitializeComponent();

            _links = links;
            _database = database;

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridViewList);

            InitTable();

            LoadMailType();
            LoadMailCategory();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {

            foreach (string link in _links)
            {
                try
                {
                    RpoList rpoList = ExcelParser.Parse(link);

                    if(rpoList != null)
                        _rpoLists.Add(rpoList);
                }
                catch (Exception exception)
                {
                    Logger.Error($"Файл: {link}\n{exception.Message}");
                }
            }

            rpoListBindingSource.DataSource = null;
            rpoListBindingSource.DataSource = _rpoLists;
        }

        private void InitTable()
        {
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dateDataGridViewTextBoxColumn.Width = 120;

            numDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numDataGridViewTextBoxColumn.Width = 120;

            countDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            countDataGridViewTextBoxColumn.Width = 100;

            errorcountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            errorcountDataGridViewTextBoxColumn.Width = 100;

            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nameDataGridViewTextBoxColumn.Width = 200;
        }

        #region Данные

        private void LoadMailCategory()
        {
            mailCategoryBindingSource.DataSource = null;
            _mailCategories = MailCategories.GetAllStandart();
            mailCategoryBindingSource.DataSource = _mailCategories;
        }

        private void LoadMailType()
        {
            mailTypeBindingSource.DataSource = null;
            _mailTypes = MailTypes.GetAllStandart();
            mailTypeBindingSource.DataSource = _mailTypes;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<RpoList> rpoLists = (List<RpoList>)rpoListBindingSource.DataSource;
            foreach (RpoList rpoList in rpoLists)
            {
                _database.Db.Insert(rpoList);
                _database.Db.InsertAll(rpoList.Rpos);
                _database.Db.UpdateWithChildren(rpoList);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ImportForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }
    }
}
