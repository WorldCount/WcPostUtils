using System.Collections.Generic;
using Newtonsoft.Json;

namespace LK.Core.Libs.Auth.Model
{
    public class PostOffice
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("kpp")]
        public string Kpp { get; set; }

        [JsonProperty("features")]
        public List<string> Features { get; set; }

        [JsonProperty("full-address")]
        public string FullAddress { get; set; }

        [JsonProperty("short-name")]
        public string ShortName { get; set; }

        [JsonProperty("additional-indices")]
        public List<string> AdditionalIndices { get; set; }

        [JsonProperty("virtual-index")]
        public string VirtualIndex { get; set; }
    }
}
