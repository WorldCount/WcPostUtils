using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace WcApi.Net
{
    public enum ParseMode
    {
        None,
        // ReSharper disable once InconsistentNaming
        HTML,
        Markdown
    }

    public class Telegram
    {
        private readonly string _token;
        private readonly string _chatId;
        private static readonly HttpClient Client = new HttpClient();

        public Telegram(string token, string chatId)
        {
            _token = token;
            _chatId = chatId;

            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36");

        }

        public async Task<bool> SendMessage(string msg, ParseMode parseMode = ParseMode.None)
        {
            string req = $"https://api.telegram.org/bot{_token}/sendMessage?chat_id={_chatId}&text={msg}";

            if (parseMode == ParseMode.HTML)
                req += "&parse_mode=html";

            if (parseMode == ParseMode.Markdown)
                req += "&parse_mode=markdown";

            HttpResponseMessage response = await Client.GetAsync(req);

            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}
