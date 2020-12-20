using PartStat.Core.Models.DB;

namespace PartStat.Core.Libs.Stats
{
    public class CustomReportStatData
    {
        public string MailName { get; set; }
        public int Count { get; set; }
        public string TransName { get; set; }
        public int InventoryCount { get; set; }
        public double PaySum { get; set; }
        public string ShortMailName { get; set; }
        public string Code { get; set; }

        public CustomReportStatData(FirmList firmList)
        {
            

            if (firmList.IsInter())
            {
                MailName = $"{firmList.MailTypeName} {firmList.InterName}";
                ShortMailName = $"{firmList.MailCategoryName[0]}{firmList.MailTypeName[0]} {firmList.InterName}".ToUpper();
                Code = $"{firmList.MailType}-{firmList.MailCategory}-{firmList.InterName}";
            }
            else
            {
                MailName = $"{firmList.MailTypeName} {firmList.MailCategoryName}";
                ShortMailName = $"{firmList.MailCategoryName[0]}{firmList.MailTypeName[0]}".ToUpper();
                Code = $"{firmList.MailType}-{firmList.MailCategory}";
            }

            TransName = firmList.InterName;

            Add(firmList);
        }

        public void Add(FirmList firmList)
        {
            Count += firmList.Count;

            if (firmList.IsInventory())
                InventoryCount += firmList.Count;

            PaySum += firmList.MassRate;
        }
    }
}
