using System.Collections.Generic;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class DynamicsModel
    {
        [JsonIgnore]
        public EntityDefinition EntityDefinition { get; set; }

        [JsonIgnore]
        public List<RelationshipDefinition> RelationshipDefinitions { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Custom { get; set; } = new Dictionary<string, object>();
    }
}
