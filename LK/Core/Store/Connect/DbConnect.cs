using SQLite;

namespace LK.Core.Store.Connect
{
    public static class DbConnect
    {
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(PathManager.DbPath, false);
        }

        public static System.Data.SQLite.SQLiteConnection GetManualConnection()
        {
            return new System.Data.SQLite.SQLiteConnection($"Data Source={PathManager.DbPath}; Version=3;");
        }
    }
}
