using System;
using NLog;

namespace PartStat.Core.Models.DB.Queries.Base
{
    public abstract class Query : IQueryable, IDisposable
    {
        private readonly Connect _connect;
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        // ReSharper disable once ConvertToAutoProperty
        public Connect Connect => _connect;

        protected Query(Connect connect)
        {
            _connect = connect;
        }

        public string GetQuery()
        {
            throw new NotImplementedException();
        }

        public Connect GetConnect()
        {
            return _connect;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
