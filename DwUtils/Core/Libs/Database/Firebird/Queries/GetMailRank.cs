using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    public class GetMailRank : PostUnitSelectQuery<List<MailRankFb>>
    {
        public GetMailRank(PostUnitConnect connect) : base(connect)
        {
        }

        public override string GetQuery()
        {
            return "select psmailrankid, name, code from psmailrank";
        }

        protected override List<MailRankFb> ParseResponse(FbDataReader reader)
        {
            List<MailRankFb> data = new List<MailRankFb>();

            while (reader.Read())
            {
                MailRankFb mailRankFb = new MailRankFb
                {
                    Id = reader.GetInt16(0),
                    Name = reader.GetString(1),
                    Code = reader.GetInt16(2)
                };

                data.Add(mailRankFb);
            }

            Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
