using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries.Base;
using DwUtils.Core.Models.Firebird;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries
{
    public class GetConnectUsers : PostUnitQuery
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

        public List<ConnectUser> Run()
        {
            string q = GetQuery();
            Logger.Debug($"Запрос в БД: {q}");

            List<ConnectUser> connectUsers = new List<ConnectUser>();

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand selectCommand = new FbCommand(q, fbConnection) { Transaction = fbTransaction };
                reader = selectCommand.ExecuteReader();

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

                    connectUsers.Add(dbUser);
                }

                Logger.Debug($"Запрос вернул записей: {connectUsers.Count}");
                return connectUsers;
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при запросе: {q}");
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
