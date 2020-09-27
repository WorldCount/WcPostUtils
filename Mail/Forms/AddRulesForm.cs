using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mail.Libs;
using Mail.Libs.Models;
using ServiceStack.OrmLite;

namespace Mail.Forms
{
    public partial class AddRulesForm : Form
    {
        private readonly Filter _filter;
        private readonly Email _email;
        private readonly OrmLiteConnectionFactory _dbFactory;

        public AddRulesForm(Filter filter, Email email = null)
        {
            InitializeComponent();

            _dbFactory = DbFarctory.Create();
            _filter = filter;
            _email = email;

            if (_email != null)
            {
                textBoxName.Text = _email.Name;
                textBoxMail.Text = _email.Text;
                // ReSharper disable once VirtualMemberCallInConstructor
                Text = $"{Properties.Settings.Default.AppName}: Редактирование правила";
            }
            else
            {
                // ReSharper disable once VirtualMemberCallInConstructor
                Text = $"{Properties.Settings.Default.AppName}: Добавление правила";
            }
        }

        private void AddRulesForm_Load(object sender, EventArgs e)
        {
            labelMailError.Text = "";
            labelNameError.Text = "";

            List<Filter> filters = DataBase.LoadAllFilters(_dbFactory);
            filterBindingSource.DataSource = null;
            filterBindingSource.DataSource = filters;

            if(_filter != null)
            {
                comboBoxFilters.SelectedIndex = GetFilterSelectId(_filter.Name);
            }
        }

        private int GetFilterSelectId(string name)
        {
            return comboBoxFilters.FindString(name);
        }

        private void GetClipboardText()
        {
            string rawText = Clipboard.GetText().Trim();
            if (rawText.Contains('['))
            {
                string[] part = rawText.Split('[');
                textBoxName.Text = part[0].Trim();
                textBoxMail.Text = part[1].Replace(']', ' ').Trim();
                Clipboard.Clear();
            }

            //string text = Clipboard.GetText().Replace('[', ' ').Replace(']', ' ').Trim();
            //Clipboard.SetText(text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelNameError.Text = "";
            labelMailError.Text = "";

            int errorCount = 0;

            string name = textBoxName.Text.Trim();
            string text = textBoxMail.Text.Replace(']', ' ').Replace('[', ' ').Trim().ToLower();

            if (string.IsNullOrEmpty(name))
            {
                labelNameError.Text = "Поле не может быть пустым.";
                errorCount += 1;
            }

            if (string.IsNullOrEmpty(text))
            {
                labelMailError.Text = "Поле не может быть пустым.";
                errorCount += 1;
            }

            if (errorCount > 0)
                return;

            using (var db = _dbFactory.Open())
            {
                Email res = db.Single<Email>(m => m.Text == text);

                if(res != null && _email == null)
                {
                    errorCount += 1;
                    Filter filter = db.Single<Filter>(f => f.Id == res.FilterId);
                    labelMailError.Text = $"Такая почта уже существует у [{filter.Name}]";
                    textBoxMail.Focus();
                    textBoxMail.SelectAll();
                }
                else
                {
                    Filter filter = (Filter) comboBoxFilters.SelectedItem;

                    if (_email != null)
                    {
                        _email.Name = name;
                        _email.Text = text;

                        if (filter != null)
                            _email.FilterId = filter.Id;

                        db.Update<Email>(_email);
                    }
                    else
                    {
                        var email = filter != null ? new Email { Name = name, Text = text, FilterId = filter.Id } : new Email { Name = name, Text = text, FilterId = _filter.Id };

                        db.Save(email, true);
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + V
            if (e.KeyCode == Keys.V && e.Control)
            {
                GetClipboardText();
                e.Handled = true;
                return;
            }
        }

        private void textBoxMail_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + V
            if (e.KeyCode == Keys.V && e.Control)
            {
                GetClipboardText();
                e.Handled = true;
                return;
            }
        }

        private void AddRulesForm_KeyDown(object sender, KeyEventArgs e)
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
        }

        
    }
}
