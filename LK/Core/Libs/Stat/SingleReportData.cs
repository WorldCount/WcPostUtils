using System;
using System.Collections.Generic;
using LK.Core.Models.DB;

namespace LK.Core.Libs.Stat
{
    public class SingleReportData
    {
        public List<Rpo> Rpos { get; set; } = new List<Rpo>();

        public string FirmName { get; set; }
        public string FirmInn { get; set; }
        public string FirmContract { get; set; }

        public List<DateList> NumsList { get; set; }
        public List<DateTime> DateList { get; set; } = new List<DateTime>();

        public RpoStatCollector RpoCollector { get; set; }
        public CityStatCollector CityCollector { get; set; }

        public SingleReportData() { }

        public SingleReportData(Firm firm, List<Rpo> rpos)
        {
            FirmName = firm.ShortName;
            FirmInn = firm.Inn;
            FirmContract = firm.Contract;
            Rpos = rpos;
            RpoCollector = new RpoStatCollector(rpos);
            CityCollector = new CityStatCollector(rpos);
        }
    }
}
