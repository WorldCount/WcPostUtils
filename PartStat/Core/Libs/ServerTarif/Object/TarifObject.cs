using Newtonsoft.Json;

namespace PartStat.Core.Libs.ServerTarif.Object
{
    public class TarifObject
    {
        [JsonProperty("pay")]
        public double Pay { get; set; }

        [JsonProperty("paynds")]
        public double PayNds { get; set; }

        [JsonProperty("paymark")]
        public double PayMark { get; set; }
    }
}
