using System.Collections.Generic;
using System.Linq;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using DwUtils.Core.Models.Base;

namespace DwUtils.Core.Services.Base
{
    public abstract class PostUnitRepository<T> where T : IEntity
    {
        private PostUnitConnect _connect;

        public PostUnitConnect Connect => _connect;

        protected PostUnitRepository(PostUnitConnect connect)
        {
            _connect = connect;
        }

        public abstract void Add(T item);

        T Get(int id) => GetAll().FirstOrDefault(item => item.Id == id);

        public abstract IEnumerable<T> GetAll();

        public abstract bool Remove(T item);

        public abstract void Update(int id, T item);
    }
}
