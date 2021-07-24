namespace LK.Core.Models.DB
{
    public class Status
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }

        [SQLite.Indexed]
        public string Name { get; set; }
    }
}
