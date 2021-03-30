using System;
using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries;
using DwUtils.Core.Models.Firebird;
using DwUtils.Core.Services.Base;

namespace DwUtils.Core.Services.Firebird
{
    public class ConnectUserRepository : PostUnitRepository<ConnectUser>
    {
        public ConnectUserRepository(PostUnitConnect connect) : base(connect)
        {
        }

        public override void Add(ConnectUser item)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<ConnectUser> GetAll()
        {
            GetConnectUsers q = new GetConnectUsers(Connect);
            var connects = q.Run();
            if(connects == null)
                return new List<ConnectUser>();
            return connects;
        }

        public override bool Remove(ConnectUser item)
        {
            throw new NotImplementedException();
        }

        public override void Update(int id, ConnectUser item)
        {
            throw new NotImplementedException();
        }
    }
}
