using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SystemUser : DynamicsModel
    {
        [JsonProperty("systemuserid")]
        public Guid? SystemUserId { get; set; }

        [JsonProperty("territoryid")]
        public string TerritoryId { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("businessunitid")]
        public string BusinessUnitId { get; set; }

        [JsonProperty("parentsystemuserid")]
        public string ParentSystemUserId { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("middlename")]
        public string MiddleName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("personalemailaddress")]
        public string PersonalEMailAddress { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("internalemailaddress")]
        public string InternalEMailAddress { get; set; }

        [JsonProperty("jobtitle")]
        public string JobTitle { get; set; }

        [JsonProperty("mobilealertemail")]
        public string MobileAlertEMail { get; set; }

        [JsonProperty("preferredemailcode")]
        public string PreferredEmailCode { get; set; }

        [JsonProperty("homephone")]
        public string HomePhone { get; set; }

        [JsonProperty("mobilephone")]
        public string MobilePhone { get; set; }

        [JsonProperty("preferredphonecode")]
        public string PreferredPhoneCode { get; set; }

        [JsonProperty("preferredaddresscode")]
        public string PreferredAddressCode { get; set; }

        [JsonProperty("photourl")]
        public string PhotoUrl { get; set; }

        [JsonProperty("domainname")]
        public string DomainName { get; set; }

        [JsonProperty("passportlo")]
        public long? PassportLo { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("passporthi")]
        public long? PassportHi { get; set; }

        [JsonProperty("disabledreason")]
        public string DisabledReason { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("employeeid")]
        public string EmployeeId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("isdisabled")]
        public bool? IsDisabled { get; set; }

        [JsonProperty("governmentid")]
        public string GovernmentId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("parentsystemuseridname")]
        public string ParentSystemUserIdName { get; set; }

        [JsonProperty("territoryidname")]
        public string TerritoryIdName { get; set; }

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

        [JsonProperty("businessunitidname")]
        public string BusinessUnitIdName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("isdisabledname")]
        public string IsDisabledName { get; set; }

        [JsonProperty("preferredphonecodename")]
        public string PreferredPhoneCodeName { get; set; }

        [JsonProperty("preferredemailcodename")]
        public string PreferredEmailCodeName { get; set; }

        [JsonProperty("preferredaddresscodename")]
        public string PreferredAddressCodeName { get; set; }

        [JsonProperty("address2_shippingmethodcodename")]
        public string Address2_ShippingMethodCodeName { get; set; }

        [JsonProperty("address1_addresstypecodename")]
        public string Address1_AddressTypeCodeName { get; set; }

        [JsonProperty("address2_addresstypecodename")]
        public string Address2_AddressTypeCodeName { get; set; }

        [JsonProperty("address1_shippingmethodcodename")]
        public string Address1_ShippingMethodCodeName { get; set; }

        [JsonProperty("skills")]
        public string Skills { get; set; }

        [JsonProperty("displayinserviceviews")]
        public bool? DisplayInServiceViews { get; set; }

        [JsonProperty("calendarid")]
        public string CalendarId { get; set; }

        [JsonProperty("activedirectoryguid")]
        public Guid? ActiveDirectoryGuid { get; set; }

        [JsonProperty("setupuser")]
        public bool? SetupUser { get; set; }

        [JsonProperty("siteid")]
        public string SiteId { get; set; }

        [JsonProperty("siteidname")]
        public string SiteIdName { get; set; }

        [JsonProperty("setupusername")]
        public string SetupUserName { get; set; }

        [JsonProperty("displayinserviceviewsname")]
        public string DisplayInServiceViewsName { get; set; }

        [JsonProperty("windowsliveid")]
        public string WindowsLiveID { get; set; }

        [JsonProperty("incomingemaildeliverymethod")]
        public string IncomingEmailDeliveryMethod { get; set; }

        [JsonProperty("outgoingemaildeliverymethod")]
        public string OutgoingEmailDeliveryMethod { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("accessmode")]
        public string AccessMode { get; set; }

        [JsonProperty("invitestatuscode")]
        public string InviteStatusCode { get; set; }

        [JsonProperty("isactivedirectoryuser")]
        public bool? IsActiveDirectoryUser { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("accessmodename")]
        public string AccessModeName { get; set; }

        [JsonProperty("incomingemaildeliverymethodname")]
        public string IncomingEmailDeliveryMethodName { get; set; }

        [JsonProperty("outgoingemaildeliverymethodname")]
        public string OutgoingEmailDeliveryMethodName { get; set; }

        [JsonProperty("invitestatuscodename")]
        public string InviteStatusCodeName { get; set; }

        [JsonProperty("parentsystemuseridyominame")]
        public string ParentSystemUserIdYomiName { get; set; }

        [JsonProperty("yomifullname")]
        public string YomiFullName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("yomilastname")]
        public string YomiLastName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("yomimiddlename")]
        public string YomiMiddleName { get; set; }

        [JsonProperty("yomifirstname")]
        public string YomiFirstName { get; set; }

        [JsonProperty("isintegrationuser")]
        public bool? IsIntegrationUser { get; set; }

        [JsonProperty("defaultfilterspopulated")]
        public bool? DefaultFiltersPopulated { get; set; }

        [JsonProperty("isintegrationusername")]
        public string IsIntegrationUserName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("queueid")]
        public string QueueId { get; set; }

        [JsonProperty("queueidname")]
        public string QueueIdName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("emailrouteraccessapproval")]
        public string EmailRouterAccessApproval { get; set; }

        [JsonProperty("emailrouteraccessapprovalname")]
        public string EmailRouterAccessApprovalName { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("caltype")]
        public string CALType { get; set; }

        [JsonProperty("caltypename")]
        public string CALTypeName { get; set; }

        [JsonProperty("islicensed")]
        public bool? IsLicensed { get; set; }

        [JsonProperty("issyncwithdirectory")]
        public bool? IsSyncWithDirectory { get; set; }

        [JsonProperty("yammeremailaddress")]
        public string YammerEmailAddress { get; set; }

        [JsonProperty("defaultmailboxname")]
        public string DefaultMailboxName { get; set; }

        [JsonProperty("yammeruserid")]
        public string YammerUserId { get; set; }

        [JsonProperty("defaultmailbox")]
        public string DefaultMailbox { get; set; }

        [JsonProperty("userlicensetype")]
        public long? UserLicenseType { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("address2_composite")]
        public string Address2_Composite { get; set; }

        [JsonProperty("address1_composite")]
        public string Address1_Composite { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("isemailaddressapprovedbyo365admin")]
        public bool? IsEmailAddressApprovedByO365Admin { get; set; }

        [JsonProperty("positionid")]
        public string PositionId { get; set; }

        [JsonProperty("positionidname")]
        public string PositionIdName { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("sharepointemailaddress")]
        public string SharePointEmailAddress { get; set; }

        [JsonProperty("mobileofflineprofileid")]
        public string MobileOfflineProfileId { get; set; }

        [JsonProperty("mobileofflineprofileidname")]
        public string MobileOfflineProfileIdName { get; set; }

        [JsonProperty("defaultodbfoldername")]
        public string DefaultOdbFolderName { get; set; }

        [JsonProperty("applicationid")]
        public Guid? ApplicationId { get; set; }

        [JsonProperty("applicationiduri")]
        public string ApplicationIdUri { get; set; }

        [JsonProperty("azureactivedirectoryobjectid")]
        public Guid? AzureActiveDirectoryObjectId { get; set; }

        [JsonProperty("identityid")]
        public long? IdentityId { get; set; }

        [JsonProperty("latestupdatetime")]
        public DateTimeOffset? LatestUpdateTime { get; set; }

        [JsonProperty("userpuid")]
        public string UserPuid { get; set; }

        [JsonProperty("islicensedname")]
        public string IsLicensedName { get; set; }


    }
}

