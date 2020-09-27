using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mail.Libs;
using Mail.Libs.Models;
using ServiceStack.OrmLite;
using ServiceStack.Text;


namespace Mail.Forms
{
    public partial class FilterForm : Form
    {
        private readonly OrmLiteConnectionFactory _dbFactory;

        public FilterForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Фильтры";

            _dbFactory = DbFarctory.Create();
        }

        private Email GetSelectEmail()
        {
            try
            {
                // ReSharper disable once PossibleNullReferenceException
                int id = dataGridViewRules.CurrentRow.Index;
                List<Email> emails = (List<Email>) emailBindingSource.DataSource;
                Email email = emails[id];
                return email;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private int GetFilterSelectId(string name)
        {
            return comboBox.FindString(name);
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void UpdateFilters()
        {
            List<Filter> filters = DataBase.LoadAllFilters(_dbFactory);
            filterBindingSource.DataSource = null;
            filterBindingSource.DataSource = filters;

            Filter filter = (Filter)comboBox.SelectedItem;
            LoadEmails(filter);
        }

        private void LoadEmails(Filter filter)
        {

            if (filter != null)
            {
                emailBindingSource.DataSource = null;
                List<Email> emails = filter.Emails;
                emailBindingSource.DataSource = emails;
                dataGridViewRules.Update();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter filter = (Filter) comboBox.SelectedItem;
            LoadEmails(filter);
        }

        #region Кнопки

        // Кнопка: Закрыть
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Кнопка: Добавить фильтр
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddFilterForm addFilterForm = new AddFilterForm();
            if (addFilterForm.ShowDialog(this) == DialogResult.OK)
            {
                UpdateFilters();
                comboBox.SelectedIndex = GetFilterSelectId(addFilterForm.GetFilter().Name);
            }
        }

        // Кнопка: Редактировать фильтр
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Filter filter = (Filter) comboBox.SelectedItem;

            if (filter != null)
            {
                AddFilterForm addFilterForm = new AddFilterForm(filter);
                if (addFilterForm.ShowDialog(this) == DialogResult.OK)
                {
                    UpdateFilters();
                    comboBox.SelectedIndex = GetFilterSelectId(addFilterForm.GetFilter().Name);
                }
            }
        }

        // Кнопка: Удалить фильтр
        private void buttonDel_Click(object sender, EventArgs e)
        {
            Filter filter = (Filter)comboBox.SelectedItem;
            if (filter != null)
            {
                if (MessageBox.Show($"Вы точно хотите удалить фильтр '{filter.Name}'?\nКоличество правил, которые так же будут удалены: {filter.Emails.Count}", $"Удаление фильтра '{filter.Name}'", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var db = _dbFactory.Open())
                    {
                        db.DeleteAll<Email>(filter.Emails);
                        db.Delete<Filter>(filter);
                        UpdateFilters();
                    }
                }
            }
        }

        // Кнопка: Добавить правило
        private void buttonAddRules_Click(object sender, EventArgs e)
        {
            Filter filter = (Filter)comboBox.SelectedItem;

            if (filter != null)
            {
                AddRulesForm addRulesForm = new AddRulesForm(filter);
                if(addRulesForm.ShowDialog(this) == DialogResult.OK)
                {
                    UpdateFilters();
                    comboBox.SelectedIndex = GetFilterSelectId(filter.Name);
                }
            }
        }

        // Кнопка: Редактировать правило
        private void buttonEditRules_Click(object sender, EventArgs e)
        {
            Email email = GetSelectEmail();
            Filter filter = (Filter)comboBox.SelectedItem;

            if (filter != null && email != null)
            {
                AddRulesForm addRulesForm = new AddRulesForm(filter, email);
                if (addRulesForm.ShowDialog(this) == DialogResult.OK)
                {
                    UpdateFilters();
                    comboBox.SelectedIndex = GetFilterSelectId(filter.Name);
                }
            }

        }

        // Кнопка: Удалить правило
        private void buttonDelRules_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
