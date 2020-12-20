using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Libs.DataBase.Queries.Base;
using PartStat.Core.Libs.DataBase.Queries.RequestObject;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Libs.DataBase.Queries.Report
{
    public class CustomReportQuery : Query
    {
        private readonly CustomReportRequest _request;

        public CustomReportQuery(Connect connect, CustomReportRequest request) : base(connect)
        {
            _request = request;
        }

        public new List<string> GetQuery()
        {
            List<string> queries = new List<string>();

            foreach (Firm firm in _request.Firms)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("select firm.firm_name, s.arttypeid, s.kategid, s.parc_count, s.summassrate, s.sumvalue, s.postmark, s.transtypeid, s.ncodecountry, s.res, s.paytypeid, s.paysubtype");
                sb.Append(" from spiski s left join firms firm on s.inn = firm.inn and s.depcode = firm.depcode");
                sb.Append($" where s.parc_count > 0 and s.dapo >= '{_request.InDate.ToShortDateString()}' and s.dapo <= '{_request.OutDate.ToShortDateString()}'");

                if (!string.IsNullOrEmpty(firm.Inn))
                    sb.Append($" and s.inn = '{firm.Inn}' and s.kpp = '{firm.Kpp}' and s.depcode = '{firm.DepCode}'");

                sb.Append(" order by firm.firm_name");

                queries.Add(sb.ToString());
            }

            return queries;
        }

        public List<FirmList> Run(int nds, int value, double interNoticeRate = 0)
        {
            List<FirmList> firmLists = new List<FirmList>();
            FbConnection fbConnection = null;
            double fullNds = (double)nds / 100 + 1;
            double fullValue = (double)value / 100;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при открытии БД: {e}");
                Logger.Error(e.Message);
                return null;
            }

            FbTransaction fbTransaction = fbConnection.BeginTransaction();
            string q = "";

            try
            {
                foreach (string query in GetQuery())
                {
                    Logger.Debug($"Запрос в БД: {query}");
                    q = query;

                    FbCommand selectCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                    FbDataReader reader = selectCommand.ExecuteReader();

                    List<FirmList> localFirmList = new List<FirmList>();

                    while (reader.Read())
                    {
                        double massRate = reader.GetDouble(4);

                        FirmList firmList = new FirmList
                        {
                            FirmName = reader.GetString(0).ToUpper(),
                            MailType = reader.GetInt32(1),
                            MailCategory = reader.GetInt32(2),
                            Count = reader.GetInt32(3),
                            Value = reader.GetDouble(5),
                            PostMark = reader.GetInt32(6),
                            TransType = reader.GetInt32(7),
                            CodeCountry = reader.GetInt32(8),
                            Manual = string.IsNullOrEmpty(reader.GetString(9)),
                            PayType = reader.GetInt32(10),
                            SubPayType = reader.GetInt32(11)
                        };

                        firmList.MassRate = firmList.PayName.ToLower() == "марки" ? massRate : Math.Round(massRate / fullNds, 2);
                        if (firmList.MailCategory == 2 || firmList.MailCategory == 4)
                            firmList.MassRate += firmList.Value * fullValue;

                        if (firmList.IsSimpleNotice() && firmList.IsInter())
                            firmList.MassRate += firmList.Count * interNoticeRate;

                        localFirmList.Add(firmList);
                    }

                    firmLists.AddRange(localFirmList);
                    Logger.Debug($"Запрос вернул записей: {localFirmList.Count}");
                    reader.Close();
                    selectCommand.Dispose();
                }

                fbTransaction.Commit();
                return firmLists;
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при запросе: {q}");
                Logger.Error(e);
                Logger.Error(e.Message);

                fbTransaction?.Rollback();
                return null;
            }
            finally
            {
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }
    }
}
