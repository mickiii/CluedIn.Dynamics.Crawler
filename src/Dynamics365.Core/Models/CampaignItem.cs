using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CampaignItem : DynamicsModel
    {
        [JsonProperty("campaignitemid")]
        public Guid? CampaignItemId { get; set; }

        [JsonProperty("entityid")]
        public Guid? EntityId { get; set; }

        [JsonProperty("entitytype")]
        public string EntityType { get; set; }

        [JsonProperty("importsequencenumber")]
        public int ImportSequenceNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public int TimezoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public int UtcConversionTimezoneCdoe { get; set; }

        [JsonProperty("versionnumber")]
        public long VersionNumber { get; set; }
    }
}
