using System.Text.Json.Serialization;

namespace WcPostApi.Tafirs.TarifObject
{
    internal class Notice
    {
        [JsonPropertyName("service")]
        public ServiceObject Service { get; set; }
    }

    internal class ServiceObject
    {
        [JsonPropertyName("val")]
        public double Pay { get; set; }
        [JsonPropertyName("valnds")]
        public double PayNds { get; set; }
        [JsonPropertyName("valmark")]
        public double PayMark { get; set; }
    }
}
