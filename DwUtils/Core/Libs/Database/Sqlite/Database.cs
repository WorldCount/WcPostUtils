using System;
using System.Threading.Tasks;
using DwUtils.Core.Models.Sqlite;
using SQLite;
using NLog;

namespace DwUtils.Core.Libs.Database.Sqlite
{
    public static class Database
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static bool CreateDb()
        {
            try
            {
                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    if (!TableExist<Delivery>())
                        db.CreateTable<Delivery>();

                    if (!TableExist<MailRank>())
                        db.CreateTable<MailRank>();

                    if (!TableExist<PostMark>())
                        db.CreateTable<PostMark>();

                    if (!TableExist<RpoCategory>())
                        db.CreateTable<RpoCategory>();

                    if (!TableExist<Firm>())
                        db.CreateTable<Firm>();

                    if (!TableExist<Rpo>())
                        db.CreateTable<Rpo>();

                    if (!TableExist<Doc>())
                        db.CreateTable<Doc>();

                    return true;
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }

        public static async Task<bool> CreateDbAsync()
        {
            return await Task.Run(CreateDb);
        }

        public static bool TableExist<T>()
        {
            const string q = "SELECT name FROM sqlite_master WHERE type='table' AND name=?";

            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                SQLiteCommand cmd = db.CreateCommand(q, typeof(T).Name);
                return cmd.ExecuteScalar<string>() != null;
            }
        }
    }
}
