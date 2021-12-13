using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Models.DB;
using LK.Core.Store.Connect;

namespace LK.Core.Store.Manager.DatabaseManager
{
    public class FirmManager : IDisposable
    {
        private List<Firm> _firms;

        public FirmManager()
        {
            _firms = Database.GetFirms();
        }

        public Firm GetFirm(string inn, string kpp, string contract, string name)
        {
            return _firms.FirstOrDefault(f => f.Inn == inn && f.Kpp == kpp && f.Contract == contract 
                                              && f.Name.ToUpper() == name.ToUpper());
        }

        public Firm GetOrCreateFirm(string inn, string kpp, string name, string contract, DateTime lastDateReceiveFile)
        {
            Firm firm = GetFirm(inn, kpp, contract, name);

            if (firm != null)
            {
                if(firm.GroupId == 0)
                    firm.GroupId = GetGroup(firm.Inn, firm.Kpp, firm.ShortName);

                if (firm.LastListDate < lastDateReceiveFile)
                    firm.LastListDate = lastDateReceiveFile;

                Database.UpdateFirm(firm);
                _firms = Database.GetFirms();
            }

            if (firm == null)
            {
                firm = new Firm
                {
                    Inn = inn,
                    Kpp = kpp,
                    Name = name,
                    ShortName = name,
                    Contract = contract,
                    GroupId = GetGroup(inn, kpp, name),
                    LastListDate = lastDateReceiveFile
                };

                using (var db = DbConnect.GetConnection())
                {
                    db.Insert(firm);
                    _firms = db.Table<Firm>().ToList();
                }
            }

            return firm;
        }

        public void Dispose()
        {
            _firms = null;
        }

        private int GetGroup(string inn, string kpp, string shortName)
        {
            int groupId = Database.GetGroupId(inn, kpp);

            if (groupId == 0)
                groupId = Database.CreateGroup(shortName);

            return groupId;
        }
    }
}
