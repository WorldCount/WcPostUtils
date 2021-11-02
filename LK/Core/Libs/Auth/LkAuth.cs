using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LK.Core.Libs.Auth.Model;
using Newtonsoft.Json;
//using System.Security.Authentication;

namespace LK.Core.Libs.Auth
{
    public class LkAuth
    {
        private readonly HttpClient _client;
        private readonly string _username;
        private readonly string _password;

        public LkAuth(string username, string password)
        {

            HttpClientHandler handler = new HttpClientHandler { CookieContainer = new CookieContainer { Capacity = 100 }, UseCookies = true };
            _client = new HttpClient(handler);

            _username = username;
            _password = password;
        }

        public LkAuth(WcApi.Cryptography.Auth auth)
        {
            //ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            HttpClientHandler handler = new HttpClientHandler
            {
                CookieContainer = new CookieContainer {Capacity = 100}, UseCookies = true
            };


            //handler.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;

            _client = new HttpClient(handler);

            _username = auth.Login;
            _password = auth.Password;
        }

        private void SetAuthHeaders()
        {
            _client.DefaultRequestHeaders.Clear();

            _client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            _client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36");
            _client.DefaultRequestHeaders.Add("Cache-Control", "max-age=0");
            _client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
            _client.DefaultRequestHeaders.Add("Origin", "https://otpravka-auth.pochta.ru");
            _client.DefaultRequestHeaders.Add("Accept-Language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            _client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            _client.DefaultRequestHeaders.Add("Referer", "https://otpravka-auth.pochta.ru/auth/login?redirect_uri=https%3A%2F%2Fpriem.pochta.ru%2Fauth");
            _client.DefaultRequestHeaders.Add("Host", "otpravka-auth.pochta.ru");
        }

        private void SetReportHeaders(Token token)
        {
            _client.DefaultRequestHeaders.Clear();


            _client.DefaultRequestHeaders.Referrer = new Uri("https://priem.pochta.ru/admin/statistics/reports");
            _client.DefaultRequestHeaders.Host = "priem.pochta.ru";

            _client.DefaultRequestHeaders.Add("Accept", "application/json;charset=UTF-8");
            _client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            _client.DefaultRequestHeaders.Add("Accept-Language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            _client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36");
            _client.DefaultRequestHeaders.Add("Origin", "https://priem.pochta.ru");
            _client.DefaultRequestHeaders.Add("Authorization", $"{token.TokenType} {token.AccessToken}");
            _client.DefaultRequestHeaders.Add("X-User-Authorization", $"{token.TokenType} {token.AccessToken}");
        }

        public async Task<string> Auth()
        {

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", _username),
                new KeyValuePair<string, string>("password", _password),
                new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded"),
            });

            SetAuthHeaders();

            Uri uri = new Uri("https://otpravka-auth.pochta.ru/auth/login?redirect_uri=https://priem.pochta.ru/auth");

            var response = await _client.PostAsync(uri, content);
            string t = response.RequestMessage.RequestUri.AbsoluteUri;

            int first = t.IndexOf('=') + 1;
            int end = t.IndexOf('&') - first;

            return t.Substring(first, end);
        }

        public async Task<Token> GetToken(string code)
        {
            Uri uriToken = new Uri("https://priem.pochta.ru/api/auth/token");

            DateTime currentDateTime = DateTime.Now;

            var tokenContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("code", code),
                new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded"),
            });

            var tokenResponse = await _client.PostAsync(uriToken, tokenContent);
            var tokenString = await tokenResponse.Content.ReadAsStringAsync();

            Token token = JsonConvert.DeserializeObject<Token>(tokenString);

            //using (StreamWriter file = File.CreateText(@"C:\1\token.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, token);
            //}

            if (token.IsExist())
                token.TokenEndDate = currentDateTime.AddSeconds(token.ExpiresIn);

            return token;
        }

        public async Task<string> ReportResponse(Token token, DateTime inDate, DateTime outDate)
        {

            string inD = inDate.ToString("yyyy-MM-dd");
            string outD = outDate.ToString("yyyy-MM-dd");

            var values = new Dictionary<string, object>
            {
                {"start-date", inD},
                {"end-date", outD},
                {"postoffice-codes", new [] {"125993"}},
            };

            SetReportHeaders(token);

            var queryContent = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://priem.pochta.ru/api/stats/processed", queryContent);

            string filePath = Path.Combine(PathManager.ReportPath, inD == outD ? $"{inD}.xlsx" : $"{inD} по {outD}.xlsx");


            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //copy the content from response to filestream
                await response.Content.CopyToAsync(fileStream);
            }

            return filePath;
        }

        public async Task<List<ReceiveDoc>> ReceiveDocResponse(Token token, DateTime startDate, DateTime endDate)
        {
            string startD = startDate.ToString("yyyy-MM-dd");
            string endD = endDate.ToString("yyyy-MM-dd");

            SetReportHeaders(token);

            string q = $"https://priem.pochta.ru/api/stats/125993/overview?startDate={startD}&endDate={endD}";

            var response = await _client.GetAsync(q);
            var tokenString = await response.Content.ReadAsStringAsync();
            List<ReceiveDoc> docs = JsonConvert.DeserializeObject<List<ReceiveDoc>>(tokenString);
            return docs;
        }

    }
}
