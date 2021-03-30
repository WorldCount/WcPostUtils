using System;
using NLog;

namespace DwUtils.Core.Libs.Database.Firebird.Queries.Base
{
    public abstract class Query : IQueryable, IDisposable
    {
        private readonly FbConnect _connect;
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        // ReSharper disable once ConvertToAutoProperty
        public FbConnect Connect => _connect;

        protected Query(FbConnect connect)
        {
            _connect = connect;
        }

        public abstract string GetQuery();

        public FbConnect GetConnect()
        {
            return _connect;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
