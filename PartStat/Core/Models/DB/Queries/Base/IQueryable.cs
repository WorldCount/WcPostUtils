
namespace PartStat.Core.Models.DB.Queries.Base
{
    public interface IQueryable
    {
        string GetQuery();

        Connect GetConnect();
    }
}
