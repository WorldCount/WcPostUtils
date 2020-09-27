using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListEditor.Models.Part.Types;

namespace ListEditor.Forms.CheckForm
{
    public partial class MailTypeForm : Form
    {
        private readonly List<MailType> _mailTypes = MailTypes.GetAllStandart();
        private MailType _mailType;

        public MailType MailType => _mailType;

        public MailTypeForm()
        {
            InitializeComponent();
        }

        private void MailTypeForm_Load(object sender, EventArgs e)
        {
            checkedListBox.DataSource = _mailTypes;
            checkedListBox.DisplayMember = "Name";
            checkedListBox.ValueMember = "Id";
            checkedListBox.SetItemChecked(0, true);
            checkedListBox.SelectedIndex = 0;
        }

        private void MailTypeForm_KeyDown(object sender, KeyEventArgs e)
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
            _mailType = (MailType)checkedListBox.Items[e.Index];
        }
    }
}
