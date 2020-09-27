using System;
using System.Collections.Generic;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Models.DB.Queries.Base;

namespace PartStat.Core.Models.DB.Queries
{
    public class ListStatusQuery : Query
    {
        public ListStatusQuery(Connect connect) : base(connect) { }

        public new string GetQuery()
        {
            return "select statusspiid, statusspiname from statusspiska order by statusspiid";
        }

        public List<ListStatus> Run()
        {
            string query = GetQuery();
            Logger.Debug($"Запрос в БД: {query}");

            List<ListStatus> listStatuses = new List<ListStatus>();
            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand selectCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    ListStatus listStatus = new ListStatus
                    {
                        Id = reader.GetChar(0),
                        Name = reader.GetString(1),
                    };
                    listStatuses.Add(listStatus);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос вернул записей: {listStatuses.Count}");
                return listStatuses;
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при запросе: {query}");
                Logger.Error(e);
                Logger.Error(e.Message);

                fbTransaction?.Rollback();
                return null;
            }
            finally
            {
                reader?.Close();
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }
    }
}
