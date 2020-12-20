using System;

namespace LK.Core.Libs.TarifManager.PostTypes
{
    [Flags]
    public enum PostMark : long
    {
        БезОтметки = 0,
        ПростоеУведомление = 1,
        ЗаказноеУведомление = 2,
        Опись = 4,
        Осторожно = 8,
        Тяжеловесная = 16,
        Крупногабаритная = 32,
        Доставка = 64,
        ВручитьВсобственныеРуки = 128,
        Документы = 256,
        Товары = 512,
        ВозвратуНеПодлежит = 1024,
        Нестандартная = 2048,
        Приграничная = 4096,
        Застраховано = 8192,
        ЭлектронноеУведомление = 16384, 
        КурьерБизнесЭкспресс = 32768,
        НестандартнаяДо10Кг = 65536,
        НестандартнаяДо20Кг = 131072,
        НаложенныйПлатеж = 262144,
        ГарантияСохранности = 524288,
        ЗаверительныйПакет = 1048576,
        ДоставкаКурьером = 2097152,
        ПроверкаКомплектности = 4194304,
        Негабаритная = 8388608,
        УпаковкаПочтыРоссии = 16777216,
        ДоставкаПоЗвонку = 33554432,
        ЦенностьВложения = 67108864,
        ОбратнаяДоставка = 134217728,
        ПредоплаченныйПакет = 268435456,
        // ReSharper disable once InconsistentNaming
        ВСД = 536870912,
        // ReSharper disable once InconsistentNaming
        COD = 1073741824,
        ЗапрещеноПродлеватьСрокХранения = 2147483648,
        ЛегкийВозврат = 4294967296
    }

    public static class PostMarkParser
    {

        public static bool IsSimpleNotice(long postMark)
        {
            return ((PostMark) postMark & PostMark.ПростоеУведомление) == PostMark.ПростоеУведомление;
        }

        public static bool IsCustomNotice(long postMark)
        {
            return ((PostMark)postMark & PostMark.ЗаказноеУведомление) == PostMark.ЗаказноеУведомление;
        }

        public static bool IsInventory(long postMark)
        {
            return ((PostMark)postMark & PostMark.Опись) == PostMark.Опись;
        }

        public static bool IsElectronicNotice(long postMark)
        {
            return ((PostMark)postMark & PostMark.ЭлектронноеУведомление) == PostMark.ЭлектронноеУведомление;
        }
    }
}
