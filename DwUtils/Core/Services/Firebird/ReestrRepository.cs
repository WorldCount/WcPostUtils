using System;
using System.Collections.Generic;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Models.Firebird;
using DwUtils.Core.Services.Base;

namespace DwUtils.Core.Services.Firebird
{
    public class ReestrRepository : PostItemRepository<Reestr>
    {
        public ReestrRepository(PostItemConnect connect) : base(connect)
        {
        }

        public override void Add(Reestr item)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Reestr> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Reestr item)
        {
            throw new NotImplementedException();
        }

        public override void Update(int id, Reestr item)
        {
            throw new NotImplementedException();
        }
    }
}
