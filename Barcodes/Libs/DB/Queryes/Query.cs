using System;

namespace Barcodes.Libs.DB.Queryes
{
    public class Query : IQueryable
    {
        private readonly Connect _connect;

        // ReSharper disable once ConvertToAutoProperty
        public Connect Connect => _connect;

        public string GetQuery()
        {
            throw new NotImplementedException();
        }

        public Query(Connect connect)
        {
            _connect = connect;
        }
    }
}
