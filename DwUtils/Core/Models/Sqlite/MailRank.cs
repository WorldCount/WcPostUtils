using SQLite;

namespace DwUtils.Core.Models.Sqlite
{
    /// <summary>Разряд отправления</summary>
    public class MailRank
    {
        [PrimaryKey]
        public int Id { get; set; }

        /// <summary>Название отметки</summary>
        public string Name { get; set; }

        /// <summary>Код отметки</summary>
        public long Code { get; set; }
    }
}
