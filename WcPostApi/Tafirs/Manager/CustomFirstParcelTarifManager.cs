using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WcPostApi.Tafirs.Types;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Manager
{
    public class CustomFistParcelTarifManager
    {
        private readonly string _path;

        public CustomFistParcelTarifManager(string path)
        {
            _path = path;
        }

        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public static List<CustomFirstParcel> GetDefault()
        {
            List<CustomFirstParcel> tarifs = new List<CustomFirstParcel>
            {
                new CustomFirstParcel { Mass = 100, Rate = 145.00},
                new CustomFirstParcel { Mass = 200, Rate = 170.00},
                new CustomFirstParcel { Mass = 500, Rate = 225.00},

                new CustomFirstParcel { Mass = 1000, Rate = 300.00},
                new CustomFirstParcel { Mass = 1500, Rate = 460.00},
                new CustomFirstParcel { Mass = 2000, Rate = 610.00},
                new CustomFirstParcel { Mass = 2500, Rate = 750.00},

                new CustomFirstParcel { Mass = 1000, Rate = 340.00, TransType = TransType.Свыше2000Км},
                new CustomFirstParcel { Mass = 1500, Rate = 510.00, TransType = TransType.Свыше2000Км},
                new CustomFirstParcel { Mass = 2000, Rate = 670.00, TransType = TransType.Свыше2000Км},
                new CustomFirstParcel { Mass = 2500, Rate = 810.00, TransType = TransType.Свыше2000Км},
            };

            return tarifs;
        }

        #endregion

        #region Sync

        public void Save(List<CustomFirstParcel> tarifs)
        {
            Serializer.Save(_path, tarifs);
        }

        public List<CustomFirstParcel> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return Serializer.Load<List<CustomFirstParcel>>(_path);
        }

        public CustomFirstParcel GetTarifByRate(double rate)
        {
            List<CustomFirstParcel> tarifs = Load();
            return tarifs.FirstOrDefault(p => p.Rate.Equals(rate));
        }

        #endregion

        #region Async

        public async Task<List<CustomFirstParcel>> LoadAsync()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return await Serializer.LoadAsync<List<CustomFirstParcel>>(_path);
        }

        public static async Task<List<CustomFirstParcel>> GetFromServer()
        {
            return await ServerTarificator.GetCustomFirstParcelTarifs();
        }

        #endregion
    }
}
