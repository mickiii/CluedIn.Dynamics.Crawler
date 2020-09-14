using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Contract : DynamicsModel
    {
        [JsonProperty("contractid")]
        public Guid? ContractId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("contracttemplateid")]
        public string ContractTemplateId { get; set; }

        [JsonProperty("contractservicelevelcode")]
        public string ContractServiceLevelCode { get; set; }

        [JsonProperty("serviceaddress")]
        public string ServiceAddress { get; set; }

        [JsonProperty("billtoaddress")]
        public string BillToAddress { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("contactid")]
        public string ContactId { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

        [JsonProperty("billingaccountid")]
        public string BillingAccountId { get; set; }

        [JsonProperty("contractnumber")]
        public string ContractNumber { get; set; }

        [JsonProperty("billingcontactid")]
        public string BillingContactId { get; set; }

        [JsonProperty("activeon")]
        public DateTimeOffset? ActiveOn { get; set; }

        [JsonProperty("expireson")]
        public DateTimeOffset? ExpiresOn { get; set; }

        [JsonProperty("cancelon")]
        public DateTimeOffset? CancelOn { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("contractlanguage")]
        public string ContractLanguage { get; set; }

        [JsonProperty("billingstarton")]
        public DateTimeOffset? BillingStartOn { get; set; }

        [JsonProperty("effectivitycalendar")]
        public string EffectivityCalendar { get; set; }

        [JsonProperty("billingendon")]
        public DateTimeOffset? BillingEndOn { get; set; }

        [JsonProperty("billingfrequencycode")]
        public string BillingFrequencyCode { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("allotmenttypecode")]
        public string AllotmentTypeCode { get; set; }

        [JsonProperty("usediscountaspercentage")]
        public bool? UseDiscountAsPercentage { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("totalprice")]
        public string TotalPrice { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("totaldiscount")]
        public string TotalDiscount { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("netprice")]
        public string NetPrice { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("originatingcontract")]
        public string OriginatingContract { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("contactidname")]
        public string ContactIdName { get; set; }

        [JsonProperty("accountidname")]
        public string AccountIdName { get; set; }

        [JsonProperty("billingcontactidname")]
        public string BillingContactIdName { get; set; }

        [JsonProperty("billingaccountidname")]
        public string BillingAccountIdName { get; set; }

        [JsonProperty("contracttemplateidname")]
        public string ContractTemplateIdName { get; set; }

        [JsonProperty("originatingcontractname")]
        public string OriginatingContractName { get; set; }

        [JsonProperty("billtoaddressname")]
        public string BillToAddressName { get; set; }

        [JsonProperty("serviceaddressname")]
        public string ServiceAddressName { get; set; }

        [JsonProperty("contracttemplateabbreviation")]
        public string ContractTemplateAbbreviation { get; set; }

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

        [JsonProperty("billingcustomerid")]
        public string BillingCustomerId { get; set; }

        [JsonProperty("billingcustomeridname")]
        public string BillingCustomerIdName { get; set; }

        [JsonProperty("billingcustomeridtype")]
        public string BillingCustomerIdType { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("usediscountaspercentagename")]
        public string UseDiscountAsPercentageName { get; set; }

        [JsonProperty("billingfrequencycodename")]
        public string BillingFrequencyCodeName { get; set; }

        [JsonProperty("contractservicelevelcodename")]
        public string ContractServiceLevelCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("allotmenttypecodename")]
        public string AllotmentTypeCodeName { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("totaldiscount_base")]
        public string TotalDiscount_Base { get; set; }

        [JsonProperty("netprice_base")]
        public string NetPrice_Base { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("totalprice_base")]
        public string TotalPrice_Base { get; set; }

        [JsonProperty("billingcontactidyominame")]
        public string BillingContactIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("billingaccountidyominame")]
        public string BillingAccountIdYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("billingcustomeridyominame")]
        public string BillingCustomerIdYomiName { get; set; }

        [JsonProperty("contactidyominame")]
        public string ContactIdYomiName { get; set; }

        [JsonProperty("accountidyominame")]
        public string AccountIdYomiName { get; set; }

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

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }


    }
}

