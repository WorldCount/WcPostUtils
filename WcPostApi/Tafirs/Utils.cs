using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcPostApi.Tafirs
{
    internal static class Utils
    {
        internal static List<int> GetListInt(int start, int end, int step = 20)
        {
            List<int> ints = new List<int>();
            if (step == 0)
                return ints;

            for (int i = start; i <= end; i += step)
            {
                ints.Add(i);
            }

            return ints;
        }


    }
}
