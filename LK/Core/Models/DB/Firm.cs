using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace LK.Core.Models.DB
{
    public class Firm
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        [Indexed]
        public string Inn { get; set; }

        [Indexed]
        public string Kpp { get; set; }

        public string Contract { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public virtual List<FirmList> FirmLists { get; set; } = new List<FirmList>();

        public override string ToString()
        {
            return ShortName;
        }
    }
}
