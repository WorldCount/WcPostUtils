using System;
using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Libs.Database.Firebird.Queries;
using DwUtils.Core.Models.Firebird;
using DwUtils.Core.Services.Base;

namespace DwUtils.Core.Services.Firebird
{
    public class UserRepository : PostUnitRepository<User>
    {
        public UserRepository(PostUnitConnect connect) : base(connect)
        {
        }

        public override void Add(User item)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<User> GetAll()
        {
            GetUsers q = new GetUsers(Connect);
            var users = q.Run();
            if(users == null)
                return new List<User>();
            return users;
        }

        public override bool Remove(User item)
        {
            throw new NotImplementedException();
        }

        public override void Update(int id, User item)
        {
            throw new NotImplementedException();
        }
    }
}
