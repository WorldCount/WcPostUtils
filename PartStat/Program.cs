using System;
using System.Drawing;
using System.Windows.Forms;
using PartStat.Forms;

namespace PartStat
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult result;
            GeneralForm generalForm = new GeneralForm();

            using (LoginForm loginForm = new LoginForm())
            {
                loginForm.WindowBorderColor = Color.SeaGreen;
                loginForm.WindowsBorderStyle = ButtonBorderStyle.Dashed;
                loginForm.AppIcon = generalForm.Icon;
                loginForm.AppText = "PartStat 4";
                loginForm.AppVersion = $"{Application.ProductName} {Application.ProductVersion}";
                loginForm.Verbose = true;
                loginForm.Secret = "6022";
                result = loginForm.ShowDialog();
            }


            if(result == DialogResult.OK)
                Application.Run(generalForm);
        }
    }
}
