using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SubscriptionSyncEntryOutlook : DynamicsModel
    {
        [JsonProperty("subscriptionid")]
        public Guid? SubscriptionId { get; set; }

        [JsonProperty("objectid")]
        public Guid? ObjectId { get; set; }

        [JsonProperty("objecttypecode")]
        public long? ObjectTypeCode { get; set; }

        [JsonProperty("syncstate")]
        public long? SyncState { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }


    }
}

