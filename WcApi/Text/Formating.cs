
namespace WcApi.Text
{
    public static class Formating
    {
        public static string FormatBytes(long bytes, int decimalPlaces, bool showByteType)
        {
            double newBytes = bytes;
            string formatString = "{0";

            // ReSharper disable once RedundantAssignment
            string byteType = "Б";

            if (newBytes > 1024 && newBytes < 1048576)
            {
                newBytes /= 1024;
                byteType = "КБ";
            }
            else if (newBytes > 1048576 && newBytes < 1073741824)
            {
                newBytes /= 1048576;
                byteType = "МБ";
            }
            else
            {
                newBytes /= 1073741824;
                byteType = "ГБ";
            }

            if (decimalPlaces > 0)
                formatString += ":0.";

            for (int i = 0; i < decimalPlaces; i++)
                formatString += "0";

            formatString += "}";

            if (showByteType)
                formatString += byteType;

            return string.Format(formatString, newBytes);
        }
    }
}
