using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WcPostApi.Types.Interface;

namespace WcPostApi.Types
{

    public enum SenderCategoryFlag : long
    {
        Население = 1,
        БюджетнаяОрганизация = 2,
        ХозрасчетнаяОрганизация = 3,
        МеждународныйОператор = 4,
        КорпоративныйКлиент = 5,
        ПочтовыйОператор = 6,
    }


    /// <summary>
    /// Категория отправителя
    /// </summary>
    public class SenderCategory : IPostType
    {
        [DisplayName(@"Code")]
        public long Code { get; set; }

        [DisplayName(@"Вкл")]
        public bool Enable { get; set; } = true;

        [DisplayName(@"Название")]
        public string Name { get; set; }

        [DisplayName(@"Сокращение")]
        public string ShortName { get; set; }

        public SenderCategory() { }

        public SenderCategory(long code, string name, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = name;
            Enable = enable;
        }

        public SenderCategory(long code, string name, string shortName, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = shortName;
            Enable = enable;
        }
    }

    public static class SenderCategories
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<SenderCategory> _s;

        static SenderCategories()
        {
            _s = new List<SenderCategory>
            {
                new SenderCategory(1, "Население"),
                new SenderCategory(2, "Бюджет"),
                new SenderCategory(3, "Хозрасчет"),
                new SenderCategory(4, "Международный оператор"),
                new SenderCategory(5, "Корпоратив"),
                new SenderCategory(6, "Почтовый оператор")
            };
        }

        public static SenderCategory GetByCode(long code) => _s.First(s => s.Code == code);
        public static SenderCategory GetByName(string name) => _s.First(s => s.Name.ToUpper() == name.ToUpper());
        public static List<SenderCategory> GetAll() => _s;
    }
}
