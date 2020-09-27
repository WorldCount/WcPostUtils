using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ListEditor.Libs;
using ListEditor.Models.RTM;
using WcApi.Ext;

namespace ListEditor.Forms
{
    public partial class EditListForm : Form
    {
        private readonly DataTable _rowsDataTable;

        public EditListForm(List<RtmRow> rows, string title = null)
        {
            InitializeComponent();
            _rowsDataTable = rows.ToDataTable();

            if (title != null)
                // ReSharper disable once VirtualMemberCallInConstructor
                Text = title;

            DataColumn rowsColumn = _rowsDataTable.Columns.Add("_RowString", typeof(string));
            foreach (DataRow dataRow in _rowsDataTable.Rows)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < _rowsDataTable.Columns.Count - 1; i++)
                {
                    sb.Append(dataRow[i]);
                    sb.Append("\t");
                }

                dataRow[rowsColumn] = sb.ToString();
            }
        }

        private void EditListForm_Load(object sender, EventArgs e)
        {
            
            dataGridView.DataSource = _rowsDataTable;
            CheckDataGridView();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            _rowsDataTable.DefaultView.RowFilter = $"[_RowString] LIKE '%{tbFilter.Text}%'";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckDataGridView()
        { 
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCell cellCity = row.Cells[7];
                DataGridViewCell cellRegion = row.Cells[8];
                string city = cellCity.Value.ToString().ToUpper();
                string region = cellRegion.Value.ToString().ToUpper();

                
                if (!CheckRegionCity.Validate(city, region))
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }   
        }
    }
}
