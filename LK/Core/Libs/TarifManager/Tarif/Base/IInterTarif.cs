using LK.Core.Libs.TarifManager.PostTypes;

namespace LK.Core.Libs.TarifManager.Tarif.Base
{
    public interface IInterTarif
    {
        TransType TransType { get; set; }
        double Rate { get; set; }
        string Mass { get; set; }
    }
}
