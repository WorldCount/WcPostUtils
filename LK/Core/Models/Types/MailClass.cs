
namespace LK.Core.Models.Types
{
    public enum MailClass
    {
        // ReSharper disable once InconsistentNaming
        ВСЕ,
        Внутреннее,
        Международное
    }

    public static class MailClassParser
    {
        public static bool IsInter(int mailClass)
        {
            return (MailClass) mailClass == MailClass.Международное;
        }

        public static bool IsHome(int mailClass)
        {
            return (MailClass) mailClass == MailClass.Внутреннее;
        }
    }
}
