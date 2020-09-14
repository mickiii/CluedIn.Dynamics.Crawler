using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class QuoteDetail : DynamicsModel
    {
        [JsonProperty("quotedetailid")]
        public Guid? QuoteDetailId { get; set; }

        [JsonProperty("quoteid")]
        public string QuoteId { get; set; }

        [JsonProperty("salesrepid")]
        public string SalesRepId { get; set; }

        [JsonProperty("lineitemnumber")]
        public long? LineItemNumber { get; set; }

        [JsonProperty("uomid")]
        public string UoMId { get; set; }

        [JsonProperty("productid")]
        public string ProductId { get; set; }

        [JsonProperty("requestdeliveryby")]
        public DateTimeOffset? RequestDeliveryBy { get; set; }

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        [JsonProperty("pricingerrorcode")]
        public string PricingErrorCode { get; set; }

        [JsonProperty("manualdiscountamount")]
        public string ManualDiscountAmount { get; set; }

        [JsonProperty("productdescription")]
        public string ProductDescription { get; set; }

        [JsonProperty("volumediscountamount")]
        public string VolumeDiscountAmount { get; set; }

        [JsonProperty("priceperunit")]
        public string PricePerUnit { get; set; }

        [JsonProperty("baseamount")]
        public string BaseAmount { get; set; }

        [JsonProperty("extendedamount")]
        public string ExtendedAmount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("shipto_name")]
        public string ShipTo_Name { get; set; }

        [JsonProperty("ispriceoverridden")]
        public bool? IsPriceOverridden { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }

        [JsonProperty("shipto_line1")]
        public string ShipTo_Line1 { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("shipto_line2")]
        public string ShipTo_Line2 { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("shipto_line3")]
        public string ShipTo_Line3 { get; set; }

        [JsonProperty("shipto_city")]
        public string ShipTo_City { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("shipto_stateorprovince")]
        public string ShipTo_StateOrProvince { get; set; }

        [JsonProperty("shipto_country")]
        public string ShipTo_Country { get; set; }

        [JsonProperty("shipto_postalcode")]
        public string ShipTo_PostalCode { get; set; }

        [JsonProperty("willcall")]
        public bool? WillCall { get; set; }

        [JsonProperty("isproductoverridden")]
        public bool? IsProductOverridden { get; set; }

        [JsonProperty("shipto_telephone")]
        public string ShipTo_Telephone { get; set; }

        [JsonProperty("shipto_fax")]
        public string ShipTo_Fax { get; set; }

        [JsonProperty("shipto_freighttermscode")]
        public string ShipTo_FreightTermsCode { get; set; }

        [JsonProperty("productidname")]
        public string ProductIdName { get; set; }

        [JsonProperty("uomidname")]
        public string UoMIdName { get; set; }

        [JsonProperty("salesrepidname")]
        public string SalesRepIdName { get; set; }

        [JsonProperty("quotestatecode")]
        public string QuoteStateCode { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("isproductoverriddenname")]
        public string IsProductOverriddenName { get; set; }

        [JsonProperty("willcallname")]
        public string WillCallName { get; set; }

        [JsonProperty("ispriceoverriddenname")]
        public string IsPriceOverriddenName { get; set; }

        [JsonProperty("shipto_freighttermscodename")]
        public string ShipTo_FreightTermsCodeName { get; set; }

        [JsonProperty("quotestatecodename")]
        public string QuoteStateCodeName { get; set; }

        [JsonProperty("pricingerrorcodename")]
        public string PricingErrorCodeName { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("shipto_addressid")]
        public Guid? ShipTo_AddressId { get; set; }

        [JsonProperty("shipto_contactname")]
        public string ShipTo_ContactName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("tax_base")]
        public string Tax_Base { get; set; }

        [JsonProperty("extendedamount_base")]
        public string ExtendedAmount_Base { get; set; }

        [JsonProperty("priceperunit_base")]
        public string PricePerUnit_Base { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("baseamount_base")]
        public string BaseAmount_Base { get; set; }

        [JsonProperty("manualdiscountamount_base")]
        public string ManualDiscountAmount_Base { get; set; }

        [JsonProperty("volumediscountamount_base")]
        public string VolumeDiscountAmount_Base { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("salesrepidyominame")]
        public string SalesRepIdYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

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

        [JsonProperty("sequencenumber")]
        public long? SequenceNumber { get; set; }

        [JsonProperty("propertyconfigurationstatus")]
        public string PropertyConfigurationStatus { get; set; }

        [JsonProperty("propertyconfigurationstatusname")]
        public string PropertyConfigurationStatusName { get; set; }

        [JsonProperty("productassociationid")]
        public Guid? ProductAssociationId { get; set; }

        [JsonProperty("parentbundleid")]
        public Guid? ParentBundleId { get; set; }

        [JsonProperty("producttypecode")]
        public string ProductTypeCode { get; set; }

        [JsonProperty("producttypecodename")]
        public string ProductTypeCodeName { get; set; }

        [JsonProperty("quoteidname")]
        public string QuoteIdName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("productname")]
        public string ProductName { get; set; }

        [JsonProperty("quotedetailname")]
        public string QuoteDetailName { get; set; }

        [JsonProperty("parentbundleidref")]
        public string ParentBundleIdRef { get; set; }

        [JsonProperty("skippricecalculation")]
        public string SkipPriceCalculation { get; set; }

        [JsonProperty("skippricecalculationname")]
        public string skippricecalculationName { get; set; }


    }
}

