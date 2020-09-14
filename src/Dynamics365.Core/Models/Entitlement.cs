using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Entitlement : DynamicsModel
    {
        [JsonProperty("entitlementid")]
        public Guid? EntitlementId { get; set; }

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

        [JsonProperty("allocationtypecode")]
        public string AllocationTypeCode { get; set; }

        [JsonProperty("allocationtypecodename")]
        public string AllocationTypeCodeName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("remainingterms")]
        public decimal? RemainingTerms { get; set; }

        [JsonProperty("restrictcasecreation")]
        public bool? RestrictCaseCreation { get; set; }

        [JsonProperty("restrictcasecreationname")]
        public string RestrictCaseCreationName { get; set; }

        [JsonProperty("totalterms")]
        public decimal? TotalTerms { get; set; }

        [JsonProperty("startdate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("enddate")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("customerid")]
        public string CustomerId { get; set; }

        [JsonProperty("customeridname")]
        public string CustomerIdName { get; set; }

        [JsonProperty("customeridyominame")]
        public string CustomerIdYomiName { get; set; }

        [JsonProperty("slaid")]
        public string SLAId { get; set; }

        [JsonProperty("slaidname")]
        public string SLAIdName { get; set; }

        [JsonProperty("kbaccesslevel")]
        public string KbAccessLevel { get; set; }

        [JsonProperty("kbaccesslevelname")]
        public string KbAccessLevelName { get; set; }

        [JsonProperty("entitlementtemplateid")]
        public string EntitlementTemplateId { get; set; }

        [JsonProperty("entitlementtemplateidname")]
        public string EntitlementTemplateIdName { get; set; }

        [JsonProperty("customeridtype")]
        public string CustomerIdType { get; set; }

        [JsonProperty("decreaseremainingon")]
        public string DecreaseRemainingOn { get; set; }

        [JsonProperty("decreaseremainingonname")]
        public string DecreaseRemainingOnName { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("isdefault")]
        public bool? IsDefault { get; set; }

        [JsonProperty("isdefaultname")]
        public string IsDefaultName { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

        [JsonProperty("accountidname")]
        public string AccountIdName { get; set; }

        [JsonProperty("accountidyominame")]
        public string AccountIdYomiName { get; set; }

        [JsonProperty("contactid")]
        public string ContactId { get; set; }

        [JsonProperty("contactidname")]
        public string ContactIdName { get; set; }

        [JsonProperty("contactidyominame")]
        public string ContactIdYomiName { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("entitytype")]
        public string entitytype { get; set; }

        [JsonProperty("entitytypename")]
        public string entitytypeName { get; set; }


    }
}

