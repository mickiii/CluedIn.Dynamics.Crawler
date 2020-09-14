using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class BusinessProcessFlowInstance : DynamicsModel
    {
        [JsonProperty("businessprocessflowinstanceid")]
        public Guid? BusinessProcessFlowInstanceId { get; set; }

        [JsonProperty("entity1id")]
        public Guid? Entity1Id { get; set; }

        [JsonProperty("entity1objecttypecode")]
        public string Entity1ObjectTypeCode { get; set; }

        [JsonProperty("entity2id")]
        public Guid? Entity2Id { get; set; }

        [JsonProperty("entity2objecttypecode")]
        public string Entity2ObjectTypeCode { get; set; }

        [JsonProperty("entity3id")]
        public Guid? Entity3Id { get; set; }

        [JsonProperty("entity3objecttypecode")]
        public string Entity3ObjectTypeCode { get; set; }

        [JsonProperty("entity4id")]
        public Guid? Entity4Id { get; set; }

        [JsonProperty("entity4objecttypecode")]
        public string Entity4ObjectTypeCode { get; set; }

        [JsonProperty("entity5id")]
        public Guid? Entity5Id { get; set; }

        [JsonProperty("entity5objecttypecode")]
        public string Entity5ObjectTypeCode { get; set; }

        [JsonProperty("processid")]
        public string ProcessId { get; set; }

        [JsonProperty("processstageid")]
        public Guid? ProcessStageId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("activestagestartedon")]
        public DateTimeOffset? ActiveStageStartedOn { get; set; }

        [JsonProperty("completedon")]
        public DateTimeOffset? CompletedOn { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }


    }
}

