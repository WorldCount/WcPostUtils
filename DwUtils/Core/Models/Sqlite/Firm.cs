using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace DwUtils.Core.Models.Sqlite
{
    /// <summary>Организация</summary>
    public class Firm
    {
        [PrimaryKey]
        public int Id { get; set; }

        /// <summary>Имя</summary>
        public string Name { get; set; }

        /// <summary>Адрес</summary>
        public string Address { get; set; }

        /// <summary>Номер доверенности</summary>
        public string ProcurationNum { get; set; }

        /// <summary>Дата доверенности</summary>
        public DateTime ProcurationDate { get; set; }

        /// <summary>Владелец доверенности</summary>
        public string ProcurationName { get; set; }

        /// <summary>Все РПО</summary>
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public virtual List<Rpo> Rpos { get; set; } = new List<Rpo>();
    }
}
