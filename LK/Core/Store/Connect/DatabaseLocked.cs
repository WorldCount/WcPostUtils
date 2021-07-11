using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using NLog;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace LK.Core.Store.Connect
{
    public class DatabaseLocked : IDisposable
    {
        private readonly SQLiteConnection _database;
        private readonly DatabaseDataLocked _databaseData;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once ConvertToAutoProperty
        public SQLiteConnection DB => _database;

        public DatabaseLocked()
        {
            _database = DbConnect.GetConnection();
            _databaseData = new DatabaseDataLocked(this);
        }

        public bool CreateDb()
        {
            try
            {

                if (!TableExist<Operator>())
                {
                    _database.CreateTable<Operator>();
                }

                if (!TableExist<Status>())
                {
                    _database.CreateTable<Status>();
                    _databaseData.FillStatusTable();
                }

                if (!TableExist<MailCategory>())
                {
                    _database.CreateTable<MailCategory>();
                    _databaseData.FillMailCategoryTable();
                }

                
                if (!TableExist<MailType>())
                {
                    _database.CreateTable<MailType>();
                    _databaseData.FillMailTypeTable();
                }
                
                if (!TableExist<Notice>())
                {
                    _database.CreateTable<Notice>();
                    _databaseData.FillNoticeTable();
                }

                if (!TableExist<Firm>())
                {
                    _database.CreateTable<Firm>();
                }

                if (!TableExist<FirmList>())
                {
                    _database.CreateTable<FirmList>();
                }

                if (!TableExist<Rpo>())
                {
                    _database.CreateTable<Rpo>();
                }

                return true;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> CreateDbAsync()
        {
            return await Task.Run(CreateDb);
        }

        public void InitDb()
        {
            CreateDb();
        }

        public async void InitDbAsync()
        {
            await CreateDbAsync();
        }

        public bool TableExist<T>()
        {
            const string q = "SELECT name FROM sqlite_master WHERE type='table' AND name=?";
            SQLiteCommand cmd = _database.CreateCommand(q, typeof(T).Name);
            return cmd.ExecuteScalar<string>() != null;
        }

        

        #region Запросы по организациям

        public Firm GetFirm(string inn, string kpp)
        {
            return _database.Table<Firm>().Where(f => f.Inn == inn).FirstOrDefault(f => f.Kpp == kpp);
        }

        public Firm GetFirm(int id)
        {
            return _database.Get<Firm>(id);
        }

        public Task<Firm> GetFirmAsync(string inn, string kpp)
        {
            return Task.Run(() => GetFirm(inn, kpp));
        }

        public Task<Firm> GetFirmAsync(int id)
        {
            return Task.Run(() => GetFirm(id));
        }

        public int SaveFirm(Firm firm)
        {
            if (firm.Id != 0)
            {
                _database.Update(firm);
                return firm.Id;
            }

            _database.Insert(firm);
            return _database.Table<Firm>().OrderByDescending(f => f.Id).FirstOrDefault().Id;
        }

        public Task<int> SaveFirmAsync(Firm firm)
        {
            return Task.Run(() => SaveFirm(firm));
        }

        public List<Firm> GetFirms()
        {
            try
            {
                return _database.Table<Firm>().OrderBy(f => f.ShortName).ToList();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<Firm>();
            }
            
        }

        public Task<List<Firm>> GetFirmsAsync()
        {
            return Task.Run(GetFirms);
        }

        #endregion

        #region Запросы по типам

        #region Тип отправления

        public MailType GetMailType(string name)
        {
            return _database.Table<MailType>().FirstOrDefault(m => m.Name == name);
        }
        
        public MailType GetMailType(int id)
        {
            return _database.Table<MailType>().FirstOrDefault(m => m.Id == id);
        }
        
        public Task<MailType> GetMailTypeAsync(string name)
        {
            return Task.Run(() => GetMailType(name));
        }
        
        public Task<MailType> GetMailTypeAsync(int id)
        {
            return Task.Run(() => GetMailType(id));
        }
        
        public List<MailType> GetMailTypes()
        {
            try
            {
                return _database.Table<MailType>().ToList();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<MailType>();
            }
            
        }
        
        public Task<List<MailType>> GetMailTypesAsync()
        {
            return Task.Run(GetMailTypes);
        }

        public List<MailType> GetEnabledMailTypes()
        {
            try
            {
                return _database.Table<MailType>().Where(m => m.Enable).ToList();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<MailType>();
            }
        }

        public Task<List<MailType>> GetEnabledMailTypesAsync()
        {
            return Task.Run(GetEnabledMailTypes);
        }

        public void UpdateMailTypes(List<MailType> mailTypes)
        {
            _database.UpdateAll(mailTypes);
        }

        #endregion

        #region Категория отправления

        public MailCategory GetMailCategory(string name)
        {
            return _database.Table<MailCategory>().FirstOrDefault(c => c.Name == name);
        }
        
        public MailCategory GetMailCategory(int id)
        {
            return _database.Table<MailCategory>().FirstOrDefault(c => c.Id == id);
        }
        
        public List<MailCategory> GetMailCategories()
        {
            try
            {
                return _database.Table<MailCategory>().ToList();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<MailCategory>();
            }
        }

        public List<MailCategory> GetEnabledMailCategories()
        {
            try
            {
                return _database.Table<MailCategory>().Where(c => c.Enable).ToList();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return new List<MailCategory>();
            }
        }

        public Task<MailCategory> GetMailCategoryAsync(string name)
        {
            return Task.Run(() => GetMailCategory(name));
        }
        
        public Task<MailCategory> GetMailCategoryAsync(int id)
        {
            return Task.Run(() => GetMailCategory(id));
        }
        
        public Task<List<MailCategory>> GetMailCategoryesAsync()
        {
            return Task.Run(GetMailCategories);
        }

        public Task<List<MailCategory>> GetEnabledMailCategoryesAsync()
        {
            return Task.Run(GetEnabledMailCategories);
        }

        #endregion

        #region Статус отправления

        public Status GetStatus(string name)
        {
            return _database.Table<Status>().FirstOrDefault(s => s.Name == name);
        }

        public Status GetStatus(int id)
        {
            return _database.Table<Status>().FirstOrDefault(s => s.Id == id);
        }

        public List<Status> GetStatuses()
        {
            return _database.Table<Status>().ToList();
        }

        public Task<Status> GetStatusAsync(string name)
        {
            return Task.Run(() => GetStatus(name));
        }

        public Task<Status> GetStatusAsync(int id)
        {
            return Task.Run(() => GetStatus(id));
        }

        public Task<List<Status>> GetStatusesAsync(int id)
        {
            return Task.Run(GetStatuses);
        }

        #endregion

        #endregion

        #region Запросы по спискам

        public int SaveFirmList(FirmList firmList)
        {
            if (firmList.Id != 0)
            {
                _database.Update(firmList);
                return firmList.Id;
            }

            _database.Insert(firmList);
            return _database.Table<FirmList>().OrderByDescending(f => f.Id).FirstOrDefault().Id;
        }

        public int SaveAllFirmList(List<FirmList> firmLists)
        {
            return _database.InsertAll(firmLists);
        }

        public List<FirmList> GetFirmsList(Firm firm, DateTime startDate, DateTime endDate)
        {
            var q = _database.Table<FirmList>().Where(f => f.Date >= startDate).Where(f => f.Date <= endDate);

            if (firm.Id != 0)
                q = q.Where(f => f.FirmId == firm.Id);

            List<FirmList> r = q.ToList();

            foreach (FirmList f in r)
                _database.GetChildren(f);

            return r;
        }

        public FirmList GetFirmList(int id)
        {
            return _database.Table<FirmList>().FirstOrDefault(r => r.Id == id);
        }

        public FirmList GetFirmList(DateTime date, int num)
        {
            return _database.Table<FirmList>().Where(r => r.Date == date).FirstOrDefault(r => r.Num == num);
        }

        public FirmList GetFirmList(int firmId, DateTime date, int num)
        {
            return _database.Table<FirmList>().Where(r => r.FirmId == firmId).Where(r => r.Date == date).FirstOrDefault(r => r.Num == num);
        }

        public Task<int> SaveFirmListAsync(FirmList rpoList)
        {
            return Task.Run(() => SaveFirmList(rpoList));
        }

        public Task<FirmList> GetFirmListAsync(int id)
        {
            return Task.Run(() => GetFirmList(id));
        }

        public Task<FirmList> GetFirmListAsync(DateTime date, int num)
        {
            return Task.Run(() => GetFirmList(date, num));
        }

        public Task<FirmList> GetFirmListAsync(int firmId, DateTime date, int num)
        {
            return Task.Run(() => GetFirmList(firmId, date, num));
        }

        #endregion

        #region Запросы по РПО

        public int SaveRpo(Rpo rpo)
        {
            if (rpo.Id != 0)
            {
                _database.Update(rpo);
                return rpo.Id;
            }

            _database.Insert(rpo);
            return _database.Table<Rpo>().OrderByDescending(r => r.Id).FirstOrDefault().Id;
        }

        public int SaveAllRpo(List<Rpo> rpos)
        {
            return _database.InsertAll(rpos);
        }

        public Rpo GetRpo(int id)
        {
            return _database.Table<Rpo>().FirstOrDefault(r => r.Id == id);
        }

        public Rpo GetRpo(string barcode, bool onlyAccept = false)
        {
            if (onlyAccept)
                return _database.Table<Rpo>().Where(r => r.StatusId == 2).FirstOrDefault(r => r.Barcode == barcode);
            return _database.Table<Rpo>().FirstOrDefault(r => r.Barcode == barcode);
        }

        public List<Rpo> GetRpos(string  barcode, bool onlyAccept = false)
        {
            if (onlyAccept)
                return _database.Table<Rpo>().Where(r => r.StatusId == 2).Where(r => r.Barcode == barcode).ToList();
            return _database.Table<Rpo>().Where(r => r.Barcode == barcode).ToList();
        }

        public Task<int> SaveRpoAsync(Rpo rpo)
        {
            return Task.Run(() => SaveRpo(rpo));
        }

        public Task<int> SaveAllRpoAsync(List<Rpo> rpos)
        {
            return Task.Run(() => SaveAllRpo(rpos));
        }

        public Task<Rpo> GetRpoAsync(int id)
        {
            return Task.Run(() => GetRpo(id));
        }

        public Task<Rpo> GetRpoAsync(string barcode, bool onlyAccept = false)
        {
            return Task.Run(() => GetRpo(barcode, onlyAccept));
        }

        public Task<List<Rpo>> GetRposAsync(string barcode, bool onlyAccept = false)
        {
            return Task.Run(() => GetRpos(barcode, onlyAccept));
        }



        #endregion

        #region Запросы по оператору

        public int SaveOperator(Operator oper)
        {
            if (oper.Id != 0)
            {
                _database.Update(oper);
                return oper.Id;
            }

            _database.Insert(oper);
            return _database.Table<Operator>().OrderByDescending(o => o.Id).FirstOrDefault().Id;
        }

        public Operator GetOperator(int id)
        {
            return _database.Table<Operator>().FirstOrDefault(o => o.Id == id);
        }

        public Operator GetOperator(string fullName)
        {
            return _database.Table<Operator>().FirstOrDefault(o => o.FullName == fullName);
        }

        #endregion


        public void Dispose()
        {
            _database?.Dispose();
        }
    }
}
