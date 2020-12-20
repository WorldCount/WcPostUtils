using System;
using System.Drawing;
using System.Windows.Forms;
using LK.Forms;
using NLog;

namespace LK
{
    static class Program
    {

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
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
                loginForm.WindowBorderColor = Color.Teal;
                loginForm.WindowsBorderStyle = ButtonBorderStyle.Dashed;
                loginForm.AppIcon = generalForm.Icon;
                loginForm.AppText = "Личный кабинет";
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
