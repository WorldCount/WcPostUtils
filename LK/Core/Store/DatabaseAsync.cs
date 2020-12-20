using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core.Models.DB;
using SQLite;

namespace LK.Core.Store
{
    public class DatabaseLockAsync
    {

        private readonly SQLiteAsyncConnection _asyncDatabase;
        //private readonly SQLiteConnection _syncDatabase;

        public SQLiteAsyncConnection AsyncDatabase => _asyncDatabase;
        //public SQLiteConnection SyncDatabase => _syncDatabase;

        public DatabaseLockAsync()
        {
            _asyncDatabase = new SQLiteAsyncConnection(PathManager.DbPath, storeDateTimeAsTicks: false);
        }

        public async Task<bool> CreateDb()
        {
            try
            {

                await _asyncDatabase.CreateTableAsync<Status>();
                await _asyncDatabase.CreateTableAsync<Firm>();
                await _asyncDatabase.CreateTableAsync<FirmList>();
                await _asyncDatabase.CreateTableAsync<Rpo>();
                //await _asyncDatabase.CreateTableAsync<MailCategory>();
                //await _asyncDatabase.CreateTableAsync<MailType>();
                //await _asyncDatabase.CreateTableAsync<PostMark>();

                FillStatusTable();
                FillMailTypeTable();
                FillMailCategoryTable();
                FillPostMarkTable();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public async void InitDb()
        {
            if (!File.Exists(PathManager.DbPath))
            {
                await CreateDb();
            }
        }

        public static bool DeleteDb()
        {
            if (!File.Exists(PathManager.DbPath))
            {
                try
                {
                    File.Delete(PathManager.DbPath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        #region Заполнение таблиц

        private void FillStatusTable()
        {
            Status s1 = new Status { Name = "Неизвестно" };
            Status s2 = new Status { Name = "Принято" };
            Status s3 = new Status { Name = "Отклонено" };
            Status s4 = new Status { Name = "Отсутствует" };

            _asyncDatabase.InsertAllAsync(new object[] { s1, s2, s3, s4 });
        }

        private void FillMailTypeTable()
        {
            //MailType m1 = new MailType { Code = 0, Name = "Не определено", ShortName = "Не определено", Enable = true };
            //MailType m2 = new MailType { Code = 2, Name = "Письмо", ShortName = "Письмо", Enable = true };
            //MailType m3 = new MailType { Code = 3, Name = "Бандероль", ShortName = "Бандероль", Enable = true };
            //MailType m4 = new MailType { Code = 15, Name = "Письмо 1 класса", ShortName = "Письмо 1 кл.", Enable = true };
            //MailType m5 = new MailType { Code = 16, Name = "Бандероль 1 класса", ShortName = "Бандероль 1 кл.", Enable = true };
            //
            //_asyncDatabase.InsertAllAsync(new object[] { m1, m2, m3, m4, m5 });

        }

        private void FillMailCategoryTable()
        {
            //MailCategory m1 = new MailCategory { Code = 1, Name = "Заказное", ShortName = "Заказное", Enable = true};
            //MailCategory m2 = new MailCategory { Code = 2, Name = "С объявленной ценностью", ShortName = "С ОЦ", Enable = true};
            //MailCategory m3 = new MailCategory { Code = 5, Name = "Не определено", ShortName = "Не определено", Enable = true};
            //
            //_asyncDatabase.InsertAllAsync(new object[] { m1, m2, m3 });
        }

        private void FillPostMarkTable()
        {
            //PostMark p1 = new PostMark { Code= 0, Name = "Без отметки", ShortName = "" };
            //PostMark p2 = new PostMark { Code= 1, Name = "Простое уведомление", ShortName = "Пр.Ув" };
            //PostMark p3 = new PostMark { Code= 2, Name = "Заказное уведомление", ShortName = "Зау.Ув" };
            //PostMark p4 = new PostMark { Code = 4, Name = "С описью", ShortName = "Опись" };
            //PostMark p5 = new PostMark { Code = 16384, Name = "Электронное уведомление", ShortName = "Эл.Ув" };
            //
            //_asyncDatabase.InsertAllAsync(new object[] { p1, p2, p3, p4, p5 });
        }

        #endregion

        public Task<Firm> GetFirmAsync(string inn, string kpp)
        {
            return _asyncDatabase.Table<Firm>().Where(f => f.Inn == inn).Where(f => f.Kpp == kpp).FirstOrDefaultAsync();
        }

        public Task<Firm> GetFirmAsync(int id)
        {
            return _asyncDatabase.Table<Firm>().Where(f => f.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveFirmAsync(Firm firm)
        {
            if (firm.Id != 0)
            {
                var id = _asyncDatabase.UpdateAsync(firm);
                return id;
            }
            else
                return _asyncDatabase.InsertAsync(firm);
        }

        public Task<List<Firm>> GetFirmsAsync()
        {
            return _asyncDatabase.Table<Firm>().ToListAsync();
        }

        
    }
}
