using System.Collections.Generic;
using System.IO;
using Barcodes.Libs.Models;
using WcApi.Xml;

namespace Barcodes.Libs
{
    public static class InternalTypeManager
    {
        public static void Save(List<InternalType> internalTypes, string path)
        {
            Serializer.Save(path, internalTypes);
        }

        public static List<InternalType> Load(string path)
        {
            if(!File.Exists(path))
                return new List<InternalType>();
            List<InternalType> internalTypes = Serializer.Load<List<InternalType>>(path);
            return internalTypes;
        }
    }
}
