using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WcPostApi.Tafirs.Types;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Manager
{
    public class NoticeTarifManager
    {
        private readonly string _path;

        public NoticeTarifManager(string path)
        {
            _path = path;
        }

        #region Default

        public void CreateDefault()
        {
            Save(GetDefault());
        }

        public static List<NoticeTarif> GetDefault()
        {
            List<NoticeTarif> tarifs = new List<NoticeTarif>
            {
                new NoticeTarif{Name = "Простое уведомление", Rate = 23.75, Type = NoticeType.Простое},
                new NoticeTarif{Name = "Заказное уведомление", Rate = 60.00, Type = NoticeType.Заказное},
                new NoticeTarif{Name = "Электронное уведомление", Rate = 18.75, Type = NoticeType.Электронное},
                new NoticeTarif { Name = "Международное уведомление", Rate = 92.00, Type = NoticeType.Международное }
            };

            return tarifs;
        }

        #endregion

        #region Sync

        public void Save(List<NoticeTarif> tarifs)
        {
            Serializer.Save(_path, tarifs);
        }

        public List<NoticeTarif> Load()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return Serializer.Load<List<NoticeTarif>>(_path);
        }

        public NoticeTarif GetTarifByRate(double rate)
        {
            List<NoticeTarif> tarifs = Load();
            return tarifs.FirstOrDefault(p => p.Rate.Equals(rate));
        }

        public NoticeTarif GetNoticeTarifByType(NoticeType type)
        {
            List<NoticeTarif> tarifs = Load();
            return tarifs.FirstOrDefault(t => t.Type == type);
        }

        #endregion

        #region Async

        public async Task<List<NoticeTarif>> LoadAsync()
        {
            if (!File.Exists(_path))
                CreateDefault();

            return await Serializer.LoadAsync<List<NoticeTarif>>(_path);
        }

        public static async Task<List<NoticeTarif>> GetFromServer()
        {
            return await ServerTarificator.GetNoticeTarifs();
        }

        #endregion
    }
}
