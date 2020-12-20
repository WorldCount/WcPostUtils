using System.Collections.Generic;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Models.Report
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
