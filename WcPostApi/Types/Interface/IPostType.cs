
namespace WcPostApi.Types.Interface
{
    public interface IPostType
    {
        long Code { get; set; }
        string Name { get; set; }
        string ShortName { get; set; }
        bool Enable { get; set; }
    }
}
