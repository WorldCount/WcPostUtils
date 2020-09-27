using Newtonsoft.Json;
using PartStat.Core.Models.Tarifs.Base;

namespace PartStat.Core.Models.Tarifs
{
    public class MailTarif : ICustomTarif
    {
        [JsonProperty("paymark")]
        public double Rate { get; set; }

        [JsonProperty("weight")]
        public string Mass { get; set; }

        public string Name { get; set; } = "Письмо Заказное";

        public int Type { get; set; } = 2;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 643;
    }
}
