using System.Collections.Generic;
using System.Linq;
using LK.Core.Libs.TarifManager;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Libs.TarifManager.Tarif;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Store;

namespace LK.Core.Libs.Stat
{
    public class RpoStatCollector
    {

        #region Private
        private List<RpoStatData> _statDatas = new List<RpoStatData>();

        // Тарифы
        private readonly List<MailTarif> _mailTarifs;
        private readonly List<ParcelTarif> _parcelTarifs;
        private readonly List<FirstMailTarif> _firstMailTarifs;
        private readonly List<FirstParcelTarif> _firstParcelTarifs;
        private readonly List<InterMailTarif> _interMailTarifs;
        private readonly List<InterParcelTarif> _interParcelTarifs;

        private readonly List<MailType> _mailTypes;
        private readonly List<MailCategory> _mailCategories;

        private readonly ServiceTarif _interNoticeTarif;

        #endregion

        #region Public

        public List<RpoStatData> Data => _statDatas;

        public int CountPos => _statDatas.Count;
        public int RpoCount { get; private set; }

        // Счетчик уведомлений
        public int SimpleNoticeCount { get; private set; }
        public int CustomNoticeCount { get; private set; }
        public int ElectronicNoticeCount { get; private set; }
        public int InterNoticeCount { get; private set; }

        // Счетчик описей
        public int InventoryCount { get; private set; }

        #endregion


        public RpoStatCollector()
        {
            _mailTarifs = MailTarifManager.Load();
            _parcelTarifs = ParcelTarifManager.Load();
            _firstMailTarifs = FirstMailTarifManager.Load();
            _firstParcelTarifs = FirstParcelTarifManager.Load();
            _interMailTarifs = InterMailTarifManager.Load();
            _interParcelTarifs = InterParcelTarifManager.Load();
            _interNoticeTarif = ServiceTarifManager.GetServiceTarifByType(ServiceType.МеждународноеУв);

            _mailTypes = Database.GetMailTypes();
            _mailCategories = Database.GetMailCategories();
        }

        public RpoStatCollector(List<Rpo> rpos) : this()
        {
            int count = 0;
            while (count < rpos.Count)
            {
                Add(rpos[count]);
                count++;
            }
        }

        public void Add(Rpo rpo)
        {
            RpoStatData data = GetStatByRate(rpo.MailType, rpo.MailCategory, rpo.MassRate, rpo.IsInter() && rpo.IsSimpleNotice());

            RpoCount += 1;

            // Счетчик описей
            if (rpo.IsInventory())
                InventoryCount += 1;

            // Счетчик уведомлений
            if (rpo.IsInter())
            {
                if (rpo.IsSimpleNotice())
                    InterNoticeCount += 1;
            }
            else
            {
                if (rpo.IsSimpleNotice())
                    SimpleNoticeCount += 1;

                if (rpo.IsCustomNotice())
                    CustomNoticeCount += 1;
            }

            if (rpo.IsElectronicNotice())
                ElectronicNoticeCount += 1;

            if (data == null)
            {
                RpoStatData newData = new RpoStatData
                {
                    Count = 1,
                    InterCode = rpo.IsInter(),
                    MailCategory = rpo.MailCategory,
                    MailType = rpo.MailType,
                    Rate = rpo.MassRate
                };

                if (rpo.MailCategory == 3 || rpo.MailCategory == 5)
                    newData.Name = $"{GetMailTypeNameById(rpo.MailType)} {GetMailCateforyNameById(rpo.MailCategory)}";

                if (rpo.MailCategory == 2)
                {
                    newData = CustomTarificate(rpo, newData);
                }

                _statDatas.Add(newData);
            }
            else
            {
                data.Count += 1;
            }
        }

        #region Данные из статистики

        #region Первый класс

