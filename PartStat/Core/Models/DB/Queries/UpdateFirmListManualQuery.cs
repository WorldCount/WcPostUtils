using System;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Models.DB.Queries.Base;

namespace PartStat.Core.Models.DB.Queries
{
    public class UpdateFirmListManualQuery : Query
    {

        private readonly FirmList _firmList;
        private readonly string _res;

        public UpdateFirmListManualQuery(Connect connect, FirmList firmList, string res = "") : base(connect)
        {
            _firmList = firmList;
            _res = res;
        }

        public new string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.IsNullOrEmpty(_res) ? $"update spiski set res = null" : $"update spiski set res = '{_res}'");
            sb.Append($" where parc_count > 0 and dapo >= '{_firmList.Date.ToShortDateString()}' and dapo <= '{_firmList.Date.ToShortDateString()}' and inn = '{_firmList.Inn}' and kpp = '{_firmList.Kpp}' and depcode = '{_firmList.DepCode}' and nspi = {_firmList.Num}");
            return sb.ToString();
        }

        public bool Run()
        {
            string query = GetQuery();
            Logger.Debug($"Запрос в БД: {query}");

            FbConnection fbConnection = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand updateCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                int count = updateCommand.ExecuteNonQuery();

                updateCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос обновил записей: {count}");

                return count > 0;
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при запросе: {query}");
                Logger.Error(e);
                Logger.Error(e.Message);

                fbTransaction?.Rollback();
                return false;
            }
            finally
            {
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }
    }
}
