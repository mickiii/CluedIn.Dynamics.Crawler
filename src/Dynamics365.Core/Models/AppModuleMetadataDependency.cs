using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class AppModuleMetadataDependency : DynamicsModel
    {
        [JsonProperty("appmodulemetadatadependencyid")]
        public Guid? AppModuleMetadataDependencyId { get; set; }

        [JsonProperty("dependentcomponentid")]
        public Guid? DependentComponentId { get; set; }

        [JsonProperty("requiredcomponenttype")]
        public long? RequiredComponentType { get; set; }

        [JsonProperty("requiredcomponentid")]
        public Guid? RequiredComponentId { get; set; }

        [JsonProperty("requiredcomponentversion")]
        public int? RequiredComponentVersion { get; set; }

        [JsonProperty("state")]
        public long? State { get; set; }

        [JsonProperty("requiredcomponentsubtype")]
        public long? RequiredComponentSubType { get; set; }

        [JsonProperty("requiredcomponentinternalid")]
        public string RequiredComponentInternalId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }


    }
}

