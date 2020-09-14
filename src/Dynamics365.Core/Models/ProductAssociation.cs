using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ProductAssociation : DynamicsModel
    {
        [JsonProperty("associatedproduct")]
        public string AssociatedProduct { get; set; }

        [JsonProperty("productid")]
        public string ProductId { get; set; }

        [JsonProperty("productassociationid")]
        public Guid? ProductAssociationId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("associatedproductidname")]
        public string AssociatedProductIdName { get; set; }

        [JsonProperty("productidname")]
        public string ProductIdName { get; set; }

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        [JsonProperty("productisrequired")]
        public string ProductIsRequired { get; set; }

        [JsonProperty("productisrequiredname")]
        public string ProductIsRequiredName { get; set; }

        [JsonProperty("uomid")]
        public string UoMId { get; set; }

        [JsonProperty("uomidname")]
        public string UoMIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("statecode")]
        public string statecode { get; set; }

        [JsonProperty("statecodename")]
        public string statecodeName { get; set; }

        [JsonProperty("statuscode")]
        public string statuscode { get; set; }

        [JsonProperty("statuscodename")]
        public string statuscodeName { get; set; }

        [JsonProperty("propertycustomizationstatus")]
        public string PropertyCustomizationStatus { get; set; }

        [JsonProperty("propertycustomizationstatusname")]
        public string PropertyCustomizationStatusName { get; set; }

        [JsonProperty("dmtimportstate")]
        public long? DMTImportState { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }


    }
}

