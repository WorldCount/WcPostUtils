using System;
using System.Security.Cryptography;
using System.Text;

namespace WcApi.Cryptography
{
    public class CryptText
    {
        // ReSharper disable once InconsistentNaming
        private static TripleDES Create3DES(string key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key));
            des.IV = new byte[des.BlockSize / 8];
            return des;
        }

        /// <summary>
        /// Шифрует текст
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="key">Ключ</param>
        /// <returns>Зашифрованная строка</returns>
        public static string EncryptText(string text, string key)
        {
            TripleDES des = Create3DES(key);
            ICryptoTransform ct = des.CreateEncryptor();
            byte[] input = Encoding.Unicode.GetBytes(text);
            byte[] inBytes = ct.TransformFinalBlock(input, 0, input.Length);
            string result = Convert.ToBase64String(inBytes);
            return result;
        }

        /// <summary>
        /// Расшифровывает текст
        /// </summary>
        /// <param name="cryptedText">Зашифрованная строка</param>
        /// <param name="key">Ключ</param>
        /// <returns>Текст</returns>
        public static string DecryptText(string cryptedText, string key)
        {
            try
            {
                byte[] b = Convert.FromBase64String(cryptedText);
                TripleDES des = Create3DES(key);
                ICryptoTransform ct = des.CreateDecryptor();
                byte[] outBytes = ct.TransformFinalBlock(b, 0, b.Length);
                return Encoding.Unicode.GetString(outBytes);
            }
            catch
            {
                return "";
            }
        }
    }
}
