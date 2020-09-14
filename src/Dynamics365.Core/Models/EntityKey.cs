using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class EntityKey : DynamicsModel
    {
        [JsonProperty("entitykeyid")]
        public Guid? EntityKeyId { get; set; }

        [JsonProperty("logicalname")]
        public string LogicalName { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }


    }
}

