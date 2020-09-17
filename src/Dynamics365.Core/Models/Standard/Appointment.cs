using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Appointment : DynamicsModel
    {
        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("isalldayevent")]
        public bool? IsAllDayEvent { get; set; }

        [JsonProperty("actualend")]
        public DateTimeOffset? ActualEnd { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("serviceid")]
        public string ServiceId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("isworkflowcreated")]
        public bool? IsWorkflowCreated { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isbilled")]
        public bool? IsBilled { get; set; }

        [JsonProperty("scheduleddurationminutes")]
        public long? ScheduledDurationMinutes { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("optionalattendees")]
        public string OptionalAttendees { get; set; }

        [JsonProperty("globalobjectid")]
        public string GlobalObjectId { get; set; }

        [JsonProperty("scheduledstart")]
        public DateTimeOffset? ScheduledStart { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("outlookownerapptid")]
        public long? OutlookOwnerApptId { get; set; }

        [JsonProperty("scheduledend")]
        public DateTimeOffset? ScheduledEnd { get; set; }

        [JsonProperty("actualdurationminutes")]
        public long? ActualDurationMinutes { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("actualstart")]
        public DateTimeOffset? ActualStart { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("subscriptionid")]
        public Guid? SubscriptionId { get; set; }

        [JsonProperty("versionnumber")]
        public long VersionNumber { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("activityid")]
        public Guid? ActivityId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("prioritycode")]
        public string PriorityCode { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("requiredattendees")]
        public string requiredattendees { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("isbilledname")]
        public string IsBilledName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("isalldayeventname")]
        public string IsAllDayEventName { get; set; }

        [JsonProperty("prioritycodename")]
        public string PriorityCodeName { get; set; }

        [JsonProperty("isworkflowcreatedname")]
        public string IsWorkflowCreatedName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("instancetypecode")]
        public string InstanceTypeCode { get; set; }

        [JsonProperty("modifiedfieldsmask")]
        public string ModifiedFieldsMask { get; set; }

        [JsonProperty("seriesid")]
        public Guid? SeriesId { get; set; }

        [JsonProperty("originalstartdate")]
        public DateTimeOffset? OriginalStartDate { get; set; }

        [JsonProperty("instancetypecodename")]
        public string InstanceTypeCodeName { get; set; }

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

        [JsonProperty("activitytypecode")]
        public string ActivityTypeCode { get; set; }

        [JsonProperty("activitytypecodename")]
        public string ActivityTypeCodeName { get; set; }

        [JsonProperty("isregularactivity")]
        public bool? IsRegularActivity { get; set; }

        [JsonProperty("isregularactivityname")]
        public string IsRegularActivityName { get; set; }

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

        [JsonProperty("attachmenterrors")]
        public string AttachmentErrors { get; set; }

        [JsonProperty("attachmenterrorsname")]
        public string AttachmentErrorsName { get; set; }

        [JsonProperty("attachmentcount")]
        public long? AttachmentCount { get; set; }

        [JsonProperty("activityadditionalparams")]
        public string ActivityAdditionalParams { get; set; }

        [JsonProperty("slaname")]
        public string SLAName { get; set; }

        [JsonProperty("slaid")]
        public string SLAId { get; set; }

        [JsonProperty("slainvokedid")]
        public string SLAInvokedId { get; set; }

        [JsonProperty("onholdtime")]
        public long? OnHoldTime { get; set; }

        [JsonProperty("lastonholdtime")]
        public DateTimeOffset? LastOnHoldTime { get; set; }

        [JsonProperty("slainvokedidname")]
        public string SLAInvokedIdName { get; set; }

        [JsonProperty("sortdate")]
        public DateTimeOffset? SortDate { get; set; }

        [JsonProperty("safedescription")]
        public string SafeDescription { get; set; }

        [JsonProperty("isunsafe")]
        public long? IsUnsafe { get; set; }

        [JsonProperty("isdraft")]
        public bool? IsDraft { get; set; }

        [JsonProperty("isdraftname")]
        public string IsDraftName { get; set; }


    }
}

