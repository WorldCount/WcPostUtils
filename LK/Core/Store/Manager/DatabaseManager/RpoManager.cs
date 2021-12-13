using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Models.DB;

namespace LK.Core.Store.Manager.DatabaseManager
{
    public class RpoManager : IDisposable
    {
        private List<Rpo> _rpos = new List<Rpo>();
        private int _firmListId;

        public RpoManager(int firmListId = 0)
        {
            _firmListId = firmListId;
        }

        public Rpo GetRpo(string barcode)
        {
            try
            {
                return _rpos.FirstOrDefault(r => r.Barcode == barcode);
            }
            catch
            {
                return null;
            }
        }

        public void Update(int firmListId)
        {
            if (_firmListId != firmListId)
            {
                _firmListId = firmListId;
                _rpos = Database.GetRpos(firmListId);
            }
        }

        public void Dispose()
        {
            _rpos = null;
        }
    }
}
