using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Libs.ServerTarif;
using PartStat.Core.Models.PostTypes;
using PartStat.Core.Models.Tarifs;
using WcApi.Xml;

namespace PartStat.Core.Libs.TarifManager
{
    public static class InterMailTarifManager
    {
        public static void Save(List<InterMailTarif> tarifs)
        {
            Serializer.Save(PathManager.InterMailTarifPath, tarifs);
        }

        public static List<InterMailTarif> Load()
        {
            if (!File.Exists(PathManager.InterMailTarifPath))
                CreateDefault();

            return Serializer.Load<List<InterMailTarif>>(PathManager.InterMailTarifPath);
        }

        public static async Task<List<InterMailTarif>> LoadAsync()
        {
            if(!File.Exists(PathManager.InterMailTarifPath))
                CreateDefault();

            return await Serializer.LoadAsync<List<InterMailTarif>>(PathManager.InterMailTarifPath);
        }

        public static InterMailTarif GetTarifByRate(double rate)
        {
            List<InterMailTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        public static List<InterMailTarif> GetDefault()
        {
            List<InterMailTarif> tarifs = new List<InterMailTarif>
            {
                new InterMailTarif{StartMass = 0, EndMass = 20, Rate = 208, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 21, EndMass = 100, Rate = 250, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 101, EndMass = 250, Rate = 355, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 251, EndMass = 500, Rate = 535, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 501, EndMass = 1000, Rate = 855, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 1001, EndMass = 2000, Rate = 1285, TransType = TransType.Назем},

                new InterMailTarif{StartMass = 0, EndMass = 20, Rate = 213, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 21, EndMass = 100, Rate = 270, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 101, EndMass = 250, Rate = 395, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 251, EndMass = 500, Rate = 590, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 501, EndMass = 1000, Rate = 1015, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 1001, EndMass = 2000, Rate = 1605, TransType = TransType.Авиа},
            };

            return tarifs;
        }

        public static void CreateDefault()
        {
            Save(GetDefault());
        }

        public static async Task<List<InterMailTarif>> GetFromServer()
        {
            return await ServerTarificator.GetInterMailTarifs();
        }
    }
}
