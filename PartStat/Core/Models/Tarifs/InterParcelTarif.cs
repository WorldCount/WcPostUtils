using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Models.Tarifs
{
    public class InterParcelTarif
    {
        public TransType TransType { get; set; }
        public double Rate { get; set; }
        public int StartMass { get; set; }
        public int EndMass { get; set; }

        public string Name { get; set; } = "Бандероль Мжд";

        public int Type { get; set; } = 3;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 0;

        public string Mass => $"{EndMass}";
    }
}
