using PartStat.Core.Models.PostTypes;
using PartStat.Core.Models.Tarifs.Base;

namespace PartStat.Core.Models.Tarifs
{
    public class NoticeTarif : INoticeTarif
    {
        public NoticeType Type { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public int Code { get; set; }
    }
}
