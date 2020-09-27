using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Models.DB.Queries.Base;
using PartStat.Core.Models.DB.Queries.RequestObject;
using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Models.DB.Queries
{
    public class FirmListQuery : Query
    {
        private readonly FirmRequest _request;

        public FirmListQuery(Connect connect, FirmRequest request) : base(connect)
        {
            _request = request;
        }

        public new string GetQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select s.dapo, firm.firm_name, s.nspi, s.inn, s.kpp, s.depcode, s.arttypeid, s.kategid, s.parc_count, s.parc_back, count(f.err), s.summassrate, s.sumvalue, s.postmark, s.statusspiid, s.transtypeid, s.ncodecountry, s.res, s.paytypeid, s.paysubtype from spiski s");
            sb.Append(" left join form_103 f on f.dapo = s.dapo and f.nspi = s.nspi and f.inn = s.inn and f.err = 'E'");
            sb.Append(" left join firms firm on s.inn = firm.inn and s.depcode = firm.depcode");
            sb.Append($" where s.parc_count > 0 and s.dapo >= '{_request.InDate.ToShortDateString()}' and s.dapo <= '{_request.OutDate.ToShortDateString()}'");

            if (!string.IsNullOrEmpty(_request.Inn))
                sb.Append($" and s.inn = '{_request.Inn}'");

            if (!string.IsNullOrEmpty(_request.Kpp))
                sb.Append($" and s.kpp = '{_request.Kpp}'");

            if (!string.IsNullOrEmpty(_request.DepCode))
                sb.Append($" and s.depcode = '{_request.DepCode}'");

            if (!string.IsNullOrEmpty(_request.StartNum))
                sb.Append($" and s.nspi >= {_request.StartNum}");

            if (!string.IsNullOrEmpty(_request.EndNum))
                sb.Append($" and s.nspi <= {_request.EndNum}");

            if (_request.MailType > 0)
                sb.Append($" and s.arttypeid = {_request.MailType}");

            if (_request.MailCategory > 0)
                sb.Append($" and s.kategid = {_request.MailCategory}");

            if (_request.Status != 'A')
                sb.Append($" and s.statusspiid = '{_request.Status}'");

            if (_request.InterCode >= 0)
                sb.Append($" and s.ncodecountry = {_request.InterCode}");

            if (_request.CreateListType == CreateListType.Ручка)
                sb.Append(" and s.res is Null");

            if (_request.CreateListType == CreateListType.Файлы)
                sb.Append(" and s.res is Not Null");

            sb.Append(" group by s.inn, firm.firm_name, s.kpp, s.depcode, s.nspi, f.err, s.dapo, s.arttypeid, s.kategid, s.parc_count, s.parc_back, s.summassrate, s.sumvalue, s.postmark, s.statusspiid, s.transtypeid, s.ncodecountry, s.res, s.paytypeid, s.paysubtype");
            sb.Append(" order by firm.firm_name, s.dapo, s.nspi");

            return sb.ToString();
        }

        public List<FirmList> Run(int nds, int value, ErrorType errorType = ErrorType.ВСЕ, double interNoticeRate = 0)
        {
            string query = GetQuery();

            Logger.Debug($"Запрос в БД: {query}");

            List<FirmList> firmLists = new List<FirmList>();

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;
            double fullNds = (double)nds / 100 + 1;
            double fullValue = (double)value / 100;

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
                    double massRate = reader.GetDouble(11);

                    FirmList firmList = new FirmList
                    {
                        Date = reader.GetDateTime(0),
                        FirmName = reader.GetString(1).ToUpper(),
                        Num = reader.GetInt32(2),
                        Inn = reader.GetString(3),
                        Kpp = reader.GetString(4),
                        DepCode = reader.GetString(5),
                        MailType = reader.GetInt32(6),
                        MailCategory = reader.GetInt32(7),
                        Count = reader.GetInt32(8),
                        ErrCount = reader.GetInt32(9),
                        WarnCount = reader.GetInt32(10),
                        Value = reader.GetDouble(12),
                        PostMark = reader.GetInt64(13),
                        Status = reader.GetChar(14),
                        TransType = reader.GetInt32(15),
                        CodeCountry = reader.GetInt32(16),
                        Manual = string.IsNullOrEmpty(reader.GetString(17)),
                        PayType = reader.GetInt32(18),
                        SubPayType = reader.GetInt32(19)
                    };

                    if (errorType != ErrorType.ВСЕ)
                    {
                        if (errorType == ErrorType.Замечания)
                            if (firmList.WarnCount == 0)
                                continue;

                        if (errorType == ErrorType.Выбывшие)
                            if (firmList.ErrCount == 0)
                                continue;

                        if (errorType == ErrorType.Нет)
                            if (firmList.ErrCount > 0 || firmList.WarnCount > 0)
                                continue;
                    }

                    firmList.MassRate = firmList.PayName.ToLower() == "марки" ? massRate : Math.Round(massRate / fullNds, 2);
                    if (firmList.MailCategory == 2 || firmList.MailCategory == 4)
                        firmList.MassRate += firmList.Value * fullValue;

                    if (firmList.IsSimpleNotice() && firmList.IsInter())
                        firmList.MassRate += firmList.Count * interNoticeRate;

                    firmLists.Add(firmList);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос вернул записей: {firmLists.Count}");
                return firmLists;
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
