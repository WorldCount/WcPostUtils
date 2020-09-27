using System;
using System.Collections.Generic;
using PartStat.Core.Libs.Stats;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Models.DataReports
{
    public class SingleReportData
    {
        public List<Rpo> Rpos { get; set; } = new List<Rpo>();

        public string Name { get; set; }
        public string Inn { get; set; }
        public string NumDog { get; set; }
        public List<DateList> NumsList { get; set; }
        public List<DateTime> DateList { get; set; } = new List<DateTime>();

        public RpoStatCollector RpoCollector { get; set; }
        public CityStatCollector CityCollector { get; set; }
    }
}
