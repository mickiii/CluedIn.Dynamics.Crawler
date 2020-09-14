using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SubscriptionStatisticsOffline : DynamicsModel
    {
        [JsonProperty("subscriptionid")]
        public Guid? SubscriptionId { get; set; }

        [JsonProperty("objecttypecode")]
        public long? ObjectTypeCode { get; set; }

        [JsonProperty("fullsyncrequired")]
        public bool? FullSyncRequired { get; set; }


    }
}

