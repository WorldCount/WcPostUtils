using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AOP.Core.Models.DB;
using NLog;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace AOP.Core
{
    public class Database : IDisposable
    {
        private readonly SQLiteConnection _database;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public SQLiteConnection Db => _database;

        public Database()
        {
            _database = new SQLiteConnection(PathManager.DbPath, storeDateTimeAsTicks: false);
        }

        public bool CreateDb()
        {
            if (!TableExist<Rpo>())
            {
                _database.CreateTable<Rpo>();
            }

            try
            {
                

                if (!TableExist<RpoList>())
                {
                    _database.CreateTable<RpoList>();
                }

                return true;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> CreateDbAsync()
        {
            return await Task.Run(CreateDb);
        }

        public bool TableExist<T>()
        {
            const string q = "SELECT name FROM sqlite_master WHERE type='table' AND name=?";
            SQLiteCommand cmd = _database.CreateCommand(q, typeof(T).Name);
            return cmd.ExecuteScalar<string>() != null;
        }

        public void Dispose()
        {
            _database?.Dispose();
        }

        #region Работа со списками

        public List<RpoList> GetRpoLists(DateTime startDate, DateTime endDate, int startNum = 0, int endNum = 0)
        {
           var query = _database.Table<RpoList>().Where(r => r.Date >= startDate).Where(r => r.Date <= endDate);

           if (startNum > 0)
               query = query.Where(r => r.Num >= startNum);

           if (endNum > 0)
               query = query.Where(r => r.Num <= endNum);

           return query.ToList();
        }

        public List<RpoList> GetRpoListsByDate(DateTime startDate, DateTime endDate)
        {
            return GetRpoLists(startDate, endDate);
        }

        #endregion

        #region Работа с РПО

        public List<Rpo> GetRposByRpoList(RpoList rpoList)
        {
            return _database.GetWithChildren<RpoList>(rpoList.Id).Rpos;
        }

        #endregion
    }
}
