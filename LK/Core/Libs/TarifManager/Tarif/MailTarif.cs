using LK.Core.Libs.TarifManager.Tarif.Base;
using Newtonsoft.Json;

namespace LK.Core.Libs.TarifManager.Tarif
{
    public class MailTarif : ICustomTarif
    {
        [JsonProperty("paymark")]
        public double Rate { get; set; }
        [JsonProperty("paynds")]
        public double RateNds { get; set; }

        [JsonProperty("weight")]
        public string Mass { get; set; }

        public string Name { get; set; } = "Письмо Заказное";

        public int Type { get; set; } = 2;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 643;
    }
}
