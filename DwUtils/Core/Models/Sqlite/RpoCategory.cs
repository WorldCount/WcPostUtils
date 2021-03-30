using SQLite;

namespace DwUtils.Core.Models.Sqlite
{
    /// <summary>Категория и тип РПО</summary>
    public class RpoCategory
    {
        /// <summary>ID вида отправления</summary>
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>Тип отправления</summary>
        [Indexed]
        public int Type { get; set; }

        /// <summary>Категория отправления</summary>
        [Indexed]
        public int Category { get; set; }
    }
}
