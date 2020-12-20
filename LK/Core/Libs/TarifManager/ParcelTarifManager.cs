using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LK.Core.Libs.TarifManager.ServerTarif;
using LK.Core.Libs.TarifManager.Tarif;
using WcApi.Xml;

namespace LK.Core.Libs.TarifManager
{
    public static class ParcelTarifManager
    {
        public static void Save(List<ParcelTarif> tarifs)
        {
            Serializer.Save(PathManager.ParcelTarifPath, tarifs);
        }

        public static List<ParcelTarif> Load()
        {
            if (!File.Exists(PathManager.ParcelTarifPath))
                CreateDefault();

            return Serializer.Load<List<ParcelTarif>>(PathManager.ParcelTarifPath);
        }

        public static async Task<List<ParcelTarif>> LoadAsync()
        {
            if (!File.Exists(PathManager.ParcelTarifPath))
                CreateDefault();

            return await Serializer.LoadAsync<List<ParcelTarif>>(PathManager.ParcelTarifPath);
        }

        public static List<ParcelTarif> GetDefault()
        {
            List<ParcelTarif> tarifs = Tarificator.ParcelTarificate(70.00, 3.00, 100, 5000, 20);
            return tarifs;
        }

        public static ParcelTarif GetNoticeTarifByRate(double rate)
        {
            List<ParcelTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        public static void CreateDefault()
        {
            Save(GetDefault());
        }

        public static async Task<List<ParcelTarif>> GetFromServer()
        {
            return await ServerTarificator.GetParcelTarifs();
        }
    }
}
