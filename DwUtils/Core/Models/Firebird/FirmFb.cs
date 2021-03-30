using DwUtils.Core.Models.Base;
using DwUtils.Core.Models.Sqlite;

namespace DwUtils.Core.Models.Firebird
{
    public class FirmFb : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Firm ToFirm()
        {
            return new Firm
            {
                Name = Name,
                Code = Id
            };
        }
    }
}
