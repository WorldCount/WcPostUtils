using DwUtils.Core.Libs.Database.Firebird.Connect;

namespace DwUtils.Core.Libs.Database.Firebird.Queries.Base
{
    public abstract class PostUnitQuery : Query<PostUnitConnect>
    {
        protected PostUnitQuery(PostUnitConnect connect) : base(connect)
        {
        }
    }
}
