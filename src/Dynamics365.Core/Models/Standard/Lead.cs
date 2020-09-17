using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Lead : DynamicsModel
    {
        [JsonProperty("leadid")]
        public Guid? LeadId { get; set; }

        [JsonProperty("contactid")]
        public string ContactId { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

        [JsonProperty("leadsourcecode")]
        public string LeadSourceCode { get; set; }

        [JsonProperty("leadqualitycode")]
        public string LeadQualityCode { get; set; }

        [JsonProperty("prioritycode")]
        public string PriorityCode { get; set; }

        [JsonProperty("industrycode")]
        public string IndustryCode { get; set; }

        [JsonProperty("preferredcontactmethodcode")]
        public string PreferredContactMethodCode { get; set; }

        [JsonProperty("salesstagecode")]
        public string SalesStageCode { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("participatesinworkflow")]
        public bool? ParticipatesInWorkflow { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("estimatedvalue")]
        public double? EstimatedValue { get; set; }

        [JsonProperty("estimatedclosedate")]
        public DateTimeOffset? EstimatedCloseDate { get; set; }

        [JsonProperty("companyname")]
        public string CompanyName { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("middlename")]
        public string MiddleName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("revenue")]
        public string Revenue { get; set; }

        [JsonProperty("numberofemployees")]
        public long? NumberOfEmployees { get; set; }

        [JsonProperty("donotphone")]
        public bool? DoNotPhone { get; set; }

        [JsonProperty("sic")]
        public string SIC { get; set; }

        [JsonProperty("donotfax")]
        public bool? DoNotFax { get; set; }

        [JsonProperty("emailaddress1")]
        public string EMailAddress1 { get; set; }

        [JsonProperty("jobtitle")]
        public string JobTitle { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("donotemail")]
        public bool? DoNotEMail { get; set; }

        [JsonProperty("emailaddress2")]
        public string EMailAddress2 { get; set; }

        [JsonProperty("donotpostalmail")]
        public bool? DoNotPostalMail { get; set; }

        [JsonProperty("emailaddress3")]
        public string EMailAddress3 { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("yomifirstname")]
        public string YomiFirstName { get; set; }

        [JsonProperty("websiteurl")]
        public string WebSiteUrl { get; set; }

        [JsonProperty("telephone1")]
        public string Telephone1 { get; set; }

        [JsonProperty("telephone2")]
        public string Telephone2 { get; set; }

        [JsonProperty("telephone3")]
        public string Telephone3 { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("isprivate")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("yomimiddlename")]
        public string YomiMiddleName { get; set; }

        [JsonProperty("yomilastname")]
        public string YomiLastName { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("yomifullname")]
        public string YomiFullName { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("mobilephone")]
        public string MobilePhone { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("versionnumber")]
        public long VersionNumber { get; set; }

        [JsonProperty("contactidname")]
        public string ContactIdName { get; set; }

        [JsonProperty("accountidname")]
        public string AccountIdName { get; set; }

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

        [JsonProperty("customerid")]
        public string CustomerId { get; set; }

        [JsonProperty("customeridname")]
        public string CustomerIdName { get; set; }

        [JsonProperty("customeridtype")]
        public string CustomerIdType { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("isprivatename")]
        public string IsPrivateName { get; set; }

        [JsonProperty("donotpostalmailname")]
        public string DoNotPostalMailName { get; set; }

        [JsonProperty("donotfaxname")]
        public string DoNotFaxName { get; set; }

        [JsonProperty("donotemailname")]
        public string DoNotEMailName { get; set; }

        [JsonProperty("donotphonename")]
        public string DoNotPhoneName { get; set; }

        [JsonProperty("participatesinworkflowname")]
        public string ParticipatesInWorkflowName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("leadsourcecodename")]
        public string LeadSourceCodeName { get; set; }

        [JsonProperty("salesstagecodename")]
        public string SalesStageCodeName { get; set; }

        [JsonProperty("prioritycodename")]
        public string PriorityCodeName { get; set; }

        [JsonProperty("address2_addresstypecodename")]
        public string Address2_AddressTypeCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("address1_shippingmethodcodename")]
        public string Address1_ShippingMethodCodeName { get; set; }

        [JsonProperty("leadqualitycodename")]
        public string LeadQualityCodeName { get; set; }

        [JsonProperty("industrycodename")]
        public string IndustryCodeName { get; set; }

        [JsonProperty("address1_addresstypecodename")]
        public string Address1_AddressTypeCodeName { get; set; }

        [JsonProperty("address2_shippingmethodcodename")]
        public string Address2_ShippingMethodCodeName { get; set; }

        [JsonProperty("preferredcontactmethodcodename")]
        public string PreferredContactMethodCodeName { get; set; }

        [JsonProperty("masterid")]
        public string MasterId { get; set; }

        [JsonProperty("campaignid")]
        public string CampaignId { get; set; }

        [JsonProperty("donotsendmm")]
        public bool? DoNotSendMM { get; set; }

        [JsonProperty("merged")]
        public bool? Merged { get; set; }

        [JsonProperty("donotbulkemail")]
        public bool? DoNotBulkEMail { get; set; }

        [JsonProperty("lastusedincampaign")]
        public DateTimeOffset? LastUsedInCampaign { get; set; }

        [JsonProperty("campaignidname")]
        public string CampaignIdName { get; set; }

        [JsonProperty("donotbulkemailname")]
        public string DoNotBulkEMailName { get; set; }

        [JsonProperty("masterleadidname")]
        public string MasterLeadIdName { get; set; }

        [JsonProperty("mergedname")]
        public string MergedName { get; set; }

        [JsonProperty("donotsendmarketingmaterialname")]
        public string DoNotSendMarketingMaterialName { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("estimatedamount")]
        public string EstimatedAmount { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("estimatedamount_base")]
        public string EstimatedAmount_Base { get; set; }

        [JsonProperty("revenue_base")]
        public string Revenue_Base { get; set; }

        [JsonProperty("yomicompanyname")]
        public string YomiCompanyName { get; set; }

        [JsonProperty("accountidyominame")]
        public string AccountIdYomiName { get; set; }

        [JsonProperty("contactidyominame")]
        public string ContactIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("masterleadidyominame")]
        public string MasterLeadIdYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("customeridyominame")]
        public string CustomerIdYomiName { get; set; }

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

        [JsonProperty("parentaccountid")]
        public string ParentAccountId { get; set; }

        [JsonProperty("parentcontactid")]
        public string ParentContactId { get; set; }

        [JsonProperty("parentaccountidname")]
        public string ParentAccountIdName { get; set; }

        [JsonProperty("parentaccountidyominame")]
        public string ParentAccountIdYomiName { get; set; }

        [JsonProperty("parentcontactidname")]
        public string ParentContactIdName { get; set; }

        [JsonProperty("parentcontactidyominame")]
        public string ParentContactIdYomiName { get; set; }

        [JsonProperty("relatedobjectid")]
        public string RelatedObjectId { get; set; }

        [JsonProperty("budgetamount")]
        public string BudgetAmount { get; set; }

        [JsonProperty("budgetamount_base")]
        public string BudgetAmount_Base { get; set; }

        [JsonProperty("budgetstatus")]
        public string BudgetStatus { get; set; }

        [JsonProperty("budgetstatusname")]
        public string BudgetStatusName { get; set; }

        [JsonProperty("decisionmaker")]
        public bool? DecisionMaker { get; set; }

        [JsonProperty("decisionmakername")]
        public string DecisionMakerName { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("needname")]
        public string NeedName { get; set; }

        [JsonProperty("purchasetimeframe")]
        public string PurchaseTimeFrame { get; set; }

        [JsonProperty("purchasetimeframename")]
        public string PurchaseTimeFrameName { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("evaluatefit")]
        public bool? EvaluateFit { get; set; }

        [JsonProperty("evaluatefitname")]
        public string EvaluateFitName { get; set; }

        [JsonProperty("initialcommunication")]
        public string InitialCommunication { get; set; }

        [JsonProperty("initialcommunicationname")]
        public string InitialCommunicationName { get; set; }

        [JsonProperty("confirminterest")]
        public bool? ConfirmInterest { get; set; }

        [JsonProperty("confirminterestname")]
        public string ConfirmInterestName { get; set; }

        [JsonProperty("purchaseprocess")]
        public string PurchaseProcess { get; set; }

        [JsonProperty("purchaseprocessname")]
        public string PurchaseProcessName { get; set; }

        [JsonProperty("salesstage")]
        public string SalesStage { get; set; }

        [JsonProperty("salesstagename")]
        public string SalesStageName { get; set; }

        [JsonProperty("schedulefollowup_prospect")]
        public DateTimeOffset? ScheduleFollowUp_Prospect { get; set; }

        [JsonProperty("schedulefollowup_qualify")]
        public DateTimeOffset? ScheduleFollowUp_Qualify { get; set; }

        [JsonProperty("qualificationcomments")]
        public string QualificationComments { get; set; }

        [JsonProperty("qualifyingopportunityid")]
        public string QualifyingOpportunityId { get; set; }

        [JsonProperty("qualifyingopportunityidname")]
        public string QualifyingOpportunityIdName { get; set; }

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

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("originatingcaseid")]
        public string OriginatingCaseId { get; set; }

        [JsonProperty("originatingcaseidname")]
        public string OriginatingCaseIdName { get; set; }

        [JsonProperty("relatedobjectidname")]
        public string RelatedObjectIdName { get; set; }

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

        [JsonProperty("isautocreatename")]
        public string isautocreateName { get; set; }

        [JsonProperty("teamsfollowed")]
        public long? TeamsFollowed { get; set; }

        [JsonProperty("businesscard")]
        public string BusinessCard { get; set; }

        [JsonProperty("businesscardattributes")]
        public string BusinessCardAttributes { get; set; }


    }
}

