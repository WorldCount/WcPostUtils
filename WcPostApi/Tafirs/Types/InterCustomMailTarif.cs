using WcPostApi.Tafirs.Types.Interface;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Types
{
    public class InterCustomMailTarif : ICustom, IInter
    {
        public string Name { get; set; } = "Письмо Мжд";
        public double Rate { get; set; }
        public int Mass { get; set; }

        public int Type { get; set; } = 2;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 0;
        public TransType TransType { get; set; }
    }
}
