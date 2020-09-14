using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TopicHistory : DynamicsModel
    {
        [JsonProperty("topicmodelexecutionhistoryid")]
        public string TopicModelExecutionHistoryId { get; set; }

        [JsonProperty("topicmodelexecutionhistoryidname")]
        public string TopicModelExecutionHistoryIdName { get; set; }

        [JsonProperty("topichistoryid")]
        public Guid? TopicHistoryId { get; set; }

        [JsonProperty("keyphrase")]
        public string KeyPhrase { get; set; }

        [JsonProperty("weight")]
        public long? Weight { get; set; }

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

