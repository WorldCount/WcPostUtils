using WcPostApi.Types;

namespace WcPostApi.Tafirs.Types.Interface
{
    public interface INotice
    {
        NoticeType Type { get; set; }
        string Name { get; set; }
        double Rate { get; set; }
    }
}
