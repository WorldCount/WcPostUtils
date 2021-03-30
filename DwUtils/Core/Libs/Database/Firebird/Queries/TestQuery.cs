using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    class TestQuery : SelectQuery<List<User>>
    {
        public TestQuery(FbConnect connect) : base(connect) { }

        public override string GetQuery()
        {
            return "select * from users where isValid = 1 order by Name";
        }

        protected override List<User> ParseResponse(FbDataReader reader)
        {
            List<User> users = new List<User>();

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

                users.Add(dbUser);
            }

            Logger.Debug($"Запрос вернул записей: {users.Count}");
            return users;
        }
    }
}
