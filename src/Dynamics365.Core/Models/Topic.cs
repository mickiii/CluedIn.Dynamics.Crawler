using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Topic : DynamicsModel
    {
        [JsonProperty("topicid")]
        public Guid? TopicId { get; set; }

        [JsonProperty("incidentid")]
        public string IncidentId { get; set; }

        [JsonProperty("incidentidname")]
        public string IncidentIdName { get; set; }

        [JsonProperty("keyphrase")]
        public string KeyPhrase { get; set; }

        [JsonProperty("score")]
        public long? Score { get; set; }

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

