using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SubscriptionTrackingDeletedObject : DynamicsModel
    {
        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("objectid")]
        public Guid? ObjectId { get; set; }

        [JsonProperty("timestamp")]
        public int? TimeStamp { get; set; }

        [JsonProperty("islogicaldelete")]
        public bool? IsLogicalDelete { get; set; }

        [JsonProperty("deletetime")]
        public DateTimeOffset? DeleteTime { get; set; }

        [JsonProperty("crmcreatedon")]
        public DateTimeOffset? CrmCreatedOn { get; set; }


    }
}

