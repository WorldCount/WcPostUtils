using System.Collections.Generic;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Store.Connect;

namespace LK.Core.Store
{
    public static class DatabaseData
    {
        #region Заполнение таблиц

        public static void FillStatusTable()
        {
            Status s1 = new Status { Name = "Неизвестно" };
            Status s2 = new Status { Name = "Принято" };
            Status s3 = new Status { Name = "Отклонено" };
            Status s4 = new Status { Name = "Отсутствует" };

            using (var db = DbConnect.GetConnection())
                db.InsertAll(new object[] { s1, s2, s3, s4 });
        }

        public static void FillPayTypeTable()
        {
            PayType p1 = new PayType {Name = "Неизвестно", Type = Libs.Auth.Types.DocPayType.UNKNOW};
            PayType p2 = new PayType {Name = "Безнал", Type = Libs.Auth.Types.DocPayType.CASHLESS};
            PayType p3 = new PayType {Name = "Франк", Type = Libs.Auth.Types.DocPayType.POSTAGE_STAMPS_FRANKING};
            PayType p4 = new PayType {Name = "Марки", Type = Libs.Auth.Types.DocPayType.POSTAGE_STAMPS_SIGNS};
            PayType p5 = new PayType {Name = "Онлайн", Type = Libs.Auth.Types.DocPayType.POSTAGE_ONLINE_PAYMENT_MARK};

            using (var db = DbConnect.GetConnection())
                db.InsertAll(new object[] { p1, p2, p3, p4, p5 });
        }

        public static List<MailType> GetMailTypes()
        {
            List<MailType> mailTypes = new List<MailType>();

            foreach (WcPostApi.Types.MailType mailType in WcPostApi.Types.MailTypes.GetAll())
            {
                mailTypes.Add(new MailType(mailType));
            }

            return mailTypes;
        }

        public static void FillMailTypeTable()
        {
            using (var db = DbConnect.GetConnection())
                db.InsertAll(GetMailTypes());
        }

        public static List<MailCategory> GetMailCategories()
        {
            List<MailCategory> mailCategories = new List<MailCategory>();

            foreach (WcPostApi.Types.MailCategory mailCategory in WcPostApi.Types.MailCategories.GetAll())
            {
                mailCategories.Add(new MailCategory(mailCategory));
            }

            return mailCategories;
        }

        public static void FillMailCategoryTable()
        {
            using (var db = DbConnect.GetConnection())
                db.InsertAll(GetMailCategories());
        }

        public static void FillNoticeTable()
        {
            Notice p1 = new Notice { Code = 0, Name = "Без отметки", ShortName = "" };
            Notice p2 = new Notice { Code = 1, Name = "ПростоеУв уведомление", ShortName = "Пр.Ув" };
            Notice p3 = new Notice { Code = 2, Name = "ЗаказноеУв уведомление", ShortName = "Зау.Ув" };
            Notice p5 = new Notice { Code = 16384, Name = "ЭлектронноеУв уведомление", ShortName = "Эл.Ув" };

            using (var db = DbConnect.GetConnection())
                db.InsertAll(new object[] { p1, p2, p3, p5 });
        }

        public static void FillFirmsTable(List<Firm> firms)
        {
            using (var db = DbConnect.GetConnection())
                db.InsertAll(firms);
        }

        public static void FillGroupTable(List<Group> groups)
        {
            using (var db = DbConnect.GetConnection())
                db.InsertAll(groups);
        }

        #endregion
    }
}
