using System;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace LK.Core.Models.DB
{
    public class Firm
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }

        [SQLite.Ignore] public virtual bool Check { get; set; } = false;

        [SQLite.Indexed]
        public string Name { get; set; }

        public string ShortName { get; set; }

        [SQLite.Indexed]
        public string Inn { get; set; }

        [SQLite.Indexed]
        public string Kpp { get; set; }

        [SQLite.Indexed]
        public string Contract { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<FirmList> FirmLists { get; set; } = new List<FirmList>();

        [ForeignKey(typeof(Group)), SQLite.Indexed]
        public int GroupId { get; set; } = 0;

        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Group Group { get; set; }

        public DateTime LastListDate { get; set; }

        public override string ToString()
        {
            return ShortName;
        }
    }
}
