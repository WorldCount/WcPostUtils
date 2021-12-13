using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Models.DB.Types;

namespace LK.Core.Store.Manager.DatabaseManager
{
    public class MailTypeManager : IDisposable
    {
        private List<MailType> _mailTypes;

        public MailTypeManager()
        {
            _mailTypes = Database.GetMailTypes();
        }

        public MailType GetMailType(string name)
        {
            return _mailTypes.FirstOrDefault(t => t.Name == name);
        }

        public void Dispose()
        {
            _mailTypes = null;
        }
    }
}
