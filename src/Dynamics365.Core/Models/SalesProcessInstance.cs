using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SalesProcessInstance : DynamicsModel
    {
        [JsonProperty("salesstagename")]
        public string SalesStageName { get; set; }

        [JsonProperty("salesprocessinstanceid")]
        public Guid? SalesProcessInstanceId { get; set; }

        [JsonProperty("businessunitid")]
        public string BusinessUnitId { get; set; }

        [JsonProperty("salesprocessname")]
        public string SalesProcessName { get; set; }

        [JsonProperty("opportunityid")]
        public string OpportunityId { get; set; }

        [JsonProperty("opportunityidname")]
        public string OpportunityIdName { get; set; }

        [JsonProperty("businessunitidname")]
        public string BusinessUnitIdName { get; set; }

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

        [JsonProperty("name")]
        public string Name { get; set; }


    }
}

