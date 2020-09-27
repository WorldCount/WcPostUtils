using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using SQLite;
using ListEditor.Models;

namespace ListEditor.Forms
{
    public partial class IndexForm : Form
    {
        public string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        public string Database = Path.Combine(Properties.Settings.Default.DataDir, Properties.Settings.Default.DB);


        public IndexForm()
        {
            InitializeComponent();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));

            ToolTip toolTipUpdate = new ToolTip();
            ToolTip toolTipClose = new ToolTip();
            ToolTip toolTipFind = new ToolTip();
            ToolTip toolTipClear = new ToolTip();

            toolTipClear.SetToolTip(btnClear, "Очистить [Ctrl + C]");
            toolTipFind.SetToolTip(btnFind, "Поиск [Ctrl + F]");
            toolTipUpdate.SetToolTip(btnUpdate, "Обновить справочник индексов [Ctrl + U]");
            toolTipClose.SetToolTip(btnClose, "Закрыть [Esc]");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(DataDir, "tmp.zip");
            Uri urlFile = new Uri(Properties.Settings.Default.IndexUrl);
            DownloadForm downloadForm = new DownloadForm(urlFile, filePath);

            if (downloadForm.ShowDialog(this) != DialogResult.OK)
                MessageBox.Show($"Ошибка обновления справочника индексов:\n{downloadForm.Error}", "Ошибка обновления", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string index = tbIndex.Text.Trim();
                string name = tbName.Text.Trim();
                string sub = tbSub.Text.Trim();
                string region = tbRegion.Text.Trim();
                string type = tbType.Text.Trim();

                if (File.Exists(Database))
                {
                    SQLiteAsyncConnection db = new SQLiteAsyncConnection(Database);

                    indexBindingSource.DataSource = null;
                    lblFindText.Text = "0";

                    string q = "select * from [Index] where";
                    List<object> param = new List<object>();

                    // Индекс
                    if (!string.IsNullOrEmpty(index))
                    {
                        if (param.Count > 0)
                            q += " and";
                        q += " num like ?";

                        if (index.Contains("%") || index.Contains("_"))
                            param.Add(index);
                        else
                            param.Add($"{index}%");
                    }

                    // Регион
                    if (!string.IsNullOrEmpty(region))
                    {
                        if (param.Count > 0)
                            q += " and";
                        q += " region like ?";

                        if (region.Contains("%") || region.Contains("_"))
                            param.Add(region);
                        else
                            param.Add($"{region}%");
                    }

                    // Подчинен
                    if (!string.IsNullOrEmpty(sub))
                    {
                        if (param.Count > 0)
                            q += " and";
                        q += " sub like ?";

                        if (sub.Contains("%") || sub.Contains("_"))
                            param.Add(sub);
                        else
                            param.Add($"{sub}%");
                    }

                    // Имя
                    if (!string.IsNullOrEmpty(name))
                    {
                        if (param.Count > 0)
                            q += " and";
                        q += " name like ?";

                        if (name.Contains("%") || name.Contains("_"))
                            param.Add(name);
                        else
                            param.Add($"{name}%");
                    }

                    // Тип
                    if (!string.IsNullOrEmpty(type))
                    {
                        if (param.Count > 0)
                            q += " and";

                        if (type.Contains("%") || type.Contains("_"))
                            q += " type like ?";
                        else
                            q += " type = ?";
                        param.Add(type);
                    }

                    if (param.Count == 0)
                        q = "select * from [Index]";
                    var result = await db.QueryAsync<Index>(q, param.ToArray());

                    lblFindText.Text = result.Count.ToString();
                    //dataGridIndex.DataSource = result;
                    dataGridIndex.DataSource = result;

                    db.GetConnection().Close();
                    db.GetConnection().Dispose();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                else
                {
                    MessageBox.Show("Базы с индексами не существует!\nВыполните обновление.", "Упс...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbIndex.Clear();
            tbName.Clear();
            tbSub.Clear();
            tbRegion.Clear();
            tbType.Clear();
            dataGridIndex.DataSource = null;
            lblFindText.Text = "0";
            tbIndex.Focus();
        }

        private void IndexForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + F
            if (e.KeyCode == Keys.F && e.Control)
            {
                btnFind.PerformClick();
            }

            // Нажатие Ctrl + C
            if (e.KeyCode == Keys.C && e.Control)
            {
                btnClear.PerformClick();
            }

            // Нажатие ESC
            if (e.KeyCode == Keys.Escape)
            {
                btnClose.PerformClick();
            }

            // Нажатие Ctrl + U
            if (e.KeyCode == Keys.D && e.Control)
            {
                btnUpdate.PerformClick();
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Enter
            if (e.KeyCode == Keys.Enter)
            {
                btnFind.PerformClick();
            }
        }
    }
}
