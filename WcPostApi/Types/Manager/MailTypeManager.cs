using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WcPostApi.Types.Manager
{
    public class MailTypeManager
    {
        private readonly string _path;

        public MailTypeManager(string path)
        {
            _path = path;
        }
        
        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public List<MailType> GetDefault()
        {
            return MailTypes.GetAll();
        }

        #endregion


        #region Sync

        public void Save(List<MailType> mailTypes)
        {
            Serializer.Save(_path, mailTypes);
        }

        public List<MailType> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();
            return Serializer.Load<List<MailType>>(_path);
        }



        public List<MailType> GetEnabled()
        {
            List<MailType> mailTypes = Load();
            return mailTypes.Where(m => m.Enable).ToList();
        }



        public MailType GetByCode(long code)
        {
            List<MailType> mailTypes = Load();
            return mailTypes.FirstOrDefault(m => m.Code == code);
        }

        #endregion


        #region Async
        public async Task<List<MailType>> LoadAsync()
        {
            return await Task.Run(Load);
        }

        public async Task<List<MailType>> GetEnabledAsync()
        {
            return await Task.Run(GetEnabled);
        }

        public async Task<MailType> GetByCodeAsync(long code)
        {
            return await Task.Run(() => GetByCode(code));
        }
        #endregion

    }
}
