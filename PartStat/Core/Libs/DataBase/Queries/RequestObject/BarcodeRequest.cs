using System;
using PartStat.Core.Libs.DataBase.Queries.Base;

namespace PartStat.Core.Libs.DataBase.Queries.RequestObject
{
    public class BarcodeRequest : Request
    {
        public string Barcode { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
    }
}
