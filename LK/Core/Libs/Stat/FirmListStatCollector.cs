using System.Collections.Generic;
using LK.Core.Libs.TarifManager;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Libs.TarifManager.Tarif;
using LK.Core.Models.DB;
using MailClass = LK.Core.Models.Types.MailClass;

namespace LK.Core.Libs.Stat
{
    public class FirmListStatCollector
    {
        #region Приватные данные

        private readonly List<FirmList> _firmLists = new List<FirmList>();

        private readonly ServiceTarif _simpleNoticeTarif;
        private readonly ServiceTarif _customNoticeTarif;
        private readonly ServiceTarif _electronicNoticeTarif;

        #endregion

        #region Данные

        #region Счетчики отправлений

        public int MailCount { get; private set; }
        public int MissCount { get; private set; }
        public int ReturnCount { get; private set; }

        #endregion

        #region Счетчики уведомлений и описей
        public int SimpleNoticeCount { get; private set; }
        public int CustomNoticeCount { get; private set; }
        public int ElectronicNoticeCount { get; private set; }
        public int InterNoticeCount { get; private set; }
        public int InventoryCount { get; private set; }

        #endregion

        #region Счетчики списков
        public int MailListCount { get; private set; }
        public int SimpleNoticeListCount { get; set; }
        public int CustomNoticeListCount { get; private set; }
        public int ElectronicNoticeListCount { get; private set; }
        public int InterNoticeListCount { get; private set; }
        public int InventoryListCount { get; private set; }

        #endregion

        #region Счетчики платы за услуги
        public double SimpleNoticeRate { get; private set; }
        public double CustomNoticeRate { get; private set; }
        public double ElectronicNoticeRate { get; private set; }
        public double MailRate { get; private set; }

        #endregion

        #endregion


        public FirmListStatCollector()
        {
            _simpleNoticeTarif = ServiceTarifManager.GetServiceTarifByType(ServiceType.ПростоеУв);
            _customNoticeTarif = ServiceTarifManager.GetServiceTarifByType(ServiceType.ЗаказноеУв);
            _electronicNoticeTarif = ServiceTarifManager.GetServiceTarifByType(ServiceType.ЭлектронноеУв);
        }

        public FirmListStatCollector(List<FirmList> firmLists)
        {
            _simpleNoticeTarif = ServiceTarifManager.GetServiceTarifByType(ServiceType.ПростоеУв);
            _customNoticeTarif = ServiceTarifManager.GetServiceTarifByType(ServiceType.ЗаказноеУв);
            _electronicNoticeTarif = ServiceTarifManager.GetServiceTarifByType(ServiceType.ЭлектронноеУв);

            if (firmLists == null)
                return;

            foreach (FirmList firmList in firmLists)
            {
                if (firmList.Check)
                    Add(firmList);
            }
        }

        public void Add(FirmList firmList)
        {
            if (!_firmLists.Contains(firmList))
            {
                _firmLists.Add(firmList);
                AddStat(firmList);
            }
        }

        private void AddStat(FirmList firmList)
        {
            if (firmList != null && firmList.Count > 0)
            {
                MailCount += firmList.CountFact;
                MailRate += firmList.MassRate;
                MissCount += firmList.CountMiss;
                ReturnCount += firmList.CountReturn;
                MailListCount += 1;

                if (firmList.Inventory)
                {
                    InventoryCount += firmList.CountFact;
                    InventoryListCount += 1;
                }

                if (firmList.MailClass == MailClass.Международное)
                {
                    if (firmList.IsSimpleNotice())
                    {
                        InterNoticeCount += firmList.CountFact;
                        InterNoticeListCount += 1;
                    }
                }
                else
                {
                    if (firmList.IsSimpleNotice())
                    {
                        SimpleNoticeCount += firmList.CountFact;
                        SimpleNoticeListCount += 1;
                        if (_simpleNoticeTarif != null)
                            SimpleNoticeRate += firmList.CountFact * _simpleNoticeTarif.Rate;
                    }

                    if (firmList.IsCustomNotice())
                    {
                        CustomNoticeCount += firmList.CountFact;
                        CustomNoticeListCount += 1;
                        if (_customNoticeTarif != null)
                            CustomNoticeRate += firmList.CountFact * _customNoticeTarif.Rate;
                    }

                    if (firmList.IsElectronicNotice())
                    {
                        ElectronicNoticeCount += firmList.CountFact;
                        ElectronicNoticeListCount += 1;
                        if (_electronicNoticeTarif != null)
                            ElectronicNoticeRate += firmList.CountFact * _electronicNoticeTarif.Rate;
                    }
                }
            }
        }

