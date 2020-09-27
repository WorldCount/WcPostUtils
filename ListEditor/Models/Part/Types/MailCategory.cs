using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ListEditor.Models.Part.Types
{
    /// <summary>
    /// Категория отправления
    /// </summary>
    public class MailCategory
    {
        [DisplayName(@"Id")]
        public string Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }

        public MailCategory() { }

        public MailCategory(string id, string name)
        {
            Id = id;
            Name = name;
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
                new MailCategory("0", "Простое"),
                new MailCategory("1", "Заказное"),
                new MailCategory("2", "С ОЦ"),
                new MailCategory("3", "Обыкновенное"),
                new MailCategory("4", "С ОЦ и НП"),
                new MailCategory("5", "Не определена")
            };
        }

        public static MailCategory GetById(string id) => _c.First(c => c.Id == id);
        public static MailCategory GetByName(string name) => _c.First(c => c.Name.ToUpper() == name.ToUpper());
        public static List<MailCategory> GetAll() => _c;
    }
}
