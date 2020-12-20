using System;
using Newtonsoft.Json;

namespace LK.Core.Libs.Auth.Model
{
    public class Token
    {

        [JsonProperty("postoffice")]
        public PostOffice PostOffice { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("user_profile")]
        public UserProfile UserProfile { get; set; }

        public DateTime TokenEndDate { get; set; }

        public bool IsExist()
        {
            return !string.IsNullOrEmpty(AccessToken);
        }
    }
}
