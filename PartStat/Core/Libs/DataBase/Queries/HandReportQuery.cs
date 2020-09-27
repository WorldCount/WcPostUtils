using System;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Libs.DataBase.Queries.Base;
using PartStat.Core.Libs.DataBase.Queries.RequestObject;
using PartStat.Core.Models.DataReports;

namespace PartStat.Core.Libs.DataBase.Queries
{
    public class HandReportQuery : Query
    {
        private readonly HandReportRequest _request;

        public HandReportQuery(Connect connect, HandReportRequest request) : base(connect)
        {
            _request = request;
        }

        public new string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select s.dapo, s.parc_count, s.summassrate, s.res from spiski s");
            sb.Append($" where s.parc_count > 0 and s.dapo >= '{_request.InDate.ToShortDateString()}' and s.dapo <= '{_request.OutDate.ToShortDateString()}'");
            sb.Append(" order by s.dapo");

            return sb.ToString();
        }

        public HandReportList Run()
        {
            string query = GetQuery();

            Logger.Debug($"Запрос в БД: {query}");

            HandReportList handReportList = new HandReportList();
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
                    HandReport report = new HandReport
                    {
                        Date = reader.GetDateTime(0),
                        AllCount = reader.GetInt32(1),
                        PaySum = reader.GetDouble(2)
                    };

                    string s = reader.GetString(3);
                    if (string.IsNullOrEmpty(s))
                    {
                        report.HandCount = report.AllCount;
                    }
                    else
                    {
                        report.NormalCount = report.AllCount;
                    }

                    handReportList.Add(report);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос вернул записей: {handReportList.Count}");
                return handReportList;
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
