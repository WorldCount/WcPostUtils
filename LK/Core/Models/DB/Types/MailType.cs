using SQLite;
using WcPostApi.Types.Interface;

namespace LK.Core.Models.DB.Types
{
    public class MailType : IPostType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Indexed]
        public long Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool Enable { get; set; }

        public MailType() { }

        public MailType(WcPostApi.Types.MailType type)
        {
            Code = type.Code;
            Name = type.Name;
            ShortName = type.ShortName;
            Enable = type.Enable;
        }
    }
}
