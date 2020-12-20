using WcPostApi.Tafirs.Types.Interface;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Types
{
    public class InterCustomParcelTarif : ICustom, IInter
    {
        public string Name { get; set; } = "Бандероль Мжд";
        public double Rate { get; set; }
        public int Mass { get; set; }

        public int Type { get; set; } = 3;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 0;
        public TransType TransType { get; set; }
    }
}
