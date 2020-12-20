using WcPostApi.Tafirs.Types.Interface;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Types
{
    public class CustomFirstMail : ICustom, IFirstClass
    {
        public string Name { get; set; } = "Письмо 1 кл.";
        public double Rate { get; set; }
        public int Mass { get; set; }
        public int Type { get; set; } = 15;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 643;
        public TransType TransType { get; set; } = TransType.До2000Км;

        public string MassName
        {
            get
            {
                if (TransType == TransType.До2000Км)
                    return $"[<]{Mass.ToString().PadLeft(6)}";
                return $"{Mass.ToString().PadRight(6)}[>]";
            }
        }
    }
}
