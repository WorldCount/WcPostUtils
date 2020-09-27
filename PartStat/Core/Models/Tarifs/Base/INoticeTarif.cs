using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Models.Tarifs.Base
{
    public interface INoticeTarif
    {
        NoticeType Type { get; set; }
        string Name { get; set; }
        double Rate { get; set; }
    }
}
