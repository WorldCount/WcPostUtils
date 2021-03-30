using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using PartStat.Core.Libs.DataBase.Queries.Base;
using PartStat.Core.Libs.DataBase.Queries.RequestObject;
using PartStat.Core.Models.DB;
using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Libs.DataBase.Queries
{
    public class BarcodeQuery : Query
    {
        private readonly BarcodeRequest _request;

        public BarcodeQuery(Connect connect, BarcodeRequest request) : base(connect)
        {
            _request = request;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select FIRST 1 f.DAPO, f.NSPI, f.INN, f.kpp, f.depcode, firm.FIRM_NAME from form_103 f");
            sb.Append(" inner join firms firm on f.INN = firm.INN");
            sb.Append($" where barcode = '{_request.Barcode}'");

            if (!string.IsNullOrEmpty(_request.Inn))
                sb.Append($" and f.INN = '{_request.Inn}' and f.dapo >= '{_request.InDate.ToShortDateString()}' and f.dapo <= '{_request.OutDate.ToShortDateString()}'");

            if (!string.IsNullOrEmpty(_request.Kpp))
                sb.Append($" and f.KPP = '{_request.Kpp}'");

            if (!string.IsNullOrEmpty(_request.DepCode))
                sb.Append($" and f.DepCode = '{_request.DepCode}'");

            return sb.ToString();
        }

        public FirmList Run(int nds, int value, ErrorType errorType = ErrorType.ВСЕ, double interNoticeRate = 0)
        {
            string query = GetQuery();
            Logger.Debug($"Запрос в БД: {query}");

            FirmRequest queryObject = new FirmRequest();

            FirmList firmList = new FirmList();

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
                    queryObject = new FirmRequest
                    {
                        InDate = reader.GetDateTime(0),
                        OutDate = reader.GetDateTime(0),
                        StartNum = reader.GetString(1),
                        EndNum = reader.GetString(1),
                        Inn = reader.GetString(2),
                        Kpp = reader.GetString(3),
                        DepCode = reader.GetString(4),
                        Status = 'A'
                    };
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                FirmListQuery firmListQuery = new FirmListQuery(Connect, queryObject);
                List<FirmList> firmLists = firmListQuery.Run(nds, value, errorType, interNoticeRate);

                Logger.Debug($"Запрос вернул записей: {firmLists.Count}");

                if (firmLists.Count > 0)
                    firmList = firmLists[0];
                return firmList;
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
