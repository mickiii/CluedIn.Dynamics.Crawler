using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class BusinessUnitNewsArticle : DynamicsModel
    {
        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("businessunitnewsarticleid")]
        public Guid? BusinessUnitNewsArticleId { get; set; }

        [JsonProperty("activeon")]
        public DateTimeOffset? ActiveOn { get; set; }

        [JsonProperty("activeuntil")]
        public DateTimeOffset? ActiveUntil { get; set; }

        [JsonProperty("newsarticle")]
        public string NewsArticle { get; set; }

        [JsonProperty("articletypecode")]
        public string ArticleTypeCode { get; set; }

        [JsonProperty("showonhomepage")]
        public bool? ShowOnHomepage { get; set; }

        [JsonProperty("articletitle")]
        public string ArticleTitle { get; set; }

        [JsonProperty("articleurl")]
        public string ArticleUrl { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("showonhomepagename")]
        public string ShowOnHomepageName { get; set; }

        [JsonProperty("articletypecodename")]
        public string ArticleTypeCodeName { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

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


    }
}

