using System;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Libs.DataBase.Queries.RequestObject
{
    public class MassReportRequest
    {
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public Firm Firm { get; set; }
    }
}
