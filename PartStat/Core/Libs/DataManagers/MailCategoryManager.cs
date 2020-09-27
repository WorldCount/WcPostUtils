using System.Collections.Generic;
using System.IO;
using System.Linq;
using PartStat.Core.Models.DB;
using WcApi.Xml;

namespace PartStat.Core.Libs.DataManagers
{
    public static class MailCategoryManager
    {
        public static void Save(List<MailCategory> mailCategories)
        {
            Serializer.Save(PathManager.MailCategoryPath, mailCategories);
        }

        public static List<MailCategory> Load()
        {
            if(!File.Exists(PathManager.MailCategoryPath))
                return new List<MailCategory>();
            return Serializer.Load<List<MailCategory>>(PathManager.MailCategoryPath);
        }

        public static List<MailCategory> GetEnabled()
        {
            List<MailCategory> mailCategories = Load();
            return mailCategories.Where(m => m.Enable).ToList();
        }

        public static MailCategory GetById(int id)
        {
            List<MailCategory> mailCategories = Load();
            return mailCategories.FirstOrDefault(m => m.Id == id);
        }
    }
}
