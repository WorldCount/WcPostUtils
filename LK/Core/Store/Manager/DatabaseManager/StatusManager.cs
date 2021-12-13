using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Models.DB;

namespace LK.Core.Store.Manager.DatabaseManager
{
    public class StatusManager : IDisposable
    {
        private List<Status> _statuses;

        public StatusManager()
        {
            _statuses = Database.GetStatuses();
        }

        public Status GetStatus(string name)
        {
            return _statuses.FirstOrDefault(s => s.Name == name);
        }

        public void Dispose()
        {
            _statuses = null;
        }
    }
}
