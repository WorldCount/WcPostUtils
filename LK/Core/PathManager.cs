using System.IO;
using System.Windows.Forms;

namespace LK.Core
{
    public static class PathManager
    {
        // Папки
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.Data);
        public static readonly string ReportPath = Path.Combine(DataDir, "LoadReport");
        public static readonly string Tarif = Path.Combine(DataDir, Properties.Settings.Default.TarifsData);


        // Данные
        public static readonly string DbPath = Path.Combine(DataDir, Properties.Settings.Default.Database);
        public static readonly string AuthPath = Path.Combine(DataDir, Properties.Settings.Default.AuthFile);
        public static readonly string DataColorPath = Path.Combine(DataDir, Properties.Settings.Default.DataColorFile);
        public static readonly string ConfigPath = Path.Combine(DataDir, Properties.Settings.Default.ConfigFile);


        // Тарифы
        public static readonly string NoticeTarifPath = Path.Combine(Tarif, Properties.Settings.Default.NoticeTarifFile);
        public static readonly string MailTarifPath = Path.Combine(Tarif, Properties.Settings.Default.MailTarifFile);
        public static readonly string ParcelTarifPath = Path.Combine(Tarif, Properties.Settings.Default.ParcelTarifFile);
        public static readonly string FirstMailTarifPath = Path.Combine(Tarif, Properties.Settings.Default.FirstMailTarifFile);
        public static readonly string FirstParcelTarifPath = Path.Combine(Tarif, Properties.Settings.Default.FirstParcelTarifFile);
        public static readonly string InterMailTarifPath = Path.Combine(Tarif, Properties.Settings.Default.InterMailTarifFile);
        public static readonly string InterParcelTarifPath = Path.Combine(Tarif, Properties.Settings.Default.InterParcelTarifFile);

        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            if (!File.Exists(Tarif))
                Directory.CreateDirectory(Tarif);
        }
    }
}
