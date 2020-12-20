using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Models.Filters;
using LK.Core.Models.Types;
using NLog;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace LK.Core.Store
{
    public static class Database
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static bool CreateDb()
        {
            try
            {
                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    if (!TableExist<Operator>())
                    {
                        db.CreateTable<Operator>();
                    }

                    if (!TableExist<Status>())
                    {
                        db.CreateTable<Status>();
                        DatabaseData.FillStatusTable();
                    }

                    if (!TableExist<MailCategory>())
                    {
                        db.CreateTable<MailCategory>();
                        DatabaseData.FillMailCategoryTable();
                    }


                    if (!TableExist<MailType>())
                    {
                        db.CreateTable<MailType>();
                        DatabaseData.FillMailTypeTable();
                    }

                    if (!TableExist<Notice>())
                    {
                        db.CreateTable<Notice>();
                        DatabaseData.FillNoticeTable();
                    }

                    if (!TableExist<Firm>())
                    {
                        db.CreateTable<Firm>();
                    }

                    if (!TableExist<FirmList>())
                    {
                        db.CreateTable<FirmList>();
                    }

                    if (!TableExist<Rpo>())
                    {
                        db.CreateTable<Rpo>();
                    }

                    return true;
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }

        public static async Task<bool> CreateDbAsync()
        {
            return await Task.Run(CreateDb);
        }

        public static bool TableExist<T>()
        {
            const string q = "SELECT name FROM sqlite_master WHERE type='table' AND name=?";

            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                SQLiteCommand cmd = db.CreateCommand(q, typeof(T).Name);
                return cmd.ExecuteScalar<string>() != null;
            }
        }

        

        #region Запросы по организациям

        public static Firm GetFirm(string inn, string kpp)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Firm>().Where(f => f.Inn == inn).FirstOrDefault(f => f.Kpp == kpp);
            }
        }

        public static Firm GetFirm(int id)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Get<Firm>(id);
            }
        }

        public static Task<Firm> GetFirmAsync(string inn, string kpp)
        {
            return Task.Run(() => GetFirm(inn, kpp));
        }

        public static Task<Firm> GetFirmAsync(int id)
        {
            return Task.Run(() => GetFirm(id));
        }

        public static int SaveFirm(Firm firm)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                if (firm.Id != 0)
                {
                    db.Update(firm);
                    return firm.Id;
                }

                db.Insert(firm);
                return db.Table<Firm>().OrderByDescending(f => f.Id).FirstOrDefault().Id;
            }
        }

        public static void UpdateFirms(List<Firm> firms)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                db.UpdateAll(firms);
            }
        }

        public static void UpdateFirm(Firm firm)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                db.Update(firm);
            }
        }

        public static Task<int> SaveFirmAsync(Firm firm)
        {
            return Task.Run(() => SaveFirm(firm));
        }

        public static List<Firm> GetFirms()
        {
            try
            {
                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    return db.Table<Firm>().OrderBy(f => f.ShortName).ToList();
                }
                
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<Firm>();
            }
        }

        public static Task<List<Firm>> GetFirmsAsync()
        {
            return Task.Run(GetFirms);
        }

        #endregion

        #region Запросы по типам

        #region Тип отправления

        public static MailType GetMailType(string name)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<MailType>().FirstOrDefault(m => m.Name == name);
            }
        }
        
        public static MailType GetMailType(int id)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<MailType>().FirstOrDefault(m => m.Id == id);
            }
        }
        
        public static Task<MailType> GetMailTypeAsync(string name)
        {
            return Task.Run(() => GetMailType(name));
        }
        
        public static Task<MailType> GetMailTypeAsync(int id)
        {
            return Task.Run(() => GetMailType(id));
        }
        
        public static List<MailType> GetMailTypes()
        {
            try
            {
                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    return db.Table<MailType>().ToList();
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<MailType>();
            }
            
        }
        
        public static Task<List<MailType>> GetMailTypesAsync()
        {
            return Task.Run(GetMailTypes);
        }

        public static List<MailType> GetEnabledMailTypes()
        {
            try
            {
                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    return db.Table<MailType>().Where(m => m.Enable).ToList();
                }
                
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<MailType>();
            }
        }

        public static Task<List<MailType>> GetEnabledMailTypesAsync()
        {
            return Task.Run(GetEnabledMailTypes);
        }

        public static void UpdateMailTypes(List<MailType> mailTypes)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                db.UpdateAll(mailTypes);
            }
        }

        #endregion

        #region Категория отправления

        public static MailCategory GetMailCategory(string name)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<MailCategory>().FirstOrDefault(c => c.Name == name);
            }
            
        }
        
        public static MailCategory GetMailCategory(int id)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<MailCategory>().FirstOrDefault(c => c.Id == id);
            }
            
        }
        
        public static List<MailCategory> GetMailCategories()
        {
            try
            {
                List<MailCategory> d;
                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    d = db.Table<MailCategory>().ToList();
                }

                return d;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<MailCategory>();
            }
        }

        public static List<MailCategory> GetEnabledMailCategories()
        {
            try
            {
                List<MailCategory> d;

                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    d = db.Table<MailCategory>().Where(c => c.Enable).ToList();
                }

                return d;

            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<MailCategory>();
            }
        }

        public static Task<MailCategory> GetMailCategoryAsync(string name)
        {
            return Task.Run(() => GetMailCategory(name));
        }
        
        public static Task<MailCategory> GetMailCategoryAsync(int id)
        {
            return Task.Run(() => GetMailCategory(id));
        }
        
        public static Task<List<MailCategory>> GetMailCategoryesAsync()
        {
            return Task.Run(GetMailCategories);
        }

        public static Task<List<MailCategory>> GetEnabledMailCategoryesAsync()
        {
            return Task.Run(GetEnabledMailCategories);
        }

        public static void UpdateMailCategories(List<MailCategory> mailCategories)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                db.UpdateAll(mailCategories);
            }
        }

        #endregion

        #region Статус отправления

        public static Status GetStatus(string name)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Status>().FirstOrDefault(s => s.Name == name);
            }
            
        }

        public static Status GetStatus(int id)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Status>().FirstOrDefault(s => s.Id == id);
            }
            
        }

        public static List<Status> GetStatuses()
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Status>().ToList();
            }
            
        }

        public static Task<Status> GetStatusAsync(string name)
        {
            return Task.Run(() => GetStatus(name));
        }

        public static Task<Status> GetStatusAsync(int id)
        {
            return Task.Run(() => GetStatus(id));
        }

        public static Task<List<Status>> GetStatusesAsync(int id)
        {
            return Task.Run(GetStatuses);
        }

        #endregion

        #endregion

        #region Запросы по спискам

        public static int SaveFirmList(FirmList firmList)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                if (firmList.Id != 0)
                {
                    db.Update(firmList);
                    return firmList.Id;
                }

                db.Insert(firmList);
                return db.Table<FirmList>().OrderByDescending(f => f.Id).FirstOrDefault().Id;
            }
        }

        public static int SaveAllFirmList(List<FirmList> firmLists)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.InsertAll(firmLists);
            }
        }

        public static List<FirmList> GetFirmsListByDate(DateTime date)
        {
            DateTime s = Utils.CropDate(date);
            DateTime e = Utils.CropDate(date, 23, 59, 59);
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<FirmList>().Where(f => f.Date >= s && f.Date <= e).ToList();
            }
        }

        public static List<FirmList> GetFirmsList(Firm firm, DateTime date)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<FirmList>().Where(f => f.FirmId == firm.Id && f.Date == date).ToList();
            }
        }

        public static List<FirmList> GetFirmsList(Firm firm, DateTime startDate, DateTime endDate)
        {

            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                var q = db.Table<FirmList>().Where(f => f.ReceptionDate >= startDate && f.ReceptionDate <= endDate);

                if (firm.Id != 0)
                    q = q.Where(f => f.FirmId == firm.Id);

                return q.ToList();
            }
        }

        public static List<FirmList> GetFirmsList(FirmListFilter filter)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                var q = db.Table<FirmList>().Where(f => f.ReceptionDate >= filter.StartDate && f.ReceptionDate <= filter.EndDate);

                if(filter.FirmId != 0)
                    q = q.Where(f => f.FirmId == filter.FirmId);

                if (filter.MailClass != MailClass.ВСЕ)
                    q = q.Where(f => f.MailClass == filter.MailClass);


                if (filter.ErrorType == ErrorType.Возвращено)
                    q = q.Where(f => f.CountReturn > 0);

                if (filter.ErrorType == ErrorType.Пропущено)
                    q = q.Where(f => f.CountMiss > 0);

                if (filter.StartNum > 0)
                    q = q.Where(f => f.Num >= filter.StartNum);

                if (filter.EndNum > 0)
                    q = q.Where(f => f.Num <= filter.EndNum);

                if (filter.MailCategoryId > 0)
                    q = q.Where(f => f.MailCategory == filter.MailCategoryId);

                if (filter.MailTypeId > 0)
                    q = q.Where(f => f.MailType == filter.MailTypeId);

                if (filter.OperatorId > 0)
                    q = q.Where(f => f.OperatorId == filter.OperatorId);

                List<FirmList> r = q.ToList();

                foreach (FirmList f in r)
                {
                    f.Firm = db.GetWithChildren<Firm>(f.FirmId);
                    f.Operator = db.GetWithChildren<Operator>(f.OperatorId);
                }

                return r;
            }
        }

        public static List<FirmList> GetFirmsListAndChildren(Firm firm, DateTime startDate, DateTime endDate)
        {

            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                var q = db.Table<FirmList>().Where(f => f.Date >= startDate && f.Date <= endDate);

                if (firm.Id != 0)
                    q = q.Where(f => f.FirmId == firm.Id);

                List<FirmList> r = q.ToList();

                foreach (FirmList f in r)
                    db.GetChildren(f);

                return r;
            }
        }

        public static List<FirmList> GetFirmListsAndChildrenByIds(List<int> ids)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                List<FirmList> r = db.Table<FirmList>().Where(f => ids.Contains(f.Id)).ToList();
                foreach (FirmList f in r)
                    db.GetChildren(f);
                return r;
            }
        }

        public static List<Rpo> FirmListRpos(int firmListId)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Rpo>().Where(r => r.FirmListId == firmListId).ToList();
            }
        }

        public static FirmList GetFirmList(int id)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<FirmList>().FirstOrDefault(r => r.Id == id);
            }
        }

        public static FirmList GetFirmList(DateTime date, int num)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<FirmList>().Where(r => r.Date == date).FirstOrDefault(r => r.Num == num);
            }
        }

        public static FirmList GetFirmList(int firmId, DateTime date, int num)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<FirmList>().Where(r => r.FirmId == firmId).Where(r => r.Date == date).FirstOrDefault(r => r.Num == num);
            }
        }

        public static Task<int> SaveFirmListAsync(FirmList rpoList)
        {
            return Task.Run(() => SaveFirmList(rpoList));
        }

        public static Task<FirmList> GetFirmListAsync(int id)
        {
            return Task.Run(() => GetFirmList(id));
        }

        public static Task<FirmList> GetFirmListAsync(DateTime date, int num)
        {
            return Task.Run(() => GetFirmList(date, num));
        }

        public static Task<FirmList> GetFirmListAsync(int firmId, DateTime date, int num)
        {
            return Task.Run(() => GetFirmList(firmId, date, num));
        }

        public static void UpdateFirmLists(List<FirmList> firmLists)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                db.UpdateAll(firmLists);
            }
        }

        #endregion

        #region Запросы по РПО

        public static int SaveRpo(Rpo rpo)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                if (rpo.Id != 0)
                {
                    db.Update(rpo);
                    return rpo.Id;
                }

                db.Insert(rpo);
                return db.Table<Rpo>().OrderByDescending(r => r.Id).FirstOrDefault().Id;
            }
            
        }

        public static int SaveAllRpo(List<Rpo> rpos)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.InsertAll(rpos);
            }
        }

        public static Rpo GetRpo(int id)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Rpo>().FirstOrDefault(r => r.Id == id);
            }
        }

        public static Rpo GetRpo(string barcode, bool onlyAccept = false)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                if (onlyAccept)
                    return db.Table<Rpo>().Where(r => r.StatusId == 2).FirstOrDefault(r => r.Barcode == barcode);
                return db.Table<Rpo>().FirstOrDefault(r => r.Barcode == barcode);
            }
        }

        public static List<Rpo> GetRpos(string  barcode, bool onlyAccept = false)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                if (onlyAccept)
                    return db.Table<Rpo>().Where(r => r.StatusId == 2).Where(r => r.Barcode == barcode).ToList();
                return db.Table<Rpo>().Where(r => r.Barcode == barcode).ToList();
            }
        }

        public static List<Rpo> GetRposByListsIds(int[] ids)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Query<Rpo>($"SELECT * from RPO where firmListId IN ({string.Join(",", ids)}) and statusId = 2 order by MassRate");
            }
        }

        public static List<Rpo> GetRpos(int firmListId)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Rpo>().Where(r => r.FirmListId == firmListId).ToList();
            }
        }

        public static Task<int> SaveRpoAsync(Rpo rpo)
        {
            return Task.Run(() => SaveRpo(rpo));
        }

        public static Task<int> SaveAllRpoAsync(List<Rpo> rpos)
        {
            return Task.Run(() => SaveAllRpo(rpos));
        }

        public static Task<Rpo> GetRpoAsync(int id)
        {
            return Task.Run(() => GetRpo(id));
        }

        public static Task<Rpo> GetRpoAsync(string barcode, bool onlyAccept = false)
        {
            return Task.Run(() => GetRpo(barcode, onlyAccept));
        }

        public static Task<List<Rpo>> GetRposAsync(string barcode, bool onlyAccept = false)
        {
            return Task.Run(() => GetRpos(barcode, onlyAccept));
        }

        #endregion

        #region Запросы по оператору

        public static int SaveOperator(Operator oper)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                if (oper.Id != 0)
                {
                    db.Update(oper);
                    return oper.Id;
                }

                db.Insert(oper);
                return db.Table<Operator>().OrderByDescending(o => o.Id).FirstOrDefault().Id;
            }
        }

        public static Operator GetOperator(int id)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Operator>().FirstOrDefault(o => o.Id == id);
            }
            
        }

        public static Operator GetOperator(string fullName)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Operator>().FirstOrDefault(o => o.FullName == fullName);
            }
            
        }

        public static List<Operator> GetAllOperator()
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                return db.Table<Operator>().OrderBy(o => o.LastName).ToList();
            }
        }

        public static void UpdateOperators(List<Operator> operators)
        {
            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                db.UpdateAll(operators);
            }
        }

        #endregion

        #region Запросы по отчетам

        public static List<Rpo> GetValueRpos(DateTime startDate, DateTime endDate)
        {

            using (var db = new SQLiteConnection(PathManager.DbPath))
            {
                var q = db.Table<Rpo>().Where(r => r.ReceptionDate >= startDate && r.ReceptionDate <= endDate && r.StatusId == 2 && r.Value > 0);

                //if (firm.Id != 0)
                //    q = q.Where(r => r.FirmId == firm.Id);

                List<Rpo> rpos = q.ToList();

                return rpos;
            }
        }

        #endregion
    }
}
