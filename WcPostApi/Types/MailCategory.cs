using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WcPostApi.Types.Interface;

namespace WcPostApi.Types
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
        [DisplayName(@"Code")]
        public long Code { get; set; }

        [DisplayName(@"Вкл")]
        public bool Enable { get; set; } = true;

        [DisplayName(@"Название")]
        public string Name { get; set; }

        [DisplayName(@"Сокращение")]
        public string ShortName { get; set; }

        public MailCategory() { }

        public MailCategory(long code, string name, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = name;
            Enable = enable;
        }

        public MailCategory(long code, string name, string shortName, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = shortName;
            Enable = enable;
        }
    }

    public static class MailCategories
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<MailCategory> _c;

        static MailCategories()
        {
            _c = new List<MailCategory>
            {
                new MailCategory(0, "Простое", "Простое", true),
                new MailCategory(1, "Заказное", "Заказное", true),
                new MailCategory(2, "С объявленной ценностью", "С ОЦ", true),
                new MailCategory(3, "Обыкновенное", "Обыкновенное", false),
                new MailCategory(4, "С объявленной ценностью и наложенным платежом", "С ОЦ и НП", false),
                new MailCategory(5, "Не определена", "Не определена", true),
                new MailCategory(6, "С объявленной ценностью и обязательным платежом", "С ОЦ и ОП", false),
                new MailCategory(7, "С обязательным платежом", "с ОП", false),
                new MailCategory(8, "Комбинированное обыкновенное", "Комбо", false),
                new MailCategory(9, "Комбинированное с объявленной ценностью", "Комбо с ОЦ", false),
                new MailCategory(10, "Комбинированное с объявленной ценностью и наложенным платежом", "Комбо с ОЦ и НП", false),
            };
        }

        public static MailCategory GetByCode(long code) => _c.First(c => c.Code == code);
        public static MailCategory GetByName(string name) => _c.First(c => c.Name.ToUpper() == name.ToUpper());
        public static List<MailCategory> GetAll() => _c;
        public static List<MailCategory> GetAllStandart() => _c.Where(c => c.Enable).ToList();
    }
}
