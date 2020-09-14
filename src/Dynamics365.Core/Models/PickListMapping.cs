using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class PickListMapping : DynamicsModel
    {
        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("picklistmappingid")]
        public Guid? PickListMappingId { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("targetvalue")]
        public long? TargetValue { get; set; }

        [JsonProperty("processcode")]
        public string ProcessCode { get; set; }

        [JsonProperty("columnmappingid")]
        public string ColumnMappingId { get; set; }

        [JsonProperty("sourcevalue")]
        public string SourceValue { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("columnmappingidname")]
        public string ColumnMappingIdName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("processcodename")]
        public string ProcessCodeName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("picklistmappingidunique")]
        public Guid? PickListMappingIdUnique { get; set; }


    }
}

