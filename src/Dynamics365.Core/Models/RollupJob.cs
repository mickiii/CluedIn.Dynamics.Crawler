using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RollupJob : DynamicsModel
    {
        [JsonProperty("rollupjobid")]
        public int? RollupJobId { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("rolluppropertiesid")]
        public string RollupPropertiesId { get; set; }

        [JsonProperty("postponeuntil")]
        public DateTimeOffset? PostponeUntil { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("retrycount")]
        public long? RetryCount { get; set; }

        [JsonProperty("sourceentitytypecode")]
        public long? SourceEntityTypeCode { get; set; }

        [JsonProperty("recordcreatedon")]
        public DateTimeOffset? RecordCreatedOn { get; set; }

        [JsonProperty("depthprocessed")]
        public long? DepthProcessed { get; set; }


    }
}

