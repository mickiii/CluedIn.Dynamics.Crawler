using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CustomerAddress : DynamicsModel
    {
        [JsonProperty("parentid")]
        public string ParentId { get; set; }

        [JsonProperty("customeraddressid")]
        public Guid? CustomerAddressId { get; set; }

        [JsonProperty("addressnumber")]
        public long? AddressNumber { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("addresstypecode")]
        public string AddressTypeCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primarycontactname")]
        public string PrimaryContactName { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateorprovince")]
        public string StateOrProvince { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postofficebox")]
        public string PostOfficeBox { get; set; }

        [JsonProperty("postalcode")]
        public string PostalCode { get; set; }

        [JsonProperty("utcoffset")]
        public long? UTCOffset { get; set; }

        [JsonProperty("freighttermscode")]
        public string FreightTermsCode { get; set; }

        [JsonProperty("upszone")]
        public string UPSZone { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("telephone1")]
        public string Telephone1 { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("shippingmethodcode")]
        public string ShippingMethodCode { get; set; }

        [JsonProperty("telephone2")]
        public string Telephone2 { get; set; }

        [JsonProperty("telephone3")]
        public string Telephone3 { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("versionnumber")]
        public long VersionNumber { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("shippingmethodcodename")]
        public string ShippingMethodCodeName { get; set; }

        [JsonProperty("freighttermscodename")]
        public string FreightTermsCodeName { get; set; }

        [JsonProperty("addresstypecodename")]
        public string AddressTypeCodeName { get; set; }

        [JsonProperty("objecttypecodename")]
        public string ObjectTypeCodeName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("parentidtypecode")]
        public string ParentIdTypeCode { get; set; }

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

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("composite")]
        public string Composite { get; set; }


    }
}

