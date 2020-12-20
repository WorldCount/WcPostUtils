using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WcPostApi.Tafirs.Types;

namespace WcPostApi.Tafirs.Manager
{
    public class CustomParcelTarifManager
    {
        private readonly string _path;

        public CustomParcelTarifManager(string path)
        {
            _path = path;
        }

        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public static List<CustomParcelTarif> GetDefault()
        {
            List<CustomParcelTarif> tarifs = Tarificator.ParcelTarificate(70.00, 3.00, 100, 5000, 20);
            return tarifs;
        }

        #endregion

        #region Sync

        public void Save(List<CustomParcelTarif> tarifs)
        {
            Serializer.Save(_path, tarifs);
        }

        public List<CustomParcelTarif> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return Serializer.Load<List<CustomParcelTarif>>(_path);
        }

        public CustomParcelTarif GetTarifByRate(double rate)
        {
            List<CustomParcelTarif> tarifs = Load();
            return tarifs.FirstOrDefault(p => p.Rate.Equals(rate));
        }

        #endregion

        #region Async

        public async Task<List<CustomParcelTarif>> LoadAsync()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return await Serializer.LoadAsync<List<CustomParcelTarif>>(_path);
        }

        public static async Task<List<CustomParcelTarif>> GetFromServer(int step, int startWeight, int endWeight)
        {
            return await ServerTarificator.GetCustomParcelTarifs(step, startWeight, endWeight);
        }

        #endregion
    }
}
