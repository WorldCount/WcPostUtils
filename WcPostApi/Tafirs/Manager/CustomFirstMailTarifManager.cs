using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WcPostApi.Tafirs.Types;

namespace WcPostApi.Tafirs.Manager
{
    public class CustomFirstMailTarifManager
    {
        private readonly string _path;

        public CustomFirstMailTarifManager(string path)
        {
            _path = path;
        }

        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public static List<CustomFirstMail> GetDefault()
        {
            List<CustomFirstMail> tarifs = new List<CustomFirstMail>
            {
                new CustomFirstMail {Mass = 20, Rate = 95.00},
                new CustomFirstMail {Mass = 50, Rate = 110.00},
                new CustomFirstMail {Mass = 100, Rate = 130.00},
                new CustomFirstMail {Mass = 200, Rate = 155.00},
                new CustomFirstMail {Mass = 500, Rate = 210.00},
            };

            return tarifs;
        }

        #endregion

        #region Sync

        public void Save(List<CustomFirstMail> tarifs)
        {
            Serializer.Save(_path, tarifs);
        }

        public List<CustomFirstMail> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return Serializer.Load<List<CustomFirstMail>>(_path);
        }

        public CustomFirstMail GetTarifByRate(double rate)
        {
            List<CustomFirstMail> tarifs = Load();
            return tarifs.FirstOrDefault(p => p.Rate.Equals(rate));
        }

        #endregion

        #region Async

        public async Task<List<CustomFirstMail>> LoadAsync()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return await Serializer.LoadAsync<List<CustomFirstMail>>(_path);
        }

        public static async Task<List<CustomFirstMail>> GetFromServer()
        {
            return await ServerTarificator.GetCustomFirstMailTarifs();
        }

        #endregion
    }
}
