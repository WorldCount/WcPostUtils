using System;
using System.Collections.Generic;
using System.Text;

namespace WcPostApi.Barcodes
{
    public static class BarcodeGenerator
    {
        private static readonly List<char> ConstList = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static readonly List<int> Multipliers = new List<int> { 8, 6, 4, 2, 3, 5, 9, 7 };

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

        public static bool IsValid(string barcode)
        {
            string b = GenBarcode(barcode);
            if (barcode == b)
                return true;
            return false;
        }

        public static string CreateBarcode(string ops, int monthNum, int rpoNum)
        {
            try
            {
               return GenBarcode($"{ops}{monthNum.ToString().PadLeft(2, '0')}{rpoNum.ToString().PadLeft(5, '0')}");
            }
            catch
            {
                return null;
            }
        }

        public static List<string> GenBarcodeList(string ops, int monthNum, int startNum, int endNum)
        {
            List<string> barcodes = new List<string>();

            if (ops.Length != 6)
                return null;

            if (endNum > 99999)
                endNum = 99999;

            if (startNum <= 0)
                startNum = 1;

            if (monthNum <= 0 || monthNum > 99)
                monthNum = 1;

            try
            {
                for (var i = startNum; i <= endNum; i++)
                {
                    string b = CreateBarcode(ops, monthNum, i);
                    if(b != null)
                        barcodes.Add(b);
                }

                return barcodes;
            }
            catch
            {
                return null;
            }
        }

        public static List<string> GenValidBarcode(object rawBarcode)
        {
            List<string> r = new List<string>();
            List<string> barcodes = new List<string>();
            int num = 0;

            if (rawBarcode is string s)
            {
                barcodes.Add(s);
            }
            else
            {
                barcodes = (List<string>) rawBarcode;
            }

            for (var i = barcodes.Count - 1; i >= 0; i--)
            {
                int index = barcodes[i].IndexOf('*');
                if (index == -1)
                    r.Add(barcodes[i]);
                else
                {
                    num++;

                    StringBuilder sb = new StringBuilder(barcodes[i]);
                    for (var n = 0; n <= 9; n++)
                    {
                        sb[index] = Char.Parse(n.ToString());
                        r.Add(sb.ToString());
                    }
                }
            }

            if (num == 0)
                return CheckBarcodes(r);
            return GenValidBarcode(r);
        }

        public static List<string> CheckBarcodes(List<string> barcodes)
        {
            List<string> r = new List<string>();
            for (var i = barcodes.Count - 1; i >= 0; i--)
            {
                if(barcodes[i][0] != '0' && IsValid(barcodes[i]))
                    r.Add(barcodes[i]);
            }

            return r;
        }
    }
}
