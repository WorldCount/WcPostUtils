using System;
using System.Collections.Generic;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Libs.DataBase.Queries.Base;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Libs.DataBase.Queries
{
    public class FirmQuery : Query
    {
        public FirmQuery(Connect connect) : base(connect) { }

        public new string GetQuery()
        {
            return "select inn, firm_name, numdog, depcode, kpp, sendtypeid, login, passw from firms order by firm_name";
        }

        public List<Firm> Run()
        {
            string query = GetQuery();

            Logger.Debug($"Запрос в БД: {query}");

            List<Firm> firms = new List<Firm>();
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
                    Firm firm = new Firm
                    {
                        Inn = reader.GetString(0),
                        Name = reader.GetString(1).ToUpper(),
                        NumDog = reader.GetString(2),
                        DepCode = reader.GetString(3),
                        Kpp = reader.GetString(4),
                        SenderType = reader.GetInt32(5),
                        Login = reader.GetString(6),
                        Password = reader.GetString(7)
                    };
                    firms.Add(firm);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос вернул записей: {firms.Count}");
                return firms;
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
