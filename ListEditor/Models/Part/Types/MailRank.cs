using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ListEditor.Models.Part.Types
{
    /// <summary>
    /// Разряд отправления
    /// </summary>
    public class MailRank
    {
        [DisplayName(@"Id")]
        public string Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }

        // ReSharper disable once UnusedMember.Global
        public MailRank() { }

        public MailRank(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }


    public class MailRanks
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<MailRank> _r;

        static MailRanks()
        {
            _r = new List<MailRank>
            {
                new MailRank("0", "Без разряда"),
                new MailRank("1", "Правительственное"),
                new MailRank("2", "Воинское"),
                new MailRank("3", "Служебное"),
                new MailRank("4", "Судебное"),
                new MailRank("5", "Президентское"),
                new MailRank("6", "Кредитное"),
                new MailRank("7", "Межоператорское")
            };
        }

        public static MailRank GetById(string id) => _r.First(r => r.Id == id);
        public static MailRank GetByName(string name) => _r.First(r => r.Name.ToUpper() == name.ToUpper());
        public static List<MailRank> GetAll() => _r;
    }
}
