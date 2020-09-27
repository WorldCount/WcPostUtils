using System.Linq;
using System.Text.RegularExpressions;

namespace WcApi.Ext
{
    public static class TextExt
    {
        // ReSharper disable once InconsistentNaming
        public static string RemoveIntLINQ(this string input)
        {
            return new string(input.Where(char.IsLetter).ToArray());
        }

        public static string RemoveIntRegex(this string input)
        {
            return Regex.Replace(input, @"[\d]", string.Empty);
        }
    }
}
