using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ContractDetail : DynamicsModel
    {
        [JsonProperty("contractdetailid")]
        public Guid? ContractDetailId { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

        [JsonProperty("serviceaddress")]
        public string ServiceAddress { get; set; }

        [JsonProperty("uomid")]
        public string UoMId { get; set; }

        [JsonProperty("productid")]
        public string ProductId { get; set; }

        [JsonProperty("productserialnumber")]
        public string ProductSerialNumber { get; set; }

        [JsonProperty("contactid")]
        public string ContactId { get; set; }

        [JsonProperty("contractid")]
        public string ContractId { get; set; }

        [JsonProperty("lineitemorder")]
        public long? LineItemOrder { get; set; }

        [JsonProperty("servicecontractunitscode")]
        public string ServiceContractUnitsCode { get; set; }

        [JsonProperty("initialquantity")]
        public long? InitialQuantity { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("effectivitycalendar")]
        public string EffectivityCalendar { get; set; }

        [JsonProperty("activeon")]
        public DateTimeOffset? ActiveOn { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("expireson")]
        public DateTimeOffset? ExpiresOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("totalallotments")]
        public long? TotalAllotments { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("rate")]
        public string Rate { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("net")]
        public string Net { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("allotmentsremaining")]
        public long? AllotmentsRemaining { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("allotmentsused")]
        public long? AllotmentsUsed { get; set; }

        [JsonProperty("uomscheduleid")]
        public string UoMScheduleId { get; set; }

        [JsonProperty("contractidname")]
        public string ContractIdName { get; set; }

        [JsonProperty("serviceaddressname")]
        public string ServiceAddressName { get; set; }

        [JsonProperty("productidname")]
        public string ProductIdName { get; set; }

        [JsonProperty("uomidname")]
        public string UoMIdName { get; set; }

        [JsonProperty("uomscheduleidname")]
        public string UoMScheduleIdName { get; set; }

        [JsonProperty("contractstatecode")]
        public string ContractStateCode { get; set; }

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

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("contractstatecodename")]
        public string ContractStateCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("servicecontractunitscodename")]
        public string ServiceContractUnitsCodeName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("discountpercentage")]
        public decimal? DiscountPercentage { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("discount_base")]
        public string Discount_Base { get; set; }

        [JsonProperty("rate_base")]
        public string Rate_Base { get; set; }

        [JsonProperty("price_base")]
        public string Price_Base { get; set; }

        [JsonProperty("net_base")]
        public string Net_Base { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("customeridyominame")]
        public string CustomerIdYomiName { get; set; }

        [JsonProperty("allotmentsoverage")]
        public long? AllotmentsOverage { get; set; }

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

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }


    }
}

