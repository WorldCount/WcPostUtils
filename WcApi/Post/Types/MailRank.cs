using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WcApi.Post.Types
{

    public enum MailRankFlag : long
    {
        Безразряда = 0,
        Правительственное = 1,
        Воинское = 2,
        Служебное = 3,
        Судебное = 4,
        Президентское = 5,
        Кредитное = 6,
        Межоператорское = 7,
        Административное = 8,
        Выборное = 9
    }

    /// <summary>
    /// Разряд отправления
    /// </summary>
    public class MailRank : IPostType
    {
        [DisplayName(@"Id")]
        public long Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }

        // ReSharper disable once UnusedMember.Global
        public MailRank() { }

        public MailRank(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }


    public static class MailRanks
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<MailRank> _r;

        static MailRanks()
        {
            _r = new List<MailRank>
            {
                new MailRank(0, "Без разряда"),
                new MailRank(1, "Правительственное"),
                new MailRank(2, "Воинское"),
                new MailRank(3, "Служебное"),
                new MailRank(4, "Судебное"),
                new MailRank(5, "Президентское"),
                new MailRank(6, "Кредитное"),
                new MailRank(7, "Межоператорское"),
                new MailRank(8, "Административное"),
                new MailRank(9, "Выборное")
            };
        }

        public static MailRank GetById(long id) => _r.First(r => r.Id == id);
        public static MailRank GetByName(string name) => _r.First(r => r.Name.ToUpper() == name.ToUpper());
        public static List<MailRank> GetAll() => _r;
    }
}
