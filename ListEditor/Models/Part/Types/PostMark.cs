using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ListEditor.Models.Part.Types
{
    /// <summary>
    /// Почтовые отметки
    /// </summary>
    [Flags]
    public enum PostMarkFlags : long
    {
        [Description("Без отметки")]
        None = 0,
        [Description("Простое уведомление")]
        SimpleNotify = 1,
        [Description("Заказное уведомление")]
        CustomNotify = 2,
        [Description("С описью")]
        Inventory = 4,
        [Description("Осторожно (Хрупкая)")]
        Caution = 8,
        [Description("Тяжеловесная")]
        Heavy = 16,
        [Description("Крупногабаритная (Громоздкая)")]
        Bulky = 32,
        [Description("С доставкой (Доставка нарочным)")]
        Delivery = 64,
        [Description("Вручить в собственные руки")]
        InHand = 128,
        [Description("С документами")]
        Documents = 256,
        [Description("С товарами")]
        Products = 512,
        [Description("Возврату не подлежит")]
        NotReturn = 1024,
        [Description("Нестандартная")]
        Custom = 2048,
        [Description("Приграничная")]
        Border = 4096,
        [Description("Застраховано")]
        Insured = 8192,
        [Description("С электронным уведомлением")]
        ElectronicNotify = 16384,
        [Description("Курьер бизнес-экспресс")]
        CourierBusinessExpress = 32768,
        [Description("Нестандартная до 10 кг")]
        CustomTo10Kg = 65536,
        [Description("Нестандартная до 20 кг")]
        CustomTo20Kg = 131072,
        [Description("С наложенным платежом")]
        Payment = 262144,
        [Description("Гарантия сохранности")]
        SecurityGuarantee = 524288,
        [Description("Заверительный пакет")]
        CertificationPackage = 1048576,
        [Description("Доставка курьером")]
        DeliveryByCourier = 2097152,
        [Description("Проверка комплектности")]
        CompletenessCheck = 4194304,
        [Description("Негабаритная")]
        Oversized = 8388608,
        [Description("В упаковке Почты России")]
        PackageRussianPost = 16777216,
        [Description("Доставка по звонку")]
        DeliveryOnCall = 33554432,
        [Description("Ценность вложения")]
        Value = 67108864,
        [Description("С обратной доставкой")]
        ReturnDelivery = 134217728,
        [Description("В предоплаченном пакете")]
        PrepaidPackage = 268435456,
        [Description("ВСД")]
        // ReSharper disable once InconsistentNaming
        VSD = 536870912,
        [Description("Вручение с COD")]
        // ReSharper disable once InconsistentNaming
        HandingWithCOD = 1073741824,
        [Description("Запрещено продлевать срок хранения")]
        NoExtendStorage = 2147483648,
        [Description("Легкий возврат")]
        EasyReturn = 4294967296
    }

    /// <summary>
    /// Почтовые отметки
    /// </summary>
    public class PostMark
    {
        [DisplayName(@"Id")]
        public long Id { get; set; }
        [DisplayName(@"Название")]
        public string Name { get; set; }

        public PostMark() { }

        public PostMark(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public static class PostMarks
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<PostMark> _p;

        static PostMarks()
        {
            _p = new List<PostMark>
            {
                new PostMark(0, "Без отметки"),
                new PostMark(1, "С простым уведомлением"),
                new PostMark(2, "С заказным уведомлением"),
                new PostMark(4, "С описью"),
                new PostMark(8, "Осторожно (Хрупкая)"),
                new PostMark(16, "Тяжеловесная"),
                new PostMark(32, "Крупногабаритная (Громоздкая)"),
                new PostMark(64, "С доставкой (Доставка нарочным)"),
                new PostMark(128, "Вручить в собственные руки"),
                new PostMark(256, "С документами"),
                new PostMark(512, "С товарами"),
                new PostMark(1024, "Возврату не подлежит"),
                new PostMark(2048, "Нестандартная"),
                new PostMark(4096, "Приграничная"),
                new PostMark(8192, "Застраховано"),
                new PostMark(16384, "С электронным уведомлением"),
                new PostMark(32768, "Курьер бизнес-экспресс"),
                new PostMark(65536, "Нестандартная до 10 кг"),
                new PostMark(131072, "Нестандартная до 20 кг"),
                new PostMark(262144, "С наложенным платежом"),
                new PostMark(524288, "Гарантия сохранности"),
                new PostMark(1048576, "Заверительный пакет"),
                new PostMark(2097152, "Доставка курьером"),
                new PostMark(4194304, "Проверка комплектности"),
                new PostMark(8388608, "Негабаритная"),
                new PostMark(16777216, "В упаковке Почты России"),
                new PostMark(33554432, "Доставка по звонку"),
                new PostMark(67108864, "Ценность вложения"),
                new PostMark(134217728, "С обратной доставкой"),
                new PostMark(268435456, "В предоплаченном пакете"),
                new PostMark(536870912, "ВСД"),
                new PostMark(1073741824, "Вручение с COD"),
                new PostMark(2147483648, "Запрещено продлевать срок хранения"),
                new PostMark(4294967296, "Легкий возврат")
            };
        }

        public static PostMark GetById(long id) => _p.First(p => p.Id == id);
        public static PostMark GetByName(string name) => _p.First(p => p.Name.ToUpper() == name.ToUpper());
        public static List<PostMark> GetAll() => _p;
        public static List<PostMark> GetAllStandart() => _p.Where(p => p.Id != 0).ToList();

        public static long[] GetFlags(long idMask)
        {
            List<PostMark> p = new List<PostMark>(GetAllStandart());
            p.Reverse();

            List<long> res = new List<long>();
            foreach (PostMark postMark in p)
            {
                if (idMask - postMark.Id >= 0)
                {
                    idMask -= postMark.Id;
                    res.Add(postMark.Id);
                }
            }
            res.Reverse();
            return res.ToArray();
        }

        public static PostMarkFlags GetPostMarkFlags(long idMask)
        {
            long[] postMarks = GetFlags(idMask);
            PostMarkFlags postMarkFlags = PostMarkFlags.None;

            foreach (long postMark in postMarks)
            {
                postMarkFlags |= (PostMarkFlags) postMark;
            }

            return postMarkFlags;
        }
    }
}
