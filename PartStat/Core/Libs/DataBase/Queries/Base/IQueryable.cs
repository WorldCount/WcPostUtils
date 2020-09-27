
namespace PartStat.Core.Libs.DataBase.Queries.Base
{
    public interface IQueryable
    {
        string GetQuery();

        Connect GetConnect();
    }
}
