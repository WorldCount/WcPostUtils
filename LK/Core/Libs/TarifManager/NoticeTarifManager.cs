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
    public static class NoticeTarifManager
    {

        public static void Save(List<NoticeTarif> tarifs)
        {
            Serializer.Save(PathManager.NoticeTarifPath, tarifs);
        }

        public static List<NoticeTarif> Load()
        {
            if(!File.Exists(PathManager.NoticeTarifPath))
                CreateDefault();

            return Serializer.Load<List<NoticeTarif>>(PathManager.NoticeTarifPath);
        }

        public static async Task<List<NoticeTarif>> LoadAsync()
        {
            if (!File.Exists(PathManager.NoticeTarifPath))
                CreateDefault();

            return await Serializer.LoadAsync<List<NoticeTarif>>(PathManager.NoticeTarifPath);
        }

        public static NoticeTarif GetNoticeTarifByType(NoticeType type)
        {
            List<NoticeTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Type == type);
        }

        public static NoticeTarif GetNoticeTarifByRate(double rate)
        {
            List<NoticeTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Rate.Equals(rate));
        }

        public static NoticeTarif GetNoticeTarifByRateNds(double rate)
        {
            List<NoticeTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.RateNds.Equals(rate));
        }

        public static List<NoticeTarif> GetDefault()
        {
            List<NoticeTarif> tarifs = new List<NoticeTarif>
            {
                new NoticeTarif { Name = "Простое уведомление", Rate = 23.75, RateNds = 30.00, Type = NoticeType.Простое, Code = 1 },
                new NoticeTarif { Name = "Заказное уведомление", Rate = 60.0, RateNds = 78.00, Type = NoticeType.Заказное, Code = 2 },
                new NoticeTarif { Name = "Электронное уведомление", Rate = 18.75, RateNds = 22.50, Type = NoticeType.Электронное, Code = 16384},
                new NoticeTarif { Name = "Международное уведомление", Rate = 92.00, RateNds = 110.40, Type = NoticeType.Международное, Code = 1 }
            };

            return tarifs;
        }

        public static void CreateDefault()
        {
            Save(GetDefault());
        }

        public static async Task<List<NoticeTarif>> GetFromServer()
        {
            return await ServerTarificator.GetNoticeTarifs();
        }
    }
}
