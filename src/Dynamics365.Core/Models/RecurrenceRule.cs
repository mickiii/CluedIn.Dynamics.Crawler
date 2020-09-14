using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RecurrenceRule : DynamicsModel
    {
        [JsonProperty("dayofmonth")]
        public long? DayOfMonth { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("ruleid")]
        public Guid? RuleId { get; set; }

        [JsonProperty("isnthmonthly")]
        public bool? IsNthMonthly { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("monthofyearname")]
        public string MonthOfYearName { get; set; }

        [JsonProperty("effectivestartdate")]
        public DateTimeOffset? EffectiveStartDate { get; set; }

        [JsonProperty("recurrencepatterntype")]
        public string RecurrencePatternType { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("monthofyear")]
        public string MonthOfYear { get; set; }

        [JsonProperty("effectiveenddate")]
        public DateTimeOffset? EffectiveEndDate { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("interval")]
        public long? Interval { get; set; }

        [JsonProperty("endtime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("patternendtype")]
        public string PatternEndType { get; set; }

        [JsonProperty("isnthyearly")]
        public bool? IsNthYearly { get; set; }

        [JsonProperty("patternstartdate")]
        public DateTimeOffset? PatternStartDate { get; set; }

        [JsonProperty("instance")]
        public string Instance { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("isweekdaypattern")]
        public bool? IsWeekDayPattern { get; set; }

        [JsonProperty("patternenddate")]
        public DateTimeOffset? PatternEndDate { get; set; }

        [JsonProperty("firstdayofweek")]
        public long? FirstDayOfWeek { get; set; }

        [JsonProperty("isregenerate")]
        public bool? IsRegenerate { get; set; }

        [JsonProperty("objectid")]
        public string ObjectId { get; set; }

        [JsonProperty("daysofweekmask")]
        public long? DaysOfWeekMask { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("occurrences")]
        public long? Occurrences { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("instancename")]
        public string InstanceName { get; set; }

        [JsonProperty("isweekdaypatternname")]
        public string IsWeekDayPatternName { get; set; }

        [JsonProperty("recurrencepatterntypename")]
        public string RecurrencePatternTypeName { get; set; }

        [JsonProperty("patternendtypename")]
        public string PatternEndTypeName { get; set; }

        [JsonProperty("isnthmonthlyname")]
        public string IsNthMonthlyName { get; set; }

        [JsonProperty("isnthyearlyname")]
        public string IsNthYearlyName { get; set; }

        [JsonProperty("isregeneratename")]
        public string IsRegenerateName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }


    }
}

