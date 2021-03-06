using System;
using System.Collections.Generic;
using WcApi.Net;

namespace LK.Core
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

        public static string GetPayName(int payType, int subPayType)
        {
            if (payType == 16)
            {
                if (subPayType == 1)
                    return "Марки";
                if (subPayType == 2)
                    return "Франк";
                return $"{payType}-{subPayType}";
            }

            if (payType == 2)
            {
                if (subPayType == 1)
                    return "Безнал";
                return $"{payType}-{subPayType}";
            }
            return $"{payType}-{subPayType}";
        }

        public static DateTime CropDate(DateTime date, int hour = 0, int minute = 0, int second = 0)
        {
            return new DateTime(date.Year, date.Month, date.Day, hour, minute, second);
        }

        public static string TrimName(string name)
        {
            name = name.ToUpper();

            if (name.Contains("\""))
                name = name.Replace("\"", "");

            if (name.Contains("ООО"))
                name = name.Replace("ООО", "");

            if (name.Contains("“"))
                name = name.Replace("“", "");

            if (name.Contains("”"))
                name = name.Replace("”", "");

            if (name.Contains("«"))
                name = name.Replace("«", "");

            if (name.Contains("»"))
                name = name.Replace("»", "");

            if (name.Contains("АКЦИОНЕРНОЕ ОБЩЕСТВО"))
                name = name.Replace("АКЦИОНЕРНОЕ ОБЩЕСТВО", "");

            if (name.Contains("ФГБУ"))
                name = name.Replace("ФГБУ", "");

            if (name.Contains("ФКУ"))
                name = name.Replace("ФКУ", "");

            if (name.Contains("ФГБОУ"))
                name = name.Replace("ФГБОУ", "");

            if (name.Contains("ГБОУ"))
                name = name.Replace("ГБОУ", "");

            name = name.TrimStart(new[] {','});
            name = name.TrimEnd(new []{','});

            name = name.Trim();

            return name;
        }
    }
}
