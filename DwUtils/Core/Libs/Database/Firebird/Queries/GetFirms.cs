using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    public class GetFirms : PostItemSelectQuery<List<FirmFb>>
    {
        public GetFirms(PostItemConnect connect) : base(connect)
        {
        }

        public override string GetQuery()
        {
            return "select dictid, Upper(vals) from dict where dicttypeid = 5 and isvalid = 1 order by Upper(vals)";
        }

        protected override List<FirmFb> ParseResponse(FbDataReader reader)
        {
            List<FirmFb> data = new List<FirmFb>();

            while (reader.Read())
            {
                FirmFb firmFb = new FirmFb
                {
                    Id = reader.GetInt16(0),
                    Name = reader.GetString(1)
                };

                data.Add(firmFb);
            }

            Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
