using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RecommendedDocument : DynamicsModel
    {
        [JsonProperty("recommendeddocumentid")]
        public Guid? RecommendedDocumentId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("externaldocumentid")]
        public string ExternalDocumentId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("absoluteurl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("readurl")]
        public string ReadUrl { get; set; }

        [JsonProperty("editurl")]
        public string EditUrl { get; set; }

        [JsonProperty("contenttype")]
        public string ContentType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("filesize")]
        public long? FileSize { get; set; }

        [JsonProperty("filetype")]
        public string FileType { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("iconclassname")]
        public string IconClassName { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

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

        [JsonProperty("externalmodifiedby")]
        public string ExternalModifiedBy { get; set; }

        [JsonProperty("associatedrecordname")]
        public string AssociatedRecordName { get; set; }


    }
}

