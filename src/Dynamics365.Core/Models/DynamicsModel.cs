using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public abstract class DynamicsModel
    {
        [JsonExtensionData]
        public Dictionary<string, JToken> Custom { get; set; } = new Dictionary<string, JToken>();
    }
}
