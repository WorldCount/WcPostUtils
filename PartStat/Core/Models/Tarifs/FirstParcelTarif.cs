using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Models.Tarifs
{
    public class FirstParcelTarif
    {
        public string Name { get; set; } = "Бандероль 1 кл.";
        public TransType TransType { get; set; } = TransType.До2000Км;
        public double Rate { get; set; }
        public int StartMass { get; set; }
        public int EndMass { get; set; }

        public int Type { get; set; } = 16;
        public int Category { get; set; } = 1;

        public string Mass
        {
            get
            {
                if (TransType == TransType.До2000Км)
                    return $"[<]{EndMass.ToString().PadLeft(6)}";
                return $"{EndMass.ToString().PadRight(6)}[>]";
            }
        }
    }
}
