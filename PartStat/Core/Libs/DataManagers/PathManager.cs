using System.IO;
using System.Windows.Forms;

namespace PartStat.Core.Libs.DataManagers
{
    public static class PathManager
    {
        public static readonly string Data = Path.Combine(Application.StartupPath, Properties.Settings.Default.Data);
        public static readonly string Tarif = Path.Combine(Data, Properties.Settings.Default.TarifsData);

        // Данные
        public static readonly string ConnectPath = Path.Combine(Data, Properties.Settings.Default.ConnectFile);
        public static readonly string MailCategoryPath = Path.Combine(Data, Properties.Settings.Default.MailCategoryFile);
        public static readonly string MailTypePath = Path.Combine(Data, Properties.Settings.Default.MailTypeFile);
        public static readonly string ListStatusPath = Path.Combine(Data, Properties.Settings.Default.ListStatusFile);
        public static readonly string DataColorPath = Path.Combine(Data, Properties.Settings.Default.DataColorFile);
        public static readonly string ConfigPath = Path.Combine(Data, Properties.Settings.Default.ConfigFile);

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
            if (!File.Exists(Data))
                Directory.CreateDirectory(Data);

            if (!File.Exists(Tarif))
                Directory.CreateDirectory(Tarif);
        }
    }
}
