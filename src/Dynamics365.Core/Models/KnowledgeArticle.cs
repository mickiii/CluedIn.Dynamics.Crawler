using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class KnowledgeArticle : DynamicsModel
    {
        [JsonProperty("knowledgearticleid")]
        public Guid? knowledgearticleId { get; set; }

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

        [JsonProperty("processid")]
        public Guid? processid { get; set; }

        [JsonProperty("stageid")]
        public Guid? stageid { get; set; }

        [JsonProperty("traversedpath")]
        public string traversedpath { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("publishon")]
        public DateTimeOffset? PublishOn { get; set; }

        [JsonProperty("expirationdate")]
        public DateTimeOffset? ExpirationDate { get; set; }

        [JsonProperty("parentarticlecontentidname")]
        public string ParentArticleContentIdName { get; set; }

        [JsonProperty("parentarticlecontentid")]
        public string ParentArticleContentId { get; set; }

        [JsonProperty("knowledgearticleviews")]
        public long? KnowledgeArticleViews { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("majorversionnumber")]
        public long? MajorVersionNumber { get; set; }

        [JsonProperty("minorversionnumber")]
        public long? MinorVersionNumber { get; set; }

        [JsonProperty("languagelocaleid")]
        public string LanguageLocaleId { get; set; }

        [JsonProperty("languagelocaleidname")]
        public string LanguageLocaleIdName { get; set; }

        [JsonProperty("scheduledstatusid")]
        public long? ScheduledStatusId { get; set; }

        [JsonProperty("expirationstatusid")]
        public long? ExpirationStatusId { get; set; }

        [JsonProperty("publishstatusid")]
        public long? PublishStatusId { get; set; }

        [JsonProperty("isprimaryname")]
        public string IsPrimaryName { get; set; }

        [JsonProperty("languagelocaleidlocaleid")]
        public long? LanguageLocaleIdLocaleId { get; set; }

        [JsonProperty("isprimary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("readyforreview")]
        public bool? ReadyForReview { get; set; }

        [JsonProperty("isreadyforreview")]
        public string isReadyForReview { get; set; }

        [JsonProperty("review")]
        public string Review { get; set; }

        [JsonProperty("isreview")]
        public string isReview { get; set; }

        [JsonProperty("updatecontent")]
        public bool? UpdateContent { get; set; }

        [JsonProperty("isupdatecontent")]
        public string isUpdateContent { get; set; }

        [JsonProperty("setproductassociations")]
        public bool? SetProductAssociations { get; set; }

        [JsonProperty("isproductassociations")]
        public string isProductAssociations { get; set; }

        [JsonProperty("expiredreviewoptions")]
        public string ExpiredReviewOptions { get; set; }

        [JsonProperty("isexpiredreviewoptions")]
        public string isExpiredReviewOptions { get; set; }

        [JsonProperty("subjectid")]
        public string SubjectId { get; set; }

        [JsonProperty("subjectiddsc")]
        public long? SubjectIdDsc { get; set; }

        [JsonProperty("subjectidname")]
        public string SubjectIdName { get; set; }

        [JsonProperty("primaryauthorid")]
        public string primaryauthorid { get; set; }

        [JsonProperty("primaryauthoridname")]
        public string primaryauthoridName { get; set; }

        [JsonProperty("isrootarticle")]
        public bool? IsRootArticle { get; set; }

        [JsonProperty("isrootarticlename")]
        public string IsRootArticleName { get; set; }

        [JsonProperty("previousarticlecontentid")]
        public string PreviousArticleContentId { get; set; }

        [JsonProperty("previousarticlecontentidname")]
        public string PreviousArticleContentIdName { get; set; }

        [JsonProperty("articlepublicnumber")]
        public string ArticlePublicNumber { get; set; }

        [JsonProperty("islatestversion")]
        public bool? IsLatestVersion { get; set; }

        [JsonProperty("islatestversionname")]
        public string IsLatestVersionName { get; set; }

        [JsonProperty("rootarticleid")]
        public string RootArticleId { get; set; }

        [JsonProperty("rootarticleidname")]
        public string RootArticleIdName { get; set; }

        [JsonProperty("knowledgearticleviews_date")]
        public DateTimeOffset? KnowledgeArticleViews_Date { get; set; }

        [JsonProperty("knowledgearticleviews_state")]
        public long? KnowledgeArticleViews_State { get; set; }

        [JsonProperty("rating")]
        public decimal? Rating { get; set; }

        [JsonProperty("rating_date")]
        public DateTimeOffset? Rating_Date { get; set; }

        [JsonProperty("rating_state")]
        public long? Rating_State { get; set; }

        [JsonProperty("rating_sum")]
        public decimal? Rating_Sum { get; set; }

        [JsonProperty("rating_count")]
        public long? Rating_Count { get; set; }

        [JsonProperty("isinternal")]
        public bool? IsInternal { get; set; }

        [JsonProperty("isinternalname")]
        public string IsInternalName { get; set; }

        [JsonProperty("setcategoryassociations")]
        public bool? SetCategoryAssociations { get; set; }

        [JsonProperty("setcategoryassociationsname")]
        public string SetCategoryAssociationsName { get; set; }

        [JsonProperty("expirationstateid")]
        public long? ExpirationStateId { get; set; }


    }
}

