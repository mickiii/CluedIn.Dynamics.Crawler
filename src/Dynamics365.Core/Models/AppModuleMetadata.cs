using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class AppModuleMetadata : DynamicsModel
    {
        [JsonProperty("appmodulemetadataid")]
        public Guid? AppModuleMetadataId { get; set; }

        [JsonProperty("appmoduleid")]
        public Guid? AppModuleId { get; set; }

        [JsonProperty("componenttype")]
        public long? ComponentType { get; set; }

        [JsonProperty("componentsubtype")]
        public long? ComponentSubType { get; set; }

        [JsonProperty("componentid")]
        public Guid? ComponentId { get; set; }

        [JsonProperty("componentversion")]
        public int? ComponentVersion { get; set; }

        [JsonProperty("parentcomponentid")]
        public Guid? ParentComponentId { get; set; }

        [JsonProperty("state")]
        public long? State { get; set; }

        [JsonProperty("componentisdefault")]
        public bool? ComponentIsDefault { get; set; }

        [JsonProperty("componentisquickfindquery")]
        public bool? ComponentIsQuickFindQuery { get; set; }

        [JsonProperty("componentisuserview")]
        public bool? ComponentIsUserView { get; set; }

        [JsonProperty("componentisuserchart")]
        public bool? ComponentIsUserChart { get; set; }

        [JsonProperty("componentisuserform")]
        public bool? ComponentIsUserForm { get; set; }

        [JsonProperty("componentistabletenabled")]
        public bool? ComponentIsTabletEnabled { get; set; }

        [JsonProperty("componentstatecode")]
        public long? ComponentStateCode { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }


    }
}

