using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WcPostApi.Tafirs.Types;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Manager
{
    public class InterCustomParcelTarifManager
    {
        private readonly string _path;

        public InterCustomParcelTarifManager(string path)
        {
            _path = path;
        }

        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public static List<InterCustomParcelTarif> GetDefault()
        {
            List<InterCustomParcelTarif> tarifs = new List<InterCustomParcelTarif>
            {
                new InterCustomParcelTarif { Mass = 20, Rate = 208, TransType = TransType.Назем},
                new InterCustomParcelTarif { Mass = 100, Rate = 250, TransType = TransType.Назем},
                new InterCustomParcelTarif { Mass = 250, Rate = 355, TransType = TransType.Назем},
                new InterCustomParcelTarif { Mass = 500, Rate = 535, TransType = TransType.Назем},
                new InterCustomParcelTarif { Mass = 1000, Rate = 855, TransType = TransType.Назем},
                new InterCustomParcelTarif { Mass = 2000, Rate = 1285, TransType = TransType.Назем},
                new InterCustomParcelTarif { Mass = 3000, Rate = 1880, TransType = TransType.Назем},
                new InterCustomParcelTarif { Mass = 4000, Rate = 2475, TransType = TransType.Назем},
                new InterCustomParcelTarif { Mass = 5000, Rate = 3070, TransType = TransType.Назем},
                                             
                new InterCustomParcelTarif { Mass = 20, Rate = 213, TransType = TransType.Авиа},
                new InterCustomParcelTarif { Mass = 100, Rate = 270, TransType = TransType.Авиа},
                new InterCustomParcelTarif { Mass = 250, Rate = 395, TransType = TransType.Авиа},
                new InterCustomParcelTarif { Mass = 500, Rate = 590, TransType = TransType.Авиа},
                new InterCustomParcelTarif { Mass = 1000, Rate = 1015, TransType = TransType.Авиа},
                new InterCustomParcelTarif { Mass = 2000, Rate = 1605, TransType = TransType.Авиа},
                new InterCustomParcelTarif { Mass = 3000, Rate = 2315, TransType = TransType.Авиа},
                new InterCustomParcelTarif { Mass = 4000, Rate = 3025, TransType = TransType.Авиа},
                new InterCustomParcelTarif { Mass = 5000, Rate = 3735, TransType = TransType.Авиа},
            };

            return tarifs;
        }

        #endregion

        #region Sync

        public void Save(List<InterCustomParcelTarif> tarifs)
        {
            Serializer.Save(_path, tarifs);
        }

        public List<InterCustomParcelTarif> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return Serializer.Load<List<InterCustomParcelTarif>>(_path);
        }

        public InterCustomParcelTarif GetTarifByRate(double rate)
        {
            List<InterCustomParcelTarif> tarifs = Load();
            return tarifs.FirstOrDefault(p => p.Rate.Equals(rate));
        }

        #endregion

        #region Async

        public async Task<List<InterCustomParcelTarif>> LoadAsync()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return await Serializer.LoadAsync<List<InterCustomParcelTarif>>(_path);
        }

        public static async Task<List<InterCustomParcelTarif>> GetFromServer()
        {
            return await ServerTarificator.GetInterCustomParcelTarifs();
        }

        #endregion
    }
}
