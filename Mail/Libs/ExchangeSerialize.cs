using System.IO;
using Microsoft.Exchange.WebServices.Data;
using WcApi.Xml;

namespace Mail.Libs
{
    public static class ExchangeSerialize
    {
        public static void Save(string path, ExchangeService service)
        {
            Serializer.Save(path, service);
        }

        public static ExchangeService Load(string path)
        {
            if (!File.Exists(path))
                return null;
            ExchangeService service = Serializer.Load<ExchangeService>(path);
            return service;
        }
    }
}
