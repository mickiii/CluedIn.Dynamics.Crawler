using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SubscriptionSyncInfo : DynamicsModel
    {
        [JsonProperty("endtime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("subscriptionsyncinfoid")]
        public long? SubscriptionSyncInfoId { get; set; }

        [JsonProperty("deleteobjectcount")]
        public long? DeleteObjectCount { get; set; }

        [JsonProperty("subscriptionid")]
        public string SubscriptionId { get; set; }

        [JsonProperty("syncresult")]
        public bool? SyncResult { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("datasize")]
        public long? DataSize { get; set; }

        [JsonProperty("insertobjectcount")]
        public long? InsertObjectCount { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("clientversion")]
        public string ClientVersion { get; set; }


    }
}

