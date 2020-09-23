using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Contact : DynamicsModel
    {
        [JsonProperty("contactid")]
        public Guid? ContactId { get; set; }

        [JsonProperty("defaultpricelevelid")]
        public string DefaultPriceLevelId { get; set; }

        [JsonProperty("customersizecode")]
        public string CustomerSizeCode { get; set; }

        [JsonProperty("customertypecode")]
        public string CustomerTypeCode { get; set; }

        [JsonProperty("preferredcontactmethodcode")]
        public string PreferredContactMethodCode { get; set; }

        [JsonProperty("leadsourcecode")]
        public string LeadSourceCode { get; set; }

        [JsonProperty("originatingleadid")]
        public string OriginatingLeadId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("paymenttermscode")]
        public string PaymentTermsCode { get; set; }

        [JsonProperty("shippingmethodcode")]
        public string ShippingMethodCode { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

        [JsonProperty("participatesinworkflow")]
        public bool? ParticipatesInWorkflow { get; set; }

        [JsonProperty("isbackofficecustomer")]
        public bool? IsBackofficeCustomer { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("jobtitle")]
        public string JobTitle { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }

        [JsonProperty("middlename")]
        public string MiddleName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("yomifirstname")]
        public string YomiFirstName { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("yomimiddlename")]
        public string YomiMiddleName { get; set; }

        [JsonProperty("yomilastname")]
        public string YomiLastName { get; set; }

        [JsonProperty("anniversary")]
        public DateTimeOffset? Anniversary { get; set; }

        [JsonProperty("birthdate")]
        public DateTimeOffset? BirthDate { get; set; }

        [JsonProperty("governmentid")]
        public string GovernmentId { get; set; }

        [JsonProperty("yomifullname")]
        public string YomiFullName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("employeeid")]
        public string EmployeeId { get; set; }

        [JsonProperty("gendercode")]
        public string GenderCode { get; set; }

        [JsonProperty("annualincome")]
        public string AnnualIncome { get; set; }

        [JsonProperty("haschildrencode")]
        public string HasChildrenCode { get; set; }

        [JsonProperty("educationcode")]
        public string EducationCode { get; set; }

        [JsonProperty("websiteurl")]
        public string WebSiteUrl { get; set; }

        [JsonProperty("familystatuscode")]
        public string FamilyStatusCode { get; set; }

        [JsonProperty("ftpsiteurl")]
        public string FtpSiteUrl { get; set; }

        [JsonProperty("emailaddress1")]
        public string EMailAddress1 { get; set; }

        [JsonProperty("spousesname")]
        public string SpousesName { get; set; }

        [JsonProperty("assistantname")]
        public string AssistantName { get; set; }

        [JsonProperty("emailaddress2")]
        public string EMailAddress2 { get; set; }

        [JsonProperty("assistantphone")]
        public string AssistantPhone { get; set; }

        [JsonProperty("emailaddress3")]
        public string EMailAddress3 { get; set; }

        [JsonProperty("donotphone")]
        public bool? DoNotPhone { get; set; }

        [JsonProperty("managername")]
        public string ManagerName { get; set; }

        [JsonProperty("managerphone")]
        public string ManagerPhone { get; set; }

        [JsonProperty("donotfax")]
        public bool? DoNotFax { get; set; }

        [JsonProperty("donotemail")]
        public bool? DoNotEMail { get; set; }

        [JsonProperty("donotpostalmail")]
        public bool? DoNotPostalMail { get; set; }

        [JsonProperty("donotbulkemail")]
        public bool? DoNotBulkEMail { get; set; }

        [JsonProperty("donotbulkpostalmail")]
        public bool? DoNotBulkPostalMail { get; set; }

        [JsonProperty("accountrolecode")]
        public string AccountRoleCode { get; set; }

        [JsonProperty("territorycode")]
        public string TerritoryCode { get; set; }

        [JsonProperty("isprivate")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("creditlimit")]
        public string CreditLimit { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("creditonhold")]
        public bool? CreditOnHold { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("numberofchildren")]
        public long? NumberOfChildren { get; set; }

        [JsonProperty("childrensnames")]
        public string ChildrensNames { get; set; }

        [JsonProperty("versionnumber")]
        public long VersionNumber { get; set; }

        [JsonProperty("mobilephone")]
        public string MobilePhone { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("telephone1")]
        public string Telephone1 { get; set; }

        [JsonProperty("telephone2")]
        public string Telephone2 { get; set; }

        [JsonProperty("telephone3")]
        public string Telephone3 { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("aging30")]
        public string Aging30 { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("aging60")]
        public string Aging60 { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("aging90")]
        public string Aging90 { get; set; }

        [JsonProperty("parentcontactid")]
        public string ParentContactId { get; set; }

        [JsonProperty("originatingleadidname")]
        public string OriginatingLeadIdName { get; set; }

        [JsonProperty("parentcontactidname")]
        public string ParentContactIdName { get; set; }

        [JsonProperty("accountidname")]
        public string AccountIdName { get; set; }

        [JsonProperty("defaultpricelevelidname")]
        public string DefaultPriceLevelIdName { get; set; }

        [JsonProperty("address1_addressid")]
        public Guid? Address1_AddressId { get; set; }

        [JsonProperty("address1_addresstypecode")]
        public string Address1_AddressTypeCode { get; set; }

        [JsonProperty("address1_name")]
        public string Address1_Name { get; set; }

        [JsonProperty("address1_primarycontactname")]
        public string Address1_PrimaryContactName { get; set; }

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

        [JsonProperty("address1_freighttermscode")]
        public string Address1_FreightTermsCode { get; set; }

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

        [JsonProperty("address2_primarycontactname")]
        public string Address2_PrimaryContactName { get; set; }

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

        [JsonProperty("address2_freighttermscode")]
        public string Address2_FreightTermsCode { get; set; }

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

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("isprivatename")]
        public string IsPrivateName { get; set; }

        [JsonProperty("donotfaxname")]
        public string DoNotFaxName { get; set; }

        [JsonProperty("isbackofficecustomername")]
        public string IsBackofficeCustomerName { get; set; }

        [JsonProperty("participatesinworkflowname")]
        public string ParticipatesInWorkflowName { get; set; }

        [JsonProperty("donotpostalmailname")]
        public string DoNotPostalMailName { get; set; }

        [JsonProperty("creditonholdname")]
        public string CreditOnHoldName { get; set; }

        [JsonProperty("donotphonename")]
        public string DoNotPhoneName { get; set; }

        [JsonProperty("donotemailname")]
        public string DoNotEMailName { get; set; }

        [JsonProperty("donotbulkpostalmailname")]
        public string DoNotBulkPostalMailName { get; set; }

        [JsonProperty("donotbulkemailname")]
        public string DoNotBulkEMailName { get; set; }

        [JsonProperty("address1_addresstypecodename")]
        public string Address1_AddressTypeCodeName { get; set; }

        [JsonProperty("preferredcontactmethodcodename")]
        public string PreferredContactMethodCodeName { get; set; }

        [JsonProperty("address2_addresstypecodename")]
        public string Address2_AddressTypeCodeName { get; set; }

        [JsonProperty("customertypecodename")]
        public string CustomerTypeCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("accountrolecodename")]
        public string AccountRoleCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("haschildrencodename")]
        public string HasChildrenCodeName { get; set; }

        [JsonProperty("territorycodename")]
        public string TerritoryCodeName { get; set; }

        [JsonProperty("address1_shippingmethodcodename")]
        public string Address1_ShippingMethodCodeName { get; set; }

        [JsonProperty("paymenttermscodename")]
        public string PaymentTermsCodeName { get; set; }

        [JsonProperty("gendercodename")]
        public string GenderCodeName { get; set; }

        [JsonProperty("address2_freighttermscodename")]
        public string Address2_FreightTermsCodeName { get; set; }

        [JsonProperty("familystatuscodename")]
        public string FamilyStatusCodeName { get; set; }

        [JsonProperty("customersizecodename")]
        public string CustomerSizeCodeName { get; set; }

        [JsonProperty("shippingmethodcodename")]
        public string ShippingMethodCodeName { get; set; }

        [JsonProperty("address1_freighttermscodename")]
        public string Address1_FreightTermsCodeName { get; set; }

        [JsonProperty("leadsourcecodename")]
        public string LeadSourceCodeName { get; set; }

        [JsonProperty("educationcodename")]
        public string EducationCodeName { get; set; }

        [JsonProperty("address2_shippingmethodcodename")]
        public string Address2_ShippingMethodCodeName { get; set; }

        [JsonProperty("preferredsystemuserid")]
        public string PreferredSystemUserId { get; set; }

        [JsonProperty("preferredserviceid")]
        public string PreferredServiceId { get; set; }

        [JsonProperty("masterid")]
        public string MasterId { get; set; }

        [JsonProperty("preferredappointmentdaycode")]
        public string PreferredAppointmentDayCode { get; set; }

        [JsonProperty("preferredappointmenttimecode")]
        public string PreferredAppointmentTimeCode { get; set; }

        [JsonProperty("donotsendmm")]
        public bool? DoNotSendMM { get; set; }

        [JsonProperty("parentcustomerid")]
        public string ParentCustomerId { get; set; }

        [JsonProperty("merged")]
        public bool? Merged { get; set; }

        [JsonProperty("externaluseridentifier")]
        public string ExternalUserIdentifier { get; set; }

        [JsonProperty("subscriptionid")]
        public Guid? SubscriptionId { get; set; }

        [JsonProperty("preferredequipmentid")]
        public string PreferredEquipmentId { get; set; }

        [JsonProperty("lastusedincampaign")]
        public DateTimeOffset? LastUsedInCampaign { get; set; }

        [JsonProperty("mastercontactidname")]
        public string MasterContactIdName { get; set; }

        [JsonProperty("preferredsystemuseridname")]
        public string PreferredSystemUserIdName { get; set; }

        [JsonProperty("mergedname")]
        public string MergedName { get; set; }

        [JsonProperty("preferredappointmenttimecodename")]
        public string PreferredAppointmentTimeCodeName { get; set; }

        [JsonProperty("preferredequipmentidname")]
        public string PreferredEquipmentIdName { get; set; }

        [JsonProperty("parentcustomeridname")]
        public string ParentCustomerIdName { get; set; }

        [JsonProperty("preferredappointmentdaycodename")]
        public string PreferredAppointmentDayCodeName { get; set; }

        [JsonProperty("preferredserviceidname")]
        public string PreferredServiceIdName { get; set; }

        [JsonProperty("parentcustomeridtype")]
        public string ParentCustomerIdType { get; set; }

        [JsonProperty("donotsendmarketingmaterialname")]
        public string DoNotSendMarketingMaterialName { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("annualincome_base")]
        public string AnnualIncome_Base { get; set; }

        [JsonProperty("creditlimit_base")]
        public string CreditLimit_Base { get; set; }

        [JsonProperty("aging60_base")]
        public string Aging60_Base { get; set; }

        [JsonProperty("aging90_base")]
        public string Aging90_Base { get; set; }

        [JsonProperty("aging30_base")]
        public string Aging30_Base { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("originatingleadidyominame")]
        public string OriginatingLeadIdYomiName { get; set; }

        [JsonProperty("parentcustomeridyominame")]
        public string ParentCustomerIdYomiName { get; set; }

        [JsonProperty("preferredsystemuseridyominame")]
        public string PreferredSystemUserIdYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("mastercontactidyominame")]
        public string MasterContactIdYomiName { get; set; }

        [JsonProperty("accountidyominame")]
        public string AccountIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("parentcontactidyominame")]
        public string ParentContactIdYomiName { get; set; }

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

        [JsonProperty("isautocreate")]
        public bool? IsAutoCreate { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("address2_composite")]
        public string Address2_Composite { get; set; }

        [JsonProperty("address1_composite")]
        public string Address1_Composite { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("slaid")]
        public string SLAId { get; set; }

        [JsonProperty("slaname")]
        public string SLAName { get; set; }

        [JsonProperty("slainvokedid")]
        public string SLAInvokedId { get; set; }

        [JsonProperty("onholdtime")]
        public long? OnHoldTime { get; set; }

        [JsonProperty("lastonholdtime")]
        public DateTimeOffset? LastOnHoldTime { get; set; }

        [JsonProperty("slainvokedidname")]
        public string SLAInvokedIdName { get; set; }

        [JsonProperty("followemail")]
        public bool? FollowEmail { get; set; }

        [JsonProperty("followemailname")]
        public string FollowEmailName { get; set; }

        [JsonProperty("timespentbymeonemailandmeetings")]
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }

        [JsonProperty("address3_country")]
        public string Address3_Country { get; set; }

        [JsonProperty("address3_line1")]
        public string Address3_Line1 { get; set; }

        [JsonProperty("address3_line2")]
        public string Address3_Line2 { get; set; }

        [JsonProperty("address3_line3")]
        public string Address3_Line3 { get; set; }

        [JsonProperty("address3_postalcode")]
        public string Address3_PostalCode { get; set; }

        [JsonProperty("address3_postofficebox")]
        public string Address3_PostOfficeBox { get; set; }

        [JsonProperty("address3_stateorprovince")]
        public string Address3_StateOrProvince { get; set; }

        [JsonProperty("address3_city")]
        public string Address3_City { get; set; }

        [JsonProperty("business2")]
        public string Business2 { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("home2")]
        public string Home2 { get; set; }

        [JsonProperty("address3_addressid")]
        public Guid? Address3_AddressId { get; set; }

        [JsonProperty("address3_addresstypecodename")]
        public string Address3_AddressTypeCodeName { get; set; }

        [JsonProperty("address3_composite")]
        public string Address3_Composite { get; set; }

        [JsonProperty("address3_fax")]
        public string Address3_Fax { get; set; }

        [JsonProperty("address3_freighttermscode")]
        public string Address3_FreightTermsCode { get; set; }

        [JsonProperty("address3_freighttermscodename")]
        public string Address3_FreightTermsCodeName { get; set; }

        [JsonProperty("address3_latitude")]
        public double? Address3_Latitude { get; set; }

        [JsonProperty("address3_longitude")]
        public double? Address3_Longitude { get; set; }

        [JsonProperty("address3_name")]
        public string Address3_Name { get; set; }

        [JsonProperty("address3_primarycontactname")]
        public string Address3_PrimaryContactName { get; set; }

        [JsonProperty("address3_shippingmethodcode")]
        public string Address3_ShippingMethodCode { get; set; }

        [JsonProperty("address3_shippingmethodcodename")]
        public string Address3_ShippingMethodCodeName { get; set; }

        [JsonProperty("address3_telephone1")]
        public string Address3_Telephone1 { get; set; }

        [JsonProperty("address3_telephone2")]
        public string Address3_Telephone2 { get; set; }

        [JsonProperty("address3_telephone3")]
        public string Address3_Telephone3 { get; set; }

        [JsonProperty("address3_upszone")]
        public string Address3_UPSZone { get; set; }

        [JsonProperty("address3_utcoffset")]
        public long? Address3_UTCOffset { get; set; }

        [JsonProperty("address3_county")]
        public string Address3_County { get; set; }

        [JsonProperty("address3_addresstypecode")]
        public string Address3_AddressTypeCode { get; set; }

        [JsonProperty("createdbyexternalparty")]
        public string CreatedByExternalParty { get; set; }

        [JsonProperty("createdbyexternalpartyname")]
        public string CreatedByExternalPartyName { get; set; }

        [JsonProperty("createdbyexternalpartyyominame")]
        public string CreatedByExternalPartyYomiName { get; set; }

        [JsonProperty("modifiedbyexternalparty")]
        public string ModifiedByExternalParty { get; set; }

        [JsonProperty("modifiedbyexternalpartyname")]
        public string ModifiedByExternalPartyName { get; set; }

        [JsonProperty("modifiedbyexternalpartyyominame")]
        public string ModifiedByExternalPartyYomiName { get; set; }

        [JsonProperty("marketingonly")]
        public bool? MarketingOnly { get; set; }

        [JsonProperty("marketingonlyname")]
        public string MarketingOnlyName { get; set; }

        [JsonProperty("teamsfollowed")]
        public long? TeamsFollowed { get; set; }

        [JsonProperty("businesscard")]
        public string BusinessCard { get; set; }

        [JsonProperty("businesscardattributes")]
        public string BusinessCardAttributes { get; set; }


    }
}

