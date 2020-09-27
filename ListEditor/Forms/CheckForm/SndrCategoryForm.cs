using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListEditor.Models.Part.Types;

namespace ListEditor.Forms.CheckForm
{
    public partial class SndrCategoryForm : Form
    {
        private SenderCategory _senderCategory;
        private readonly List<SenderCategory> _senderCategories = SenderCategories.GetAll();

        public SenderCategory SenderCategory => _senderCategory;

        public SndrCategoryForm()
        {
            InitializeComponent();
        }

        private void SndrCategoryForm_Load(object sender, EventArgs e)
        {
            checkedListBox.DataSource = _senderCategories;
            checkedListBox.DisplayMember = "Name";
            checkedListBox.ValueMember = "Id";
            checkedListBox.SetItemChecked(2, true);
            checkedListBox.SelectedIndex = 2;
        }

        private void SndrCategoryForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
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

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                    if (e.Index != i) checkedListBox.SetItemChecked(i, false);
            _senderCategory = (SenderCategory)checkedListBox.Items[e.Index];
        }
    }
}
