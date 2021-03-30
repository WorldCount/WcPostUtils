using DwUtils.Core.Models.Base;
using DwUtils.Core.Models.Sqlite;

namespace DwUtils.Core.Models.Firebird
{
    public class RpoCategoryFb : IEntity
    {
        public int Id { get; set; }

        public int Type { get; set; }

        public int Category { get; set; }

        public string Name { get; set; }

        public RpoCategory ToRpoCategory()
        {
            return new RpoCategory
            {
                Name = Name,
                Id = Id,
                Type = Type,
                Category = Category
            };
        }
    }
}
