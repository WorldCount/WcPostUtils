using Newtonsoft.Json;

namespace PartStat.Core.Libs.ServerTarif.Object
{
    public class NoticeObject
    {
        [JsonProperty("service")]
        public ServiceObject Service { get; set; }
    }

    public class ServiceObject
    {
        [JsonProperty("val")]
        public double Pay { get; set; }

        [JsonProperty("valnds")]
        public double PayNds { get; set; }

        [JsonProperty("valmark")]
        public double PayMark { get; set; }
    }
}
