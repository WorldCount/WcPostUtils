
namespace PartStat.Core.Models.Tarifs.Base
{
    public interface IFirstClassTarif
    {
        string Name { get; set; }
        double Rate { get; set; }
        int StartMass { get; set; }
        int EndMass { get; set; }
        string Mass { get; set; }
    }
}
