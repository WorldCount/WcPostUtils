using System.Collections.Generic;
using System.Text;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    public class GetConnectUsers : PostUnitSelectQuery<List<ConnectUser>>
    {
        public GetConnectUsers(PostUnitConnect connect) : base(connect) { }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select c.userid, c.paramplaceid, c.connecttime, c.worktime, u.name, p.name, u.isadmin, u.isvalid from userconnect c");
            sb.Append(" left join users u on c.userid = u.userid");
            sb.Append(" left join paramplace p on c.paramplaceid = p.paramplaceid");

            return sb.ToString();
        }

        protected override List<ConnectUser> ParseResponse(FbDataReader reader)
        {
            List<ConnectUser> data = new List<ConnectUser>();

            while (reader.Read())
            {
                ConnectUser dbUser = new ConnectUser
                {
                    UserId = reader.GetInt32(0),
                    PlaceId = reader.GetInt32(1),
                    ConnectDate = reader.GetDateTime(2),
                    WorkDate = reader.GetDateTime(3),
                    UserName = reader.GetString(4),
                    PlaceName = reader.GetString(5),
                    IsAdmin = reader.GetBoolean(6),
                    IsValid = reader.GetBoolean(7)
                };

                data.Add(dbUser);
            }

            Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
