using Newtonsoft.Json;
using PartStat.Core.Models.Tarifs.Base;

namespace PartStat.Core.Models.Tarifs
{
    public class ParcelTarif : ICustomTarif
    {
        [JsonProperty("paymark")]
        public double Rate { get; set; }

        [JsonProperty("weight")]
        public string Mass { get; set; }

        public string Name { get; set; } = "Бандероль Заказная";

        public int Type { get; set; } = 3;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 643;
    }
}
