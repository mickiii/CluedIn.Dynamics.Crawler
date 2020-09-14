using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Email : DynamicsModel
    {
        [JsonProperty("scheduledstart")]
        public DateTimeOffset? ScheduledStart { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("submittedby")]
        public string SubmittedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("to")]
        public string to { get; set; }

        [JsonProperty("isworkflowcreated")]
        public bool? IsWorkflowCreated { get; set; }

        [JsonProperty("activityid")]
        public Guid? ActivityId { get; set; }

        [JsonProperty("scheduledend")]
        public DateTimeOffset? ScheduledEnd { get; set; }

        [JsonProperty("mimetype")]
        public string MimeType { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("readreceiptrequested")]
        public bool? ReadReceiptRequested { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("isbilled")]
        public bool? IsBilled { get; set; }

        [JsonProperty("actualdurationminutes")]
        public long? ActualDurationMinutes { get; set; }

        [JsonProperty("prioritycode")]
        public string PriorityCode { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("actualstart")]
        public DateTimeOffset? ActualStart { get; set; }

        [JsonProperty("from")]
        public string from { get; set; }

        [JsonProperty("directioncode")]
        public bool? DirectionCode { get; set; }

        [JsonProperty("actualend")]
        public DateTimeOffset? ActualEnd { get; set; }

        [JsonProperty("trackingtoken")]
        public string TrackingToken { get; set; }

        [JsonProperty("serviceid")]
        public string ServiceId { get; set; }

        [JsonProperty("scheduleddurationminutes")]
        public long? ScheduledDurationMinutes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("bcc")]
        public string bcc { get; set; }

        [JsonProperty("cc")]
        public string cc { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("torecipients")]
        public string ToRecipients { get; set; }

        [JsonProperty("deliveryreceiptrequested")]
        public bool? DeliveryReceiptRequested { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("messageid")]
        public string MessageId { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("deliveryreceiptrequestedname")]
        public string DeliveryReceiptRequestedName { get; set; }

        [JsonProperty("prioritycodename")]
        public string PriorityCodeName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("isworkflowcreatedname")]
        public string IsWorkflowCreatedName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("readreceiptrequestedname")]
        public string ReadReceiptRequestedName { get; set; }

        [JsonProperty("isbilledname")]
        public string IsBilledName { get; set; }

        [JsonProperty("directioncodename")]
        public string DirectionCodeName { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("deliveryattempts")]
        public long? DeliveryAttempts { get; set; }

        [JsonProperty("messageiddupcheck")]
        public Guid? MessageIdDupCheck { get; set; }

        [JsonProperty("compressed")]
        public bool? Compressed { get; set; }

        [JsonProperty("notifications")]
        public string Notifications { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("compressedname")]
        public string CompressedName { get; set; }

        [JsonProperty("notificationsname")]
        public string NotificationsName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

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

        [JsonProperty("emailsender")]
        public string EmailSender { get; set; }

        [JsonProperty("emailsendername")]
        public string EmailSenderName { get; set; }

        [JsonProperty("emailsenderobjecttypecode")]
        public string EmailSenderObjectTypeCode { get; set; }

        [JsonProperty("sendersaccount")]
        public string SendersAccount { get; set; }

        [JsonProperty("sendersaccountobjecttypecode")]
        public string SendersAccountObjectTypeCode { get; set; }

        [JsonProperty("attachmentcount")]
        public long? AttachmentCount { get; set; }

        [JsonProperty("sendermailboxid")]
        public string SenderMailboxId { get; set; }

        [JsonProperty("sendermailboxidname")]
        public string SenderMailboxIdName { get; set; }

        [JsonProperty("deliveryprioritycode")]
        public string DeliveryPriorityCode { get; set; }

        [JsonProperty("deliveryprioritycodename")]
        public string DeliveryPriorityCodeName { get; set; }

        [JsonProperty("parentactivityid")]
        public string ParentActivityId { get; set; }

        [JsonProperty("parentactivityidname")]
        public string ParentActivityIdName { get; set; }

        [JsonProperty("inreplyto")]
        public string InReplyTo { get; set; }

        [JsonProperty("baseconversationindexhash")]
        public long? BaseConversationIndexHash { get; set; }

        [JsonProperty("conversationindex")]
        public string ConversationIndex { get; set; }

        [JsonProperty("correlationmethod")]
        public string CorrelationMethod { get; set; }

        [JsonProperty("senton")]
        public DateTimeOffset? SentOn { get; set; }

        [JsonProperty("postponeemailprocessinguntil")]
        public DateTimeOffset? PostponeEmailProcessingUntil { get; set; }

        [JsonProperty("safedescription")]
        public string SafeDescription { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("activityadditionalparams")]
        public string ActivityAdditionalParams { get; set; }

        [JsonProperty("isunsafe")]
        public long? IsUnsafe { get; set; }

        [JsonProperty("slaid")]
        public string SLAId { get; set; }

        [JsonProperty("slainvokedid")]
        public string SLAInvokedId { get; set; }

        [JsonProperty("onholdtime")]
        public long? OnHoldTime { get; set; }

        [JsonProperty("lastonholdtime")]
        public DateTimeOffset? LastOnHoldTime { get; set; }

        [JsonProperty("sendersaccountname")]
        public string SendersAccountName { get; set; }

        [JsonProperty("sendersaccountyominame")]
        public string SendersAccountYomiName { get; set; }

        [JsonProperty("emailsenderyominame")]
        public string EmailSenderYomiName { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("slaname")]
        public string SLAName { get; set; }

        [JsonProperty("slainvokedidname")]
        public string SLAInvokedIdName { get; set; }

        [JsonProperty("attachmentopencount")]
        public long? AttachmentOpenCount { get; set; }

        [JsonProperty("conversationtrackingid")]
        public Guid? ConversationTrackingId { get; set; }

        [JsonProperty("delayedemailsendtime")]
        public DateTimeOffset? DelayedEmailSendTime { get; set; }

        [JsonProperty("lastopenedtime")]
        public DateTimeOffset? LastOpenedTime { get; set; }

        [JsonProperty("linksclickedcount")]
        public long? LinksClickedCount { get; set; }

        [JsonProperty("opencount")]
        public long? OpenCount { get; set; }

        [JsonProperty("replycount")]
        public long? ReplyCount { get; set; }

        [JsonProperty("emailtrackingid")]
        public Guid? EmailTrackingId { get; set; }

        [JsonProperty("followemailuserpreference")]
        public bool? FollowEmailUserPreference { get; set; }

        [JsonProperty("followemailuserpreferencename")]
        public string FollowEmailUserPreferenceName { get; set; }

        [JsonProperty("isemailfollowed")]
        public bool? IsEmailFollowed { get; set; }

        [JsonProperty("isemailfollowedname")]
        public string IsEmailFollowedName { get; set; }

        [JsonProperty("emailreminderexpirytime")]
        public DateTimeOffset? EmailReminderExpiryTime { get; set; }

        [JsonProperty("emailremindertype")]
        public string EmailReminderType { get; set; }

        [JsonProperty("emailremindertypename")]
        public string EmailReminderTypeName { get; set; }

        [JsonProperty("emailreminderstatus")]
        public string EmailReminderStatus { get; set; }

        [JsonProperty("emailreminderstatusname")]
        public string EmailReminderStatusName { get; set; }

        [JsonProperty("emailremindertext")]
        public string EmailReminderText { get; set; }

        [JsonProperty("templateid")]
        public string TemplateId { get; set; }

        [JsonProperty("reminderactioncardid")]
        public Guid? ReminderActionCardId { get; set; }

        [JsonProperty("templateidname")]
        public string TemplateIdName { get; set; }

        [JsonProperty("sortdate")]
        public DateTimeOffset? SortDate { get; set; }

        [JsonProperty("isemailreminderset")]
        public bool? IsEmailReminderSet { get; set; }

        [JsonProperty("isemailremindersetname")]
        public string IsEmailReminderSetName { get; set; }


    }
}

