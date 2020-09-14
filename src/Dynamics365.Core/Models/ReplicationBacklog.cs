using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ReplicationBacklog : DynamicsModel
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("replicationbacklogid")]
        public Guid? ReplicationBacklogId { get; set; }

        [JsonProperty("replicationbacklogtype")]
        public string ReplicationBacklogType { get; set; }

        [JsonProperty("replicationbacklogtypename")]
        public string ReplicationBacklogTypeName { get; set; }

        [JsonProperty("targetobjectid")]
        public string TargetObjectId { get; set; }

        [JsonProperty("targetobjectidname")]
        public string TargetObjectIdName { get; set; }

        [JsonProperty("targetobjecttypecode")]
        public string TargetObjectTypeCode { get; set; }

        [JsonProperty("targetdatacenterid")]
        public Guid? TargetDatacenterId { get; set; }


    }
}

