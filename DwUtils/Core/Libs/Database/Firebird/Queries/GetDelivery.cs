using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    class GetDelivery : PostUnitSelectQuery<List<DeliveryFb>>
    {
        public GetDelivery(PostUnitConnect connect) : base(connect)
        {
        }

        public override string GetQuery()
        {
            return "select * from psissuetype";
        }

        protected override List<DeliveryFb> ParseResponse(FbDataReader reader)
        {
            List<DeliveryFb> data = new List<DeliveryFb>();

            while (reader.Read())
            {
                DeliveryFb deliveryFb = new DeliveryFb
                {
                    Id = reader.GetInt16(0),
                    Name = reader.GetName(1),
                    Code = reader.GetInt16(2)
                };
            }

            Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
