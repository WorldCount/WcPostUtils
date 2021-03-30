using DwUtils.Core.Models.Base;
using DwUtils.Core.Models.Sqlite;

namespace DwUtils.Core.Models.Firebird
{
    public class MailRankFb : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }

        public MailRank ToMailRank()
        {
            return new MailRank
            {
                Id = Id,
                Name = Name,
                Code = Code
            };
        }
    }
}
