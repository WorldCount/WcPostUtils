using WcPostApi.Types.Manager;

namespace AOP.Core
{
    public static class DataManager
    {
        public static MailTypeManager MailTypeManager = new MailTypeManager(PathManager.MailTypePath);
        public static MailCategoryManager MailCategoryManager = new MailCategoryManager(PathManager.MailCategoryPath);
    }
}
