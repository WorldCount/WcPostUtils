using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Models.DB.Types;

namespace LK.Core.Store.Manager.DatabaseManager
{
    public class MailCategoryManager : IDisposable
    {
        private List<MailCategory> _mailCategories;

        public MailCategoryManager()
        {
            _mailCategories = Database.GetMailCategories();
        }

        public MailCategory GetMailCategory(string name)
        {
            return _mailCategories.FirstOrDefault(c => c.Name == name);
        }

        public void Dispose()
        {
            _mailCategories = null;
        }
    }
}
