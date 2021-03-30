using System.IO;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using WcApi.Xml;
namespace DwUtils.Core.Libs.Database.Firebird
{
    public static class FbDataBase
    {
        public static class PostItem
        {
            public static PostItemConnect GetConnect()
            {
                if (!File.Exists(PathManager.PostItemConnectPath))
                    return new PostItemConnect();
                return Serializer.Load<PostItemConnect>(PathManager.PostItemConnectPath);
            }

            public static void SaveConnect(PostItemConnect connect)
            {
                Serializer.Save(PathManager.PostItemConnectPath, connect);
            }
        }

        public static class PostUnit
        {
            public static PostUnitConnect GetConnect()
            {
                if (!File.Exists(PathManager.PostUnitConnectPath))
                    return new PostUnitConnect();
                return Serializer.Load<PostUnitConnect>(PathManager.PostUnitConnectPath);
            }

            public static void SaveConnect(PostUnitConnect connect)
            {
                Serializer.Save(PathManager.PostUnitConnectPath, connect);
            }
        }

    }
}
