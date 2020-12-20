using System.Collections.Generic;
using LK.Core.Models.DB;

namespace LK.Core.Libs.Parse
{
    public class ParseData
    {
        public List<Rpo> Rpos { get; set; } = new List<Rpo>();
        public List<Firm> Firms { get; set; } = new List<Firm>();
        public List<FirmList> FirmLists { get; set; } = new List<FirmList>();
        public List<Operator> Operators { get; set; } = new List<Operator>();
    }
}
