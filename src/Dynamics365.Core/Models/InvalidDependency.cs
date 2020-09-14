using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class InvalidDependency : DynamicsModel
    {
        [JsonProperty("invaliddependencyid")]
        public Guid? InvalidDependencyId { get; set; }

        [JsonProperty("isexistingnoderequiredcomponent")]
        public bool? IsExistingNodeRequiredComponent { get; set; }

        [JsonProperty("existingdependencytype")]
        public string ExistingDependencyType { get; set; }

        [JsonProperty("missingcomponenttype")]
        public string MissingComponentType { get; set; }

        [JsonProperty("missingcomponentid")]
        public Guid? MissingComponentId { get; set; }

        [JsonProperty("missingcomponentinfo")]
        public string MissingComponentInfo { get; set; }

        [JsonProperty("missingcomponentlookuptype")]
        public long? MissingComponentLookupType { get; set; }

        [JsonProperty("existingcomponentid")]
        public Guid? ExistingComponentId { get; set; }

        [JsonProperty("existingcomponenttype")]
        public string ExistingComponentType { get; set; }

        [JsonProperty("existingdependencytypename")]
        public string ExistingDependencyTypeName { get; set; }

        [JsonProperty("missingcomponenttypename")]
        public string MissingComponentTypeName { get; set; }

        [JsonProperty("existingcomponenttypename")]
        public string ExistingComponentTypeName { get; set; }


    }
}

