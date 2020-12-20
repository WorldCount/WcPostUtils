using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Libs.TarifManager.Tarif.Base;

namespace LK.Core.Libs.TarifManager.Tarif
{
    public class NoticeTarif : INoticeTarif
    {
        public NoticeType Type { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public double RateNds { get; set; }
        public int Code { get; set; }
    }
}
