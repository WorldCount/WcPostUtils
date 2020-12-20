using SQLite;

namespace LK.Core.Models.DB.Types
{
    public class Notice
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Indexed]
        public long Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }
    }
}
