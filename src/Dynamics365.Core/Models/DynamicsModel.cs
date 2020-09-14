using System.Collections.Generic;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public abstract class DynamicsModel
    {
        [JsonExtensionData]
        public Dictionary<string, string> Custom { get; set; } = new Dictionary<string, string>();
    }
}
