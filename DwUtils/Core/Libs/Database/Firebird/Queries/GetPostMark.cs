using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    public class GetPostMark : PostUnitSelectQuery<List<PostMarkFb>>
    {
        public GetPostMark(PostUnitConnect connect) : base(connect)
        {
        }

        public override string GetQuery()
        {
            return "select pspostmarkid, name, code from pspostmark";
        }

        protected override List<PostMarkFb> ParseResponse(FbDataReader reader)
        {
            List<PostMarkFb> data = new List<PostMarkFb>();

            while (reader.Read())
            {
                PostMarkFb postMarkFb = new PostMarkFb
                {
                    Id = reader.GetInt16(0),
                    Name = reader.GetString(1),
                    Code = reader.GetInt64(2)
                };

                data.Add(postMarkFb);
            }

            Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
