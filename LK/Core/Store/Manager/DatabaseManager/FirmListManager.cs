using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Models.DB;

namespace LK.Core.Store.Manager.DatabaseManager
{
    public class FirmListManager : IDisposable
    {
        private  List<FirmList> _firmLists = new List<FirmList>();
        private DateTime _date;
        private readonly bool _recount;

        public FirmListManager(DateTime date, bool recount = true)
        {
            _date = date;
            _recount = recount;
        }

        public FirmList GetFirmList(int firmId, int num, DateTime receptDate)
        {
            try
            {
                return _firmLists.FirstOrDefault(f => f.FirmId == firmId && f.Num == num && f.ReceptionDate == receptDate);
            }
            catch
            {
                return null;
            }
            
        }

        public void Load()
        {
            _firmLists = Database.GetFirmsListByDate(_date);
        }

        public void AddFirmList(FirmList firmList)
        {
            _firmLists.Add(firmList);
        }

        public void Update(DateTime date)
        {
            if (date != _date)
            {
                _date = date;
                Load();
            }
        }

        public void Recount(List<int> ids)
        {

            if (_recount)
            {

                Config ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);
                Config valueConfig = ConfigManager.GetConfigByName(ConfigName.Value);

                _firmLists = Database.GetFirmListsAndChildrenByIds(ids);

                foreach (FirmList firmList in _firmLists)
                {
                    firmList.Recount(ndsConfig.GetIntValue(), valueConfig.GetIntValue());
                }

                Database.UpdateFirmLists(_firmLists);
            }
        }

        public void Dispose()
        {
            _firmLists = null;
        }
    }
}
