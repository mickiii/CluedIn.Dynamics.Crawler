using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Dependency : DynamicsModel
    {
        [JsonProperty("dependencyid")]
        public Guid? DependencyId { get; set; }

        [JsonProperty("dependencytype")]
        public string DependencyType { get; set; }

        [JsonProperty("requiredcomponentnodeid")]
        public string RequiredComponentNodeId { get; set; }

        [JsonProperty("requiredcomponentobjectid")]
        public Guid? RequiredComponentObjectId { get; set; }

        [JsonProperty("requiredcomponenttype")]
        public string RequiredComponentType { get; set; }

        [JsonProperty("requiredcomponentbasesolutionid")]
        public Guid? RequiredComponentBaseSolutionId { get; set; }

        [JsonProperty("requiredcomponentparentid")]
        public Guid? RequiredComponentParentId { get; set; }

        [JsonProperty("dependentcomponentnodeid")]
        public string DependentComponentNodeId { get; set; }

        [JsonProperty("dependentcomponentobjectid")]
        public Guid? DependentComponentObjectId { get; set; }

        [JsonProperty("dependentcomponenttype")]
        public string DependentComponentType { get; set; }

        [JsonProperty("dependentcomponentbasesolutionid")]
        public Guid? DependentComponentBaseSolutionId { get; set; }

        [JsonProperty("dependentcomponentparentid")]
        public Guid? DependentComponentParentId { get; set; }

        [JsonProperty("dependencytypename")]
        public string DependencyTypeName { get; set; }

        [JsonProperty("requiredcomponenttypename")]
        public string RequiredComponentTypeName { get; set; }

        [JsonProperty("dependentcomponenttypename")]
        public string DependentComponentTypeName { get; set; }

        [JsonProperty("requiredcomponentintroducedversion")]
        public double? RequiredComponentIntroducedVersion { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }


    }
}

