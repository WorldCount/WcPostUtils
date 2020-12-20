using System.IO;
using System.Windows.Forms;

namespace AOP.Core
{
    public static class PathManager
    {
        // Папки
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.Data);
        public static readonly string TemplateDir = Path.Combine(DataDir, Properties.Settings.Default.Template);
        public static readonly string LastOpenDir = Path.Combine(Properties.Settings.Default.LastOpenDir);

        // Шаблоны
        public static readonly string A4Template = Path.Combine(TemplateDir, "A4.docx");
        public static readonly string C5Template = Path.Combine(TemplateDir, "C5.docx");
        public static readonly string ExcelTemplate = Path.Combine(TemplateDir, "Excel.xls");

        // Данные
        public static readonly string DbPath = Path.Combine(DataDir, Properties.Settings.Default.Database);
        public static readonly string MailCategoryPath = Path.Combine(DataDir, Properties.Settings.Default.MailCategoryFile);
        public static readonly string MailTypePath = Path.Combine(DataDir, Properties.Settings.Default.MailTypeFile);

        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            if (!File.Exists(TemplateDir))
                Directory.CreateDirectory(TemplateDir);
        }
    }
}
