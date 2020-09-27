using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcApi.Net;

namespace PartStat.Core
{
    public static class Utils
    {
        public static Telegram Telegram = new Telegram("537500200:AAGgB6YVgRaDGy36zcOk33azvDWdy9EAVDg", "126979457");

        public static List<int> GetListInt(int start, int end, int step = 20)
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
