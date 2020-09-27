using System;
using PartStat.Core.Libs.DataBase.Queries.Base;
using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Libs.DataBase.Queries.RequestObject
{
    public class FirmRequest : Request
    {
        public int MailType { get; set; }
        public int MailCategory { get; set; }
        public char Status { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public string StartNum { get; set; }
        public string EndNum { get; set; }
        public int InterCode { get; set; } = -1;
        public CreateListType CreateListType {get; set; }
    }
}
