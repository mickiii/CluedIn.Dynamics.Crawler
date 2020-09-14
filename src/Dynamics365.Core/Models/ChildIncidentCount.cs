using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ChildIncidentCount : DynamicsModel
    {
        [JsonProperty("parentcaseid")]
        public Guid? ParentCaseId { get; set; }

        [JsonProperty("numberofchildincidents")]
        public string NumberOfChildIncidents { get; set; }

        [JsonProperty("childincidentcountid")]
        public Guid? ChildIncidentCountId { get; set; }

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