        public void Remove(FirmList firmList)
        {
            if (_firmLists.Contains(firmList))
            {
                _firmLists.Remove(firmList);
                RemoveStat(firmList);
            }
        }

        public void RemoveStat(FirmList firmList)
        {
            if (firmList != null && firmList.Count > 0)
            {
                MailCount -= firmList.CountFact;
                MailRate -= firmList.MassRate;
                MissCount -= firmList.CountMiss;
                ReturnCount -= firmList.CountReturn;
                MailListCount -= 1;

                if (firmList.Inventory)
                {
                    InventoryCount -= firmList.CountFact;
                    InventoryListCount -= 1;
                }

                if (firmList.MailClass == MailClass.Международное)
                {
                    if (firmList.IsSimpleNotice())
                    {
                        InterNoticeCount -= firmList.CountFact;
                        InterNoticeListCount -= 1;
                    }
                }
                else
                {
                    if (firmList.IsSimpleNotice())
                    {
                        SimpleNoticeCount -= firmList.CountFact;
                        SimpleNoticeListCount -= 1;
                        if (_simpleNoticeTarif != null)
                            SimpleNoticeRate -= firmList.CountFact * _simpleNoticeTarif.Rate;
                    }

                    if (firmList.IsCustomNotice())
                    {
                        CustomNoticeCount -= firmList.CountFact;
                        CustomNoticeListCount -= 1;
                        if (_customNoticeTarif != null)
                            CustomNoticeRate -= firmList.CountFact * _customNoticeTarif.Rate;
                    }

                    if (firmList.IsElectronicNotice())
                    {
                        ElectronicNoticeCount -= firmList.CountFact;
                        ElectronicNoticeListCount -= 1;
                        if (_electronicNoticeTarif != null)
                            ElectronicNoticeRate -= firmList.CountFact * _electronicNoticeTarif.Rate;
                    }
                }
            }
        }

        public void Refresh()
        {
            CleanStat();

            foreach (FirmList firmList in _firmLists)
            {
                if(firmList.Check)
                    Add(firmList);
            }
        }

        public void CleanStat()
        {
            MailCount = 0;
            MissCount = 0;
            ReturnCount = 0;

            SimpleNoticeCount = 0;
            CustomNoticeCount = 0;
            ElectronicNoticeCount = 0;
            InterNoticeCount = 0;
            InventoryCount = 0;

            MailListCount = 0;
            SimpleNoticeListCount = 0;
            CustomNoticeListCount = 0;
            ElectronicNoticeListCount = 0;
            InterNoticeListCount = 0;
            InventoryListCount = 0;

            SimpleNoticeRate = 0;
            CustomNoticeRate = 0;
            ElectronicNoticeRate = 0;
            MailRate = 0;
        }

        public List<StatData> GetListStat()
        {
            List<StatData> datas = new List<StatData>();

            StatData all = new StatData { Name = "Отправлений всего", Count = MailCount, ListCount = MailListCount, Return = ReturnCount, Miss = MissCount, Rate = MailRate };
            datas.Add(all);

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
                StatData inter = new StatData { Name = "Мжд.Увед", Count = InterNoticeCount, ListCount = InterNoticeListCount };
                datas.Add(inter);
            }

            if (InventoryCount > 0)
            {
                StatData inventory = new StatData { Name = "Опись", Count = InventoryCount, ListCount = InventoryListCount };
                datas.Add(inventory);
            }

            return datas;
        }
    }
}
