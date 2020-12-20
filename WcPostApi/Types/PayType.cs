using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WcPostApi.Types.Interface;

namespace WcPostApi.Types
{
    
    [Flags]
    public enum PayTypeFlag : long
    {
        Наличная = 1,
        Безналичная = 2,
        Бесплатно = 4,
        ПластиковаяКарта = 8,
        Марки = 16,
        Предоплата = 32,
        // ReSharper disable once InconsistentNaming
        ОплаченоМО = 64,
        Франкирование = 256
    }

    public class PayType : IPostType
    {
        [DisplayName(@"Code")]
        public long Code { get; set; }

        [DisplayName(@"Вкл")]
        public bool Enable { get; set; } = true;

        [DisplayName(@"Название")]
        public string Name { get; set; }

        [DisplayName(@"Сокращение")]
        public string ShortName { get; set; }

        public PayType() { }

        public PayType(long code, string name, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = name;
            Enable = enable;
        }

        public PayType(long code, string name, string shortName, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = shortName;
            Enable = enable;
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
                new PayType(1, "Наличная"),
                new PayType(2, "Безналичная"),
                new PayType(4, "Бесплатно"),
                new PayType(8, "Пластиковая карта"),
                new PayType(16, "Марки"),
                new PayType(32, "Предоплата"),
                new PayType(64, "Оплачено МО"),
                new PayType(256, "Франкирование")
            };
        }

        public static PayType GetByCode(long code) => _p.First(p => p.Code == code);
        public static PayType GetByName(string name) => _p.First(p => p.Name.ToUpper() == name.ToUpper());
        public static List<PayType> GetAll() => _p;
    }
}
