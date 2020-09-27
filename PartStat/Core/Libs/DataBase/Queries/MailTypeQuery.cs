using System;
using System.Collections.Generic;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Libs.DataBase.Queries.Base;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Libs.DataBase.Queries
{
    public class MailTypeQuery : Query
    {
        public MailTypeQuery(Connect connect) : base(connect) { }

        public new string GetQuery()
        {
            return "select arttypeid, arttypename from arttype where arttypeid > 0 order by arttypeid";
        }

        public List<MailType> Run()
        {
            string query = GetQuery();
            Logger.Debug($"Запрос в БД: {query}");

            List<MailType> mailTypes = new List<MailType>();
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
                    MailType mailType = new MailType
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        ShortName = reader.GetString(1)
                    };
                    mailTypes.Add(mailType);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос вернул записей: {mailTypes.Count}");
                return mailTypes;
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
