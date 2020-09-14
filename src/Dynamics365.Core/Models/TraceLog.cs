using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TraceLog : DynamicsModel
    {
        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("levelname")]
        public string LevelName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

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

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("tracecode")]
        public long? TraceCode { get; set; }

        [JsonProperty("tracelogid")]
        public Guid? TraceLogId { get; set; }

        [JsonProperty("traceregardingid")]
        public string TraceRegardingId { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("traceparameterxml")]
        public string TraceParameterXml { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("isunique")]
        public bool? IsUnique { get; set; }

        [JsonProperty("parenttracelogid")]
        public string ParentTraceLogId { get; set; }

        [JsonProperty("traceparameterhash")]
        public long? TraceParameterHash { get; set; }

        [JsonProperty("collationlevel")]
        public long? CollationLevel { get; set; }

        [JsonProperty("isuniquename")]
        public string IsUniqueName { get; set; }

        [JsonProperty("tracedetailxml")]
        public string TraceDetailXml { get; set; }

        [JsonProperty("canbedeleted")]
        public bool? CanBeDeleted { get; set; }

        [JsonProperty("canbedeletedname")]
        public string CanBeDeletedName { get; set; }

        [JsonProperty("traceactionxml")]
        public string TraceActionXml { get; set; }

        [JsonProperty("machinename")]
        public string MachineName { get; set; }

        [JsonProperty("errortypedisplay")]
        public string ErrorTypeDisplay { get; set; }

        [JsonProperty("tracestatus")]
        public bool? TraceStatus { get; set; }

        [JsonProperty("tracestatusname")]
        public string TraceStatusName { get; set; }

        [JsonProperty("errordetails")]
        public string ErrorDetails { get; set; }


    }
}

