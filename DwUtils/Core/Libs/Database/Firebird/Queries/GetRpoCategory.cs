using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    public class GetRpoCategory : PostUnitSelectQuery<List<RpoCategoryFb>>
    {
        public GetRpoCategory(PostUnitConnect connect) : base(connect)
        {
        }

        public override string GetQuery()
        {
            return "select pstypecategoryid, pstypeid, pscategoryid, name from pstypecategory";
        }

        protected override List<RpoCategoryFb> ParseResponse(FbDataReader reader)
        {
            List<RpoCategoryFb> data = new List<RpoCategoryFb>();

            while (reader.Read())
            {
                RpoCategoryFb rpoCategoryFb = new RpoCategoryFb
                {
                    Id = reader.GetInt16(0),
                    Type = reader.GetInt16(1),
                    Category = reader.GetInt16(2),
                    Name = reader.GetString(3)
                };

                data.Add(rpoCategoryFb);
            }

            Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
