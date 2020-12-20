using System.Text.Json.Serialization;

namespace WcPostApi.Tafirs.TarifObject
{
    internal class Tarif
    {
        [JsonPropertyName("pay")]
        public double Pay { get; set; }

        [JsonPropertyName("paynds")]
        public double PayNds { get; set; }

        [JsonPropertyName("paymark")]
        public double PayMark { get; set; }

        [JsonPropertyName("weight")]
        public int Mass { get; set; }
    }
}
