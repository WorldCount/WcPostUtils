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
        public static readonly string AuthPath = Path.Combine(DataDir, Properties.Settings.Default.AuthFile);
        public static readonly string PostItemConnectPath = Path.Combine(DataDir, Properties.Settings.Default.PostItemConnectFile);
        public static readonly string PostUnitConnectPath = Path.Combine(DataDir, Properties.Settings.Default.PostUnitConnectFile);

        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);
        }
    }
}
