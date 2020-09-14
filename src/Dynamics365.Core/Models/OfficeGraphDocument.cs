using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class OfficeGraphDocument : DynamicsModel
    {
        [JsonProperty("officegraphdocumentid")]
        public Guid? OfficeGraphDocumentId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("previewimageurl")]
        public string PreviewImageUrl { get; set; }

        [JsonProperty("filetype")]
        public string FileType { get; set; }

        [JsonProperty("weblocationurl")]
        public string WebLocationUrl { get; set; }

        [JsonProperty("viewcount")]
        public long? ViewCount { get; set; }

        [JsonProperty("authornames")]
        public string AuthorNames { get; set; }

        [JsonProperty("querytype")]
        public long? QueryType { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdtime")]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedtime")]
        public DateTimeOffset? ModifiedTime { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("documentid")]
        public string DocumentId { get; set; }

        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("siteurl")]
        public string SiteUrl { get; set; }

        [JsonProperty("readurl")]
        public string ReadUrl { get; set; }

        [JsonProperty("sitetitle")]
        public string SiteTitle { get; set; }

        [JsonProperty("documentlastmodifiedby")]
        public string DocumentLastModifiedBy { get; set; }

        [JsonProperty("documentlastmodifiedon")]
        public DateTimeOffset? DocumentLastModifiedOn { get; set; }

        [JsonProperty("fileextension")]
        public string FileExtension { get; set; }

        [JsonProperty("secondaryfileextension")]
        public string SecondaryFileExtension { get; set; }

        [JsonProperty("documentpreviewmetadata")]
        public string DocumentPreviewMetadata { get; set; }


    }
}

