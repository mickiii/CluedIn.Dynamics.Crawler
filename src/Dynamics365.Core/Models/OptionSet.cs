using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class OptionSet : DynamicsModel
    {
        [JsonProperty("optionsetid")]
        public Guid? OptionSetId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }


    }
}

