using System;
using System.Windows.Forms;
using AOP.Forms;

namespace AOP
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
            Application.Run(new GeneralForm());
        }
    }
}
