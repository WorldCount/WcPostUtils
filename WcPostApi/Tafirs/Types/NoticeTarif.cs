using WcPostApi.Tafirs.Types.Interface;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Types
{
    public class NoticeTarif : INotice
    {
        public NoticeType Type { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
    }
}
