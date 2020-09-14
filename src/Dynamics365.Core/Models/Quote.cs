using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Quote : DynamicsModel
    {
        [JsonProperty("quoteid")]
        public Guid? QuoteId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("pricelevelid")]
        public string PriceLevelId { get; set; }

        [JsonProperty("opportunityid")]
        public string OpportunityId { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

        [JsonProperty("contactid")]
        public string ContactId { get; set; }

        [JsonProperty("quotenumber")]
        public string QuoteNumber { get; set; }

        [JsonProperty("revisionnumber")]
        public long? RevisionNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pricingerrorcode")]
        public string PricingErrorCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountamount")]
        public string DiscountAmount { get; set; }

        [JsonProperty("freightamount")]
        public string FreightAmount { get; set; }

        [JsonProperty("totalamount")]
        public string TotalAmount { get; set; }

        [JsonProperty("totallineitemamount")]
        public string TotalLineItemAmount { get; set; }

        [JsonProperty("totallineitemdiscountamount")]
        public string TotalLineItemDiscountAmount { get; set; }

        [JsonProperty("totalamountlessfreight")]
        public string TotalAmountLessFreight { get; set; }

        [JsonProperty("effectivefrom")]
        public DateTimeOffset? EffectiveFrom { get; set; }

        [JsonProperty("totaltax")]
        public string TotalTax { get; set; }

        [JsonProperty("totaldiscountamount")]
        public string TotalDiscountAmount { get; set; }

        [JsonProperty("effectiveto")]
        public DateTimeOffset? EffectiveTo { get; set; }

        [JsonProperty("expireson")]
        public DateTimeOffset? ExpiresOn { get; set; }

        [JsonProperty("closedon")]
        public DateTimeOffset? ClosedOn { get; set; }

        [JsonProperty("requestdeliveryby")]
        public DateTimeOffset? RequestDeliveryBy { get; set; }

        [JsonProperty("shippingmethodcode")]
        public string ShippingMethodCode { get; set; }

        [JsonProperty("paymenttermscode")]
        public string PaymentTermsCode { get; set; }

        [JsonProperty("freighttermscode")]
        public string FreightTermsCode { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("shipto_name")]
        public string ShipTo_Name { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("shipto_line1")]
        public string ShipTo_Line1 { get; set; }

        [JsonProperty("shipto_line2")]
        public string ShipTo_Line2 { get; set; }

        [JsonProperty("shipto_line3")]
        public string ShipTo_Line3 { get; set; }

        [JsonProperty("shipto_city")]
        public string ShipTo_City { get; set; }

        [JsonProperty("shipto_stateorprovince")]
        public string ShipTo_StateOrProvince { get; set; }

        [JsonProperty("shipto_country")]
        public string ShipTo_Country { get; set; }

        [JsonProperty("shipto_postalcode")]
        public string ShipTo_PostalCode { get; set; }

        [JsonProperty("willcall")]
        public bool? WillCall { get; set; }

        [JsonProperty("shipto_telephone")]
        public string ShipTo_Telephone { get; set; }

        [JsonProperty("billto_name")]
        public string BillTo_Name { get; set; }

        [JsonProperty("shipto_freighttermscode")]
        public string ShipTo_FreightTermsCode { get; set; }

        [JsonProperty("shipto_fax")]
        public string ShipTo_Fax { get; set; }

        [JsonProperty("billto_line1")]
        public string BillTo_Line1 { get; set; }

        [JsonProperty("billto_line2")]
        public string BillTo_Line2 { get; set; }

        [JsonProperty("billto_line3")]
        public string BillTo_Line3 { get; set; }

        [JsonProperty("billto_city")]
        public string BillTo_City { get; set; }

        [JsonProperty("billto_stateorprovince")]
        public string BillTo_StateOrProvince { get; set; }

        [JsonProperty("billto_country")]
        public string BillTo_Country { get; set; }

        [JsonProperty("billto_postalcode")]
        public string BillTo_PostalCode { get; set; }

        [JsonProperty("billto_telephone")]
        public string BillTo_Telephone { get; set; }

        [JsonProperty("billto_fax")]
        public string BillTo_Fax { get; set; }

        [JsonProperty("discountpercentage")]
        public decimal? DiscountPercentage { get; set; }

        [JsonProperty("contactidname")]
        public string ContactIdName { get; set; }

        [JsonProperty("accountidname")]
        public string AccountIdName { get; set; }

        [JsonProperty("opportunityidname")]
        public string OpportunityIdName { get; set; }

        [JsonProperty("pricelevelidname")]
        public string PriceLevelIdName { get; set; }

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

        [JsonProperty("willcallname")]
        public string WillCallName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("pricingerrorcodename")]
        public string PricingErrorCodeName { get; set; }

        [JsonProperty("paymenttermscodename")]
        public string PaymentTermsCodeName { get; set; }

        [JsonProperty("shippingmethodcodename")]
        public string ShippingMethodCodeName { get; set; }

        [JsonProperty("shipto_freighttermscodename")]
        public string ShipTo_FreightTermsCodeName { get; set; }

        [JsonProperty("freighttermscodename")]
        public string FreightTermsCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("campaignid")]
        public string CampaignId { get; set; }

        [JsonProperty("shipto_addressid")]
        public Guid? ShipTo_AddressId { get; set; }

        [JsonProperty("shipto_contactname")]
        public string ShipTo_ContactName { get; set; }

        [JsonProperty("billto_addressid")]
        public Guid? BillTo_AddressId { get; set; }

        [JsonProperty("billto_contactname")]
        public string BillTo_ContactName { get; set; }

        [JsonProperty("campaignidname")]
        public string CampaignIdName { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("uniquedscid")]
        public Guid? UniqueDscId { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("totallineitemdiscountamount_base")]
        public string TotalLineItemDiscountAmount_Base { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("totalamountlessfreight_base")]
        public string TotalAmountLessFreight_Base { get; set; }

        [JsonProperty("discountamount_base")]
        public string DiscountAmount_Base { get; set; }

        [JsonProperty("freightamount_base")]
        public string FreightAmount_Base { get; set; }

        [JsonProperty("totalamount_base")]
        public string TotalAmount_Base { get; set; }

        [JsonProperty("totaldiscountamount_base")]
        public string TotalDiscountAmount_Base { get; set; }

        [JsonProperty("totaltax_base")]
        public string TotalTax_Base { get; set; }

        [JsonProperty("totallineitemamount_base")]
        public string TotalLineItemAmount_Base { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("accountidyominame")]
        public string AccountIdYomiName { get; set; }

        [JsonProperty("contactidyominame")]
        public string ContactIdYomiName { get; set; }

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

        [JsonProperty("billto_composite")]
        public string BillTo_Composite { get; set; }

        [JsonProperty("shipto_composite")]
        public string ShipTo_Composite { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("onholdtime")]
        public long? OnHoldTime { get; set; }

        [JsonProperty("lastonholdtime")]
        public DateTimeOffset? LastOnHoldTime { get; set; }

        [JsonProperty("slaid")]
        public string SLAId { get; set; }

        [JsonProperty("slaname")]
        public string SLAName { get; set; }

        [JsonProperty("slainvokedid")]
        public string SLAInvokedId { get; set; }

        [JsonProperty("slainvokedidname")]
        public string SLAInvokedIdName { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("skippricecalculation")]
        public string SkipPriceCalculation { get; set; }

        [JsonProperty("skippricecalculationname")]
        public string skippricecalculationName { get; set; }


    }
}

