using Newtonsoft.Json;

namespace LK.Core.Libs.TarifManager.ServerTarif.Object
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
