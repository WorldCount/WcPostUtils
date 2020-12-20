using System.Collections.Generic;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using SQLite;

namespace LK.Core.Store.Connect
{
    public class DatabaseDataLocked
    {

        private readonly SQLiteConnection _database;

        public DatabaseDataLocked(DatabaseLocked database)
        {
            _database = database.DB;
        }

        #region Заполнение таблиц

        public void FillStatusTable()
        {
            Status s1 = new Status { Name = "Неизвестно" };
            Status s2 = new Status { Name = "Принято" };
            Status s3 = new Status { Name = "Отклонено" };
            Status s4 = new Status { Name = "Отсутствует" };

            _database.InsertAll(new object[] { s1, s2, s3, s4 });
        }

        public List<MailType> GetMailTypes()
        {
            List<MailType> mailTypes = new List<MailType>();

            foreach (WcPostApi.Types.MailType mailType in WcPostApi.Types.MailTypes.GetAll())
            {
                mailTypes.Add(new MailType(mailType));
            }

            return mailTypes;
        }

        public void FillMailTypeTable()
        {
            _database.InsertAll(GetMailTypes());

        }

        public List<MailCategory> GetMailCategories()
        {
            List<MailCategory> mailCategories = new List<MailCategory>();

            foreach (WcPostApi.Types.MailCategory mailCategory in WcPostApi.Types.MailCategories.GetAll())
            {
                mailCategories.Add(new MailCategory(mailCategory));
            }

            return mailCategories;
        }

        public void FillMailCategoryTable()
        {
            _database.InsertAll(GetMailCategories());
        }

        public void FillNoticeTable()
        {
            Notice p1 = new Notice { Code = 0, Name = "Без отметки", ShortName = "" };
            Notice p2 = new Notice { Code = 1, Name = "Простое уведомление", ShortName = "Пр.Ув" };
            Notice p3 = new Notice { Code = 2, Name = "Заказное уведомление", ShortName = "Зау.Ув" };
            Notice p5 = new Notice { Code = 16384, Name = "Электронное уведомление", ShortName = "Эл.Ув" };

            _database.InsertAll(new object[] { p1, p2, p3, p5 });
        }

        #endregion
    }
}
