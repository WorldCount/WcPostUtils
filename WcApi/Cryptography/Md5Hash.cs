using System.Text;
using System.Security.Cryptography;

namespace WcApi.Cryptography
{
    public static class Md5Hash
    {
        public static string GetMd5Hash(string input, bool upper=true)
        {
            using(MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                if (upper)
                    return sBuilder.ToString().ToUpper();
                else
                    return sBuilder.ToString();
            }
        }
    }
}
