using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SyncAttributeMapping : DynamicsModel
    {
        [JsonProperty("syncattributemappingid")]
        public Guid? SyncAttributeMappingId { get; set; }

        [JsonProperty("syncattributemappingidunique")]
        public Guid? SyncAttributeMappingIdUnique { get; set; }

        [JsonProperty("mappingname")]
        public string MappingName { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("entitytypecode")]
        public string EntityTypeCode { get; set; }

        [JsonProperty("syncattributemappingprofileid")]
        public string SyncAttributeMappingProfileId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("attributecrmname")]
        public string AttributeCRMName { get; set; }

        [JsonProperty("attributeexchangename")]
        public string AttributeExchangeName { get; set; }

        [JsonProperty("syncdirection")]
        public string SyncDirection { get; set; }

        [JsonProperty("syncdirectionname")]
        public string SyncDirectionName { get; set; }

        [JsonProperty("iscomputed")]
        public bool? IsComputed { get; set; }

        [JsonProperty("computedproperties")]
        public string ComputedProperties { get; set; }

        [JsonProperty("parentsyncattributemappingid")]
        public string ParentSyncAttributeMappingId { get; set; }

        [JsonProperty("defaultsyncdirection")]
        public string DefaultSyncDirection { get; set; }

        [JsonProperty("defaultsyncdirectionname")]
        public string DefaultSyncDirectionName { get; set; }

        [JsonProperty("allowedsyncdirection")]
        public long? AllowedSyncDirection { get; set; }


    }
}

