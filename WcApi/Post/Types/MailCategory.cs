using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WcApi.Post.Types
{
    /// <summary>
    /// Категория отправления
    /// </summary>
    public class MailCategory : IPostType
    {
        [DisplayName(@"Id")]
        public long Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }

        public MailCategory() { }

        public MailCategory(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public static class MailCategories
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<MailCategory> _c;
        public static string[] Standart = {"Простое", "Заказное"};

        static MailCategories()
        {
            _c = new List<MailCategory>
            {
                new MailCategory(0, "Простое"),
                new MailCategory(1, "Заказное"),
                new MailCategory(2, "С ОЦ"),
                new MailCategory(3, "Обыкновенное"),
                new MailCategory(4, "С ОЦ и НП"),
                new MailCategory(5, "Не определена")
            };
        }

        public static MailCategory GetById(long id) => _c.First(c => c.Id == id);
        public static MailCategory GetByName(string name) => _c.First(c => c.Name.ToUpper() == name.ToUpper());
        public static List<MailCategory> GetAll() => _c;
        public static List<MailCategory> GetAllStandart() => _c.Where(c => Standart.Contains(c.Name)).ToList();
    }
}
