using SQLite;

namespace LK.Core.Models.DB
{
    public class Status
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Indexed]
        public string Name { get; set; }
    }
}
