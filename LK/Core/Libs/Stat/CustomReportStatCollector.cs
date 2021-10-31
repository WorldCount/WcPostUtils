using System.Collections.Generic;
using System.Linq;
using LK.Core.Libs.Stat.StatObject;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;

namespace LK.Core.Libs.Stat
{
    public class CustomReportStatCollector
    {
        #region Private Fields

        private readonly List<FirmList> _firmLists;
        private readonly Dictionary<string, CustomReportStatData> _datas = new Dictionary<string, CustomReportStatData>();
        private readonly List<MailType> _mailTypes;
        private readonly List<MailCategory> _mailCategories;

        #endregion

        #region Public Properties

        // Счетчик уведомлений
        public int SimpleNoticeCount { get; private set; }
        public int CustomNoticeCount { get; private set; }
        public int ElectronicNoticeCount { get; private set; }
        public int InterNoticeCount { get; private set; }

        // Счетчик описей
        public int InventoryCount { get; private set; }

        public Dictionary<string, CustomReportStatData> Data => _datas;

        public List<ServiceData> Services
        {
            get
            {
                List<ServiceData> d = new List<ServiceData>();

                if (SimpleNoticeCount > 0)
                    d.Add(new ServiceData { Name = "Пр.ув", Value = SimpleNoticeCount });

                if (CustomNoticeCount > 0)
                    d.Add(new ServiceData { Name = "Зак.ув", Value = CustomNoticeCount });

                if (ElectronicNoticeCount > 0)
                    d.Add(new ServiceData { Name = "Эл.ув", Value = ElectronicNoticeCount });

                if (InterNoticeCount > 0)
                    d.Add(new ServiceData { Name = "Мжд.ув", Value = InterNoticeCount });

                if (InventoryCount > 0)
                    d.Add(new ServiceData { Name = "Опись", Value = InventoryCount });

                return d;
            }
        }

        #endregion

        public CustomReportStatCollector(List<MailType> mailTypes, List<MailCategory> mailCategories)
        {
            _mailTypes = mailTypes;
            _mailCategories = mailCategories;
            _firmLists = new List<FirmList>();
        }

        public CustomReportStatCollector(List<FirmList> firmLists, List<MailType> mailTypes, List<MailCategory> mailCategories)
        {
            _mailTypes = mailTypes;
            _mailCategories = mailCategories;
            _firmLists = firmLists;

            int count = 0;
            while (count < _firmLists.Count)
            {
                Add(_firmLists[count]);
                count++;
            }
        }

        #region Private Methods

        private string GetCategoryName(int code, bool shortName = false)
        {
            MailCategory mailCategory = _mailCategories.FirstOrDefault(c => c.Id == code);
            if (mailCategory == null)
                return code.ToString();
            return shortName ? $"{mailCategory.ShortName[0]}" : mailCategory.ShortName;
        }

        private string GetTypeName(int code, bool shortName = false)
        {
            MailType mailType = _mailTypes.FirstOrDefault(t => t.Id == code);
            if (mailType == null)
                return code.ToString();

            return shortName ? $"{mailType.ShortName[0]}" : mailType.ShortName;
        }

        private void Add(FirmList firmList)
        {
            CustomReportStatData stat = new CustomReportStatData(firmList);
            if (stat.IsInter)
            {
                stat.MailName = $"{GetTypeName(stat.MailType)} {stat.TransName}";
                stat.ShortMailName = $"{GetCategoryName(stat.MailCategory, true)}{GetTypeName(stat.MailType, true)} {stat.TransName}".ToUpper();
            }
            else
            {
                stat.MailName = $"{GetTypeName(stat.MailType)} {GetCategoryName(stat.MailCategory)}";
                stat.ShortMailName = $"{GetTypeName(stat.MailType, true)}{GetCategoryName(stat.MailCategory, true)}".ToUpper();
            }

            InventoryCount += stat.InventoryCount;

            if (_datas.ContainsKey(stat.Code))
                _datas[stat.Code].Add(firmList);
            else
                _datas.Add(stat.Code, stat);

            AddNotice(firmList);
        }

        private void AddNotice(FirmList firmList)
        {
            if (firmList.IsSimpleNotice())
            {
                if (firmList.IsInter())
                    InterNoticeCount += firmList.CountFact;
                else
                    SimpleNoticeCount += firmList.CountFact;
            }

            if (firmList.IsCustomNotice())
                CustomNoticeCount += firmList.CountFact;

            if (firmList.IsElectronicNotice())
                ElectronicNoticeCount += firmList.CountFact;
        }

        #endregion
    }
}
