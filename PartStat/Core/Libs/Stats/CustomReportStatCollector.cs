using System.Collections.Generic;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Libs.Stats.StatObject;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Libs.Stats
{
    public class CustomReportStatCollector
    {
        private readonly List<FirmList> _firmLists;

        private readonly Dictionary<string, CustomReportStatData> _datas = new Dictionary<string, CustomReportStatData>();

        // Счетчик уведомлений
        public int SimpleNoticeCount { get; private set; }
        public int CustomNoticeCount { get; private set; }
        public int ElectronicNoticeCount { get; private set; }
        public int InterNoticeCount { get; private set; }

        // Счетчик списков в ручку
        public int ManualCount { get; private set; }
        // Счетчик описей
        public int InventoryCount { get; private set; }

        public bool PayMark { get; private set; }

        public CustomReportStatCollector()
        {
            _firmLists = new List<FirmList>();
        }

        public CustomReportStatCollector(List<FirmList> firmLists)
        {
            _firmLists = firmLists;

            int count = 0;
            while (count < _firmLists.Count)
            {
                Add(_firmLists[count]);
                count++;
            }
        }

        private void Add(FirmList firmList)
        {
            CustomReportStatData stat = new CustomReportStatData(firmList);

            InventoryCount += stat.InventoryCount;

            if (_datas.ContainsKey(stat.Code))
            {
                _datas[stat.Code].Add(firmList);
            }
            else
            {
                _datas.Add(stat.Code, stat);
            }

            AddNotice(firmList);

            PayMark = firmList.IsPayMark();

            if (firmList.Manual)
                ManualCount += firmList.Count;
        }

        private void AddNotice(FirmList firmList)
        {
            if (firmList.IsSimpleNotice())
            {
                if(firmList.IsInter())
                    InterNoticeCount += firmList.Count;
                else
                    SimpleNoticeCount += firmList.Count;
            }

            if (firmList.IsCustomNotice())
                CustomNoticeCount += firmList.Count;

            if (firmList.IsElectronicNotice())
                ElectronicNoticeCount += firmList.Count;
        }

        public Dictionary<string, CustomReportStatData> Data => _datas;

        public List<ServiceData> Services
        {
            get
            {
                List<ServiceData> d = new List<ServiceData>();

                if(SimpleNoticeCount > 0)
                    d.Add(new ServiceData { Name = "Пр.ув", Value = SimpleNoticeCount });

                if(CustomNoticeCount > 0)
                    d.Add(new ServiceData { Name = "Зак.ув", Value = CustomNoticeCount });

                if(ElectronicNoticeCount > 0)
                    d.Add(new ServiceData { Name = "Эл.ув", Value = ElectronicNoticeCount });

                if (InterNoticeCount > 0)
                    d.Add(new ServiceData { Name = "Мжд.ув", Value = InterNoticeCount });

                if (ManualCount > 0)
                    d.Add(new ServiceData { Name = "Ручка", Value = ManualCount });

                if(InventoryCount > 0)
                    d.Add(new ServiceData { Name = "Опись", Value = InventoryCount });

                return d;
            }
        }
    }
}
