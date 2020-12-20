using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Libs.DataBase.Queries.Base;
using PartStat.Core.Libs.DataBase.Queries.RequestObject;
using PartStat.Core.Models.DataReports;

namespace PartStat.Core.Libs.DataBase.Queries.Report
{
    public class MassReportQuery : Query
    {
        private readonly MassReportRequest _request;

        public MassReportQuery(Connect connect, MassReportRequest request) : base(connect)
        {
            _request = request;
        }

        public new string GetQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select dapo, count(*), sum(mass) from form_103");
            sb.Append($" where dapo >= '{_request.InDate}' and dapo <= '{_request.OutDate}'");

            if (_request.Firm != null)
            {
                if (!string.IsNullOrEmpty(_request.Firm.Inn))
                    sb.Append($" and inn = '{_request.Firm.Inn}'");

                if (!string.IsNullOrEmpty(_request.Firm.Kpp))
                    sb.Append($" and kpp = '{_request.Firm.Kpp}'");

                if (!string.IsNullOrEmpty(_request.Firm.DepCode))
                    sb.Append($" and depcode = '{_request.Firm.DepCode}'");
            }

            sb.Append(" group by dapo order by dapo");
            return sb.ToString();
        }

        public List<MassReport> Run()
        {
            string query = GetQuery();
            List<MassReport> reports = new List<MassReport>();

            Logger.Debug($"Запрос в БД: {query}");

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
                    MassReport report = new MassReport
                    {
                        Date = reader.GetDateTime(0),
                        Count = reader.GetInt32(1),
                        Mass = reader.GetDouble(2)
                    };

                    reports.Add(report);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос вернул записей: {reports.Count}");
                return reports;
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
