using System.Collections.Generic;
using System.IO;
using Barcodes.Libs.Models;
using WcApi.Xml;

namespace Barcodes.Libs
{
    public static class IndexManager
    {
        public static void Save(List<Index> indices, string path)
        {
            Serializer.Save(path, indices);
        }

        public static List<Index> Load(string path)
        {
            if (!File.Exists(path))
                return new List<Index>();
            List<Index> indices = Serializer.Load<List<Index>>(path);
            return indices;
        }
    }
}
