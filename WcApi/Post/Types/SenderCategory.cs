using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WcApi.Post.Types
{
    /// <summary>
    /// Категория отправителя
    /// </summary>
    public class SenderCategory : IPostType
    {
        [DisplayName(@"Id")]
        public long Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }

        public SenderCategory() { }

        public SenderCategory(long id, string name)
        {
            Id = id;
            Name = name;
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

        public static SenderCategory GetById(long id) => _s.First(s => s.Id == id);
        public static SenderCategory GetByName(string name) => _s.First(s => s.Name.ToUpper() == name.ToUpper());
        public static List<SenderCategory> GetAll() => _s;
    }
}
