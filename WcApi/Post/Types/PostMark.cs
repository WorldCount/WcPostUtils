using System;
using System.ComponentModel;

namespace WcApi.Post.Types
{
    /// <summary>
    /// Почтовые отметки
    /// </summary>
    [Flags]
    public enum PostMarkFlags : long
    {
        [Description("Без отметки")]
        БезОтметки = 0,
        [Description("Простое уведомление")]
        ПростоеУведомление = 1,
        [Description("Заказное уведомление")]
        ЗаказноеУведомление = 2,
        [Description("С описью")]
        Опись = 4,
        [Description("Осторожно (Хрупкая)")]
        Осторожно = 8,
        [Description("Тяжеловесная")]
        Тяжеловесная = 16,
        [Description("Крупногабаритная (Громоздкая)")]
        Крупногабаритная = 32,
        [Description("С доставкой (Доставка нарочным)")]
        Доставка = 64,
        [Description("Вручить в собственные руки")]
        ВручитьВсобственныеРуки = 128,
        [Description("С документами")]
        Документы = 256,
        [Description("С товарами")]
        Товары = 512,
        [Description("Возврату не подлежит")]
        ВозвратуНеПодлежит = 1024,
        [Description("Нестандартная")]
        Нестандартная = 2048,
        [Description("Приграничная")]
        Приграничная = 4096,
        [Description("Застраховано")]
        Застраховано = 8192,
        [Description("С электронным уведомлением")]
        ЭлектронноеУведомление = 16384,
        [Description("Курьер бизнес-экспресс")]
        КурьерБизнесЭкспресс = 32768,
        [Description("Нестандартная до 10 кг")]
        НестандартнаяДо10Кг = 65536,
        [Description("Нестандартная до 20 кг")]
        НестандартнаяДо20Кг = 131072,
        [Description("С наложенным платежом")]
        НаложенныйПлатеж = 262144,
        [Description("Гарантия сохранности")]
        ГарантияСохранности = 524288,
        [Description("Заверительный пакет")]
        ЗаверительныйПакет = 1048576,
        [Description("Доставка курьером")]
        ДоставкаКурьером = 2097152,
        [Description("Проверка комплектности")]
        ПроверкаКомплектности = 4194304,
        [Description("Негабаритная")]
        Негабаритная = 8388608,
        [Description("В упаковке Почты России")]
        УпаковкаПочтыРоссии = 16777216,
        [Description("Доставка по звонку")]
        ДоставкаПоЗвонку = 33554432,
        [Description("Ценность вложения")]
        ЦенностьВложения = 67108864,
        [Description("С обратной доставкой")]
        ОбратнаяДоставка = 134217728,
        [Description("В предоплаченном пакете")]
        ПредоплаченныйПакет = 268435456,
        [Description("ВСД")]
        // ReSharper disable once InconsistentNaming
        ВСД = 536870912,
        [Description("Вручение с COD")]
        // ReSharper disable once InconsistentNaming
        COD = 1073741824,
        [Description("Запрещено продлевать срок хранения")]
        ЗапрещеноПродлеватьСрокХранения = 2147483648,
        [Description("Легкий возврат")]
        ЛегкийВозврат = 4294967296
    }

    public static class PostMarkParser
    {

        public static bool IsSimpleNotice(long postMark)
        {
            return ((PostMarkFlags)postMark & PostMarkFlags.ПростоеУведомление) == PostMarkFlags.ПростоеУведомление;
        }

        public static bool IsCustomNotice(long postMark)
        {
            return ((PostMarkFlags)postMark & PostMarkFlags.ЗаказноеУведомление) == PostMarkFlags.ЗаказноеУведомление;
        }

        public static bool IsInventory(long postMark)
        {
            return ((PostMarkFlags)postMark & PostMarkFlags.Опись) == PostMarkFlags.Опись;
        }

        public static bool IsElectronicNotice(long postMark)
        {
            return ((PostMarkFlags)postMark & PostMarkFlags.ЭлектронноеУведомление) == PostMarkFlags.ЭлектронноеУведомление;
        }
    }
}
