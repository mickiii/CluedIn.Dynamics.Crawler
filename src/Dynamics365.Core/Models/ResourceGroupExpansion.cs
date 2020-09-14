using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ResourceGroupExpansion : DynamicsModel
    {
        [JsonProperty("objectid")]
        public Guid? ObjectId { get; set; }

        [JsonProperty("resourcegroupexpansionid")]
        public Guid? ResourceGroupExpansionId { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("itemid")]
        public Guid? ItemId { get; set; }

        [JsonProperty("methodcode")]
        public string MethodCode { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("methodcodename")]
        public string methodcodeName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }


    }
}

