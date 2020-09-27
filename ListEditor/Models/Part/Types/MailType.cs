using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ListEditor.Models.Part.Types
{
    /// <summary>
    /// Тип отправления
    /// </summary>
    public class MailType
    {
        [DisplayName(@"Id")]
        public string Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }

        // ReSharper disable once UnusedMember.Global
        public MailType() { }

        public MailType(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public static class MailTypes
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<MailType> _t;
        public static string[] Standart = { "Письмо", "Бандероль", "Посылка", "Мелкий пакет", "Письмо 1 класса", "Бандероль 1 класса" };

        static MailTypes()
        {
            _t = new List<MailType> {
                new MailType("0", "Не определено"),
                new MailType("1", "Бланк почтового перевода"),
                new MailType("2", "Письмо"),
                new MailType("3", "Бандероль"),
                new MailType("4", "Посылка"),
                new MailType("5", "Мелкий пакет"),
                new MailType("6", "Почтовая карточка"),
                new MailType("7", "Отправление EMS"),
                new MailType("8", "Секограмма"),
                new MailType("9", "Мешок «М»"),
                new MailType("10", "Отправление ВСД"),
                new MailType("11", "Письмо 2.0"),
                new MailType("12", "Бланк уведомления"),
                new MailType("13", "Газетная пачка"),
                new MailType("14", "«Консигнация»"),
                new MailType("15", "Письмо 1 класса"),
                new MailType("16", "Бандероль 1 класса"),
                new MailType("17", "Бланк уведомления 1 класса"),
                new MailType("18", "Сумка страховая"),
                new MailType("19", "ОВПО - письмо"),
                new MailType("20", "Мультиконверт"),
                new MailType("21", "Тяжеловесное отправление"),
                new MailType("22", "ОВПО - карточка"),
                new MailType("23", "Посылка онлайн"),
                new MailType("24", "Курьер онлайн"),
                new MailType("25", "Отправление ДМ"),
                new MailType("26", "Пакет ДМ"),
                new MailType("27", "Посылка стандарт"),
                new MailType("28", "Посылка курьер EMS"),
                new MailType("29", "Посылка экспресс"),
                new MailType("30", "Бизнес курьер"),
                new MailType("31", "Бизнес курьер экспресс"),
                new MailType("32", "Письмо Экспресс"),
                new MailType("33", "Письмо Курьерское"),
                new MailType("34", "EMS оптимальное"),
                new MailType("35", "Бандероль-комплект"),
                new MailType("36", "Трек-открытка"),
                new MailType("37", "Трек-письмо"),
                new MailType("38", "Посылка-экомпро"),
                new MailType("39", "КПО-стандарт"),
                new MailType("40", "КПО-эконом"),
                new MailType("41", "EMS РТ"),
                new MailType("42", "Посылка онлайн плюс"),
                new MailType("43", "Курьер онлайн плюс"),
                new MailType("44", "Резерв"),
                new MailType("45", "Резерв"),
                new MailType("46", "ВГПО 1 кл"),
                new MailType("47", "Посылка 1 класса"),
                new MailType("48", "Письмо 1-го класса 2.0"),
                new MailType("49", "Письмо 1-го класса Курьерское"),
                new MailType("50", "Пакет ДМ-возврат"),
                new MailType("51", "Посылка Легкий возврат"),
                new MailType("52", "EMS Тендер")
            };
        }

        public static MailType GetById(string id) => _t.First(t => t.Id == id);
        public static MailType GetByName(string name) => _t.First(t => t.Name.ToUpper() == name.ToUpper());
        public static List<MailType> GetAll() => _t;
        public static List<MailType> GetAllStandart() => _t.Where(t => Standart.Contains(t.Name)).ToList();
    }
}
