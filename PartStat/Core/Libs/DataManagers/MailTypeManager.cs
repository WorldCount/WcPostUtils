using System.Collections.Generic;
using System.IO;
using System.Linq;
using PartStat.Core.Models.DB;
using WcApi.Xml;

namespace PartStat.Core.Libs.DataManagers
{
    public static class MailTypeManager
    {
        public static void Save(List<MailType> mailTypes)
        {
            Serializer.Save(PathManager.MailTypePath, mailTypes);
        }

        public static List<MailType> Load()
        {
            if (!File.Exists(PathManager.MailTypePath))
                return new List<MailType>();
            return Serializer.Load<List<MailType>>(PathManager.MailTypePath);
        }

        public static List<MailType> GetEnabled()
        {
            List<MailType> mailTypes = Load();
            return mailTypes.Where(m => m.Enable).ToList();
        }

        public static MailType GetById(int id)
        {
            List<MailType> mailTypes = Load();
            return mailTypes.FirstOrDefault(m => m.Id == id);
        }
    }
}
