using System.Collections.Generic;
using LK.Core.Libs.Auth.Types;
using SQLiteNetExtensions.Attributes;

namespace LK.Core.Models.DB
{
    public class PayType
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public DocPayType Type { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<FirmList> FirmLists { get; set; } = new List<FirmList>();
    }
}
