using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class BusinessUnit : DynamicsModel
    {
        [JsonProperty("businessunitid")]
        public Guid? BusinessUnitId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("usergroupid")]
        public Guid? UserGroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("divisionname")]
        public string DivisionName { get; set; }

        [JsonProperty("fileasname")]
        public string FileAsName { get; set; }

        [JsonProperty("tickersymbol")]
        public string TickerSymbol { get; set; }

        [JsonProperty("stockexchange")]
        public string StockExchange { get; set; }

        [JsonProperty("utcoffset")]
        public long? UTCOffset { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("creditlimit")]
        public double? CreditLimit { get; set; }

        [JsonProperty("costcenter")]
        public string CostCenter { get; set; }

        [JsonProperty("websiteurl")]
        public string WebSiteUrl { get; set; }

        [JsonProperty("ftpsiteurl")]
        public string FtpSiteUrl { get; set; }

        [JsonProperty("emailaddress")]
        public string EMailAddress { get; set; }

        [JsonProperty("inheritancemask")]
        public long? InheritanceMask { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("workflowsuspended")]
        public bool? WorkflowSuspended { get; set; }

        [JsonProperty("parentbusinessunitid")]
        public string ParentBusinessUnitId { get; set; }

        [JsonProperty("isdisabled")]
        public bool? IsDisabled { get; set; }

        [JsonProperty("disabledreason")]
        public string DisabledReason { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("parentbusinessunitidname")]
        public string ParentBusinessUnitIdName { get; set; }

        [JsonProperty("address1_addressid")]
        public Guid? Address1_AddressId { get; set; }

        [JsonProperty("address1_addresstypecode")]
        public string Address1_AddressTypeCode { get; set; }

        [JsonProperty("address1_name")]
        public string Address1_Name { get; set; }

        [JsonProperty("address1_line1")]
        public string Address1_Line1 { get; set; }

        [JsonProperty("address1_line2")]
        public string Address1_Line2 { get; set; }

        [JsonProperty("address1_line3")]
        public string Address1_Line3 { get; set; }

        [JsonProperty("address1_city")]
        public string Address1_City { get; set; }

        [JsonProperty("address1_stateorprovince")]
        public string Address1_StateOrProvince { get; set; }

        [JsonProperty("address1_county")]
        public string Address1_County { get; set; }

        [JsonProperty("address1_country")]
        public string Address1_Country { get; set; }

        [JsonProperty("address1_postofficebox")]
        public string Address1_PostOfficeBox { get; set; }

        [JsonProperty("address1_postalcode")]
        public string Address1_PostalCode { get; set; }

        [JsonProperty("address1_utcoffset")]
        public long? Address1_UTCOffset { get; set; }

        [JsonProperty("address1_upszone")]
        public string Address1_UPSZone { get; set; }

        [JsonProperty("address1_latitude")]
        public double? Address1_Latitude { get; set; }

        [JsonProperty("address1_telephone1")]
        public string Address1_Telephone1 { get; set; }

        [JsonProperty("address1_longitude")]
        public double? Address1_Longitude { get; set; }

        [JsonProperty("address1_shippingmethodcode")]
        public string Address1_ShippingMethodCode { get; set; }

        [JsonProperty("address1_telephone2")]
        public string Address1_Telephone2 { get; set; }

        [JsonProperty("address1_telephone3")]
        public string Address1_Telephone3 { get; set; }

        [JsonProperty("address1_fax")]
        public string Address1_Fax { get; set; }

        [JsonProperty("address2_addressid")]
        public Guid? Address2_AddressId { get; set; }

        [JsonProperty("address2_addresstypecode")]
        public string Address2_AddressTypeCode { get; set; }

        [JsonProperty("address2_name")]
        public string Address2_Name { get; set; }

        [JsonProperty("address2_line1")]
        public string Address2_Line1 { get; set; }

        [JsonProperty("address2_line2")]
        public string Address2_Line2 { get; set; }

        [JsonProperty("address2_line3")]
        public string Address2_Line3 { get; set; }

        [JsonProperty("address2_city")]
        public string Address2_City { get; set; }

        [JsonProperty("address2_stateorprovince")]
        public string Address2_StateOrProvince { get; set; }

        [JsonProperty("address2_county")]
        public string Address2_County { get; set; }

        [JsonProperty("address2_country")]
        public string Address2_Country { get; set; }

        [JsonProperty("address2_postofficebox")]
        public string Address2_PostOfficeBox { get; set; }

        [JsonProperty("address2_postalcode")]
        public string Address2_PostalCode { get; set; }

        [JsonProperty("address2_utcoffset")]
        public long? Address2_UTCOffset { get; set; }

        [JsonProperty("address2_upszone")]
        public string Address2_UPSZone { get; set; }

        [JsonProperty("address2_latitude")]
        public double? Address2_Latitude { get; set; }

        [JsonProperty("address2_telephone1")]
        public string Address2_Telephone1 { get; set; }

        [JsonProperty("address2_longitude")]
        public double? Address2_Longitude { get; set; }

        [JsonProperty("address2_shippingmethodcode")]
        public string Address2_ShippingMethodCode { get; set; }

        [JsonProperty("address2_telephone2")]
        public string Address2_Telephone2 { get; set; }

        [JsonProperty("address2_telephone3")]
        public string Address2_Telephone3 { get; set; }

        [JsonProperty("address2_fax")]
        public string Address2_Fax { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("isdisabledname")]
        public string IsDisabledName { get; set; }

        [JsonProperty("workflowsuspendedname")]
        public string WorkflowSuspendedName { get; set; }

        [JsonProperty("address2_addresstypecodename")]
        public string Address2_AddressTypeCodeName { get; set; }

        [JsonProperty("address2_shippingmethodcodename")]
        public string Address2_ShippingMethodCodeName { get; set; }

        [JsonProperty("address1_shippingmethodcodename")]
        public string Address1_ShippingMethodCodeName { get; set; }

        [JsonProperty("address1_addresstypecodename")]
        public string Address1_AddressTypeCodeName { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("calendarid")]
        public string CalendarId { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

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

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }


    }
}

