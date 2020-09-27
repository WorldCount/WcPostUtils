using System;
using System.Windows.Forms;

namespace Installer.Forms
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        public ErrorForm(string message, string title)
        {
            InitializeComponent();

            richTextBox.Text = message;
            // ReSharper disable once VirtualMemberCallInConstructor
            Text = title;
        }

        public ErrorForm Init(string message, string title)
        {
            richTextBox.Text = message;
            Text = title;
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
        public static void Show(string message, string title)
        {
            using (ErrorForm form = new ErrorForm(message, title))
            {
                form.ShowDialog();
            }
        }
    }
}
