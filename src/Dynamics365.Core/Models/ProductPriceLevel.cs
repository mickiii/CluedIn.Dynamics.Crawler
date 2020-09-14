using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ProductPriceLevel : DynamicsModel
    {
        [JsonProperty("pricelevelid")]
        public string PriceLevelId { get; set; }

        [JsonProperty("productpricelevelid")]
        public Guid? ProductPriceLevelId { get; set; }

        [JsonProperty("uomid")]
        public string UoMId { get; set; }

        [JsonProperty("uomscheduleid")]
        public string UoMScheduleId { get; set; }

        [JsonProperty("discounttypeid")]
        public string DiscountTypeId { get; set; }

        [JsonProperty("productid")]
        public string ProductId { get; set; }

        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("quantitysellingcode")]
        public string QuantitySellingCode { get; set; }

        [JsonProperty("roundingpolicycode")]
        public string RoundingPolicyCode { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("pricingmethodcode")]
        public string PricingMethodCode { get; set; }

        [JsonProperty("roundingoptioncode")]
        public string RoundingOptionCode { get; set; }

        [JsonProperty("roundingoptionamount")]
        public string RoundingOptionAmount { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("discounttypeidname")]
        public string DiscountTypeIdName { get; set; }

        [JsonProperty("productidname")]
        public string ProductIdName { get; set; }

        [JsonProperty("pricelevelidname")]
        public string PriceLevelIdName { get; set; }

        [JsonProperty("uomidname")]
        public string UoMIdName { get; set; }

        [JsonProperty("uomscheduleidname")]
        public string UoMScheduleIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("roundingpolicycodename")]
        public string RoundingPolicyCodeName { get; set; }

        [JsonProperty("quantitysellingcodename")]
        public string QuantitySellingCodeName { get; set; }

        [JsonProperty("pricingmethodcodename")]
        public string PricingMethodCodeName { get; set; }

        [JsonProperty("roundingoptioncodename")]
        public string RoundingOptionCodeName { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("amount_base")]
        public string Amount_Base { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("roundingoptionamount_base")]
        public string RoundingOptionAmount_Base { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

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

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("productnumber")]
        public string ProductNumber { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }


    }
}

