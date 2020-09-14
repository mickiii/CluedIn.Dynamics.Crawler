using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Incident : DynamicsModel
    {
        [JsonProperty("incidentid")]
        public Guid? IncidentId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("contractdetailid")]
        public string ContractDetailId { get; set; }

        [JsonProperty("subjectid")]
        public string SubjectId { get; set; }

        [JsonProperty("contractid")]
        public string ContractId { get; set; }

        [JsonProperty("slaid")]
        public string SLAId { get; set; }

        [JsonProperty("slaname")]
        public string SLAName { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("actualserviceunits")]
        public long? ActualServiceUnits { get; set; }

        [JsonProperty("caseorigincode")]
        public string CaseOriginCode { get; set; }

        [JsonProperty("billedserviceunits")]
        public long? BilledServiceUnits { get; set; }

        [JsonProperty("casetypecode")]
        public string CaseTypeCode { get; set; }

        [JsonProperty("productserialnumber")]
        public string ProductSerialNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("productid")]
        public string ProductId { get; set; }

        [JsonProperty("contractservicelevelcode")]
        public string ContractServiceLevelCode { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("contactid")]
        public string ContactId { get; set; }

        [JsonProperty("isdecrementing")]
        public bool? IsDecrementing { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("ticketnumber")]
        public string TicketNumber { get; set; }

        [JsonProperty("prioritycode")]
        public string PriorityCode { get; set; }

        [JsonProperty("customersatisfactioncode")]
        public string CustomerSatisfactionCode { get; set; }

        [JsonProperty("incidentstagecode")]
        public string IncidentStageCode { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("followupby")]
        public DateTimeOffset? FollowupBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("severitycode")]
        public string SeverityCode { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("responsiblecontactid")]
        public string ResponsibleContactId { get; set; }

        [JsonProperty("subjectidname")]
        public string SubjectIdName { get; set; }

        [JsonProperty("accountidname")]
        public string AccountIdName { get; set; }

        [JsonProperty("contactidname")]
        public string ContactIdName { get; set; }

        [JsonProperty("responsiblecontactidname")]
        public string ResponsibleContactIdName { get; set; }

        [JsonProperty("contractidname")]
        public string ContractIdName { get; set; }

        [JsonProperty("contractdetailidname")]
        public string ContractDetailIdName { get; set; }

        [JsonProperty("productidname")]
        public string ProductIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("customerid")]
        public string CustomerId { get; set; }

        [JsonProperty("customeridname")]
        public string CustomerIdName { get; set; }

        [JsonProperty("customeridtype")]
        public string CustomerIdType { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("isdecrementingname")]
        public string IsDecrementingName { get; set; }

        [JsonProperty("prioritycodename")]
        public string PriorityCodeName { get; set; }

        [JsonProperty("caseorigincodename")]
        public string CaseOriginCodeName { get; set; }

        [JsonProperty("incidentstagecodename")]
        public string IncidentStageCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("severitycodename")]
        public string SeverityCodeName { get; set; }

        [JsonProperty("casetypecodename")]
        public string CaseTypeCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("customersatisfactioncodename")]
        public string CustomerSatisfactionCodeName { get; set; }

        [JsonProperty("contractservicelevelcodename")]
        public string ContractServiceLevelCodeName { get; set; }

        [JsonProperty("kbarticleid")]
        public string KbArticleId { get; set; }

        [JsonProperty("kbarticleidname")]
        public string KbArticleIdName { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("contactidyominame")]
        public string ContactIdYomiName { get; set; }

        [JsonProperty("accountidyominame")]
        public string AccountIdYomiName { get; set; }

        [JsonProperty("responsiblecontactidyominame")]
        public string ResponsibleContactIdYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("customeridyominame")]
        public string CustomerIdYomiName { get; set; }

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

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("servicestage")]
        public string ServiceStage { get; set; }

        [JsonProperty("servicestagename")]
        public string ServiceStageName { get; set; }

        [JsonProperty("existingcase")]
        public string ExistingCase { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("checkemail")]
        public bool? CheckEmail { get; set; }

        [JsonProperty("activitiescomplete")]
        public bool? ActivitiesComplete { get; set; }

        [JsonProperty("activitiescompletename")]
        public string ActivitiesCompleteName { get; set; }

        [JsonProperty("checkemailname")]
        public string CheckEmailName { get; set; }

        [JsonProperty("followuptaskcreated")]
        public bool? FollowUpTaskCreated { get; set; }

        [JsonProperty("followuptaskcreatedname")]
        public string FollowUpTaskCreatedName { get; set; }

        [JsonProperty("numberofchildincidents")]
        public long? NumberOfChildIncidents { get; set; }

        [JsonProperty("socialprofileid")]
        public string SocialProfileId { get; set; }

        [JsonProperty("slainvokedidname")]
        public string SLAInvokedIdName { get; set; }

        [JsonProperty("slainvokedid")]
        public string SLAInvokedId { get; set; }

        [JsonProperty("messagetypecode")]
        public string MessageTypeCode { get; set; }

        [JsonProperty("blockedprofile")]
        public bool? BlockedProfile { get; set; }

        [JsonProperty("decremententitlementtermname")]
        public string DecrementEntitlementTermName { get; set; }

        [JsonProperty("entitlementid")]
        public string EntitlementId { get; set; }

        [JsonProperty("entitlementidname")]
        public string EntitlementIdName { get; set; }

        [JsonProperty("masterid")]
        public string MasterId { get; set; }

        [JsonProperty("masteridname")]
        public string MasterIdName { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("parentcaseid")]
        public string ParentCaseId { get; set; }

        [JsonProperty("decremententitlementterm")]
        public bool? DecrementEntitlementTerm { get; set; }

        [JsonProperty("parentcaseidname")]
        public string ParentCaseIdName { get; set; }

        [JsonProperty("createdbyexternalparty")]
        public string CreatedByExternalParty { get; set; }

        [JsonProperty("createdbyexternalpartyname")]
        public string CreatedByExternalPartyName { get; set; }

        [JsonProperty("createdbyexternalpartyyominame")]
        public string CreatedByExternalPartyYomiName { get; set; }

        [JsonProperty("modifiedbyexternalparty")]
        public string ModifiedByExternalParty { get; set; }

        [JsonProperty("modifiedbyexternalpartyname")]
        public string ModifiedByExternalPartyName { get; set; }

        [JsonProperty("modifiedbyexternalpartyyominame")]
        public string ModifiedByExternalPartyYomiName { get; set; }

        [JsonProperty("sentimentvalue")]
        public double? SentimentValue { get; set; }

        [JsonProperty("socialprofileidname")]
        public string SocialProfileIdName { get; set; }

        [JsonProperty("influencescore")]
        public double? InfluenceScore { get; set; }

        [JsonProperty("messagetypecodename")]
        public string MessageTypeCodeName { get; set; }

        [JsonProperty("blockedprofilename")]
        public string BlockedProfileName { get; set; }

        [JsonProperty("merged")]
        public bool? Merged { get; set; }

        [JsonProperty("routecase")]
        public bool? RouteCase { get; set; }

        [JsonProperty("resolveby")]
        public DateTimeOffset? ResolveBy { get; set; }

        [JsonProperty("responseby")]
        public DateTimeOffset? ResponseBy { get; set; }

        [JsonProperty("customercontacted")]
        public bool? CustomerContacted { get; set; }

        [JsonProperty("isescalated")]
        public bool? IsEscalated { get; set; }

        [JsonProperty("escalatedon")]
        public DateTimeOffset? EscalatedOn { get; set; }

        [JsonProperty("primarycontactid")]
        public string PrimaryContactId { get; set; }

        [JsonProperty("primarycontactidname")]
        public string PrimaryContactIdName { get; set; }

        [JsonProperty("primarycontactidyominame")]
        public string PrimaryContactIdYomiName { get; set; }

        [JsonProperty("isescalatedname")]
        public string IsEscalatedName { get; set; }

        [JsonProperty("firstresponsesent")]
        public bool? FirstResponseSent { get; set; }

        [JsonProperty("mergedname")]
        public string MergedName { get; set; }

        [JsonProperty("firstresponseslastatus")]
        public string FirstResponseSLAStatus { get; set; }

        [JsonProperty("resolvebyslastatus")]
        public string ResolveBySLAStatus { get; set; }

        [JsonProperty("firstresponseslastatusname")]
        public string FirstResponseSLAStatusName { get; set; }

        [JsonProperty("resolvebyslastatusname")]
        public string ResolveBySLAStatusName { get; set; }

        [JsonProperty("firstresponsesentname")]
        public string FirstResponseSentName { get; set; }

        [JsonProperty("onholdtime")]
        public long? OnHoldTime { get; set; }

        [JsonProperty("lastonholdtime")]
        public DateTimeOffset? LastOnHoldTime { get; set; }

        [JsonProperty("resolvebykpiid")]
        public string ResolveByKPIId { get; set; }

        [JsonProperty("resolvebykpiidname")]
        public string ResolveByKPIIdName { get; set; }

        [JsonProperty("firstresponsebykpiid")]
        public string FirstResponseByKPIId { get; set; }

        [JsonProperty("firstresponsebykpiidname")]
        public string FirstResponseByKPIIdName { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("routecasename")]
        public string routecaseName { get; set; }

        [JsonProperty("customercontactedname")]
        public string customercontactedName { get; set; }


    }
}

