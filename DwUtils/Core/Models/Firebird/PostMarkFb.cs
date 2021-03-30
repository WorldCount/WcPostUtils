using DwUtils.Core.Models.Base;
using DwUtils.Core.Models.Sqlite;

namespace DwUtils.Core.Models.Firebird
{
    public class PostMarkFb : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public long Code { get; set; }

        public PostMark ToPostMark()
        {
            return new PostMark
            {
                Id = Id,
                Name = Name,
                Code = Code
            };
        }
    }
}
