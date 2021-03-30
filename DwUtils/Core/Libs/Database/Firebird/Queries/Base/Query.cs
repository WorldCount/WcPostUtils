using System;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using NLog;

namespace DwUtils.Core.Libs.Database.Firebird.Queries.Base
{
    public abstract class Query<T> : IQueryable<T>, IDisposable
    {
        private readonly T _connect;
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        // ReSharper disable once ConvertToAutoProperty
        public T Connect => _connect;

        protected Query(T connect)
        {
            _connect = connect;
        }

        public abstract string GetQuery();

        public T GetConnect()
        {
            return _connect;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
