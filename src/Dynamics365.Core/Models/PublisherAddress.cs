using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class PublisherAddress : DynamicsModel
    {
        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("telephone3")]
        public string Telephone3 { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("telephone1")]
        public string Telephone1 { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shippingmethodcode")]
        public string ShippingMethodCode { get; set; }

        [JsonProperty("publisheraddressid")]
        public Guid? PublisherAddressId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("primarycontactname")]
        public string PrimaryContactName { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("utcoffset")]
        public long? UTCOffset { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("postofficebox")]
        public string PostOfficeBox { get; set; }

        [JsonProperty("upszone")]
        public string UPSZone { get; set; }

        [JsonProperty("telephone2")]
        public string Telephone2 { get; set; }

        [JsonProperty("freighttermscode")]
        public string FreightTermsCode { get; set; }

        [JsonProperty("parentid")]
        public string ParentId { get; set; }

        [JsonProperty("postalcode")]
        public string PostalCode { get; set; }

        [JsonProperty("addressnumber")]
        public long? AddressNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("stateorprovince")]
        public string StateOrProvince { get; set; }

        [JsonProperty("addresstypecode")]
        public string AddressTypeCode { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("shippingmethodcodename")]
        public string ShippingMethodCodeName { get; set; }

        [JsonProperty("freighttermscodename")]
        public string FreightTermsCodeName { get; set; }

        [JsonProperty("addresstypecodename")]
        public string AddressTypeCodeName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("parentidtypecode")]
        public string ParentIdTypeCode { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }


    }
}

