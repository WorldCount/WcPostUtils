using SQLite;
using WcPostApi.Types.Interface;

namespace LK.Core.Models.DB.Types
{
    public class MailCategory : IPostType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Indexed]
        public long Code { get; set; }

        public  string Name { get; set; }

        public string ShortName { get; set; }

        public bool Enable { get; set; }

        public MailCategory() { }

        public MailCategory(WcPostApi.Types.MailCategory category)
        {
            Code = category.Code;
            Name = category.Name;
            ShortName = category.ShortName;
            Enable = category.Enable;
        }
    }
}
