using System.IO;
using System.Windows.Forms;

namespace DwUtils.Core
{
    internal static class PathManager
    {
        // Папки
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.Data);

        // Данные
        public static readonly string DbPath = Path.Combine(DataDir, Properties.Settings.Default.Database);

        //public static readonly string AuthPath = Path.Combine(DataDir, Properties.Settings.Default.AuthFile);

        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);
        }
    }
}
