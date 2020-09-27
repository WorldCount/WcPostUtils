using System;
using System.Linq;
using System.Windows.Forms;
using Mail.Libs;
using Mail.Libs.Models;
using ServiceStack.OrmLite;

namespace Mail.Forms
{
    public partial class AddFilterForm : Form
    {
        private readonly OrmLiteConnectionFactory _dbFactory;
        private Filter _filter;

        public AddFilterForm(Filter filer = null)
        {
            InitializeComponent();

            _dbFactory = DbFarctory.Create();
            _filter = filer;

            labelError.Text = "";
            if (_filter != null)
            {
                textBoxName.Text = _filter.Name;
                // ReSharper disable once VirtualMemberCallInConstructor
                Text = $"{Properties.Settings.Default.AppName}: Редактирование фильтра";
            }
            else
            {
                // ReSharper disable once VirtualMemberCallInConstructor
                Text = $"{Properties.Settings.Default.AppName}: Добавление фильтра";
            }         
        }

        public Filter GetFilter()
        {
            return _filter;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string text = textBoxName.Text.Trim();

            if (!string.IsNullOrEmpty(text))
            {
                using (var db = _dbFactory.Open())
                {
                    Filter res = db.Select<Filter>(f => f.Name == text).FirstOrDefault();

                    if (res != null)
                    {
                        labelError.Text = "Фильтр с таким названием уже существует";
                        textBoxName.Focus();
                        textBoxName.SelectAll();
                    }
                    else
                    {
                        if (_filter != null)
                        {
                            _filter.Name = text;
                            db.Update<Filter>(_filter);
                        }
                        else
                        {
                            _filter = new Filter {Name = text};
                            db.Save(_filter, true);
                        }

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
            else
            {
                labelError.Text = "Название не может быть пустым.";
                textBoxName.Focus();
                textBoxName.SelectAll();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddFilterForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                buttonAdd.PerformClick();
            }

            // Нажатие ESC
            if (e.KeyCode == Keys.Escape)
            {
                buttonCancel.PerformClick();
            }

            // Нажатие ENTER
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.PerformClick();
            }

            // Нажатие Ctrl + F
            if (e.KeyCode == Keys.Escape)
            {
                textBoxName.Focus();
                textBoxName.SelectAll();
            }
        }
    }
}
