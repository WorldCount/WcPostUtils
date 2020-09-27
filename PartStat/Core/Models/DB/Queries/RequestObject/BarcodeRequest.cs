using System;
using PartStat.Core.Models.DB.Queries.Base;

namespace PartStat.Core.Models.DB.Queries.RequestObject
{
    public class BarcodeRequest : Request
    {
        public string Barcode { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
    }
}
