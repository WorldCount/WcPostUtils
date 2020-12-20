using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LK.Core.Libs.TarifManager.ServerTarif;
using LK.Core.Libs.TarifManager.Tarif;
using WcApi.Xml;

namespace LK.Core.Libs.TarifManager
{
    public static class MailTarifManager
    {
        public static void Save(List<MailTarif> tarifs)
        {
            Serializer.Save(PathManager.MailTarifPath, tarifs);
        }

        public static List<MailTarif> Load()
        {
            if (!File.Exists(PathManager.MailTarifPath))
                CreateDefault();

            return Serializer.Load<List<MailTarif>>(PathManager.MailTarifPath);
        }

        public static async Task<List<MailTarif>> LoadAsync()
        {
            if (!File.Exists(PathManager.MailTarifPath))
                CreateDefault();

            return await Serializer.LoadAsync<List<MailTarif>>(PathManager.MailTarifPath);
        }

        public static List<MailTarif> GetDefault()
        {
            List<MailTarif> tarifs = Tarificator.MailTarificate(54.00, 3.00, 20, 100, 20);
            return tarifs;
        }

        public static MailTarif GetMailTarifByRate(double rate)
        {
            List<MailTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        public static void CreateDefault()
        {
            Save(GetDefault());
        }

        public static async Task<List<MailTarif>> GetFromServer()
        {
            return await ServerTarificator.GetMailTarifs();
        }
    }
}
