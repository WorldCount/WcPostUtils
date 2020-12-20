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
                new InterParcelTarif{StartMass = 0, EndMass = 20, Rate = 208, RateNds = 249.60, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 21, EndMass = 100, Rate = 250, RateNds = 300.00, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 101, EndMass = 250, Rate = 355, RateNds = 426.00, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 251, EndMass = 500, Rate = 535, RateNds = 642.00, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 501, EndMass = 1000, Rate = 855, RateNds = 1026.00, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 1001, EndMass = 2000, Rate = 1285, RateNds = 1542.00, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 2001, EndMass = 3000, Rate = 1880, RateNds = 2252.00, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 3001, EndMass = 4000, Rate = 2475, RateNds = 2970.00, TransType = TransType.Назем},
                new InterParcelTarif{StartMass = 4001, EndMass = 5000, Rate = 3070, RateNds = 3070.00, TransType = TransType.Назем},

                new InterParcelTarif{StartMass = 0, EndMass = 20, Rate = 213, RateNds = 255.60, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 21, EndMass = 100, Rate = 270, RateNds = 324.00, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 101, EndMass = 250, Rate = 395, RateNds = 474.00, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 251, EndMass = 500, Rate = 590, RateNds = 708.00, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 501, EndMass = 1000, Rate = 1015, RateNds = 1218.00, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 1001, EndMass = 2000, Rate = 1605, RateNds = 1926.00, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 2001, EndMass = 3000, Rate = 2315, RateNds = 2778.00, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 3001, EndMass = 4000, Rate = 3025, RateNds = 3630.00, TransType = TransType.Авиа},
                new InterParcelTarif{StartMass = 4001, EndMass = 5000, Rate = 3735, RateNds = 4482.00, TransType = TransType.Авиа},
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
