using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListEditor.Models.Part.Types;

namespace ListEditor.Forms.CheckForm
{
    public partial class PayTypeForm : Form
    {
        private readonly List<PayType> _payTypes = PayTypes.GetAll();
        private PayType _payType;

        public PayType PayType => _payType;

        public PayTypeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PayTypeForm_Load(object sender, EventArgs e)
        {
            checkedListBox.DataSource = _payTypes;
            checkedListBox.DisplayMember = "Name";
            checkedListBox.ValueMember = "Id";
            checkedListBox.SetItemChecked(1, true);
            checkedListBox.SelectedIndex = 1;
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                    if(e.Index != i) checkedListBox.SetItemChecked(i, false);
                _payType = (PayType) checkedListBox.Items[e.Index];
        }

        private void PayTypeForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
        }
    }
}
