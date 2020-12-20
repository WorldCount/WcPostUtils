using WcPostApi.Tafirs.Types.Interface;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Types
{
    public class CustomMailTarif : ICustom
    {
        public string Name { get; set; } = "Письмо Заказное";
        public double Rate { get; set; }
        public int Mass { get; set; }
        public int Type { get; set; } = 2;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 643;
        public TransType TransType { get; set; } = TransType.Нет;
    }
}
