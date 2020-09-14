using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SalesLiteratureItem : DynamicsModel
    {
        [JsonProperty("salesliteratureitemid")]
        public Guid? SalesLiteratureItemId { get; set; }

        [JsonProperty("salesliteratureid")]
        public string SalesLiteratureId { get; set; }

        [JsonProperty("iscustomerviewable")]
        public bool? IsCustomerViewable { get; set; }

        [JsonProperty("attacheddocumenturl")]
        public string AttachedDocumentUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("mimetype")]
        public string MimeType { get; set; }

        [JsonProperty("authorname")]
        public string AuthorName { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("documentbody")]
        public string DocumentBody { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("keywords")]
        public string KeyWords { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("filetypecode")]
        public string FileTypeCode { get; set; }

        [JsonProperty("filesize")]
        public long? FileSize { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("iscustomerviewablename")]
        public string IsCustomerViewableName { get; set; }

        [JsonProperty("filetypecodename")]
        public string FileTypeCodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

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

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("filetype")]
        public long? FileType { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }


    }
}

