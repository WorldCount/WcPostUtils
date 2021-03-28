using System;
using System.Drawing;
using System.Windows.Forms;
using DwUtils.Forms;
using NLog;

namespace DwUtils
{
    static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;

            DialogResult result;
            GeneralForm generalForm = new GeneralForm();

            using (LoginForm loginForm = new LoginForm())
            {
                loginForm.WindowBorderColor = Color.FromArgb(255, 67, 74, 84);
                loginForm.WindowsBorderStyle = ButtonBorderStyle.Dashed;
                loginForm.AppIcon = generalForm.Icon;
                loginForm.AppText = "DwUtils";
                loginForm.AppVersion = $"{Application.ProductName} {Application.ProductVersion}";
                loginForm.Verbose = true;
                loginForm.Secret = "6022";
                result = loginForm.ShowDialog();
            }

            if (result == DialogResult.OK)
                Application.Run(new GeneralForm());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Logger.Error($"{e.Exception.Source}: {e.Exception}");
        }
    }
}
