using System.Collections.Generic;
using Newtonsoft.Json;

namespace LK.Core.Libs.Auth.Model
{
    public class UserProfile
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display-name")]
        public string DisplayName { get; set; }

        [JsonProperty("postoffice_code")]
        public string PostofficeCode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }

    }
}
