using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TraceAssociation : DynamicsModel
    {
        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("traceassociationid")]
        public Guid? TraceAssociationId { get; set; }

        [JsonProperty("tracelogid")]
        public string TraceLogId { get; set; }

        [JsonProperty("tracelogidname")]
        public string TraceLogIdName { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }


    }
}

