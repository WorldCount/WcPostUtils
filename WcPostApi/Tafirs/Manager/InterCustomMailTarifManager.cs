using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WcPostApi.Tafirs.Types;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Manager
{
    public class InterCustomMailTarifManager
    {
        private readonly string _path;

        public InterCustomMailTarifManager(string path)
        {
            _path = path;
        }

        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public static List<InterCustomMailTarif> GetDefault()
        {
            List<InterCustomMailTarif> tarifs = new List<InterCustomMailTarif>
            {
                new InterCustomMailTarif{ Mass = 20, Rate = 208, TransType = TransType.Назем },
                new InterCustomMailTarif{ Mass = 100, Rate = 250, TransType = TransType.Назем },
                new InterCustomMailTarif{ Mass = 250, Rate = 355, TransType = TransType.Назем },
                new InterCustomMailTarif{ Mass = 500, Rate = 535, TransType = TransType.Назем },
                new InterCustomMailTarif{ Mass = 1000, Rate = 855, TransType = TransType.Назем },
                new InterCustomMailTarif{ Mass = 2000, Rate = 1285, TransType = TransType.Назем },
                                          
                new InterCustomMailTarif{ Mass = 20, Rate = 213, TransType = TransType.Авиа },
                new InterCustomMailTarif{ Mass = 100, Rate = 270, TransType = TransType.Авиа },
                new InterCustomMailTarif{ Mass = 250, Rate = 395, TransType = TransType.Авиа },
                new InterCustomMailTarif{ Mass = 500, Rate = 590, TransType = TransType.Авиа },
                new InterCustomMailTarif{ Mass = 1000, Rate = 1015, TransType = TransType.Авиа },
                new InterCustomMailTarif{ Mass = 2000, Rate = 1605, TransType = TransType.Авиа },
            };

            return tarifs;
        }

        #endregion

        #region Sync

        public void Save(List<InterCustomMailTarif> tarifs)
        {
            Serializer.Save(_path, tarifs);
        }

        public List<InterCustomMailTarif> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return Serializer.Load<List<InterCustomMailTarif>>(_path);
        }

        public InterCustomMailTarif GetTarifByRate(double rate)
        {
            List<InterCustomMailTarif> tarifs = Load();
            return tarifs.FirstOrDefault(p => p.Rate.Equals(rate));
        }

        #endregion

        #region Async

        public async Task<List<InterCustomMailTarif>> LoadAsync()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return await Serializer.LoadAsync<List<InterCustomMailTarif>>(_path);
        }

        public static async Task<List<InterCustomMailTarif>> GetFromServer()
        {
            return await ServerTarificator.GetInterCustomMailTarifs();
        }

        #endregion
    }
}
