using System;

namespace PartStat.Core.Models.DataReports
{
    public class HandReport
    {
        // Дата отчета
        public DateTime Date { get; set; }
        // Всего отправлений
        public int AllCount { get; set; }
        // Отправлений в ручку
        public int HandCount { get; set; }
        // Обычные отправления
        public int NormalCount { get; set; }
        // Плата за пересылку
        public double PaySum { get; set; }

    }
}
