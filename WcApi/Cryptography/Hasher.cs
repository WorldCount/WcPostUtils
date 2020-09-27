using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WcApi.Cryptography
{
    public static class Hasher
    {
        public static string HashFile(string filePath, HashType hashType)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                switch (hashType)
                {
                    case HashType.MD5:
                        return MakeHashString(MD5.Create().ComputeHash(stream));
                    case HashType.SHA1:
                        return MakeHashString(SHA1.Create().ComputeHash(stream));
                    case HashType.SHA512:
                        return MakeHashString(SHA512.Create().ComputeHash(stream));
                    case HashType.CRC32:
                        // ReSharper disable once AccessToStaticMemberViaDerivedType
                        return MakeHashString(CRC32.Create().ComputeHash(stream));
                    default:
                        return "";
                }
            }
            
        }

        private static string MakeHashString(byte[] hash)
        {
            StringBuilder s = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
                s.Append(b.ToString("X2").ToUpper());

            return s.ToString();
        }
    }
}
