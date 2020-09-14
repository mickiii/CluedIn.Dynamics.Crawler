using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Publisher : DynamicsModel
    {
        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("address1_telephone3")]
        public string Address1_Telephone3 { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("address2_country")]
        public string Address2_Country { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("address1_telephone2")]
        public string Address1_Telephone2 { get; set; }

        [JsonProperty("address2_addresstypecode")]
        public string Address2_AddressTypeCode { get; set; }

        [JsonProperty("address1_addresstypecode")]
        public string Address1_AddressTypeCode { get; set; }

        [JsonProperty("address1_line3")]
        public string Address1_Line3 { get; set; }

        [JsonProperty("address2_name")]
        public string Address2_Name { get; set; }

        [JsonProperty("address1_addressid")]
        public Guid? Address1_AddressId { get; set; }

        [JsonProperty("address2_addressid")]
        public Guid? Address2_AddressId { get; set; }

        [JsonProperty("address1_latitude")]
        public double? Address1_Latitude { get; set; }

        [JsonProperty("address2_county")]
        public string Address2_County { get; set; }

        [JsonProperty("address1_country")]
        public string Address1_Country { get; set; }

        [JsonProperty("address2_city")]
        public string Address2_City { get; set; }

        [JsonProperty("emailaddress")]
        public string EMailAddress { get; set; }

        [JsonProperty("address1_shippingmethodcode")]
        public string Address1_ShippingMethodCode { get; set; }

        [JsonProperty("address2_longitude")]
        public double? Address2_Longitude { get; set; }

        [JsonProperty("address2_line2")]
        public string Address2_Line2 { get; set; }

        [JsonProperty("address1_utcoffset")]
        public long? Address1_UTCOffset { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("address1_county")]
        public string Address1_County { get; set; }

        [JsonProperty("address1_fax")]
        public string Address1_Fax { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("address2_utcoffset")]
        public long? Address2_UTCOffset { get; set; }

        [JsonProperty("address1_name")]
        public string Address1_Name { get; set; }

        [JsonProperty("address1_upszone")]
        public string Address1_UPSZone { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("address1_postofficebox")]
        public string Address1_PostOfficeBox { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("customizationprefix")]
        public string CustomizationPrefix { get; set; }

        [JsonProperty("address2_stateorprovince")]
        public string Address2_StateOrProvince { get; set; }

        [JsonProperty("address2_shippingmethodcode")]
        public string Address2_ShippingMethodCode { get; set; }

        [JsonProperty("address2_telephone2")]
        public string Address2_Telephone2 { get; set; }

        [JsonProperty("address2_upszone")]
        public string Address2_UPSZone { get; set; }

        [JsonProperty("address1_telephone1")]
        public string Address1_Telephone1 { get; set; }

        [JsonProperty("supportingwebsiteurl")]
        public string SupportingWebsiteUrl { get; set; }

        [JsonProperty("address1_longitude")]
        public double? Address1_Longitude { get; set; }

        [JsonProperty("address2_postofficebox")]
        public string Address2_PostOfficeBox { get; set; }

        [JsonProperty("address2_latitude")]
        public double? Address2_Latitude { get; set; }

        [JsonProperty("address2_line3")]
        public string Address2_Line3 { get; set; }

        [JsonProperty("address2_telephone1")]
        public string Address2_Telephone1 { get; set; }

        [JsonProperty("publisherid")]
        public Guid? PublisherId { get; set; }

        [JsonProperty("address2_line1")]
        public string Address2_Line1 { get; set; }

        [JsonProperty("address1_line2")]
        public string Address1_Line2 { get; set; }

        [JsonProperty("address2_postalcode")]
        public string Address2_PostalCode { get; set; }

        [JsonProperty("address1_postalcode")]
        public string Address1_PostalCode { get; set; }

        [JsonProperty("address1_stateorprovince")]
        public string Address1_StateOrProvince { get; set; }

        [JsonProperty("address1_line1")]
        public string Address1_Line1 { get; set; }

        [JsonProperty("address2_fax")]
        public string Address2_Fax { get; set; }

        [JsonProperty("address1_city")]
        public string Address1_City { get; set; }

        [JsonProperty("address2_telephone3")]
        public string Address2_Telephone3 { get; set; }

        [JsonProperty("address1_shippingmethodcodename")]
        public string Address1_ShippingMethodCodeName { get; set; }

        [JsonProperty("address2_addresstypecodename")]
        public string Address2_AddressTypeCodeName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("address2_shippingmethodcodename")]
        public string Address2_ShippingMethodCodeName { get; set; }

        [JsonProperty("address1_addresstypecodename")]
        public string Address1_AddressTypeCodeName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("friendlyname")]
        public string FriendlyName { get; set; }

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

        [JsonProperty("customizationoptionvalueprefix")]
        public long? CustomizationOptionValuePrefix { get; set; }

        [JsonProperty("pinpointpublisherid")]
        public int? PinpointPublisherId { get; set; }

        [JsonProperty("pinpointpublisherdefaultlocale")]
        public string PinpointPublisherDefaultLocale { get; set; }

        [JsonProperty("isreadonly")]
        public bool? IsReadonly { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }


    }
}

