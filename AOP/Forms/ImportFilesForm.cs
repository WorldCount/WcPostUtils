using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AOP.Models;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SQLite;
using SQLiteNetExtensions.Extensions;
using WcApi.Post.Types;

namespace AOP.Forms
{
    public partial class ImportFilesForm : Form
    {
        public List<MailCategory> Types = MailCategories.GetAllStandart();
        public List<RpoList> RpoLists = new List<RpoList>();
        public string[] Links;

        public ImportFilesForm(string[] links)
        {
            InitializeComponent();
            Links = links;
            mailCategoryBindingSource.DataSource = Types;
        }

        private List<Rpo> ParseFile(string link, bool xlsx = false)
        {
            List<Rpo> data = new List<Rpo>();
            IWorkbook workbook;

            using (FileStream fileStream = new FileStream(link, FileMode.Open, FileAccess.Read))
            {
                if(xlsx)
                    workbook = new XSSFWorkbook(fileStream);
                else
                    workbook = new HSSFWorkbook(fileStream);
            }

            ISheet sheet = workbook.GetSheetAt(0);
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {

                IRow row = sheet.GetRow(i);

                if(row == null && i > 3)
                    break;

                if (row != null)
                {
                    string d = "";
                    foreach (ICell cell in row.Cells)
                        d += cell.ToString();

                    string dUpper = d.ToUpper();

                    if (string.IsNullOrEmpty(d) && i > 3 || dUpper.Contains("СДАЛ:"))
                        break;

                    if(dUpper.Contains("ДОЛЖНОСТЬ, ФИО") || dUpper.Contains("НАИМЕНОВАНИЕ ОРГАНИЗАЦИИ") || dUpper.Contains("СПИСОК ПОЧТОВЫХ ОТПРАВЛЕНИЙ"))
                        continue;

                    try
                    {   
                        string region = row.GetCell(1, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string index = row.GetCell(2, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string place = row.GetCell(4, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string address = row.GetCell(5, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string rcpn = row.GetCell(6, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string comment = row.GetCell(7, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();

                        //if (i == 69)
                        //    MessageBox.Show($"Регион: '{region}'\nИндекс: '{index}'\nГород: '{place}'\nАдрес: '{address}'\nПолучатель: '{rcpn}'\nПримечание: '{comment}'");

                        string t = $"{region}{index}{place}{address}{rcpn}{comment}";
                        if (string.IsNullOrEmpty(t))
                        {
                            //MessageBox.Show($"Row: {i}\nCell: {row.Cells.Count}\nString: '{t}'\n{string.IsNullOrEmpty(t)}");
                            continue;
                        }

                        Rpo rpo = new Rpo
                        {
                            Region = region.Trim(),
                            Index = index.Trim(),
                            PlaceTo = place.Trim(),
                            Address = address.Trim(),
                            Rcpn = rcpn.Trim(),
                            Comment = comment.Trim()
                        };

                        data.Add(rpo);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Строка: {i + 1} -> пропущена ({row.Cells.Count}):\n{e.Message}");
                    }                   
                }
            }

            return data;
        }

        private void ImportFilesForm_Load(object sender, EventArgs e)
        {
            foreach (string link in Links)
            {
                FileInfo fileInfo = new FileInfo(link);
                string ext = fileInfo.Extension;

                if (ext == ".xls" || ext == ".xlsx")
                {
                    try
                    {
                        //RpoList rpoList = new RpoList { Name = fileInfo.Name.Split('.')[0].Trim() };
                        RpoList rpoList = new RpoList { Name = new string(fileInfo.Name.Where(char.IsDigit).ToArray())};

                        if (fileInfo.Name.ToUpper().Contains("З"))
                            rpoList.Category = 1;
                        rpoList.Rpos = ParseFile(link, fileInfo.Extension == ".xlsx");
                        rpoList.Count = rpoList.Rpos.Count;
                        RpoLists.Add(rpoList);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Файл: {link}\n{exception.Message}");
                        continue;
                    }
                    
                }
            }

            rpoListBindingSource.DataSource = RpoLists;
            dataGridView.DataSource = rpoListBindingSource;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            List<RpoList> rpoLists = (List<RpoList>) rpoListBindingSource.DataSource;
            using (var db = new SQLiteConnection(GeneralForm.DbPath))
            {
                foreach (RpoList rpoList in rpoLists)
                {
                    db.Insert(rpoList);
                    db.InsertAll(rpoList.Rpos);
                    db.UpdateWithChildren(rpoList);
                }
            }

            Close();
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            foreach (RpoList rpoList in RpoLists)
            {
                rpoList.Date = date.Date;
            }

            rpoListBindingSource.DataSource = null;
            rpoListBindingSource.DataSource = RpoLists;
        }

        private void ImportFilesForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnAccept.PerformClick();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;


            if (e.ColumnIndex == 3)
            {
                List<RpoList> rpoLists = (List<RpoList>) rpoListBindingSource.DataSource;
                RpoList rpoList = rpoLists[e.RowIndex];

                RpoListForm rpoListForm = new RpoListForm(rpoList, true);
                rpoListForm.ShowDialog(this);
            }
        }
    }
}
