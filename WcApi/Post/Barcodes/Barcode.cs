
namespace WcApi.Post.Barcodes
{
    public class Barcode
    {
        public string Ops { get; set; } = "";
        public string Month { get; set; } = "";
        public string Number { get; set; } = "";
        public string ControlRank { get; set; } = "";

        public Barcode()
        {
        }

        public Barcode(string barcodeRaw)
        {
            Parse(barcodeRaw);
        }

        public Barcode(string ops, string month, string number)
        {
            Ops = ops;
            Month = month;
            Number = number;
            ControlRank = Barcodes.ControlRank.GenControlRank($"{Ops}{Month.PadLeft(2, '0')}{Number.PadLeft(5, '0')}").ToString();
        }

        /// <summary>
        /// Парсит ШПИ отправления
        /// </summary>
        /// <param name="barcode">ШПИ</param>
        /// <param name="genControlRank">Генерировать контрольный разряд</param>
        /// <returns></returns>
        public bool Parse(string barcode, bool genControlRank = false)
        {
            if (barcode.Length < 13)
                return false;

            if (genControlRank == false && barcode.Length < 14)
                return false;

            Ops = barcode.Substring(0, 6);
            Month = barcode.Substring(6, 2);
            Number = barcode.Substring(8, 5);

            if (genControlRank)
            {
                ControlRank = Barcodes.ControlRank.GenControlRank($"{Ops}{Month.PadLeft(2, '0')}{Number.PadLeft(5, '0')}").ToString();
                if (ControlRank != null)
                    return true;
                return false;
            }
            else
            {
                ControlRank = barcode.Substring(13, 1);
                return true;
            }
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(ControlRank))
                ControlRank = Barcodes.ControlRank.GenControlRank($"{Ops}{Month.PadLeft(2, '0')}{Number.PadLeft(5, '0')}").ToString();
            return $"{Ops}{Month.PadLeft(2, '0')}{Number.PadLeft(5, '0')}{ControlRank}";
        }
    }
}
