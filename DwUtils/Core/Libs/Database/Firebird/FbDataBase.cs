using System.IO;
using WcApi.Xml;

namespace DwUtils.Core.Libs.Database.Firebird
{
    public static class FbDataBase
    {
        public static class PostItem
        {
            public static FbConnect GetConnect()
            {
                if (!File.Exists(PathManager.PostItemConnectPath))
                    return new FbConnect();
                return Serializer.Load<FbConnect>(PathManager.PostItemConnectPath);
            }

            public static void SaveConnect(FbConnect connect)
            {
                Serializer.Save(PathManager.PostItemConnectPath, connect);
            }
        }

        public static class PostUnit
        {
            public static FbConnect GetConnect()
            {
                if (!File.Exists(PathManager.PostUnitConnectPath))
                    return new FbConnect();
                return Serializer.Load<FbConnect>(PathManager.PostUnitConnectPath);
            }

            public static void SaveConnect(FbConnect connect)
            {
                Serializer.Save(PathManager.PostUnitConnectPath, connect);
            }
        }

    }
}
