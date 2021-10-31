using System.Collections.Generic;
using LK.Core.Models.DB;

namespace LK.Core.Models.Reports
{
    public class Report
    {
        // Id отчета
        public int Id { get; set; } = 0;
        // Название
        public string Name { get; set; }
        // Включен
        public bool Enable { get; set; }
        // Список фирм для отчета
        public List<Firm> Firms { get; set; } = new List<Firm>();
    }
}
