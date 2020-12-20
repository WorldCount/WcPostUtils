using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WcPostApi.Types.Interface;

namespace WcPostApi.Types
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
        [DisplayName(@"Code")]
        public long Code { get; set; }

        [DisplayName(@"Вкл")]
        public bool Enable { get; set; } = true;

        [DisplayName(@"Название")]
        public string Name { get; set; }

        [DisplayName(@"Сокращение")]
        public string ShortName { get; set; }

        // ReSharper disable once UnusedMember.Global
        public MailType() { }

        public MailType(long code, string name, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = name;
            Enable = enable;
        }

        public MailType(long code, string name, string shortName, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = shortName;
            Enable = enable;
        }
    }

    public static class MailTypes
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<MailType> _t;

        static MailTypes()
        {
            _t = new List<MailType> {
                new MailType(0, "Не определено"),
                new MailType(1, "Бланк почтового перевода", false),
                new MailType(2, "Письмо"),
                new MailType(3, "Бандероль"),
                new MailType(4, "Посылка", false),
                new MailType(5, "Мелкий пакет", false),
                new MailType(6, "Почтовая карточка", false),
                new MailType(7, "Отправление EMS", false),
                new MailType(8, "Секограмма", false),
                new MailType(9, "Мешок «М»", false),
                new MailType(10, "Отправление ВСД", false),
                new MailType(11, "Письмо 2.0", false),
                new MailType(12, "Бланк уведомления", false),
                new MailType(13, "Газетная пачка", false),
                new MailType(14, "«Консигнация»", false),
                new MailType(15, "Письмо 1 класса"),
                new MailType(16, "Бандероль 1 класса"),
                new MailType(17, "Бланк уведомления 1 класса", false),
                new MailType(18, "Сумка страховая", false),
                new MailType(19, "ОВПО - письмо", false),
                new MailType(20, "Мультиконверт", false),
                new MailType(21, "Тяжеловесное отправление", false),
                new MailType(22, "ОВПО - карточка", false),
                new MailType(23, "Посылка онлайн", false),
                new MailType(24, "Курьер онлайн", false),
                new MailType(25, "Отправление ДМ", false),
                new MailType(26, "Пакет ДМ", false),
                new MailType(27, "Посылка стандарт", false),
                new MailType(28, "Посылка курьер EMS", false),
                new MailType(29, "Посылка экспресс", false),
                new MailType(30, "Бизнес курьер", false),
                new MailType(31, "Бизнес курьер экспресс", false),
                new MailType(32, "Письмо Экспресс", false),
                new MailType(33, "Письмо Курьерское", false),
                new MailType(34, "EMS оптимальное", false),
                new MailType(35, "Бандероль-комплект", false),
                new MailType(36, "Трек-открытка", false),
                new MailType(37, "Трек-письмо", false),
                new MailType(38, "Посылка-экомпро", false),
                new MailType(39, "КПО-стандарт", false),
                new MailType(40, "КПО-эконом", false),
                new MailType(41, "EMS РТ", false),
                new MailType(42, "Посылка онлайн плюс", false),
                new MailType(43, "Курьер онлайн плюс", false),
                new MailType(44, "Резерв", false),
                new MailType(45, "Резерв", false),
                new MailType(46, "ВГПО 1 кл", false),
                new MailType(47, "Посылка 1 класса", false),
                new MailType(48, "Письмо 1-го класса 2.0", false),
                new MailType(49, "Письмо 1-го класса Курьерское", false),
                new MailType(50, "Пакет ДМ-возврат", false),
                new MailType(51, "Посылка Легкий возврат", false),
                new MailType(52, "EMS Тендер", false),
                new MailType(53, "ЕКОМ", false),
                new MailType(54, "ЕКОМ Маркетплейс", false),
                new MailType(55, "ГКО", false),
            };
        }

        public static MailType GetByCode(long code) => _t.First(t => t.Code == code);
        public static MailType GetByName(string name) => _t.First(t => t.Name.ToUpper() == name.ToUpper());
        public static List<MailType> GetAll() => _t;
        public static List<MailType> GetAllStandart() => _t.Where(t => t.Enable).ToList();
    }
}
