using LK.Core.Models.DB;

namespace LK.Core.Libs.Stat
{
    public class CustomReportStatData
    {
        #region Public Properties

        public string MailName { get; set; }
        public string ShortMailName { get; set; }
        public int Count { get; set; }
        public string TransName { get; set; }
        public int InventoryCount { get; set; }
        public double PaySum { get; set; }
        public bool IsInter { get; set; }
        public int MailCategory { get; set; }
        public int MailType { get; set; }
        public string Code { get; set; }

        #endregion

        public CustomReportStatData(FirmList firmList)
        {
            if (firmList.IsInter())
            {
                IsInter = true;
                Code = $"{firmList.MailType}-{firmList.MailCategory}-{firmList.MailClassName}";
            }
            else
                Code = $"{firmList.MailType}-{firmList.MailCategory}";

            MailCategory = firmList.MailCategory;
            MailType = firmList.MailType;

            TransName = firmList.MailClassName;

            Add(firmList);
        }

        public void Add(FirmList firmList)
        {
            Count += firmList.CountFact;

            if (firmList.IsInventory())
                InventoryCount += firmList.CountFact;

            PaySum += firmList.MassRate;
        }
    }
}
