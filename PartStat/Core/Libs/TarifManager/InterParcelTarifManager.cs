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
    public static class InterParcelTarifManager
    {
        public static void Save(List<InterParcelTarif> tarifs)
        {
            Serializer.Save(PathManager.InterParcelTarifPath, tarifs);
        }

        public static List<InterParcelTarif> Load()
        {
            if (!File.Exists(PathManager.InterParcelTarifPath))
                CreateDefault();

            return Serializer.Load<List<InterParcelTarif>>(PathManager.InterParcelTarifPath);
        }

        public static async Task<List<InterParcelTarif>> LoadAsync()
        {
            if (!File.Exists(PathManager.InterParcelTarifPath))
                CreateDefault();

            return await Serializer.LoadAsync<List<InterParcelTarif>>(PathManager.InterParcelTarifPath);
        }

        public static InterParcelTarif GetTarifByRate(double rate)
        {
            List<InterParcelTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        public static List<InterParcelTarif> GetDefault()
        {
            List<InterParcelTarif> tarifs = new List<InterParcelTarif>
            {
                new InterParcelTarif{StartMass = 0, EndMass = 20, Rate = 208, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 21, EndMass = 100, Rate = 250, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 101, EndMass = 250, Rate = 355, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 251, EndMass = 500, Rate = 535, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 501, EndMass = 1000, Rate = 855, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 1001, EndMass = 2000, Rate = 1285, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 2001, EndMass = 3000, Rate = 1880, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 3001, EndMass = 4000, Rate = 2475, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 4001, EndMass = 5000, Rate = 3070, TransType = TransType.Назем},

                new InterParcelTarif{StartMass = 0, EndMass = 20, Rate = 213, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 21, EndMass = 100, Rate = 270, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 101, EndMass = 250, Rate = 395, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 251, EndMass = 500, Rate = 590, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 501, EndMass = 1000, Rate = 1015, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 1001, EndMass = 2000, Rate = 1605, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 2001, EndMass = 3000, Rate = 2315, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 3001, EndMass = 4000, Rate = 3025, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 4001, EndMass = 5000, Rate = 3735, TransType = TransType.Авиа},
            };

            return tarifs;
        }

        public static void CreateDefault()
        {
            Save(GetDefault());
        }

        public static async Task<List<InterParcelTarif>> GetFromServer()
        {
            return await ServerTarificator.GetInterParcelTarifs();
        }
    }
}
