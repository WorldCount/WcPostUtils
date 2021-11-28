using LK.Core.Libs.TarifManager.PostTypes;

namespace LK.Core.Libs.TarifManager.Tarif.Base
{
    public interface INoticeTarif
    {
        ServiceType Type { get; set; }
        string Name { get; set; }
        double Rate { get; set; }
    }
}
