using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Calendar : DynamicsModel
    {
        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("calendarid")]
        public Guid? CalendarId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("businessunitid")]
        public string BusinessUnitId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("primaryuserid")]
        public Guid? PrimaryUserId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("isshared")]
        public bool? IsShared { get; set; }

        [JsonProperty("businessunitidname")]
        public string BusinessUnitIdName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

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

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typename")]
        public string TypeName { get; set; }

        [JsonProperty("holidayschedulecalendarid")]
        public string HolidayScheduleCalendarId { get; set; }

        [JsonProperty("holidayschedulecalendaridname")]
        public string HolidayScheduleCalendarIdName { get; set; }


    }
}

