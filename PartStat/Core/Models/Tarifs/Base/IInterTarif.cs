using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Models.Tarifs.Base
{
    public interface IInterTarif
    {
        TransType TransType { get; set; }
        double Rate { get; set; }
        string Mass { get; set; }
    }
}
