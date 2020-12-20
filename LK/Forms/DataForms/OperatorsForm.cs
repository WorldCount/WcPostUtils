using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LK.Core.Models.DB;
using LK.Core.Store;

namespace LK.Forms.DataForms
{
    public partial class OperatorsForm : Form
    {
        private List<Operator> _operators;

        public OperatorsForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Организации";

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _operators = LoadData();
            UpdateData();
        }

        public void InitTable()
        {
            fullNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            lastNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            lastNameDataGridViewTextBoxColumn.Width = 160;

            firstNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firstNameDataGridViewTextBoxColumn.Width = 160;

            middleNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            middleNameDataGridViewTextBoxColumn.Width = 160;
        }

        public List<Operator> LoadData()
        {
            return Database.GetAllOperator();
        }

        public void SaveData()
        {
            Database.UpdateOperators(_operators);
        }

        public void UpdateData()
        {
            operatorBindingSource.DataSource = null;
            operatorBindingSource.DataSource = _operators;
            lblCount.Text = $"{_operators.Count} шт";
        }

        public Operator GetOperatorByRowIndex(int rowIndex)
        {
            try
            {
                List<Operator> operators = (List<Operator>) operatorBindingSource.DataSource;

                if (operators != null && operators.Count > 0)
                {
                    Operator oper = operators[rowIndex];
                    return oper;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _operators = LoadData();
            UpdateData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OperatorsForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == fullNameDataGridViewTextBoxColumn.Index && e.RowIndex >= 0)
            {
                Operator oper = GetOperatorByRowIndex(e.RowIndex);

                if (oper != null)
                {
                    string[] names = oper.FullName.Split(' ');
                    if (names.Length > 2)
                    {
                        oper.LastName = names[0];
                        oper.FirstName = names[1];
                        oper.MiddleName = names[2];
                    }
                }
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string q = tbFilter.Text.ToUpper();

            if (!string.IsNullOrEmpty(q))
            {
                List<Operator> filtered = _operators.Where(m => m.LastName.ToUpper().Contains(q) || m.FirstName.ToUpper().Contains(q) || m.MiddleName.ToUpper().Contains(q) || m.FullName.ToUpper().Contains(q)).ToList();
                operatorBindingSource.DataSource = filtered;
                lblCount.Text = $"{filtered.Count} шт";
            }
            else
            {
                operatorBindingSource.DataSource = _operators;
                lblCount.Text = $"{_operators.Count} шт";
            }
        }
    }
}
