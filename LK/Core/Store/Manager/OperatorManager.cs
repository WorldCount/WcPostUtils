using System;
using System.Collections.Generic;
using System.Linq;
using LK.Core.Models.DB;
using LK.Core.Store.Connect;

namespace LK.Core.Store.Manager
{
    public class OperatorManager : IDisposable
    {
        private static List<Operator> _operators;

        public OperatorManager()
        {
            _operators = Database.GetAllOperator();
        }

        private Operator GetOperator(string fullName)
        {
            return _operators.FirstOrDefault(o => o.FullName.ToUpper() == fullName.ToUpper());
        }

        public Operator GetOrCreateOperator(string fullName)
        {
            Operator oper = GetOperator(fullName);

            if (oper == null)
            {
                oper = new Operator(fullName);

                using (var db = DbConnect.GetConnection())
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
