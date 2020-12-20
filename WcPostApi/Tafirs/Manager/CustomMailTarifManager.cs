using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WcPostApi.Tafirs.Types;

namespace WcPostApi.Tafirs.Manager
{
    public class CustomMailTarifManager
    {
        private readonly string _path;

        public CustomMailTarifManager(string path)
        {
            _path = path;
        }

        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public static List<CustomMailTarif> GetDefault()
        {
            List<CustomMailTarif> tarifs = Tarificator.MailTarificate(54.00, 3.00, 20, 100, 20);
            return tarifs;
        }

        #endregion

        #region Sync

        public void Save(List<CustomMailTarif> tarifs)
        {
            Serializer.Save(_path, tarifs);
        }

        public List<CustomMailTarif> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return Serializer.Load<List<CustomMailTarif>>(_path);
        }

        public CustomMailTarif GetTarifByRate(double rate)
        {
            List<CustomMailTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        #endregion

        #region Async

        public async Task<List<CustomMailTarif>> LoadAsync()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return await Serializer.LoadAsync<List<CustomMailTarif>>(_path);
        }

        public static async Task<List<CustomMailTarif>> GetFromServer(int step, int startWeight, int endWeight)
        {
            return await ServerTarificator.GetCustomMailTarifs(step, startWeight, endWeight);
        }

        #endregion
    }
}
