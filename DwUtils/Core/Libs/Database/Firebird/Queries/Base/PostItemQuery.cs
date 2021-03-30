using DwUtils.Core.Libs.Database.Firebird.Connect;

namespace DwUtils.Core.Libs.Database.Firebird.Queries.Base
{
    public abstract class PostItemQuery : Query<PostItemConnect>
    {
        protected PostItemQuery(PostItemConnect connect) : base(connect)
        {
        }
    }
}
