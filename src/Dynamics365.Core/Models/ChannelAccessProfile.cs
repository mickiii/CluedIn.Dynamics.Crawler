using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ChannelAccessProfile : DynamicsModel
    {
        [JsonProperty("channelaccessprofileid")]
        public Guid? ChannelAccessProfileId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("emailaccess")]
        public bool? EmailAccess { get; set; }

        [JsonProperty("emailaccessname")]
        public string EmailAccessName { get; set; }

        [JsonProperty("facebookaccess")]
        public bool? FacebookAccess { get; set; }

        [JsonProperty("facebookaccessname")]
        public string FacebookAccessName { get; set; }

        [JsonProperty("phoneaccess")]
        public bool? PhoneAccess { get; set; }

        [JsonProperty("phoneaccessname")]
        public string PhoneAccessName { get; set; }

        [JsonProperty("twitteraccess")]
        public bool? TwitterAccess { get; set; }

        [JsonProperty("twitteraccessname")]
        public string TwitterAccessName { get; set; }

        [JsonProperty("webaccess")]
        public bool? WebAccess { get; set; }

        [JsonProperty("webaccessname")]
        public string WebAccessName { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("viewknowledgearticles")]
        public bool? ViewKnowledgeArticles { get; set; }

        [JsonProperty("viewknowledgearticlesname")]
        public string ViewKnowledgeArticlesName { get; set; }

        [JsonProperty("viewarticlerating")]
        public bool? ViewArticleRating { get; set; }

        [JsonProperty("viewarticleratingname")]
        public string ViewArticleRatingName { get; set; }

        [JsonProperty("rateknowledgearticles")]
        public bool? RateKnowledgeArticles { get; set; }

        [JsonProperty("rateknowledgearticlesname")]
        public string RateKnowledgeArticlesName { get; set; }

        [JsonProperty("submitfeedback")]
        public bool? SubmitFeedback { get; set; }

        [JsonProperty("submitfeedbackname")]
        public string SubmitFeedbackName { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("channelaccessprofileidunique")]
        public Guid? ChannelAccessProfileIdUnique { get; set; }

        [JsonProperty("isguestprofile")]
        public bool? IsGuestProfile { get; set; }

        [JsonProperty("candeletename")]
        public string CanDeleteName { get; set; }

        [JsonProperty("haveprivilegeschanged")]
        public bool? HavePrivilegesChanged { get; set; }

        [JsonProperty("haveprivilegeschangedname")]
        public string HavePrivilegesChangedName { get; set; }


    }
}

