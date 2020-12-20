using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Models.DB;
using SQLite;

namespace LK.Core.Store.Manager
{
    public class FirmManager : IDisposable
    {
        private List<Firm> _firms;

        public FirmManager()
        {
            _firms = Database.GetFirms();
        }

        public Firm GetFirm(string inn, string kpp)
        {
            return _firms.FirstOrDefault(f => f.Inn == inn && f.Kpp == kpp);
        }

        public Firm GetOrCreateFirm(string inn, string kpp, string name, string contract)
        {
            Firm firm = GetFirm(inn, kpp);

            if (firm == null)
            {
                firm = new Firm {Inn = inn, Kpp = kpp, Name = name, ShortName = name, Contract = contract};
                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    db.Insert(firm);
                    _firms = db.Table<Firm>().ToList();
                }

                firm = GetFirm(inn, kpp);
            }

            return firm;
        }

        public void Dispose()
        {
            _firms = null;
        }
    }
}
