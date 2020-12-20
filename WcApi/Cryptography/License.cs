using System;
using System.IO;
using WcApi.Xml;

namespace WcApi.Cryptography
{

    public class Auth
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Auth()
        {
        }

        public Auth(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void Save(string filePath)
        {
            Auth auth = new Auth(Login, CryptText.EncryptText(Password, AuthKey.Key));
            Serializer.Save(filePath, auth);
        }

        public static Auth Load(string filePath)
        {
            if (!File.Exists(filePath))
                return new Auth();
            Auth auth = Serializer.Load<Auth>(filePath);
            auth.Password = CryptText.DecryptText(auth.Password, AuthKey.Key);
            return auth;
        }
    }

    public static class AuthKey
    {
        public static string Key = "WorldCountTheBest";
    }

    public static class LicenseKey
    {
        public static string GetKey(string ip, string authKey, string productName)
        {
            return Md5Hash.GetMd5Hash($"{ip}{authKey}{productName}");
        }
    }

    public static class License
    {

        /// <summary>
        /// Возвращает дату действия лицензии строкой
        /// </summary>
        /// <param name="licenseKey">Ключ лицензии</param>
        /// <param name="key">Ключ шифрования для лицензии</param>
        /// <returns>Строка с датой лицензии</returns>
        public static string GetLicenseExpiresString(string licenseKey, string key)
        {
            string licenseText;

            try
            {
                licenseText = CryptText.DecryptText(licenseKey, key);
            }
            catch
            {
                return null;
            }

            return licenseText;
        }

        /// <summary>
        /// Возвращает дату действия лицензии
        /// </summary>
        /// <param name="licenseKey">Ключ лицензии</param>
        /// <param name="key">Ключ шифрования для лицензии</param>
        /// <returns>Дата действия лицензии</returns>
        public static DateTime GetLicenseExpires(string licenseKey, string key)
        {
            DateTime exp = new DateTime();

            try
            {
                string licenseText = GetLicenseExpiresString(licenseKey, key);
                exp = DateTime.Parse(licenseText);
                return exp;
            }
            catch
            {
                return exp;
            }
        }

        /// <summary>
        /// Проверяет лицензию на валидность
        /// </summary>
        /// <param name="licenseKey">Ключ лицензии</param>
        /// <param name="key">Ключ шифрования лицензии</param>
        /// <returns>Валидность</returns>
        public static bool CheckLicense(string licenseKey, string key)
        {
            try
            {
                DateTime licenseDate = GetLicenseExpires(licenseKey, key);

                if (licenseDate < DateTime.Today)
                    throw new Exception();
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Возвращает ключ лицензии
        /// </summary>
        /// <param name="license">Дата лицензии строкой</param>
        /// <param name="key">Ключ шифрования для лицензии</param>
        /// <returns>Ключ лицензии</returns>
        public static string GetLicenseKey(string license, string key)
        {
            return CryptText.EncryptText(license, key);
        }

        /// <summary>
        /// Возвращает ключ лицензии
        /// </summary>
        /// <param name="licenseDate">Дата лицензии</param>
        /// <param name="key">Ключ шифрования для лицензии</param>
        /// <returns>Ключ лицензии</returns>
        public static string GetLicenseKey(DateTime licenseDate, string key)
        {
            string license = licenseDate.ToString("dd.MM.yyyy");
            return GetLicenseKey(license, key);
        }

    }
}
