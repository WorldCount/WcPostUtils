using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DwUtils.Core.Libs.ServerRequest
{
    public static class ServerManager
    {
        private static readonly HttpClient Client = new HttpClient();

        public static async Task<ServerAuth> GetServerAuth()
        {
            try
            {
                Uri uri = new Uri("https://worldcount.ru/updates/auth.json");
                var response = await Client.GetAsync(uri);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return new ServerAuth {Work = false, Message = "Упс, сервис теперь не доступен. Удачи :)"};
                }

                ServerAuth serverAuth =
                    JsonConvert.DeserializeObject<ServerAuth>(await response.Content.ReadAsStringAsync());
                return serverAuth;
            }
            catch
            {
                return new ServerAuth {Work = false, Message = "Упс, сервис теперь не доступен. Удачи :)"};
            }
        }
    }

    public class ServerAuth
    {
        [JsonProperty("work")] public bool Work { get; set; }

        [JsonProperty("message")] public string Message { get; set; }
    }
}
