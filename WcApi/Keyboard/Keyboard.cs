using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WcApi.Keyboard
{
    public static class Keyboard
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowThreadProcessId([In] IntPtr hWnd,[Out, Optional] IntPtr lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern ushort GetKeyboardLayout([In] int idThread);

        /// <summary>
        /// Вернёт Id раскладки
        /// </summary>
        public static ushort GetKeyboardLayout()
        {
            return GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), IntPtr.Zero));
        }

        /// <summary>
        /// Вернет обозначение раскладки
        /// </summary>
        /// <returns>Строка</returns>
        public static string GetKeyboardLayoutName()
        {
            return GetKeyboardLayout() == 1033 ? "EN" : "RU";
        }

        /// <summary>
        /// Возвращает английский язык ввода
        /// </summary>
        /// <returns>Язык ввода</returns>
        public static InputLanguage GetEnglishLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName != null && lang.Culture.EnglishName.ToLower().Contains("english"))
                    return lang;
            }

            return null;
        }

        /// <summary>
        /// Устанавливает английский язык ввода
        /// </summary>
        public static void SetEnglishLanguage()
        {
            InputLanguage lang = GetEnglishLanguage();
            if (lang != null)
                InputLanguage.CurrentInputLanguage = lang;
        }

        /// <summary>
        /// Возвращает русский язык ввода
        /// </summary>
        /// <returns>Язык ввода</returns>
        public static InputLanguage GetRussianLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName != null && lang.Culture.EnglishName.ToLower().Contains("russian"))
                    return lang;
            }

            return null;
        }

        /// <summary>
        /// Устанавливает русский язык ввода
        /// </summary>
        public static void SetRussianLanguage()
        {
            InputLanguage lang = GetRussianLanguage();
            if (lang != null)
                InputLanguage.CurrentInputLanguage = lang;
        }
    }
}
