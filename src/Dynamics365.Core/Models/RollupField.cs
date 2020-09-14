using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RollupField : DynamicsModel
    {
        [JsonProperty("rollupfieldid")]
        public Guid? RollupFieldId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("sourceattribute")]
        public string SourceAttribute { get; set; }

        [JsonProperty("dateattribute")]
        public string DateAttribute { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("metricid")]
        public string MetricId { get; set; }

        [JsonProperty("metricidname")]
        public string MetricIdName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("goalattribute")]
        public string GoalAttribute { get; set; }

        [JsonProperty("sourcestate")]
        public long? SourceState { get; set; }

        [JsonProperty("sourcestatus")]
        public long? SourceStatus { get; set; }

        [JsonProperty("sourceentity")]
        public string SourceEntity { get; set; }

        [JsonProperty("sourceentityname")]
        public string SourceEntityName { get; set; }

        [JsonProperty("entityfordateattribute")]
        public string EntityForDateAttribute { get; set; }

        [JsonProperty("entityfordateattributename")]
        public string EntityForDateAttributeName { get; set; }

        [JsonProperty("isstateparententityattribute")]
        public bool? IsStateParentEntityAttribute { get; set; }


    }
}

