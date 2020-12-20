using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcPostApi.Types;

namespace WcPostApi.Tafirs.Types.Interface
{
    public interface IInter
    {
        string Name { get; set; }
        double Rate { get; set; }
        int Mass { get; set; }
        int Type { get; set; }
        int Category { get; set; }
        int CodeCountry { get; set; }
        TransType TransType { get; set; }
    }
}
