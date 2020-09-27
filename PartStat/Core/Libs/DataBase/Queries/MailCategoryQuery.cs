using System;
using System.Collections.Generic;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Libs.DataBase.Queries.Base;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Libs.DataBase.Queries
{
    public class MailCategoryQuery : Query
    {
        public MailCategoryQuery(Connect connect) : base(connect) { }

        public new string GetQuery()
        {
            return "select kategid, kategname from artkateg where kategid > 0 order by kategid";
        }

        public List<MailCategory> Run()
        {
            string query = GetQuery();

            Logger.Debug($"Запрос в БД: {query}");

            List<MailCategory> mailCategories = new List<MailCategory>();
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
                    MailCategory mailCategory = new MailCategory
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        ShortName = reader.GetString(1)
                    };
                    mailCategories.Add(mailCategory);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос вернул записей: {mailCategories.Count}");
                return mailCategories;
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
