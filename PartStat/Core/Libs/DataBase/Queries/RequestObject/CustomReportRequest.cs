using System;
using System.Collections.Generic;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Libs.DataBase.Queries.RequestObject
{
    public class CustomReportRequest
    {
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public List<Firm> Firms { get; set; }
    }
}
