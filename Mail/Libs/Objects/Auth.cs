using System.IO;
using WcApi.Cryptography;
using WcApi.Xml;

namespace Mail.Libs.Objects
{
    public class Auth
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ExchangeUrl { get; set; }

        public Auth()
        {
        }

        public Auth(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public Auth(string login, string password, string email)
        {
            Login = login;
            Password = password;
            Email = email;
        }

        public Auth(string login, string password, string email, string exchange)
        {
            Login = login;
            Password = password;
            Email = email;
            ExchangeUrl = exchange;
        }

        public void Save(string filePath)
        {
            Auth auth = new Auth(Login, CryptText.EncryptText(Password, AuthKey.Key), Email, ExchangeUrl);
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
}
