
namespace LK.Core.Store.Connect
{
    public static class DbConnect
    {
        public static SQLite.SQLiteConnection GetConnection()
        {
            return new SQLite.SQLiteConnection(PathManager.DbPath, false);
        }

        public static Microsoft.Data.Sqlite.SqliteConnection GetManualConnection()
        {
            return new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={PathManager.DbPath}");
        }
    }
}
