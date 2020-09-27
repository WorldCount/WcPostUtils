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
    public static class FirstParcelTarifManager
    {
        public static void Save(List<FirstParcelTarif> tarifs)
        {
            Serializer.Save(PathManager.FirstParcelTarifPath, tarifs);
        }

        public static List<FirstParcelTarif> Load()
        {
            if (!File.Exists(PathManager.FirstParcelTarifPath))
                CreateDefault();

            return Serializer.Load<List<FirstParcelTarif>>(PathManager.FirstParcelTarifPath);
        }

        public static async Task<List<FirstParcelTarif>> LoadAsync()
        {
            if (!File.Exists(PathManager.FirstParcelTarifPath))
                CreateDefault();

            return await Serializer.LoadAsync<List<FirstParcelTarif>>(PathManager.FirstParcelTarifPath);
        }

        public static FirstParcelTarif GetNoticeTarifByRate(double rate)
        {
            List<FirstParcelTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        public static List<FirstParcelTarif> GetDefault()
        {
            List<FirstParcelTarif> tarifs = new List<FirstParcelTarif>
            {
                new FirstParcelTarif {StartMass = 0, EndMass = 100, Rate = 145.00},
                new FirstParcelTarif {StartMass = 101, EndMass = 200, Rate = 170.00},
                new FirstParcelTarif {StartMass = 201, EndMass = 500, Rate = 225.00},

                new FirstParcelTarif {StartMass = 501, EndMass = 1000, Rate = 300.00},
                new FirstParcelTarif {StartMass = 1001, EndMass = 1500, Rate = 460.00},
                new FirstParcelTarif {StartMass = 1501, EndMass = 2000, Rate = 610.00},
                new FirstParcelTarif {StartMass = 2001, EndMass = 2500, Rate = 750.00},

                new FirstParcelTarif {StartMass = 501, EndMass = 1000, Rate = 340.00, TransType = TransType.Свыше2000Км},
                new FirstParcelTarif {StartMass = 1001, EndMass = 1500, Rate = 510.00, TransType = TransType.Свыше2000Км},
                new FirstParcelTarif {StartMass = 1501, EndMass = 2000, Rate = 670.00, TransType = TransType.Свыше2000Км},
                new FirstParcelTarif {StartMass = 2001, EndMass = 2500, Rate = 810.00, TransType = TransType.Свыше2000Км},
            };

            return tarifs;
        }

        public static void CreateDefault()
        {
            Save(GetDefault());
        }

        public static async Task<List<FirstParcelTarif>> GetFromServer()
        {
            return await ServerTarificator.GetFirstParcelTarifs();
        }
    }
}
