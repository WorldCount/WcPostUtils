using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    public class GetUsers : PostUnitSelectQuery<List<User>>
    {
        public GetUsers(PostUnitConnect connect) : base(connect) { }

        public override string GetQuery()
        {
            return "select userid, Upper(name), pass, isadmin, isvalid from users where isValid = 1 order by Upper(name)";
        }

        protected override List<User> ParseResponse(FbDataReader reader)
        {
            List<User> data = new List<User>();

            while (reader.Read())
            {
                User dbUser = new User
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Password = reader.GetString(2),
                    IsAdmin = reader.GetBoolean(3),
                    IsValid = reader.GetBoolean(4)
                };

                data.Add(dbUser);
            }

            Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
