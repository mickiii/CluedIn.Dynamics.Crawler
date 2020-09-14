using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TimeZoneRule : DynamicsModel
    {
        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("standardday")]
        public long? StandardDay { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("standardminute")]
        public long? StandardMinute { get; set; }

        [JsonProperty("standardbias")]
        public long? StandardBias { get; set; }

        [JsonProperty("standardyear")]
        public long? StandardYear { get; set; }

        [JsonProperty("daylightmonth")]
        public long? DaylightMonth { get; set; }

        [JsonProperty("standarddayofweek")]
        public long? StandardDayOfWeek { get; set; }

        [JsonProperty("daylightsecond")]
        public long? DaylightSecond { get; set; }

        [JsonProperty("bias")]
        public long? Bias { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("daylightbias")]
        public long? DaylightBias { get; set; }

        [JsonProperty("standardmonth")]
        public long? StandardMonth { get; set; }

        [JsonProperty("effectivedatetime")]
        public DateTimeOffset? EffectiveDateTime { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("daylighthour")]
        public long? DaylightHour { get; set; }

        [JsonProperty("standardhour")]
        public long? StandardHour { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("daylightyear")]
        public long? DaylightYear { get; set; }

        [JsonProperty("standardsecond")]
        public long? StandardSecond { get; set; }

        [JsonProperty("daylightminute")]
        public long? DaylightMinute { get; set; }

        [JsonProperty("timezonedefinitionid")]
        public string TimeZoneDefinitionId { get; set; }

        [JsonProperty("daylightdayofweek")]
        public long? DaylightDayOfWeek { get; set; }

        [JsonProperty("timezoneruleid")]
        public Guid? TimeZoneRuleId { get; set; }

        [JsonProperty("daylightday")]
        public long? DaylightDay { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }


    }
}

