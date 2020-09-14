using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Commitment : DynamicsModel
    {
        [JsonProperty("participationtypemask")]
        public long? ParticipationTypeMask { get; set; }

        [JsonProperty("resourcespecid")]
        public Guid? ResourceSpecId { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("activitytypecode")]
        public string ActivityTypeCode { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("scheduledstart")]
        public DateTimeOffset? ScheduledStart { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("partyid")]
        public Guid? PartyId { get; set; }

        [JsonProperty("serviceid")]
        public string ServiceId { get; set; }

        [JsonProperty("scheduledend")]
        public DateTimeOffset? ScheduledEnd { get; set; }

        [JsonProperty("effort")]
        public double? Effort { get; set; }

        [JsonProperty("commitmentid")]
        public Guid? CommitmentId { get; set; }

        [JsonProperty("activityid")]
        public Guid? ActivityId { get; set; }

        [JsonProperty("partyobjecttypecode")]
        public string PartyObjectTypeCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

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
        public string Name { get; set; }


    }
}

