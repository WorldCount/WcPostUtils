using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WcPostApi.Types.Manager
{
    public class MailCategoryManager
    {

        private readonly string _path;

        public MailCategoryManager(string path)
        {
            _path = path;
        }

        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public List<MailCategory> GetDefault()
        {
            return MailCategories.GetAll();
        }

        #endregion


        #region Sync

        public void Save(List<MailCategory> mailCategories)
        {
            Serializer.Save(_path, mailCategories);
        }

        public List<MailCategory> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();
            return Serializer.Load<List<MailCategory>>(_path);
        }

        public List<MailCategory> GetEnabled()
        {
            List<MailCategory> mailCategories = Load();
            return mailCategories.Where(m => m.Enable).ToList();
        }

        public MailCategory GetByCode(long code)
        {
            List<MailCategory> mailCategories = Load();
            return mailCategories.FirstOrDefault(m => m.Code == code);
        }

        #endregion


        #region Async

        public async Task<List<MailCategory>> LoadAsync()
        {
            return await Task.Run(Load);
        }

        public async Task<List<MailCategory>> GetEnabledAsync()
        {
            return await Task.Run(GetEnabled);
        }

        public async Task<MailCategory> GetByCodeAsync(long code)
        {
            return await Task.Run(() => GetByCode(code));
        }

        #endregion
    }
}
