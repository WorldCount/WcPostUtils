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
    public static class ServiceTarifManager
    {

        public static void Save(List<ServiceTarif> tarifs)
        {
            Serializer.Save(PathManager.ServiceTarifPath, tarifs);
        }

        public static List<ServiceTarif> Load()
        {
            if(!File.Exists(PathManager.ServiceTarifPath))
                CreateDefault();

            return Serializer.Load<List<ServiceTarif>>(PathManager.ServiceTarifPath);
        }

        public static async Task<List<ServiceTarif>> LoadAsync()
        {
            if (!File.Exists(PathManager.ServiceTarifPath))
                CreateDefault();

            return await Serializer.LoadAsync<List<ServiceTarif>>(PathManager.ServiceTarifPath);
        }

        public static ServiceTarif GetServiceTarifByType(ServiceType type)
        {
            List<ServiceTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Type == type);
        }

        public static ServiceTarif GetServiceTarifByRate(double rate)
        {
            List<ServiceTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        public static ServiceTarif GetServiceTarifByRateNds(double rate)
        {
            List<ServiceTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.RateNds.Equals(rate));
        }

        public static List<ServiceTarif> GetDefault()
        {
            List<ServiceTarif> tarifs = new List<ServiceTarif>
            {
                new ServiceTarif { Name = "Простое уведомление", Rate = 23.75, RateNds = 30.00, Type = ServiceType.ПростоеУв, Code = 1 },
                new ServiceTarif { Name = "Заказное уведомление", Rate = 60.0, RateNds = 78.00, Type = ServiceType.ЗаказноеУв, Code = 2 },
                new ServiceTarif { Name = "Электронное уведомление", Rate = 18.75, RateNds = 22.50, Type = ServiceType.ЭлектронноеУв, Code = 16384},
                new ServiceTarif { Name = "Международное уведомление", Rate = 92.00, RateNds = 110.40, Type = ServiceType.МеждународноеУв, Code = 1 },
                new ServiceTarif { Name = "Опись", Rate = 77.50, RateNds = 93.00, Type = ServiceType.Опись, Code = 0 }
            };

            return tarifs;
        }

        public static void CreateDefault()
        {
            Save(GetDefault());
        }

        public static async Task<List<ServiceTarif>> GetFromServer()
        {
            return await ServerTarificator.GetServiceTarifs();
        }
    }
}
