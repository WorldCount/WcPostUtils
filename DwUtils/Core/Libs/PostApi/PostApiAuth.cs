using System;
using System.IO;
using System.Threading.Tasks;
using DwUtils.PostApi;
using NLog;
using WcApi.Cryptography;
using WcApi.Xml;

namespace DwUtils.Core.Libs.PostApi
{
    public class PostApiAuth
    {
        private readonly OperationHistory12Client _client = new OperationHistory12Client();
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public string Login { get; set; }
        public string Password { get; set; }

        public PostApiAuth()
        {
        }

        public PostApiAuth(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void Save(string filePath)
        {
            PostApiAuth auth = new PostApiAuth(Login, CryptText.EncryptText(Password, AuthKey.Key));
            Serializer.Save(filePath, auth);
        }

        public static PostApiAuth Load(string filePath)
        {
            if (!File.Exists(filePath))
                return new PostApiAuth();
            PostApiAuth auth = Serializer.Load<PostApiAuth>(filePath);
            auth.Password = CryptText.DecryptText(auth.Password, AuthKey.Key);
            return auth;
        }

        public bool TestAuth()
        {
            AuthorizationHeader authHeader = new AuthorizationHeader {login = Login, password = Password};
            SmsHistoryRequest req = new SmsHistoryRequest{Barcode = "18503547007531", Language = "RUS"};

            try
            {
                var resp = _client.getSmsHistory(authHeader, req);

                if (resp == null)
                    return false;
                return true;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> TestAuthAsync()
        {
            AuthorizationHeader authHeader = new AuthorizationHeader { login = Login, password = Password };
            SmsHistoryRequest req = new SmsHistoryRequest { Barcode = "18503547007531", Language = "RUS" };

            try
            {
                var resp = await _client.getSmsHistoryAsync(authHeader, req);

                if (resp == null)
                    return false;
                return true;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }
    }
}
