using SQLite;
using SQLiteNetExtensions.Attributes;

namespace AOP.Models
{
    [Table("Rpo")]
    public class Rpo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Index { get; set; }
        public string Region { get; set; }
        public string PlaceTo { get; set; }
        public string Address { get; set; }
        public int Mass { get; set; } = 0;

        [Indexed]
        public string Rcpn { get; set; }
        [Indexed]
        public string Comment { get; set; }
        [ForeignKey(typeof(RpoList))]
        public int RpoListId { get; set; }  
        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public RpoList RpoList { get; set; }
    }
}
