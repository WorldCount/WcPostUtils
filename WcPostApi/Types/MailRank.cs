using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WcPostApi.Types.Interface;

namespace WcPostApi.Types
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
        public long Code { get; set; }

        [DisplayName(@"Вкл")]
        public bool Enable { get; set; } = true;

        [DisplayName(@"Название")]
        public string Name { get; set; }

        [DisplayName(@"Сокращение")]
        public string ShortName { get; set; }

        // ReSharper disable once UnusedMember.Global
        public MailRank() { }

        public MailRank(long code, string name, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = name;
            Enable = enable;
        }

        public MailRank(long code, string name, string shortName, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = shortName;
            Enable = enable;
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

        public static MailRank GetByCode(long code) => _r.First(r => r.Code == code);
        public static MailRank GetByName(string name) => _r.First(r => r.Name.ToUpper() == name.ToUpper());
        public static List<MailRank> GetAll() => _r;
    }
}
