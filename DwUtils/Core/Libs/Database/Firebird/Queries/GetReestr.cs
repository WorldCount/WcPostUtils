using System.Collections.Generic;
using System.Text;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Libs.Database.Firebird.Queries.Params;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    class GetReestr : PostItemSelectQuery<List<Reestr>>
    {
        private readonly GetReestrParams _param;

        public GetReestr(PostItemConnect connect, GetReestrParams param = null) : base(connect)
        {
            _param = param;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select r.reestrid, r.reestrnum, t.name, r.reestrtypeid, d.vali,  d.vals, r.reestrstateid, r.placeid, r.reestrdate, r.createtime, r.edittime, r.edituserid, count(dv.reestrid)");
            sb.Append(" from reestr r");
            sb.Append(" left join reestrtype t on r.reestrtypeid = t.reestrtypeid");
            sb.Append(" left join dict d on r.dictid = d.dictid");
            sb.Append(" left join docval dv on r.reestrid = dv.reestrid");

            if (_param != null)
            {
                sb.Append($" where r.reestrdate >= '{_param.StartCreateDate.ToShortDateString()}' and r.reestrdate <= '{_param.StartCreateDate.ToShortDateString()}'");

                if (_param.UserId > 0)
                    sb.Append($" and r.edituserid = {_param.UserId}");

                if(_param.StateId > 0)
                    sb.Append($" and r.reestrstateid = {_param.StateId}");
            }

            sb.Append(" group by r.reestrid, r.reestrnum, t.name, r.reestrtypeid, d.vali,  d.vals, r.reestrstateid, r.placeid, r.reestrdate, r.createtime, r.edittime, r.edituserid");
            sb.Append(" order by r.createtime desc");

            return "";
        }

        protected override List<Reestr> ParseResponse(FbDataReader reader)
        {
            List<Reestr> data = new List<Reestr>();

            while (reader.Read())
            {

                string index = reader.GetString(4);
                string place = reader.GetString(5);

                Reestr reestr = new Reestr
                {
                    Id = reader.GetInt16(0),
                    Num = reader.GetInt64(1),
                    Name = reader.GetString(2),
                    Type = reader.GetInt16(3),
                    StateId = reader.GetInt16(6),
                    PlaceId = reader.GetInt16(7),
                    Date = reader.GetDateTime(8),
                    CreateDate = reader.GetDateTime(9),
                    EditDate = reader.GetDateTime(10),
                    UserId = reader.GetInt16(11),
                    RpoCount = reader.GetInt16(12)
                };

                if (!string.IsNullOrEmpty(index))
                    reestr.DirectionIndex = index;

                if (!string.IsNullOrEmpty(place))
                    reestr.DirectionPlace = place;

                data.Add(reestr);
            }

            Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
