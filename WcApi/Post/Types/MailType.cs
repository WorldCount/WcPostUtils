using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WcApi.Post.Types
{

    public enum MailTypeFlag : long
    {
        НеОпределено = 0,
        БланкПочтовогоПеревода = 1,
        Письмо = 2,
        Бандероль = 3,
        Посылка = 4,
        МелкийПакет = 5,
        ПочтоваяКарточка = 6,
        // ReSharper disable once InconsistentNaming
        ОтправлениеEMS = 7,
        Секограмма = 8,
        МешокМ = 9,
        // ReSharper disable once InconsistentNaming
        ОтправлениеВСД = 10,
        // ReSharper disable once InconsistentNaming
        Письмо2 = 11,
        БланкУведомления = 12,
        ГазетнаяПачка = 13,
        Консигнация = 14,
        // ReSharper disable once InconsistentNaming
        Письмо1класса = 15,
        // ReSharper disable once InconsistentNaming
        Бандероль1класса = 16,
        // ReSharper disable once InconsistentNaming
        БланкУведомления1класса = 17,
        СумкаСтраховая = 18,
        // ReSharper disable once InconsistentNaming
        ОВПО_письмо = 19,
        Мультиконверт = 20,
        ТяжеловесноеПочтовоеОтправление = 21,
        // ReSharper disable once InconsistentNaming
        ОВПО_карточка = 22,
        ПосылкаОнлайн = 23,
        КурьерОнлайн = 24,
        // ReSharper disable once InconsistentNaming
        ОтправлениеДМ = 25,
        // ReSharper disable once InconsistentNaming
        ПакетДМ = 26,
        ПосылкаСтандарт = 27,
        // ReSharper disable once InconsistentNaming
        ПосылкаКурьерEMS = 28,
        ПосылкаЭкспресс = 29,
        БизнесКурьер = 30,
        БизнесКурьерЭкспресс = 31,
        ПисьмоЭкспресс = 32,
        ПисьмоКурьерское = 33,
        // ReSharper disable once InconsistentNaming
        EMS_оптимальное = 34,
        БандерольКомплект = 35,
        ТрекОткрытка = 36,
        ТрекПисьмо = 37,
        ПосылкаЭкомпро = 38,
        // ReSharper disable once InconsistentNaming
        КПО_стандарт = 39,
        // ReSharper disable once InconsistentNaming
        КПО_эконом = 40,
        // ReSharper disable once InconsistentNaming
        EMS_РТ = 41,
        ПосылкаОнлайнПлюс = 42,
        КурьерОнлайнПлюс = 43,
        Резерв = 44,
        Резeрв = 45,
        // ReSharper disable once InconsistentNaming
        ВГПО_1кл = 46,
        // ReSharper disable once InconsistentNaming
        Посылка1класса = 47,
        // ReSharper disable once InconsistentNaming
        Письмо1класса2 = 48,
        // ReSharper disable once InconsistentNaming
        Письмо1классаКурьерское = 49,
        // ReSharper disable once InconsistentNaming
        ПакетДМ_возврат = 50,
        ПосылкаЛегкийВозврат = 51,
        // ReSharper disable once InconsistentNaming
        EMS_Тендер = 52,
        // ReSharper disable once InconsistentNaming
        ЕКОМ = 53,
        // ReSharper disable once InconsistentNaming
        ЕКОМ_Маркетплейс = 54,
        // ReSharper disable once InconsistentNaming
        ГКО = 55
    }

    /// <summary>
    /// Тип отправления
    /// </summary>
    public class MailType : IPostType
    {
        [DisplayName(@"Id")]
        public long Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool Enable { get; set; }

        // ReSharper disable once UnusedMember.Global
        public MailType() { }

        public MailType(long id, string name)
        {
            Id = id;
            Name = name;
            ShortName = name;
            Enable = true;
        }

        public MailType(long id, string name, string shortName, bool enable = true)
        {
            Id = id;
            Name = name;
            ShortName = shortName;
            Enable = enable;
        }
    }

    public static class MailTypes
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<MailType> _t;
        public static string[] Standart = { "Не определено", "Письмо", "Бандероль", "Письмо 1 класса", "Бандероль 1 класса" };

        static MailTypes()
        {
            _t = new List<MailType> {
                new MailType(0, "Не определено"),
                new MailType(1, "Бланк почтового перевода"),
                new MailType(2, "Письмо"),
                new MailType(3, "Бандероль"),
                new MailType(4, "Посылка"),
                new MailType(5, "Мелкий пакет"),
                new MailType(6, "Почтовая карточка"),
                new MailType(7, "Отправление EMS"),
                new MailType(8, "Секограмма"),
                new MailType(9, "Мешок «М»"),
                new MailType(10, "Отправление ВСД"),
                new MailType(11, "Письмо 2.0"),
                new MailType(12, "Бланк уведомления"),
                new MailType(13, "Газетная пачка"),
                new MailType(14, "«Консигнация»"),
                new MailType(15, "Письмо 1 класса"),
                new MailType(16, "Бандероль 1 класса"),
                new MailType(17, "Бланк уведомления 1 класса"),
                new MailType(18, "Сумка страховая"),
                new MailType(19, "ОВПО - письмо"),
                new MailType(20, "Мультиконверт"),
                new MailType(21, "Тяжеловесное отправление"),
                new MailType(22, "ОВПО - карточка"),
                new MailType(23, "Посылка онлайн"),
                new MailType(24, "Курьер онлайн"),
                new MailType(25, "Отправление ДМ"),
                new MailType(26, "Пакет ДМ"),
                new MailType(27, "Посылка стандарт"),
                new MailType(28, "Посылка курьер EMS"),
                new MailType(29, "Посылка экспресс"),
                new MailType(30, "Бизнес курьер"),
                new MailType(31, "Бизнес курьер экспресс"),
                new MailType(32, "Письмо Экспресс"),
                new MailType(33, "Письмо Курьерское"),
                new MailType(34, "EMS оптимальное"),
                new MailType(35, "Бандероль-комплект"),
                new MailType(36, "Трек-открытка"),
                new MailType(37, "Трек-письмо"),
                new MailType(38, "Посылка-экомпро"),
                new MailType(39, "КПО-стандарт"),
                new MailType(40, "КПО-эконом"),
                new MailType(41, "EMS РТ"),
                new MailType(42, "Посылка онлайн плюс"),
                new MailType(43, "Курьер онлайн плюс"),
                new MailType(44, "Резерв"),
                new MailType(45, "Резерв"),
                new MailType(46, "ВГПО 1 кл"),
                new MailType(47, "Посылка 1 класса"),
                new MailType(48, "Письмо 1-го класса 2.0"),
                new MailType(49, "Письмо 1-го класса Курьерское"),
                new MailType(50, "Пакет ДМ-возврат"),
                new MailType(51, "Посылка Легкий возврат"),
                new MailType(52, "EMS Тендер"),
                new MailType(53, "ЕКОМ"),
                new MailType(54, "ЕКОМ Маркетплейс"),
                new MailType(55, "ГКО"),
            };
        }

        public static MailType GetById(long id) => _t.First(t => t.Id == id);
        public static MailType GetByName(string name) => _t.First(t => t.Name.ToUpper() == name.ToUpper());
        public static List<MailType> GetAll() => _t;
        public static List<MailType> GetAllStandart() => _t.Where(t => Standart.Contains(t.Name)).ToList();
    }
}
