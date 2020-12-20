using System;

namespace PartStat.Core.Models.DataReports
{
    public class MassReport
    {
        // Дата отчета
        public DateTime Date { get; set; }
        // Всего отправлений
        public int Count { get; set; }
        // Вес
        public double Mass { get; set; }
    }
}
