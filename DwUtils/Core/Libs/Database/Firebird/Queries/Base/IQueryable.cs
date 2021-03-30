using DwUtils.Core.Libs.Database.Firebird.Connect;

namespace DwUtils.Core.Libs.Database.Firebird.Queries.Base
{
    public interface IQueryable<T>
    {
        string GetQuery();

        T GetConnect();
    }
}
