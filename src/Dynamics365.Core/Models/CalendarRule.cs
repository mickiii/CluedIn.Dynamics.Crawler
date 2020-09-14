using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CalendarRule : DynamicsModel
    {
        [JsonProperty("isvaried")]
        public bool? IsVaried { get; set; }

        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("calendarruleid")]
        public Guid? CalendarRuleId { get; set; }

        [JsonProperty("effort")]
        public double? Effort { get; set; }

        [JsonProperty("endtime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("timecode")]
        public long? TimeCode { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("businessunitid")]
        public Guid? BusinessUnitId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("offset")]
        public long? Offset { get; set; }

        [JsonProperty("issimple")]
        public bool? IsSimple { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("timezonecode")]
        public long? TimeZoneCode { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("isselected")]
        public bool? IsSelected { get; set; }

        [JsonProperty("extentcode")]
        public long? ExtentCode { get; set; }

        [JsonProperty("effectiveintervalend")]
        public DateTimeOffset? EffectiveIntervalEnd { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("calendarid")]
        public string CalendarId { get; set; }

        [JsonProperty("innercalendarid")]
        public string InnerCalendarId { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("groupdesignator")]
        public string GroupDesignator { get; set; }

        [JsonProperty("ismodified")]
        public bool? IsModified { get; set; }

        [JsonProperty("subcode")]
        public long? SubCode { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("effectiveintervalstart")]
        public DateTimeOffset? EffectiveIntervalStart { get; set; }

        [JsonProperty("serviceid")]
        public string ServiceId { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("issimplename")]
        public string IsSimpleName { get; set; }

        [JsonProperty("isselectedname")]
        public string IsSelectedName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("ismodifiedname")]
        public string IsModifiedName { get; set; }

        [JsonProperty("isvariedname")]
        public string IsVariedName { get; set; }

        [JsonProperty("serviceidname")]
        public string ServiceIdName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

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


    }
}

