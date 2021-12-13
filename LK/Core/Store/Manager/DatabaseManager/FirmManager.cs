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

        public Firm GetOrCreateFirm(string inn, string kpp, string name, string contract)
        {
            Firm firm = GetFirm(inn, kpp, contract, name);

            if (firm == null)
            {
                firm = new Firm {Inn = inn, Kpp = kpp, Name = name, ShortName = name, Contract = contract};
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
    }
}
