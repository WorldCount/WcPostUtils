
namespace PartStat.Core.Models.Tarifs.Base
{
    public interface ICustomTarif
    {
        double Rate { get; set; }
        string Mass { get; set; }
    }
}
