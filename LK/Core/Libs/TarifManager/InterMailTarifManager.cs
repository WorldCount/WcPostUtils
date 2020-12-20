using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Libs.TarifManager.ServerTarif;
using LK.Core.Libs.TarifManager.Tarif;
using WcApi.Xml;

namespace LK.Core.Libs.TarifManager
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
                new InterMailTarif{StartMass = 0, EndMass = 20, Rate = 208, RateNds = 249.60, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 21, EndMass = 100, Rate = 250, RateNds = 300.00, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 101, EndMass = 250, Rate = 355, RateNds = 426.00, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 251, EndMass = 500, Rate = 535, RateNds = 642.00, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 501, EndMass = 1000, Rate = 855, RateNds = 1026.00, TransType = TransType.Назем},
                new InterMailTarif{StartMass = 1001, EndMass = 2000, Rate = 1285, RateNds = 1542.00, TransType = TransType.Назем},

                new InterMailTarif{StartMass = 0, EndMass = 20, Rate = 213, RateNds = 255.60, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 21, EndMass = 100, Rate = 270, RateNds = 324.00, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 101, EndMass = 250, Rate = 395, RateNds = 474.00, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 251, EndMass = 500, Rate = 590, RateNds = 708.00, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 501, EndMass = 1000, Rate = 1015, RateNds = 1218.00, TransType = TransType.Авиа},
                new InterMailTarif{StartMass = 1001, EndMass = 2000, Rate = 1605, RateNds = 1926.00, TransType = TransType.Авиа},
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
