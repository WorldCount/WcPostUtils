using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LK.Core.Libs.TarifManager.ServerTarif;
using LK.Core.Libs.TarifManager.Tarif;
using WcApi.Xml;

namespace LK.Core.Libs.TarifManager
{
    class FirstMailTarifManager
    {
        public static void Save(List<FirstMailTarif> tarifs)
        {
            Serializer.Save(PathManager.FirstMailTarifPath, tarifs);
        }

        public static List<FirstMailTarif> Load()
        {
            if (!File.Exists(PathManager.FirstMailTarifPath))
                CreateDefault();

            return Serializer.Load<List<FirstMailTarif>>(PathManager.FirstMailTarifPath);
        }

        public static async Task<List<FirstMailTarif>> LoadAsync()
        {
            if (!File.Exists(PathManager.FirstMailTarifPath))
                CreateDefault();

            return await Serializer.LoadAsync<List<FirstMailTarif>>(PathManager.FirstMailTarifPath);
        }

        public static FirstMailTarif GetNoticeTarifByRate(double rate)
        {
            List<FirstMailTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        public static List<FirstMailTarif> GetDefault()
        {
            List<FirstMailTarif> tarifs = new List<FirstMailTarif>
            {
                new FirstMailTarif {StartMass = 0, EndMass = 20, Rate = 95.00, RateNds = 114.00},
                new FirstMailTarif {StartMass = 21, EndMass = 50, Rate = 110.00, RateNds = 132.00},
                new FirstMailTarif {StartMass = 51, EndMass = 100, Rate = 130.00, RateNds = 156.00},
                new FirstMailTarif {StartMass = 101, EndMass = 200, Rate = 155.00, RateNds = 186.00},
                new FirstMailTarif {StartMass = 201, EndMass = 500, Rate = 210.00, RateNds = 252.00},
            };

            return tarifs;
        }

        public static void CreateDefault()
        {
            Save(GetDefault());
        }

        public static async Task<List<FirstMailTarif>> GetFromServer()
        {
            return await ServerTarificator.GetFirstMailTarifs();
        }
    }
}
