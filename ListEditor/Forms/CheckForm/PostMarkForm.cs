using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ListEditor.Models.Part.Types;

namespace ListEditor.Forms.CheckForm
{
    public partial class PostMarkForm : Form
    {
        private long _postMarkMask;

        public long PostMarkMask => _postMarkMask;

        public PostMarkForm(string postMarkMask)
        {
            InitializeComponent();

            try
            {
                _postMarkMask = long.Parse(postMarkMask);
            }
            catch
            {
                _postMarkMask = 0;
            }

            ToolTip toolTipCheck = new ToolTip();
            ToolTip toolTipUncheck = new ToolTip();
            ToolTip toolTipSubmit = new ToolTip();
            ToolTip toolTipCancel = new ToolTip();

            toolTipCheck.SetToolTip(btnCheck, "Поставить все отметки [Ctrl + A]");
            toolTipUncheck.SetToolTip(btnUncheck, "Снять все отметки [Ctrl + D]");
            toolTipSubmit.SetToolTip(btnSubmit, "Сохранить [Ctrl + S]");
            toolTipCancel.SetToolTip(btnCancel, "Отмена [Esc]");
        }

        private void ParsePostMark()
        {
            long[] marks = PostMarks.GetFlags(_postMarkMask);
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (marks.Contains(((PostMark) checkedListBox.Items[i]).Id))
                    checkedListBox.SetItemChecked(i, true);
            }

            lblMask.Text = _postMarkMask.ToString();
        }

        private void PostMarkForm_Load(object sender, EventArgs e)
        {
            List<PostMark> postMarks = PostMarks.GetAllStandart();
            checkedListBox.DataSource = postMarks;
            checkedListBox.DisplayMember = "Name";
            checkedListBox.ValueMember = "Id";

            ParsePostMark();
        }

        private void CheckAll()
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }

        private void UncheckAll()
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            UncheckAll();
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            _postMarkMask = 0;

            foreach (PostMark postMark in checkedListBox.CheckedItems)
                _postMarkMask += postMark.Id;

            if (e.NewValue == CheckState.Checked)
                _postMarkMask += ((PostMark) checkedListBox.Items[e.Index]).Id;
            else
                _postMarkMask -= ((PostMark)checkedListBox.Items[e.Index]).Id;

            lblMask.Text = _postMarkMask.ToString();
        }

        private void PostMarkForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + A
            if (e.KeyCode == Keys.A && e.Control)
            {
                CheckAll();
            }

            // Нажатие Ctrl + D
            if (e.KeyCode == Keys.D && e.Control)
            {
               UncheckAll();
            }

            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSubmit.PerformClick();
            }

            // Нажатие Ecs
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }
    }
}
