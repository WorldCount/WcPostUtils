using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WcApi.Post.Types
{

    public enum MailCategoryFlag : long
    {
        Простое = 0,
        Заказное = 1,
        // ReSharper disable once InconsistentNaming
        ОЦ = 2,
        Обыкновенное = 3,
        // ReSharper disable once InconsistentNaming
        ОЦиНП = 4,
        НеОпределена = 5,
        // ReSharper disable once InconsistentNaming
        ОЦиОП = 6,
        СОбязательнымПлатежом = 7,
        КомбинированноеОбыкновенное = 8,
        // ReSharper disable once InconsistentNaming
        КомбинированноеОЦ = 9,
        // ReSharper disable once InconsistentNaming
        КомбинированноеОЦиНП = 10
    }

    /// <summary>
    /// Категория отправления
    /// </summary>
    public class MailCategory : IPostType
    {
        [DisplayName(@"Id")]
        public long Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool Enable { get; set; }

        public MailCategory() { }

        public MailCategory(long id, string name)
        {
            Id = id;
            Name = name;
            ShortName = name;
            Enable = true;
        }

        public MailCategory(long id, string name, string shortName, bool enable = true)
        {
            Id = id;
            Name = name;
            ShortName = shortName;
            Enable = enable;
        }
    }

    public static class MailCategories
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<MailCategory> _c;
        public static string[] Standart = { "Не определено", "Простое", "Заказное", "С ОЦ" };

        static MailCategories()
        {
            _c = new List<MailCategory>
            {
                new MailCategory(0, "Простое"),
                new MailCategory(1, "Заказное"),
                new MailCategory(2, "С ОЦ"),
                new MailCategory(3, "Обыкновенное"),
                new MailCategory(4, "С ОЦ и НП"),
                new MailCategory(5, "Не определено")
            };
        }

        public static MailCategory GetById(long id) => _c.First(c => c.Id == id);
        public static MailCategory GetByName(string name) => _c.First(c => c.Name.ToUpper() == name.ToUpper());
        public static List<MailCategory> GetAll() => _c;
        public static List<MailCategory> GetAllStandart() => _c.Where(c => Standart.Contains(c.Name)).ToList();
    }
}
