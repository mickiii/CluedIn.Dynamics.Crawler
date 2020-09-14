using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RecurringAppointmentMaster : DynamicsModel
    {
        [JsonProperty("isweekdaypattern")]
        public bool? IsWeekDayPattern { get; set; }

        [JsonProperty("ruleid")]
        public string RuleId { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("isnthyearly")]
        public bool? IsNthYearly { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("groupid")]
        public string GroupId { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("optionalattendees")]
        public string OptionalAttendees { get; set; }

        [JsonProperty("subscriptionid")]
        public Guid? SubscriptionId { get; set; }

        [JsonProperty("lastexpandedinstancedate")]
        public DateTimeOffset? LastExpandedInstanceDate { get; set; }

        [JsonProperty("effectiveenddate")]
        public DateTimeOffset? EffectiveEndDate { get; set; }

        [JsonProperty("patternstartdate")]
        public DateTimeOffset? PatternStartDate { get; set; }

        [JsonProperty("isworkflowcreated")]
        public bool? IsWorkflowCreated { get; set; }

        [JsonProperty("instancetypecode")]
        public string InstanceTypeCode { get; set; }

        [JsonProperty("isregenerate")]
        public bool? IsRegenerate { get; set; }

        [JsonProperty("firstdayofweek")]
        public long? FirstDayOfWeek { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("outlookownerapptid")]
        public long? OutlookOwnerApptId { get; set; }

        [JsonProperty("recurrencepatterntype")]
        public string RecurrencePatternType { get; set; }

        [JsonProperty("nextexpansioninstancedate")]
        public DateTimeOffset? NextExpansionInstanceDate { get; set; }

        [JsonProperty("expansionstatecode")]
        public string ExpansionStateCode { get; set; }

        [JsonProperty("prioritycode")]
        public string PriorityCode { get; set; }

        [JsonProperty("isbilled")]
        public bool? IsBilled { get; set; }

        [JsonProperty("patternenddate")]
        public DateTimeOffset? PatternEndDate { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("globalobjectid")]
        public string GlobalObjectId { get; set; }

        [JsonProperty("effectivestartdate")]
        public DateTimeOffset? EffectiveStartDate { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("dayofmonth")]
        public long? DayOfMonth { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("occurrences")]
        public long? Occurrences { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("monthofyearname")]
        public string MonthOfYearName { get; set; }

        [JsonProperty("isalldayevent")]
        public bool? IsAllDayEvent { get; set; }

        [JsonProperty("seriesstatus")]
        public bool? SeriesStatus { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("isnthmonthly")]
        public bool? IsNthMonthly { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("endtime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("serviceid")]
        public string ServiceId { get; set; }

        [JsonProperty("daysofweekmask")]
        public long? DaysOfWeekMask { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("activityid")]
        public Guid? ActivityId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("requiredattendees")]
        public string RequiredAttendees { get; set; }

        [JsonProperty("instance")]
        public string Instance { get; set; }

        [JsonProperty("deletedexceptionslist")]
        public string DeletedExceptionsList { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("interval")]
        public long? Interval { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("monthofyear")]
        public string MonthOfYear { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("isworkflowcreatedname")]
        public string IsWorkflowCreatedName { get; set; }

        [JsonProperty("instancetypecodename")]
        public string InstanceTypeCodeName { get; set; }

        [JsonProperty("isregeneratename")]
        public string IsRegenerateName { get; set; }

        [JsonProperty("prioritycodename")]
        public string PriorityCodeName { get; set; }

        [JsonProperty("seriesstatusname")]
        public string SeriesStatusName { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("isweekdaypatternname")]
        public string IsWeekDayPatternName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("patternendtypename")]
        public string PatternEndTypeName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("instancename")]
        public string InstanceName { get; set; }

        [JsonProperty("expansionstatecodename")]
        public string ExpansionStateCodeName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("isalldayeventname")]
        public string IsAllDayEventName { get; set; }

        [JsonProperty("isbilledname")]
        public string IsBilledName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("isnthmonthlyname")]
        public string IsNthMonthlyName { get; set; }

        [JsonProperty("recurrencepatterntypename")]
        public string RecurrencePatternTypeName { get; set; }

        [JsonProperty("isnthyearlyname")]
        public string IsNthYearlyName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("scheduledstart")]
        public DateTimeOffset? ScheduledStart { get; set; }

        [JsonProperty("scheduledend")]
        public DateTimeOffset? ScheduledEnd { get; set; }

        [JsonProperty("activitytypecode")]
        public string ActivityTypeCode { get; set; }

        [JsonProperty("activitytypecodename")]
        public string ActivityTypeCodeName { get; set; }

        [JsonProperty("isregularactivity")]
        public bool? IsRegularActivity { get; set; }

        [JsonProperty("isregularactivityname")]
        public string IsRegularActivityName { get; set; }

        [JsonProperty("patternendtype")]
        public string PatternEndType { get; set; }

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

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("ismapiprivate")]
        public bool? IsMapiPrivate { get; set; }

        [JsonProperty("ismapiprivatename")]
        public string IsMapiPrivateName { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("sortdate")]
        public DateTimeOffset? SortDate { get; set; }

        [JsonProperty("safedescription")]
        public string SafeDescription { get; set; }

        [JsonProperty("isunsafe")]
        public long? IsUnsafe { get; set; }


    }
}

