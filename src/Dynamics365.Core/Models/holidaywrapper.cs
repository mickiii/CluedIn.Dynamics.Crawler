using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class holidaywrapper : DynamicsModel
    {
        [JsonProperty("holidaywrapperid")]
        public Guid? holidaywrapperId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("calendarid")]
        public string CalendarId { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("endtime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("selectedyear")]
        public long? SelectedYear { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }


    }
}

