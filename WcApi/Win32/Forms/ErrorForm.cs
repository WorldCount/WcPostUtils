using System;
using System.Windows.Forms;

namespace WcApi.Win32.Forms
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        public ErrorForm(string message, string title, Control parent = null)
        {
            InitializeComponent();

            richTextBox.Text = message;
            // ReSharper disable once VirtualMemberCallInConstructor
            Text = title;
            if (parent != null)
                Parent = parent;
        }

        public ErrorForm Init(string message, string title, Control parent = null)
        {
            richTextBox.Text = message;
            Text = title;
            if(parent != null)
                Parent = parent;
            return this;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    // ReSharper disable once UnusedMember.Global
    public static class ErrorMessageBox
    {
        // ReSharper disable once UnusedMember.Global
        public static void Show(string message, string title, Control parent = null)
        {
            using (ErrorForm form = new ErrorForm(message, title, parent))
            {
                form.ShowDialog(parent);
            }
        }
    }
}
