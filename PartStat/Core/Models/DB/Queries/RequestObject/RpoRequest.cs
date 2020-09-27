using System;
using PartStat.Core.Models.DB.Queries.Base;
using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Models.DB.Queries.RequestObject
{
    public class RpoRequest : Request
    {
        public string NumsList { get; set; }
        public DateTime Date { get; set; }
        public int MailType { get; set; }
        public int MailCategory { get; set; }
        public char Status { get; set; }
        public int InterCode { get; set; } = -1;
        public CreateListType CreateListType { get; set; }
    }
}
