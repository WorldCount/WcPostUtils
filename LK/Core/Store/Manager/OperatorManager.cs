using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Models.DB;
using SQLite;

namespace LK.Core.Store.Manager
{
    public class OperatorManager : IDisposable
    {
        private static List<Operator> _operators;

        public OperatorManager()
        {
            _operators = Database.GetAllOperator();
        }

        public Operator GetOperator(string fullName)
        {
            string[] s = fullName.Split(' ');
            return _operators.FirstOrDefault(o => o.LastName.ToUpper() == s[0].ToUpper());
        }

        public Operator GetOrCreateOperator(string fullName)
        {
            Operator oper = GetOperator(fullName);

            if (oper == null)
            {
                oper = new Operator(fullName);

                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    db.Insert(oper);
                    _operators = db.Table<Operator>().ToList();
                }

                oper = GetOperator(fullName);
            }

            return oper;
        }

        public void Dispose()
        {
            _operators = null;
        }
    }
}
