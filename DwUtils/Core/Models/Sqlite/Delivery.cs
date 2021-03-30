using SQLite;

namespace DwUtils.Core.Models.Sqlite
{
    /// <summary>Вид вручения</summary>
    public class Delivery
    {
        [PrimaryKey]
        public int Id { get; set; }

        /// <summary>Название</summary>
        public string Name { get; set; }

        /// <summary>Код</summary>
        public int Code { get; set; }
    }
}
