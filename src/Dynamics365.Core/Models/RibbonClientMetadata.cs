using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RibbonClientMetadata : DynamicsModel
    {
        [JsonProperty("ribbonid")]
        public Guid? RibbonId { get; set; }

        [JsonProperty("ribbonjson")]
        public string RibbonJson { get; set; }

        [JsonProperty("entitylogicalname")]
        public string EntityLogicalName { get; set; }

        [JsonProperty("ribboncontext")]
        public string RibbonContext { get; set; }

        [JsonProperty("componentstate")]
        public long? ComponentState { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("ribbonidunique")]
        public Guid? RibbonIdUnique { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }


    }
}

