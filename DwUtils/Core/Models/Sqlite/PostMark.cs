using SQLite;

namespace DwUtils.Core.Models.Sqlite
{
    /// <summary>Почтовые отметки</summary>
    public class PostMark
    {
        [PrimaryKey]
        public int Id { get; set; }

        /// <summary>Название отметки</summary>
        public string Name { get; set; }

        /// <summary>Код отметки</summary>
        public long Code { get; set; }
    }
}
