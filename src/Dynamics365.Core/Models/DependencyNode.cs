using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class DependencyNode : DynamicsModel
    {
        [JsonProperty("dependencynodeid")]
        public Guid? DependencyNodeId { get; set; }

        [JsonProperty("componenttype")]
        public string ComponentType { get; set; }

        [JsonProperty("objectid")]
        public Guid? ObjectId { get; set; }

        [JsonProperty("basesolutionid")]
        public string BaseSolutionId { get; set; }

        [JsonProperty("topsolutionid")]
        public string TopSolutionId { get; set; }

        [JsonProperty("parentid")]
        public Guid? ParentId { get; set; }

        [JsonProperty("componenttypename")]
        public string ComponentTypeName { get; set; }

        [JsonProperty("issharedcomponent")]
        public bool? IsSharedComponent { get; set; }

        [JsonProperty("introducedversion")]
        public double? IntroducedVersion { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }


    }
}

