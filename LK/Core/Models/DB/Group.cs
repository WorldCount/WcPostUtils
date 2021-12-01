using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace LK.Core.Models.DB
{
    public class Group
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Firm> Firms { get; set; } = new List<Firm>();

        public override string ToString()
        {
            return Name;
        }
    }
}
