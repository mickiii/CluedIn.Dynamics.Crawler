using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class OpportunityProduct : DynamicsModel
    {
        [JsonProperty("productid")]
        public string ProductId { get; set; }

        [JsonProperty("opportunityproductid")]
        public Guid? OpportunityProductId { get; set; }

        [JsonProperty("pricingerrorcode")]
        public string PricingErrorCode { get; set; }

        [JsonProperty("isproductoverridden")]
        public bool? IsProductOverridden { get; set; }

        [JsonProperty("ispriceoverridden")]
        public bool? IsPriceOverridden { get; set; }

        [JsonProperty("priceperunit")]
        public string PricePerUnit { get; set; }

        [JsonProperty("opportunityid")]
        public string OpportunityId { get; set; }

        [JsonProperty("baseamount")]
        public string BaseAmount { get; set; }

        [JsonProperty("extendedamount")]
        public string ExtendedAmount { get; set; }

        [JsonProperty("uomid")]
        public string UoMId { get; set; }

        [JsonProperty("manualdiscountamount")]
        public string ManualDiscountAmount { get; set; }

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("volumediscountamount")]
        public string VolumeDiscountAmount { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("productdescription")]
        public string ProductDescription { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("productidname")]
        public string ProductIdName { get; set; }

        [JsonProperty("uomidname")]
        public string UoMIdName { get; set; }

        [JsonProperty("opportunityidname")]
        public string OpportunityIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("ispriceoverriddenname")]
        public string IsPriceOverriddenName { get; set; }

        [JsonProperty("isproductoverriddenname")]
        public string IsProductOverriddenName { get; set; }

        [JsonProperty("pricingerrorcodename")]
        public string PricingErrorCodeName { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("opportunitystatecode")]
        public string OpportunityStateCode { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("opportunitystatecodename")]
        public string OpportunityStateCodeName { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("baseamount_base")]
        public string BaseAmount_Base { get; set; }

        [JsonProperty("manualdiscountamount_base")]
        public string ManualDiscountAmount_Base { get; set; }

        [JsonProperty("volumediscountamount_base")]
        public string VolumeDiscountAmount_Base { get; set; }

        [JsonProperty("priceperunit_base")]
        public string PricePerUnit_Base { get; set; }

        [JsonProperty("tax_base")]
        public string Tax_Base { get; set; }

        [JsonProperty("extendedamount_base")]
        public string ExtendedAmount_Base { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("lineitemnumber")]
        public long? LineItemNumber { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

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

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("parentbundleid")]
        public Guid? ParentBundleId { get; set; }

        [JsonProperty("producttypecode")]
        public string ProductTypeCode { get; set; }

        [JsonProperty("producttypecodename")]
        public string ProductTypeCodeName { get; set; }

        [JsonProperty("propertyconfigurationstatus")]
        public string PropertyConfigurationStatus { get; set; }

        [JsonProperty("propertyconfigurationstatusname")]
        public string PropertyConfigurationStatusName { get; set; }

        [JsonProperty("productassociationid")]
        public Guid? ProductAssociationId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("productname")]
        public string ProductName { get; set; }

        [JsonProperty("opportunityproductname")]
        public string OpportunityProductName { get; set; }

        [JsonProperty("parentbundleidref")]
        public string ParentBundleIdRef { get; set; }

        [JsonProperty("skippricecalculation")]
        public string SkipPriceCalculation { get; set; }

        [JsonProperty("skippricecalculationname")]
        public string skippricecalculationName { get; set; }


    }
}
