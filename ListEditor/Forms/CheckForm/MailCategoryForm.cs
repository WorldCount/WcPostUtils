using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListEditor.Models.Part.Types;

namespace ListEditor.Forms.CheckForm
{
    public partial class MailCategoryForm : Form
    {
        private readonly List<MailCategory> _mailCategories = MailCategories.GetAll();
        private MailCategory _mailCategory;

        public MailCategory MailCategory => _mailCategory;

        public MailCategoryForm()
        {
            InitializeComponent();
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                    if (e.Index != i) checkedListBox.SetItemChecked(i, false);
            _mailCategory = (MailCategory)checkedListBox.Items[e.Index];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MailCategoryForm_Load(object sender, EventArgs e)
        {
            checkedListBox.DataSource = _mailCategories;
            checkedListBox.DisplayMember = "Name";
            checkedListBox.ValueMember = "Id";
            checkedListBox.SetItemChecked(1, true);
            checkedListBox.SelectedIndex = 1;
        }

        private void MailCategoryForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
        }
    }
}
