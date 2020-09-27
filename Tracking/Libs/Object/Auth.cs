using System.IO;
using WcApi.Xml;
using WcApi.Cryptography;

namespace Tracking.Libs.Object
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
            if(!File.Exists(filePath))
                return new Auth();
            Auth auth = Serializer.Load<Auth>(filePath);
            auth.Password = CryptText.DecryptText(auth.Password, AuthKey.Key);
            return auth;
        }
    }
}
