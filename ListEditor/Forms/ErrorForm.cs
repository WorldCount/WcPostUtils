using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListEditor.Models;

namespace ListEditor.Forms
{
    public partial class ErrorForm : Form
    {
        private readonly List<Error> _errorList;

        public ErrorForm(List<Error> errorList, string title = null)
        {
            InitializeComponent();
            _errorList = errorList;
            if (title != null)
                // ReSharper disable once VirtualMemberCallInConstructor
                Text = title;
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _errorList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
