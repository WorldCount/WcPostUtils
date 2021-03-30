namespace DwUtils.Core.Libs.Database.Firebird.Queries.Base
{
    public interface IQueryable
    {
        string GetQuery();

        FbConnect GetConnect();
    }
}
