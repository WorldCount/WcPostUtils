using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ListEditor.Models.Part.Types
{
    public class PayType
    {
        [DisplayName(@"Id")]
        public string Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }

        public PayType() { }

        public PayType(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public static class PayTypes
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<PayType> _p;

        static PayTypes()
        {
            _p = new List<PayType>
            {
                new PayType("1", "Наличная"),
                new PayType("2", "Безналичная"),
                new PayType("4", "Бесплатно"),
                new PayType("8", "Пластиковая карта"),
                new PayType("16", "Марки"),
                new PayType("32", "Предоплата"),
                new PayType("64", "Оплачено МО"),
                new PayType("256", "Франкирование")
            };
        }

        public static PayType GetById(string id) => _p.First(p => p.Id == id);
        public static PayType GetByName(string name) => _p.First(p => p.Name.ToUpper() == name.ToUpper());
        public static List<PayType> GetAll() => _p;
    }
}
