using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Account : DynamicsModel
    {
        [JsonProperty("accountid")]
        public Guid? AccountId { get; set; }

        [JsonProperty("accountcategorycode")]
        public string AccountCategoryCode { get; set; }

        [JsonProperty("territoryid")]
        public string TerritoryId { get; set; }

        [JsonProperty("defaultpricelevelid")]
        public string DefaultPriceLevelId { get; set; }

        [JsonProperty("customersizecode")]
        public string CustomerSizeCode { get; set; }

        [JsonProperty("preferredcontactmethodcode")]
        public string PreferredContactMethodCode { get; set; }

        [JsonProperty("customertypecode")]
        public string CustomerTypeCode { get; set; }

        [JsonProperty("accountratingcode")]
        public string AccountRatingCode { get; set; }

        [JsonProperty("industrycode")]
        public string IndustryCode { get; set; }

        [JsonProperty("territorycode")]
        public string TerritoryCode { get; set; }

        [JsonProperty("accountclassificationcode")]
        public string AccountClassificationCode { get; set; }

        [JsonProperty("businesstypecode")]
        public string BusinessTypeCode { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("originatingleadid")]
        public string OriginatingLeadId { get; set; }

        [JsonProperty("paymenttermscode")]
        public string PaymentTermsCode { get; set; }

        [JsonProperty("shippingmethodcode")]
        public string ShippingMethodCode { get; set; }

        [JsonProperty("primarycontactid")]
        public string PrimaryContactId { get; set; }

        [JsonProperty("participatesinworkflow")]
        public bool? ParticipatesInWorkflow { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accountnumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("revenue")]
        public string Revenue { get; set; }

        [JsonProperty("numberofemployees")]
        public long? NumberOfEmployees { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sic")]
        public string SIC { get; set; }

        [JsonProperty("ownershipcode")]
        public string OwnershipCode { get; set; }

        [JsonProperty("marketcap")]
        public string MarketCap { get; set; }

        [JsonProperty("sharesoutstanding")]
        public long? SharesOutstanding { get; set; }

        [JsonProperty("tickersymbol")]
        public string TickerSymbol { get; set; }

        [JsonProperty("stockexchange")]
        public string StockExchange { get; set; }

        [JsonProperty("websiteurl")]
        public string WebSiteURL { get; set; }

        [JsonProperty("ftpsiteurl")]
        public string FtpSiteURL { get; set; }

        [JsonProperty("emailaddress1")]
        public string EMailAddress1 { get; set; }

        [JsonProperty("emailaddress2")]
        public string EMailAddress2 { get; set; }

        [JsonProperty("emailaddress3")]
        public string EMailAddress3 { get; set; }

        [JsonProperty("donotphone")]
        public bool? DoNotPhone { get; set; }

        [JsonProperty("donotfax")]
        public bool? DoNotFax { get; set; }

        [JsonProperty("telephone1")]
        public string Telephone1 { get; set; }

        [JsonProperty("donotemail")]
        public bool? DoNotEMail { get; set; }

        [JsonProperty("telephone2")]
        public string Telephone2 { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("telephone3")]
        public string Telephone3 { get; set; }

        [JsonProperty("donotpostalmail")]
        public bool? DoNotPostalMail { get; set; }

        [JsonProperty("donotbulkemail")]
        public bool? DoNotBulkEMail { get; set; }

        [JsonProperty("donotbulkpostalmail")]
        public bool? DoNotBulkPostalMail { get; set; }

        [JsonProperty("creditlimit")]
        public string CreditLimit { get; set; }

        [JsonProperty("creditonhold")]
        public bool? CreditOnHold { get; set; }

        [JsonProperty("isprivate")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("versionnumber")]
        public long? VersionNumber { get; set; }

        [JsonProperty("parentaccountid")]
        public string ParentAccountId { get; set; }

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

        [JsonProperty("originatingleadidname")]
        public string OriginatingLeadIdName { get; set; }

        [JsonProperty("primarycontactidname")]
        public string PrimaryContactIdName { get; set; }

        [JsonProperty("parentaccountidname")]
        public string ParentAccountIdName { get; set; }

        [JsonProperty("defaultpricelevelidname")]
        public string DefaultPriceLevelIdName { get; set; }

        [JsonProperty("territoryidname")]
        public string TerritoryIdName { get; set; }

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

        [JsonProperty("donotfaxname")]
        public string DoNotFaxName { get; set; }

        [JsonProperty("donotphonename")]
        public string DoNotPhoneName { get; set; }

        [JsonProperty("donotbulkpostalmailname")]
        public string DoNotBulkPostalMailName { get; set; }

        [JsonProperty("creditonholdname")]
        public string CreditOnHoldName { get; set; }

        [JsonProperty("donotemailname")]
        public string DoNotEMailName { get; set; }

        [JsonProperty("isprivatename")]
        public string IsPrivateName { get; set; }

        [JsonProperty("donotpostalmailname")]
        public string DoNotPostalMailName { get; set; }

        [JsonProperty("participatesinworkflowname")]
        public string ParticipatesInWorkflowName { get; set; }

        [JsonProperty("donotbulkemailname")]
        public string DoNotBulkEMailName { get; set; }

        [JsonProperty("address1_shippingmethodcodename")]
        public string Address1_ShippingMethodCodeName { get; set; }

        [JsonProperty("industrycodename")]
        public string IndustryCodeName { get; set; }

        [JsonProperty("accountratingcodename")]
        public string AccountRatingCodeName { get; set; }

        [JsonProperty("ownershipcodename")]
        public string OwnershipCodeName { get; set; }

        [JsonProperty("accountclassificationcodename")]
        public string AccountClassificationCodeName { get; set; }

        [JsonProperty("customersizecodename")]
        public string CustomerSizeCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("shippingmethodcodename")]
        public string ShippingMethodCodeName { get; set; }

        [JsonProperty("address1_freighttermscodename")]
        public string Address1_FreightTermsCodeName { get; set; }

        [JsonProperty("businesstypecodename")]
        public string BusinessTypeCodeName { get; set; }

        [JsonProperty("address2_freighttermscodename")]
        public string Address2_FreightTermsCodeName { get; set; }

        [JsonProperty("accountcategorycodename")]
        public string AccountCategoryCodeName { get; set; }

        [JsonProperty("paymenttermscodename")]
        public string PaymentTermsCodeName { get; set; }

        [JsonProperty("preferredcontactmethodcodename")]
        public string PreferredContactMethodCodeName { get; set; }

        [JsonProperty("territorycodename")]
        public string TerritoryCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("customertypecodename")]
        public string CustomerTypeCodeName { get; set; }

        [JsonProperty("address1_addresstypecodename")]
        public string Address1_AddressTypeCodeName { get; set; }

        [JsonProperty("address2_shippingmethodcodename")]
        public string Address2_ShippingMethodCodeName { get; set; }

        [JsonProperty("address2_addresstypecodename")]
        public string Address2_AddressTypeCodeName { get; set; }

        [JsonProperty("preferredappointmentdaycode")]
        public string PreferredAppointmentDayCode { get; set; }

        [JsonProperty("preferredsystemuserid")]
        public string PreferredSystemUserId { get; set; }

        [JsonProperty("preferredappointmenttimecode")]
        public string PreferredAppointmentTimeCode { get; set; }

        [JsonProperty("merged")]
        public bool? Merged { get; set; }

        [JsonProperty("donotsendmm")]
        public bool? DoNotSendMM { get; set; }

        [JsonProperty("masterid")]
        public string MasterId { get; set; }

        [JsonProperty("lastusedincampaign")]
        public DateTimeOffset? LastUsedInCampaign { get; set; }

        [JsonProperty("preferredserviceid")]
        public string PreferredServiceId { get; set; }

        [JsonProperty("preferredequipmentid")]
        public string PreferredEquipmentId { get; set; }

        [JsonProperty("preferredequipmentidname")]
        public string PreferredEquipmentIdName { get; set; }

        [JsonProperty("preferredserviceidname")]
        public string PreferredServiceIdName { get; set; }

        [JsonProperty("preferredappointmenttimecodename")]
        public string PreferredAppointmentTimeCodeName { get; set; }

        [JsonProperty("preferredappointmentdaycodename")]
        public string PreferredAppointmentDayCodeName { get; set; }

        [JsonProperty("preferredsystemuseridname")]
        public string PreferredSystemUserIdName { get; set; }

        [JsonProperty("mergedname")]
        public string MergedName { get; set; }

        [JsonProperty("masteraccountidname")]
        public string MasterAccountIdName { get; set; }

        [JsonProperty("donotsendmarketingmaterialname")]
        public string DoNotSendMarketingMaterialName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("creditlimit_base")]
        public string CreditLimit_Base { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("aging30_base")]
        public string Aging30_Base { get; set; }

        [JsonProperty("revenue_base")]
        public string Revenue_Base { get; set; }

        [JsonProperty("aging90_base")]
        public string Aging90_Base { get; set; }

        [JsonProperty("marketcap_base")]
        public string MarketCap_Base { get; set; }

        [JsonProperty("aging60_base")]
        public string Aging60_Base { get; set; }

        [JsonProperty("preferredsystemuseridyominame")]
        public string PreferredSystemUserIdYomiName { get; set; }

        [JsonProperty("parentaccountidyominame")]
        public string ParentAccountIdYomiName { get; set; }

        [JsonProperty("originatingleadidyominame")]
        public string OriginatingLeadIdYomiName { get; set; }

        [JsonProperty("masteraccountidyominame")]
        public string MasterAccountIdYomiName { get; set; }

        [JsonProperty("primarycontactidyominame")]
        public string PrimaryContactIdYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("yominame")]
        public string YomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

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

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("address2_composite")]
        public string Address2_Composite { get; set; }

        [JsonProperty("address1_composite")]
        public string Address1_Composite { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public long? EntityImage_Timestamp { get; set; }

        [JsonProperty("opendeals")]
        public long? OpenDeals { get; set; }

        [JsonProperty("opendeals_date")]
        public DateTimeOffset? OpenDeals_Date { get; set; }

        [JsonProperty("opendeals_state")]
        public long? OpenDeals_State { get; set; }

        [JsonProperty("timespentbymeonemailandmeetings")]
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }

        [JsonProperty("openrevenue")]
        public string OpenRevenue { get; set; }

        [JsonProperty("openrevenue_base")]
        public string OpenRevenue_Base { get; set; }

        [JsonProperty("openrevenue_date")]
        public DateTimeOffset? OpenRevenue_Date { get; set; }

        [JsonProperty("openrevenue_state")]
        public long? OpenRevenue_State { get; set; }

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

        [JsonProperty("primarysatoriid")]
        public string PrimarySatoriId { get; set; }

        [JsonProperty("primarytwitterid")]
        public string PrimaryTwitterId { get; set; }

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

        [JsonProperty("marketingonly")]
        public bool? MarketingOnly { get; set; }

        [JsonProperty("marketingonlyname")]
        public string MarketingOnlyName { get; set; }

        [JsonProperty("teamsfollowed")]
        public long? TeamsFollowed { get; set; }

    }
}

