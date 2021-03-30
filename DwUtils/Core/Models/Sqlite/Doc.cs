using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace DwUtils.Core.Models.Sqlite
{
    /// <summary>Накладная</summary>
    public class Doc
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>ID накладной в PostItem</summary>
        [Indexed]
        public long DocId { get; set; }

        /// <summary>ШПИ накладной</summary>
        public long Num { get; set; }

        /// <summary>Название накладной</summary>
        public string Name { get; set; }

        /// <summary>Тип накладной</summary>
        public int Type { get; set; }

        /// <summary>Индекс направления накладной</summary>
        public string DirectionIndex { get; set; }

        /// <summary>Название направления накладной</summary>
        public string DirectionPlace { get; set; }

        /// <summary>Статус накладной (Открыта\Закрыта)</summary>
        public int State { get; set; }

        /// <summary>ID участка накладной (Заказной\Страховой)</summary>
        public int PlaceId { get; set; }

        /// <summary>Дата накладной</summary>
        public DateTime Date { get; set; }

        /// <summary>Дата создания накладной</summary>
        public DateTime CreateDate { get; set; }

        /// <summary>Дата редактирования накладной</summary>
        public DateTime EditDate { get; set; }

        /// <summary>ID польззователя накладной</summary>
        public int UserId { get; set; }

        /// <summary>Количество отправлений в накладной</summary>
        public int Count { get; set; }

        /// <summary>Количество проверенных в ОАСУ отправлений</summary>
        public int CheckCount { get; set; }

        /// <summary>Все РПО</summary>
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public virtual List<Rpo> Rpos { get; set; } = new List<Rpo>();

        public override string ToString()
        {
            return $"[{Num}] {DirectionIndex} {DirectionPlace}";
        }
    }
}
