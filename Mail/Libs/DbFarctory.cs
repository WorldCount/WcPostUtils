using System.IO;
using System.Windows.Forms;
using Mail.Libs.Models;
using ServiceStack.OrmLite;

namespace Mail.Libs
{
    public static class DbFarctory
    {

        public static string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        public static readonly string DbPath = Path.Combine(DataDir, Properties.Settings.Default.Database);

        static DbFarctory()
        {
            CreateDb();
        }

        public static OrmLiteConnectionFactory Create()
        {
            return new OrmLiteConnectionFactory(DbPath, SqliteDialect.Provider);
        }

        // Создает базу данных
        public static void CreateDb()
        {
            OrmLiteConnectionFactory dbFactory = Create();

            using (var db = dbFactory.Open())
            {
                db.CreateTableIfNotExists<Filter>();
                db.CreateTableIfNotExists<Email>();
            }
        }
    }
}
