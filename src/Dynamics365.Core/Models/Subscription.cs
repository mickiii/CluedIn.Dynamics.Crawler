using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Subscription : DynamicsModel
    {
        [JsonProperty("subscriptionid")]
        public Guid? SubscriptionId { get; set; }

        [JsonProperty("systemuserid")]
        public Guid? SystemUserId { get; set; }

        [JsonProperty("machinename")]
        public string MachineName { get; set; }

        [JsonProperty("lastsyncstartedon")]
        public DateTimeOffset? LastSyncStartedOn { get; set; }

        [JsonProperty("syncentrytablename")]
        public string SyncEntryTableName { get; set; }

        [JsonProperty("subscriptiontype")]
        public long? SubscriptionType { get; set; }

        [JsonProperty("completedsyncstartedon")]
        public DateTimeOffset? CompletedSyncStartedOn { get; set; }

        [JsonProperty("reinitialize")]
        public bool? ReInitialize { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("completedsyncversionnumber")]
        public int? CompletedSyncVersionNumber { get; set; }

        [JsonProperty("clientversion")]
        public string ClientVersion { get; set; }

        [JsonProperty("resetforcreate")]
        public bool? ResetForCreate { get; set; }


    }
}

