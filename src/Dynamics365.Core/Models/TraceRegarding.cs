using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TraceRegarding : DynamicsModel
    {
        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("regardingobjectownerid")]
        public string RegardingObjectOwnerId { get; set; }

        [JsonProperty("regardingobjectowneridtype")]
        public string RegardingObjectOwnerIdType { get; set; }

        [JsonProperty("regardingobjectowningbusinessunit")]
        public string RegardingObjectOwningBusinessUnit { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("regardingobjecttypecodeforsharing")]
        public string RegardingObjectTypeCodeForSharing { get; set; }

        [JsonProperty("traceregardingid")]
        public Guid? TraceRegardingId { get; set; }


    }
}

