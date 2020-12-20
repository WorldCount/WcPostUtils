using System.Collections.Generic;
using PartStat.Core.Libs.Stats.StatObject;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models.DB;
using PartStat.Core.Models.PostTypes;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Core.Libs.Stats
{
    public class FirmListStatCollector
    {
        private readonly List<FirmList> _firmLists = new List<FirmList>();

        private readonly NoticeTarif _simpleNoticeTarif;
        private readonly NoticeTarif _customNoticeTarif;
        private readonly NoticeTarif _electronicNoticeTarif;

        public int MailCount { get; private set; }
        public int WarnCount { get; private set; }
        public int ErrorCount { get;private set;}

        public int SimpleNoticeCount { get; private set; } 
        public int CustomNoticeCount { get; private set; } 
        public int ElectronicNoticeCount { get; private set; }
        public int InterNoticeCount { get; private set; }
        public int InventoryCount { get; private set; }
        public int ManualCount { get; private set; }

        public int MailListCount { get; private set; }
        public int SimpleNoticeListCount { get; set; }
        public int CustomNoticeListCount { get; private set; }
        public int ElectronicNoticeListCount { get; private set; }
        public int InterNoticeListCount { get; private set; }
        public int InventoryListCount { get; private set; }
        public int ManualListCount { get; private set; }


        public double SimpleNoticeRate { get; private set; }
        public double CustomNoticeRate { get; private set; } 
        public double ElectronicNoticeRate { get; private set; }
        public double MailRate { get; private set; }
        public double ManualRate { get; private set; }

        public FirmListStatCollector()
        {
            _simpleNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Простое);
            _customNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Заказное);
            _electronicNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Электронное);
        }

        public FirmListStatCollector(List<FirmList> firmLists)
        {
            _simpleNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Простое);
            _customNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Заказное);
            _electronicNoticeTarif = NoticeTarifManager.GetNoticeTarifByType(NoticeType.Электронное);

            if(firmLists == null)
                return;

            foreach (FirmList firmList in firmLists)
            {
                if(firmList.Check)
                    Add(firmList);
            }
        }

        public void Add(FirmList firm)
        {
            if (!_firmLists.Contains(firm))
            {
                _firmLists.Add(firm);
                AddStat(firm);
            }
        }

        public void Remove(FirmList firm)
        {
            if (_firmLists.Contains(firm))
            {
                _firmLists.Remove(firm);
                RemoveStat(firm);
            }
        }

        private void AddStat(FirmList firm)
        {
            if (firm != null && firm.Count > 0)
            {
                MailCount += firm.Count;
                MailRate += firm.MassRate;
                WarnCount += firm.WarnCount;
                ErrorCount += firm.ErrCount;
                MailListCount += 1;

                if (firm.Manual)
                {
                    ManualCount += firm.Count;
                    ManualListCount += 1;
                    ManualRate += firm.MassRate;
                }

                if (firm.IsInventory())
                {
                    InventoryCount += firm.Count;
                    InventoryListCount += 1;
                }

                if (firm.IsInter())
                {
                    if (firm.IsSimpleNotice())
                    {
                        InterNoticeCount += firm.Count;
                        InterNoticeListCount += 1;
                    }
                }
                else
                {
                    if (firm.IsSimpleNotice())
                    {
                        SimpleNoticeCount += firm.Count;
                        SimpleNoticeListCount += 1;
                        if (_simpleNoticeTarif != null)
                            SimpleNoticeRate += firm.Count * _simpleNoticeTarif.Rate;
                    }

                    if (firm.IsCustomNotice())
                    {
                        CustomNoticeCount += firm.Count;
                        CustomNoticeListCount += 1;
                        if (_customNoticeTarif != null)
                            CustomNoticeRate += firm.Count * _customNoticeTarif.Rate;
                    }

                    if (firm.IsElectronicNotice())
                    {
                        ElectronicNoticeCount += firm.Count;
                        ElectronicNoticeListCount += 1;
                        if (_electronicNoticeTarif != null)
                            ElectronicNoticeRate += firm.Count * _electronicNoticeTarif.Rate;
                    }
                }

            }
        }

        private void RemoveStat(FirmList firm)
        {
            if (firm != null && firm.Count > 0)
            {
                MailCount -= firm.Count;
                MailRate -= firm.MassRate;
                WarnCount -= firm.WarnCount;
                ErrorCount -= firm.ErrCount;
                MailListCount -= 1;

                if (firm.Manual)
                {
                    ManualCount -= firm.Count;
                    ManualListCount -= 1;
                    ManualRate -= firm.MassRate;
                }

                if (firm.IsInventory())
                {
                    InventoryCount -= firm.Count;
                    InventoryListCount -= 1;
                }

                if (firm.IsInter())
                {
                    if (firm.IsSimpleNotice())
                    {
                        InterNoticeCount -= firm.Count;
                        InterNoticeListCount -= 1;
                    }
                }
                else
                {
                    if (firm.IsSimpleNotice())
                    {
                        SimpleNoticeCount -= firm.Count;
                        SimpleNoticeListCount -= 1;
                        if (_simpleNoticeTarif != null)
                            SimpleNoticeRate -= firm.Count * _simpleNoticeTarif.Rate;
                    }

                    if (firm.IsCustomNotice())
                    {
                        CustomNoticeCount -= firm.Count;
                        CustomNoticeListCount -= 1;
                        if (_customNoticeTarif != null)
                            CustomNoticeRate -= firm.Count * _customNoticeTarif.Rate;
                    }

                    if (firm.IsElectronicNotice())
                    {
                        ElectronicNoticeCount -= firm.Count;
                        ElectronicNoticeListCount -= 1;
                        if (_electronicNoticeTarif != null)
                            ElectronicNoticeRate -= firm.Count * _electronicNoticeTarif.Rate;
                    }
                }

            }
        }

        public void Refresh()
        {
            ClearStat();

            foreach (FirmList firmList in _firmLists)
            {
                if(firmList.Check)
                    Add(firmList);
            }
        }

        public void ClearStat()
        {
            MailCount = 0;
            WarnCount = 0;
            ErrorCount = 0;

            SimpleNoticeCount = 0;
            CustomNoticeCount = 0;
            ElectronicNoticeCount = 0;
            InterNoticeCount = 0;
            InventoryCount = 0;
            ManualCount = 0;

            MailListCount = 0;
            SimpleNoticeListCount = 0;
            CustomNoticeListCount = 0;
            ElectronicNoticeListCount = 0;
            InterNoticeListCount = 0;
            InventoryListCount = 0;
            ManualListCount = 0;

            SimpleNoticeRate = 0;
            CustomNoticeRate = 0;
            ElectronicNoticeRate = 0;
            MailRate = 0;
            ManualRate = 0;
        }

        public List<StatData> GetListStat()
        {
            List<StatData> datas = new List<StatData>();

            StatData all = new StatData {Name = "Отправлений всего", Count = MailCount, ListCount = MailListCount, Error = ErrorCount, Warn = WarnCount, Rate = MailRate};
            datas.Add(all);

            if (ManualCount > 0)
            {
                StatData manual = new StatData { Name = "Отправлений в ручку", Count = ManualCount, ListCount = ManualListCount, Rate = ManualRate };
                datas.Add(manual);
            }

            if (SimpleNoticeCount > 0)
            {
                StatData simple = new StatData { Name = "Пр.Увед", Count = SimpleNoticeCount, ListCount = SimpleNoticeListCount, Rate = SimpleNoticeRate };
                datas.Add(simple);
            }

            if (CustomNoticeCount > 0)
            {
                StatData custom = new StatData { Name = "Зак.Увед", Count = CustomNoticeCount, ListCount = CustomNoticeListCount, Rate = CustomNoticeRate };
                datas.Add(custom);
            }

            if (ElectronicNoticeCount > 0)
            {
                StatData electronic = new StatData { Name = "Эл.Увед", Count = ElectronicNoticeCount, ListCount = ElectronicNoticeListCount, Rate = ElectronicNoticeRate };
                datas.Add(electronic);
            }

            if (InterNoticeCount > 0)
            {
                StatData inter = new StatData { Name = "Мжд.Увед", Count = InterNoticeCount, ListCount = InterNoticeListCount};
                datas.Add(inter);
            }

            if (InventoryCount > 0)
            {
                StatData inventory = new StatData { Name = "Опись", Count = InventoryCount, ListCount = InventoryListCount};
                datas.Add(inventory);
            }

            return datas;
        }
    }
}
