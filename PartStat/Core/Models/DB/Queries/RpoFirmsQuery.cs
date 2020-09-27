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
    public class RpoFirmsQuery : Query
    {
        private readonly RpoRequest _request;

        public RpoFirmsQuery(Connect connect, RpoRequest request) : base(connect)
        {
            _request = request;
        }

        public new string GetQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select f.indexto, f.massrate + f.airrate, f.value_, count(*), s.arttypeid, s.kategid, s.postmark, s.paytypeid, s.paysubtype, s.ncodecountry, s.res from form_103 f");
            sb.Append(" left join spiski s on s.dapo = f.dapo and s.nspi = f.nspi and s.inn = f.inn");
            sb.Append($" where f.dapo = '{_request.Date.ToShortDateString()}'");

            if (!string.IsNullOrEmpty(_request.Inn))
                sb.Append($" and s.inn = '{_request.Inn}'");

            if (!string.IsNullOrEmpty(_request.Kpp))
                sb.Append($" and s.kpp = '{_request.Kpp}'");

            if (!string.IsNullOrEmpty(_request.DepCode))
                sb.Append($" and s.depcode = '{_request.DepCode}'");

            if (_request.MailType > 0)
                sb.Append($" and s.arttypeid = {_request.MailType}");

            if (_request.MailCategory > 0)
                sb.Append($" and s.kategid = {_request.MailCategory}");

            if (_request.InterCode >= 0)
                sb.Append($" and s.ncodecountry = {_request.InterCode}");

            if (!string.IsNullOrEmpty(_request.NumsList))
                sb.Append($" and f.nspi in ({_request.NumsList})");

            if (_request.Status != 'A')
                sb.Append($" and s.statusspiid = '{_request.Status}'");

            if (_request.CreateListType == CreateListType.Ручка)
                sb.Append(" and s.res is Null");

            if (_request.CreateListType == CreateListType.Файлы)
                sb.Append(" and s.res is Not Null");

            sb.Append(" group by f.massrate, f.airrate, f.value_, s.arttypeid, s.kategid, s.postmark, s.paytypeid, s.paysubtype, f.indexto, s.ncodecountry, s.res");
            sb.Append(" order by f.massrate");

            return sb.ToString();
        }

        public List<Rpo> Run(int nds, int value)
        {
            string query = GetQuery();
            Logger.Debug($"Запрос в БД: {query}");

            List<Rpo> rpos = new List<Rpo>();

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
                    double massRate = reader.GetDouble(1);

                    Rpo rpo = new Rpo()
                    {
                        Index = reader.GetString(0),
                        MassRate = reader.GetDouble(1),
                        Value = reader.GetDouble(2),
                        Count = reader.GetInt32(3),
                        MailType = reader.GetInt32(4),
                        MailCategory = reader.GetInt32(5),
                        PostMark = reader.GetInt64(6),
                        PayType = reader.GetInt32(7),
                        SubPayType = reader.GetInt32(8),
                        CodeCountry = reader.GetInt32(9),
                        Res = reader.GetString(10)
                    };

                    rpo.MassRate = rpo.PayName.ToLower() == "марки" ? massRate : Math.Round(massRate / fullNds, 2);

                    if (rpo.MailCategory == 2 || rpo.MailCategory == 4)
                        rpo.MassRate += rpo.Value * fullValue;

                    rpos.Add(rpo);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                Logger.Debug($"Запрос вернул записей: {rpos.Count}");
                return rpos;
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