        public RpoStatData[] GetFirstMailStat()
        {
            return _statDatas.Where(s => s.MailType == 16).Where(s => s.MailCategory == 2).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetFirstMailStatExcept()
        {
            RpoStatData[] d = GetFirstMailStat();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetFirstMailValueStat()
        {
            return _statDatas.Where(s => s.MailType == 16).Where(s => s.MailCategory > 2).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetFirstMailValueStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 16).Where(s => s.MailCategory > 2).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetFirstParcelStat()
        {
            return _statDatas.Where(s => s.MailType == 17).Where(s => s.MailCategory == 2).OrderBy(s => s.TransType).ThenBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetFirstParcelStatExept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 17).Where(s => s.MailCategory == 2).OrderBy(s => s.TransType).ThenBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetFirstParcelValueStat()
        {
            return _statDatas.Where(s => s.MailType == 17).Where(s => s.MailCategory > 2).OrderBy(s => s.TransType).ThenBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetFirstParcelValueStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 17).Where(s => s.MailCategory > 2).OrderBy(s => s.TransType).ThenBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        #endregion

        #region Письма и бандероли

        public RpoStatData[] GetMailStat()
        {
            return _statDatas.Where(s => s.MailType == 3).Where(s => s.MailCategory == 2).Where(s => s.InterCode == false).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetMailStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 3).Where(s => s.MailCategory == 2).Where(s => s.InterCode == false).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetMailValueStat()
        {
            return _statDatas.Where(s => s.MailType == 3).Where(s => s.MailCategory > 2).Where(s => s.InterCode == false).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetMailValueStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 3).Where(s => s.MailCategory > 2).Where(s => s.InterCode == false).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetParcelStat()
        {
            return _statDatas.Where(s => s.MailType == 4).Where(s => s.MailCategory == 2).Where(s => s.InterCode == false).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetParcelStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 4).Where(s => s.MailCategory == 2).Where(s => s.InterCode == false).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetParcelValueStat()
        {
            return _statDatas.Where(s => s.MailType == 4).Where(s => s.MailCategory > 2).Where(s => s.InterCode == false).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetParcelValueStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 4).Where(s => s.MailCategory > 2).Where(s => s.InterCode == false).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        #endregion

        #region Международка

        public RpoStatData[] GetInterMailStat()
        {
            return _statDatas.Where(s => s.MailType == 3).Where(s => s.InterCode).Where(s => s.SimpleNotice == false).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetInterMailStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 3).Where(s => s.InterCode).Where(s => s.SimpleNotice == false).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetInterMailNoticeStat()
        {
            return _statDatas.Where(s => s.MailType == 3).Where(s => s.InterCode).Where(s => s.SimpleNotice).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetInterMailNoticeStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 3).Where(s => s.InterCode).Where(s => s.SimpleNotice).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetInterParcelStat()
        {
            return _statDatas.Where(s => s.MailType == 4).Where(s => s.InterCode).Where(s => s.SimpleNotice == false).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetInterParcelStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 4).Where(s => s.InterCode).Where(s => s.SimpleNotice == false).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        public RpoStatData[] GetInterParcelNoticeStat()
        {
            return _statDatas.Where(s => s.MailType == 4).Where(s => s.InterCode).Where(s => s.SimpleNotice).OrderBy(s => s.MassInt).ToArray();
        }

        public RpoStatData[] GetInterParcelNoticeStatExcept()
        {
            RpoStatData[] d = _statDatas.Where(s => s.MailType == 4).Where(s => s.InterCode).Where(s => s.SimpleNotice).OrderBy(s => s.MassInt).ToArray();
            _statDatas = _statDatas.Except(d).ToList();
            return d;
        }

        #endregion

        #endregion

        #region Тарификаторы

        private RpoStatData CustomTarificate(Rpo rpo, RpoStatData newData)
        {

            if (rpo.MailType == 3)
            {
                if (rpo.IsInter())
                {
                    InterMailTarif tarif = GetInterMailTarifByRate(rpo.MassRate);

                    if (tarif != null)
                    {
                        if (rpo.IsSimpleNotice())
                        {
                            newData.Name = $"{tarif.Name} ({tarif.TransType}) с Ув";
                            newData.Rate = tarif.Rate + _interNoticeTarif.Rate;
                            newData.SimpleNotice = true;
                            newData.TransType = tarif.TransType;
                        }
                        else
                        {
                            newData.Name = $"{tarif.Name} ({tarif.TransType})";
                            newData.Rate = tarif.Rate;
                            newData.SimpleNotice = false;
                            newData.TransType = tarif.TransType;
                        }
                        newData.Mass = tarif.Mass;
                    }
                    else
                        newData.Name = $"{GetMailTypeNameById(rpo.MailType)} {GetMailCateforyNameById(rpo.MailCategory)}";

                }
                else
                {
                    MailTarif tarif = GetMailTarifByRate(rpo.MassRate);

                    if (tarif != null)
                    {
                        newData.Name = tarif.Name;
                        newData.Mass = tarif.Mass;
                        newData.Rate = tarif.Rate;
                    }
                    else
                        newData.Name = $"{GetMailTypeNameById(rpo.MailType)} {GetMailCateforyNameById(rpo.MailCategory)}";
                }
            }

            if (rpo.MailType == 4)
            {
                if (rpo.IsInter())
                {
                    InterParcelTarif tarif = GetInterParcelTarifByRate(rpo.MassRate);

                    if (tarif != null)
                    {
                        if (rpo.IsSimpleNotice())
                        {
                            newData.Name = $"{tarif.Name} ({tarif.TransType}) с Ув";
                            newData.Rate = tarif.Rate + _interNoticeTarif.Rate;
                            newData.SimpleNotice = true;
                            newData.TransType = tarif.TransType;
                        }
                        else
                        {
                            newData.Name = $"{tarif.Name} ({tarif.TransType})";
                            newData.Rate = tarif.Rate;
                            newData.SimpleNotice = false;
                            newData.TransType = tarif.TransType;
                        }
                        newData.Mass = tarif.Mass;
                    }
                    else
                        newData.Name = $"{GetMailTypeNameById(rpo.MailType)} {GetMailCateforyNameById(rpo.MailCategory)}";

                }
                else
                {
                    ParcelTarif tarif = GetParcelTarifByRate(rpo.MassRate);
                    if (tarif != null)
                    {
                        newData.Name = tarif.Name;
                        newData.Mass = tarif.Mass;
                        newData.Rate = tarif.Rate;
                    }
                    else
                        newData.Name = $"{GetMailTypeNameById(rpo.MailType)} {GetMailCateforyNameById(rpo.MailCategory)}";
                }
            }

            if (rpo.MailType == 16)
            {
                FirstMailTarif tarif = GetFirstMailTarifByRate(rpo.MassRate);

                if (tarif != null)
                {
                    newData.Name = $"{tarif.Name}";
                    newData.Rate = tarif.Rate;
                    newData.Mass = tarif.EndMass.ToString();
                }
                else
                    newData.Name = $"{GetMailTypeNameById(rpo.MailType)} {GetMailCateforyNameById(rpo.MailCategory)}";
            }

            if (rpo.MailType == 17)
            {
                FirstParcelTarif tarif = GetFirstParcelTarifByRate(rpo.MassRate);

                if (tarif != null)
                {
                    newData.Name = $"{tarif.Name}";
                    newData.Rate = tarif.Rate;
                    newData.Mass = tarif.EndMass.ToString();
                    newData.TransType = tarif.TransType;
                    newData.SubName = tarif.Mass;
                }
                else
                    newData.Name = $"{GetMailTypeNameById(rpo.MailType)} {GetMailCateforyNameById(rpo.MailCategory)}";
            }

            return newData;
        }

        #endregion

        #region Тарифы

        private InterMailTarif GetInterMailTarifByRate(double rate)
        {
            return _interMailTarifs.FirstOrDefault(m => m.Rate.Equals(rate));
        }

        private InterParcelTarif GetInterParcelTarifByRate(double rate)
        {
            return _interParcelTarifs.FirstOrDefault(m => m.Rate.Equals(rate));
        }

        private MailTarif GetMailTarifByRate(double rate)
        {
            return _mailTarifs.FirstOrDefault(m => m.Rate.Equals(rate));
        }

        private ParcelTarif GetParcelTarifByRate(double rate)
        {
            return _parcelTarifs.FirstOrDefault(m => m.Rate.Equals(rate));
        }

        private FirstMailTarif GetFirstMailTarifByRate(double rate)
        {
            return _firstMailTarifs.FirstOrDefault(m => m.Rate.Equals(rate));
        }

        private FirstParcelTarif GetFirstParcelTarifByRate(double rate)
        {
            return _firstParcelTarifs.FirstOrDefault(m => m.Rate.Equals(rate));
        }

        #endregion

        #region Приватные методы

        private string GetMailTypeNameById(int id)
        {
            return _mailTypes.FirstOrDefault(m => m.Id == id)?.ShortName;
        }

        private string GetMailCateforyNameById(int id)
        {
            return _mailCategories.FirstOrDefault(m => m.Id == id)?.ShortName;
        }

        private RpoStatData[] GetStatByCategory(int type, int category)
        {
            return _statDatas.Where(s => s.MailType == type).Where(s => s.MailCategory == category).ToArray();
        }

        private RpoStatData[] GetStatByNotice(int type, int category, bool simpleNotice)
        {
            return GetStatByCategory(type, category).Where(s => s.SimpleNotice == simpleNotice).ToArray();
        }

        private RpoStatData GetStatByRate(int type, int category, double rate, bool simpleNotice)
        {
            return GetStatByNotice(type, category, simpleNotice).FirstOrDefault(s => s.Rate.Equals(rate));
        }

        #endregion
    }
}
