using LK.Core.Libs.TarifManager.Tarif.Base;
using Newtonsoft.Json;

namespace LK.Core.Libs.TarifManager.Tarif
{
    public class ParcelTarif : ICustomTarif
    {
        [JsonProperty("paymark")]
        public double Rate { get; set; }
        public double RateNds { get; set; }

        [JsonProperty("weight")]
        public string Mass { get; set; }

        public string Name { get; set; } = "Бандероль Заказная";

        public int Type { get; set; } = 3;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 643;
    }
}
