using System.Collections.Generic;
using System.IO;
using System.Linq;
using PartStat.Core.Models.DB;
using WcApi.Xml;

namespace PartStat.Core.Libs.DataManagers
{
    public static class ListStatusManager
    {
        public static void Save(List<ListStatus> listStatuses)
        {
            Serializer.Save(PathManager.ListStatusPath, listStatuses);
        }

        public static List<ListStatus> Load()
        {
            if (!File.Exists(PathManager.ListStatusPath))
                return new List<ListStatus>();
            return Serializer.Load<List<ListStatus>>(PathManager.ListStatusPath);
        }

        public static List<ListStatus> GetEnabled()
        {
            List<ListStatus> listStatuses = Load();
            return listStatuses.Where(l => l.Enable).ToList();
        }
    }
}
