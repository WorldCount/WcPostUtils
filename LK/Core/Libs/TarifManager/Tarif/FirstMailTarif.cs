
namespace LK.Core.Libs.TarifManager.Tarif
{
    public class FirstMailTarif
    {
        public string Name { get; set; } = "Письмо 1 кл.";
        public double Rate { get; set; }
        public double RateNds { get; set; }
        public int StartMass { get; set; }
        public int EndMass { get; set; }

        public int Type { get; set; } = 15;
        public int Category { get; set; } = 1;

        public string Mass => $"{EndMass}";
    }
}
