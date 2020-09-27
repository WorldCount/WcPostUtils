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

        public static List<NoticeTarif> GetDefault()
        {
            List<NoticeTarif> tarifs = new List<NoticeTarif>
            {
                new NoticeTarif{Name = "Простое уведомление", Rate = 23.75, Type = NoticeType.Простое},
                new NoticeTarif{Name = "Заказное уведомление", Rate = 60.0, Type = NoticeType.Заказное},
                new NoticeTarif{Name = "Электронное уведомление", Rate = 18.75, Type = NoticeType.Электронное},
                new NoticeTarif { Name = "Международное уведомление", Rate = 92.00, Type = NoticeType.Международное }
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
