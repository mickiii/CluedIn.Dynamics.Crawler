using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Mailbox : DynamicsModel
    {
        [JsonProperty("mailboxid")]
        public Guid? MailboxId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("exchangesyncstatexml")]
        public string ExchangeSyncStateXml { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("incomingemaildeliverymethod")]
        public string IncomingEmailDeliveryMethod { get; set; }

        [JsonProperty("incomingemaildeliverymethodname")]
        public string IncomingEmailDeliveryMethodName { get; set; }

        [JsonProperty("outgoingemaildeliverymethod")]
        public string OutgoingEmailDeliveryMethod { get; set; }

        [JsonProperty("outgoingemaildeliverymethodname")]
        public string OutgoingEmailDeliveryMethodName { get; set; }

        [JsonProperty("processanddeleteemails")]
        public bool? ProcessAndDeleteEmails { get; set; }

        [JsonProperty("processanddeleteemailsname")]
        public string ProcessAndDeleteEmailsName { get; set; }

        [JsonProperty("allowemailconnectortousecredentials")]
        public bool? AllowEmailConnectorToUseCredentials { get; set; }

        [JsonProperty("allowemailconnectortousecredentialsname")]
        public string AllowEmailConnectorToUseCredentialsName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("emailserverprofile")]
        public string EmailServerProfile { get; set; }

        [JsonProperty("emailserverprofilename")]
        public string EmailServerProfileName { get; set; }

        [JsonProperty("isforwardmailbox")]
        public bool? IsForwardMailbox { get; set; }

        [JsonProperty("isforwardmailboxname")]
        public string IsForwardMailboxName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("owningbusinessunitname")]
        public string OwningBusinessUnitName { get; set; }

        [JsonProperty("emailrouteraccessapproval")]
        public string EmailRouterAccessApproval { get; set; }

        [JsonProperty("emailrouteraccessapprovalname")]
        public string EmailRouterAccessApprovalName { get; set; }

        [JsonProperty("hostid")]
        public string HostId { get; set; }

        [JsonProperty("noemailcount")]
        public long? NoEmailCount { get; set; }

        [JsonProperty("processemailreceivedafter")]
        public DateTimeOffset? ProcessEmailReceivedAfter { get; set; }

        [JsonProperty("receivingpostponeduntil")]
        public DateTimeOffset? ReceivingPostponedUntil { get; set; }

        [JsonProperty("lastmessageid")]
        public string LastMessageId { get; set; }

        [JsonProperty("outgoingemailstatus")]
        public string OutgoingEmailStatus { get; set; }

        [JsonProperty("outgoingemailstatusname")]
        public string OutgoingEmailStatusName { get; set; }

        [JsonProperty("incomingemailstatus")]
        public string IncomingEmailStatus { get; set; }

        [JsonProperty("incomingemailstatusname")]
        public string IncomingEmailStatusName { get; set; }

        [JsonProperty("testmailboxaccesscompletedon")]
        public DateTimeOffset? TestMailboxAccessCompletedOn { get; set; }

        [JsonProperty("testemailconfigurationscheduled")]
        public bool? TestEmailConfigurationScheduled { get; set; }

        [JsonProperty("enabledforincomingemail")]
        public bool? EnabledForIncomingEmail { get; set; }

        [JsonProperty("transientfailurecount")]
        public long? TransientFailureCount { get; set; }

        [JsonProperty("actdeliverymethod")]
        public string ACTDeliveryMethod { get; set; }

        [JsonProperty("actdeliverymethodname")]
        public string ACTDeliveryMethodName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("testemailconfigurationscheduledname")]
        public string TestEmailConfigurationScheduledName { get; set; }

        [JsonProperty("postponetestemailconfigurationuntil")]
        public DateTimeOffset? PostponeTestEmailConfigurationUntil { get; set; }

        [JsonProperty("testemailconfigurationretrycount")]
        public long? TestEmailConfigurationRetryCount { get; set; }

        [JsonProperty("postponesendinguntil")]
        public DateTimeOffset? PostponeSendingUntil { get; set; }

        [JsonProperty("lastactiveon")]
        public DateTimeOffset? LastActiveOn { get; set; }

        [JsonProperty("undeliverablefolder")]
        public string UndeliverableFolder { get; set; }

        [JsonProperty("ispasswordset")]
        public bool? IsPasswordSet { get; set; }

        [JsonProperty("enabledforincomingemailname")]
        public string EnabledForIncomingEmailName { get; set; }

        [JsonProperty("enabledforoutgoingemail")]
        public bool? EnabledForOutgoingEmail { get; set; }

        [JsonProperty("enabledforoutgoingemailname")]
        public string EnabledForOutgoingEmailName { get; set; }

        [JsonProperty("processingstatecode")]
        public long? ProcessingStateCode { get; set; }

        [JsonProperty("lastautodiscoveredon")]
        public DateTimeOffset? LastAutoDiscoveredOn { get; set; }

        [JsonProperty("postponemailboxprocessinguntil")]
        public DateTimeOffset? PostponeMailboxProcessingUntil { get; set; }

        [JsonProperty("ewsurl")]
        public string EWSURL { get; set; }

        [JsonProperty("mailboxprocessingcontext")]
        public long? MailboxProcessingContext { get; set; }

        [JsonProperty("enabledforact")]
        public bool? EnabledForACT { get; set; }

        [JsonProperty("enabledforactname")]
        public string EnabledForACTName { get; set; }

        [JsonProperty("receivingpostponeduntilforact")]
        public DateTimeOffset? ReceivingPostponedUntilForACT { get; set; }

        [JsonProperty("noactcount")]
        public long? NoACTCount { get; set; }

        [JsonProperty("actstatus")]
        public string ACTStatus { get; set; }

        [JsonProperty("actstatusname")]
        public string ACTStatusName { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("isemailaddressapprovedbyo365admin")]
        public bool? IsEmailAddressApprovedByO365Admin { get; set; }

        [JsonProperty("isactsyncorgflagset")]
        public bool? IsACTSyncOrgFlagSet { get; set; }

        [JsonProperty("processedtimes")]
        public long? ProcessedTimes { get; set; }

        [JsonProperty("lastduration")]
        public long? LastDuration { get; set; }

        [JsonProperty("orgmarkedasprimaryforexchangesync")]
        public bool? OrgMarkedAsPrimaryForExchangeSync { get; set; }

        [JsonProperty("averagetotalduration")]
        public long? AverageTotalDuration { get; set; }

        [JsonProperty("lastsyncerrorcode")]
        public long? LastSyncErrorCode { get; set; }

        [JsonProperty("lastsyncerror")]
        public string LastSyncError { get; set; }

        [JsonProperty("lastsyncerrorcount")]
        public long? LastSyncErrorCount { get; set; }

        [JsonProperty("lastsyncerroroccurredon")]
        public DateTimeOffset? LastSyncErrorOccurredOn { get; set; }

        [JsonProperty("lastsyncerrormachinename")]
        public string LastSyncErrorMachineName { get; set; }

        [JsonProperty("itemsprocessedforlastsync")]
        public long? ItemsProcessedForLastSync { get; set; }

        [JsonProperty("itemsfailedforlastsync")]
        public long? ItemsFailedForLastSync { get; set; }

        [JsonProperty("lastsyncstartedon")]
        public DateTimeOffset? LastSyncStartedOn { get; set; }

        [JsonProperty("lastsuccessfulsynccompletedon")]
        public DateTimeOffset? LastSuccessfulSyncCompletedOn { get; set; }

        [JsonProperty("folderhierarchy")]
        public string FolderHierarchy { get; set; }

        [JsonProperty("processinglastattemptedon")]
        public DateTimeOffset? ProcessingLastAttemptedOn { get; set; }

        [JsonProperty("forcedunlockcount")]
        public long? ForcedUnlockCount { get; set; }

        [JsonProperty("lastmailboxforcedunlockoccurredon")]
        public DateTimeOffset? LastMailboxForcedUnlockOccurredOn { get; set; }

        [JsonProperty("isserviceaccount")]
        public bool? IsServiceAccount { get; set; }

        [JsonProperty("verboseloggingenabled")]
        public long? VerboseLoggingEnabled { get; set; }

        [JsonProperty("officeappsdeploymentscheduled")]
        public bool? OfficeAppsDeploymentScheduled { get; set; }

        [JsonProperty("officeappsdeploymentscheduledname")]
        public string OfficeAppsDeploymentScheduledName { get; set; }

        [JsonProperty("officeappsdeploymentstatus")]
        public string OfficeAppsDeploymentStatus { get; set; }

        [JsonProperty("officeappsdeploymentstatusname")]
        public string OfficeAppsDeploymentStatusName { get; set; }

        [JsonProperty("officeappsdeploymentcompleteon")]
        public DateTimeOffset? OfficeAppsDeploymentCompleteOn { get; set; }

        [JsonProperty("officeappsdeploymenterror")]
        public string OfficeAppsDeploymentError { get; set; }

        [JsonProperty("postponeofficeappsdeploymentuntil")]
        public DateTimeOffset? PostponeOfficeAppsDeploymentUntil { get; set; }

        [JsonProperty("mailboxstatus")]
        public string MailboxStatus { get; set; }

        [JsonProperty("mailboxstatusname")]
        public string MailboxStatusName { get; set; }

        [JsonProperty("isexchangecontactsimportscheduled")]
        public bool? IsExchangeContactsImportScheduled { get; set; }

        [JsonProperty("exchangecontactsimportstatus")]
        public string ExchangeContactsImportStatus { get; set; }

        [JsonProperty("exchangecontactsimportcompletedon")]
        public DateTimeOffset? ExchangeContactsImportCompletedOn { get; set; }


    }
}

