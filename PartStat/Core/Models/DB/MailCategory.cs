
namespace PartStat.Core.Models.DB
{
    public class MailCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool Enable { get; set; } = true;
    }
}
