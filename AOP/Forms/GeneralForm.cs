using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AOP.Models;
using NPOI.XWPF.UserModel;
using SQLite;
using SQLiteNetExtensions.Extensions;
using WcApi.Post.Types;

namespace AOP.Forms
{
    public partial class GeneralForm : Form
    {
        public string LastOpenDir = Properties.Settings.Default.LastOpenDir;
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        public static readonly string DbPath = Path.Combine(DataDir, Properties.Settings.Default.Database);
        public static readonly string A4Template = Path.Combine(DataDir, "A4.docx");
        public static readonly string C5Template = Path.Combine(DataDir, "C5.docx");
        public static readonly string Report = @"D:\test.docx";
        private readonly List<MailCategory> _mailCategories = MailCategories.GetAllStandart();

        public GeneralForm()
        {
            InitializeComponent();

            if (!Directory.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            mailCategoryBindingSource.DataSource = _mailCategories;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {Filter = "Excel|*.xls*", Multiselect = true};

            if (!string.IsNullOrEmpty(LastOpenDir))
                openFileDialog.InitialDirectory = LastOpenDir;
            

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                
                LastOpenDir = openFileDialog.InitialDirectory;
                Properties.Settings.Default.LastOpenDir = LastOpenDir;
                Properties.Settings.Default.Save();

                ImportFilesForm importFilesForm = new ImportFilesForm(openFileDialog.FileNames);
                importFilesForm.ShowDialog(this);
            }
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DbPath))
            {
                using (var db = new SQLiteConnection(DbPath))
                {
                    db.CreateTable<RpoList>();
                    db.CreateTable<Rpo>();
                }
            }       
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var db = new SQLiteConnection(DbPath))
            {
                var data = db.Table<RpoList>().Where(r => r.Date >= dateTimePickerIn.Value.Date).Where(r => r.Date <= dateTimePickerOut.Value.Date).OrderBy(r => r.Name).ToList();
                rpoListBindingSource.DataSource = data.Count > 0 ? data : null;
            }
        }

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerOut.Value = dateTimePickerIn.Value;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                RpoList rpoList = GetRpoList(e.RowIndex);
                if (rpoList != null)
                {
                    using (var db = new SQLiteConnection(DbPath))
                    {
                        db.Update(rpoList);
                    }
                }
            }
        }

        private RpoList GetRpoList(int rowId)
        {
            List<RpoList> rpoLists = (List<RpoList>) rpoListBindingSource.DataSource;
            return rpoLists[rowId];           
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var box = e.Control as TextBox;
            if (box != null)
                box.CharacterCasing = CharacterCasing.Upper;
        }

        private static void FillTemplate(List<Rpo> rpos, string templateLink, string category)
        {
            XWPFDocument document;

            using (FileStream fileStream = new FileStream(templateLink, FileMode.Open, FileAccess.Read))
            {
                document = new XWPFDocument(fileStream);
            }

            for (int i = 0; i < rpos.Count; i++)
            {
                Replace replace = new Replace(rpos[i], category);

                if (i == 0)
                {
                    foreach (XWPFTable table in document.Tables)
                    {
                        ReplaceTableValue(table, replace);
                    }

                    continue;
                }

                XWPFDocument template;
                using (FileStream fileStream = new FileStream(templateLink, FileMode.Open, FileAccess.Read))
                {
                    template = new XWPFDocument(fileStream);
                }

                CopyDocument(template, document, replace);
            }

            using (FileStream fileStream = new FileStream(Report, FileMode.Create, FileAccess.Write))
            {
                document.Write(fileStream);
            }

            Process.Start(Report);
        }

        private static void CopyDocument(XWPFDocument template, XWPFDocument document, Replace replace)
        {
            foreach (var bodyElement in template.BodyElements)
            {
                BodyElementType elementType = bodyElement.ElementType;
                if (elementType == BodyElementType.PARAGRAPH)
                {
                    XWPFParagraph pr = (XWPFParagraph) bodyElement;
                    document.CreateParagraph();
                    int pos = document.Paragraphs.Count - 1;
                    document.SetParagraph(pr, pos);
                }
                else if (elementType == BodyElementType.TABLE)
                {
                    XWPFTable table = (XWPFTable) bodyElement;

                    // Replace
                    ReplaceTableValue(table, replace);

                    document.CreateTable();
                    int pos = document.Tables.Count - 1;
                    document.SetTable(pos, table);
                }
            }
        }

        private static void ReplaceTableValue(XWPFTable table, Replace replace)
        {
            foreach (XWPFTableRow row in table.Rows)
                foreach (XWPFTableCell cell in row.GetTableCells())
                    foreach (XWPFParagraph p in cell.Paragraphs)
                        foreach (XWPFRun r in p.Runs)
                        {
                            string text = r.GetText(0);
                            if (text != null)
                            {
                                foreach (string key in replace.Keys)
                                {
                                    if (text.Contains(key))
                                    {
                                        text = text.Replace(key, replace.Data[key]);
                                        r.SetText(text, 0);
                                    }
                                }    
                            }
                        }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridView.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow != -1)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[currentMouseOverRow].Selected = true;
                    contextMenuStrip.Show(dataGridView, new Point(e.X, e.Y));
                }
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            int rowId = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            if (rowId != -1)
            {
                RpoList rpoList = GetRpoList(rowId);
                using (var db = new SQLiteConnection(DbPath))
                {
                    db.GetChildren(rpoList, true);
                    db.Delete(rpoList, true);                 
                }
                btnLoad.PerformClick();
            }
        }

        private void a4MenuItem_Click(object sender, EventArgs e)
        {
            int rowId = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            string templateLink = A4Template;

            if (rowId != -1)
            {
                RpoList rpoList = GetRpoList(rowId);

                if (rpoList == null)
                    return;

                string category = MailCategories.GetById(Convert.ToInt64(rpoList.Category)).Name;
                List<Rpo> rpos;
                using (var db = new SQLiteConnection(DbPath))
                {
                    rpos = db.GetWithChildren<RpoList>(rpoList.Id).Rpos;
                }

                try
                {
                    FillTemplate(rpos, templateLink, category);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка: {exception.Message}", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void c5MenuItem_Click(object sender, EventArgs e)
        {
            int rowId = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            string templateLink = C5Template;

            if (rowId != -1)
            {
                RpoList rpoList = GetRpoList(rowId);

                if (rpoList == null)
                    return;

                string category = MailCategories.GetById(Convert.ToInt64(rpoList.Category)).Name;
                List<Rpo> rpos;
                using (var db = new SQLiteConnection(DbPath))
                {
                    rpos = db.GetWithChildren<RpoList>(rpoList.Id).Rpos;
                }

                try
                {
                    FillTemplate(rpos, templateLink, category);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка: {exception.Message}", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;


            if (e.ColumnIndex == dataGridView.ColumnCount - 1)
            {
                List<RpoList> rpoLists = (List<RpoList>)rpoListBindingSource.DataSource;
                RpoList rpoList = rpoLists[e.RowIndex];

                using (var db = new SQLiteConnection(DbPath))
                {
                    db.GetChildren(rpoList);
                }

                RpoListForm rpoListForm = new RpoListForm(rpoList);
                if (rpoListForm.ShowDialog(this) == DialogResult.OK)
                {
                    using (var db = new SQLiteConnection(DbPath))
                    {
                        db.InsertOrReplaceWithChildren(rpoListForm.RpoList);
                    }
                }
            }
        }        
    }
}
