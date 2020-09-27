using System.Collections.Generic;

namespace WcApi.Post.Barcodes
{
    public static class ControlRank
    {
        private static readonly List<char> ConstList = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static readonly List<int> Multipliers = new List<int> { 8, 6, 4, 2, 3, 5, 9, 7 };

        /// <summary>
        /// Генерирует обычный ШПИ
        /// </summary>
        /// <param name="barcode">ШПИ</param>
        /// <returns>Строка со ШПИ или null</returns>
        private static string GenNormalBarcode(string barcode)
        {
            // Сумма четных
            int even = 0;
            // Сумма нечетных
            int odd = 0;
            // Длина ШПИ
            int barcodeLen = barcode.Length;

            if (barcodeLen < 13 || barcodeLen > 14)
                return null;

            for (int i = 0; i < 13; i++)
            {
                try
                {
                    if (i % 2 == 0)
                        even += int.Parse(barcode[i].ToString());
                    else
                        odd += int.Parse(barcode[i].ToString());
                }
                catch { return null; }
            }

            int allSum = (even * 3) + odd;
            int numCr = 10 - (allSum % 10);
            string controlRank = numCr == 10 ? "0" : numCr.ToString();

            if (barcodeLen == 13)
                return $"{barcode}{controlRank}";
            return $"{barcode.Substring(0, 13)}{controlRank}";
        }

        /// <summary>
        /// Генерирует ШПИ международного отправления
        /// </summary>
        /// <param name="barcode">ШПИ</param>
        /// <returns>Строка со ШПИ или null</returns>
        private static string GenEmsBarcode(string barcode)
        {
            // Сумма элементов
            int numberSum = 0;
            // Длина ШПИ
            int barcodeLen = barcode.Length;

            if (barcodeLen != 13)
                return null;

            string barcodeType = barcode.Substring(0, 2);
            string barcodeNum = barcode.Substring(2, 8);
            string barcodeLand = barcode.Substring(11, 2);

            for (int i = 0; i < 8; i++)
            {
                try
                {
                    numberSum += (int.Parse(barcodeNum[i].ToString()) * Multipliers[i]);
                }
                catch { return null; }
            }

            int numCr = 11 - (numberSum % 11);
            string controlRank;

            if (numCr == 10)
                controlRank = "0";
            else if (numCr == 11)
                controlRank = "5";
            else
                controlRank = numCr.ToString();

            return $"{barcodeType}{barcodeNum}{controlRank}{barcodeLand}";
        }

        /// <summary>
        /// Генерирует ШПИ
        /// </summary>
        /// <param name="barcode">ШПИ</param>
        /// <returns>Строка со ШПИ или null</returns>
        public static string GenBarcode(string barcode)
        {
            // Длина ШПИ
            int barcodeLen = barcode.Length;

            if (barcodeLen < 13 || barcodeLen > 14)
                return null;

            if (ConstList.Contains(barcode[0]))
                return GenNormalBarcode(barcode);
            return GenEmsBarcode(barcode);
        }

        /// <summary>
        /// Генерирует контрольный разряд отправления
        /// </summary>
        /// <param name="barcode">ШПИ</param>
        /// <returns>char или null</returns>
        public static char? GenControlRank(string barcode)
        {
            string result = GenBarcode(barcode);
            if (result != null)
            {
                if (ConstList.Contains(result[0]))
                    return result[13];
                return result[10];
            }
            return null;
        }
    }
}
