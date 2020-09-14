using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Campaign : DynamicsModel
    {
        [JsonProperty("typecode")]
        public string TypeCode { get; set; }

        [JsonProperty("proposedend")]
        public DateTimeOffset? ProposedEnd { get; set; }

        [JsonProperty("budgetedcost")]
        public string BudgetedCost { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("promotioncodename")]
        public string PromotionCodeName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("pricelistid")]
        public string PriceListId { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("istemplate")]
        public bool? IsTemplate { get; set; }

        [JsonProperty("campaignid")]
        public Guid? CampaignId { get; set; }

        [JsonProperty("actualstart")]
        public DateTimeOffset? ActualStart { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("totalactualcost")]
        public string TotalActualCost { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("expectedrevenue")]
        public string ExpectedRevenue { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("codename")]
        public string CodeName { get; set; }

        [JsonProperty("proposedstart")]
        public DateTimeOffset? ProposedStart { get; set; }

        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("actualend")]
        public DateTimeOffset? ActualEnd { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("othercost")]
        public string OtherCost { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("totalcampaignactivityactualcost")]
        public string TotalCampaignActivityActualCost { get; set; }

        [JsonProperty("expectedresponse")]
        public long? ExpectedResponse { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("typecodename")]
        public string TypeCodeName { get; set; }

        [JsonProperty("istemplatename")]
        public string IsTemplateName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("pricelistname")]
        public string PriceListName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("totalcampaignactivityactualcost_base")]
        public string TotalCampaignActivityActualCost_Base { get; set; }

        [JsonProperty("budgetedcost_base")]
        public string BudgetedCost_Base { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("expectedrevenue_base")]
        public string ExpectedRevenue_Base { get; set; }

        [JsonProperty("othercost_base")]
        public string OtherCost_Base { get; set; }

        [JsonProperty("totalactualcost_base")]
        public string TotalActualCost_Base { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

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

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("tmpregardingobjectid")]
        public string TmpRegardingObjectId { get; set; }


    }
}

