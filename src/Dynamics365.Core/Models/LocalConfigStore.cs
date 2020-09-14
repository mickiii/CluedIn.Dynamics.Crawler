using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class LocalConfigStore : DynamicsModel
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }

        [JsonProperty("assemblyname")]
        public string AssemblyName { get; set; }

        [JsonProperty("publictoken")]
        public string PublicToken { get; set; }

        [JsonProperty("keyname")]
        public string KeyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("isvalueset")]
        public bool? IsValueSet { get; set; }


    }
}

