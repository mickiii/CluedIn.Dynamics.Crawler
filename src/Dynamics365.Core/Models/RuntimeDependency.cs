using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RuntimeDependency : DynamicsModel
    {
        [JsonProperty("dependencyid")]
        public Guid? DependencyId { get; set; }

        [JsonProperty("dependentcomponentnodeid")]
        public Guid? DependentComponentNodeId { get; set; }

        [JsonProperty("requiredcomponentnodeid")]
        public string RequiredComponentNodeId { get; set; }

        [JsonProperty("dependentcomponenttype")]
        public long? DependentComponentType { get; set; }

        [JsonProperty("requiredcomponenttype")]
        public long? RequiredComponentType { get; set; }

        [JsonProperty("createdtime")]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("requiredcomponentmodifiedtime")]
        public DateTimeOffset? RequiredComponentModifiedTime { get; set; }

        [JsonProperty("ispublished")]
        public string IsPublished { get; set; }


    }
}

