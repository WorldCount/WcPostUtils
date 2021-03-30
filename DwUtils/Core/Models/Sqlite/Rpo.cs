using SQLite;
using SQLiteNetExtensions.Attributes;

namespace DwUtils.Core.Models.Sqlite
{
    /// <summary>РПО</summary>
    public class Rpo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>ШПИ</summary>
        public string Barcode { get; set; }

        /// <summary>Вес в граммах</summary>
        public double Mass { get; set; }

        /// <summary>Весовой сбор в копейках</summary>
        public double MassRate { get; set; }

        /// <summary>Ценность в копейках</summary>
        public double Value { get; set; }

        /// <summary>Категория отправления</summary>
        public int MailCategory { get; set; }

        /// <summary>Вид отправления</summary>
        public int MailType { get; set; }

        /// <summary>Вид вручения</summary>
        public int DeliveryId { get; set; }

        /// <summary>Почтовая отметка</summary>
        public long PostMarkCode { get; set; }

        /// <summary>Разряд отправления</summary>
        public int MailRank { get; set; }

        [ForeignKey(typeof(Doc))]
        public int DocId { get; set; }

        [ForeignKey(typeof(Firm))]
        public int FirmId { get; set; }
    }
}
