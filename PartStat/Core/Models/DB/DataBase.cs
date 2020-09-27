using System.IO;
using WcApi.Xml;

namespace PartStat.Core.Models.DB
{
    public static class DataBase
    {
        #region Подключение

        public static Connect GetConnect(string path)
        {
            if (!File.Exists(path))
                return new Connect();
            return Serializer.Load<Connect>(path);
        }

        public static void SaveConnect(Connect connect, string path)
        {
            Serializer.Save(path, connect);
        }

        #endregion
    }
}
