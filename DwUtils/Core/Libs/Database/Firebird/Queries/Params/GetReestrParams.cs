using System;

namespace DwUtils.Core.Libs.Database.Firebird.Queries.Params
{
    /// <summary>Параметры для запроса</summary>
    public class GetReestrParams
    {
        /// <summary>Начальная дата</summary>
        public DateTime StartCreateDate { get; set; }
        /// <summary>Конечная дата</summary>
        public DateTime EndCreateDate { get; set; }
        /// <summary>Статус накладной</summary>
        public int StateId { get; set; }
        /// <summary>Пользователь</summary>
        public int UserId { get; set; }
    }
}
