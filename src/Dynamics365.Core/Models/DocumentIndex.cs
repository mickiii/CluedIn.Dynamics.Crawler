using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class DocumentIndex : DynamicsModel
    {
        [JsonProperty("documentindexid")]
        public Guid? DocumentIndexId { get; set; }

        [JsonProperty("subjectid")]
        public string SubjectId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("ispublished")]
        public bool? IsPublished { get; set; }

        [JsonProperty("documenttypecode")]
        public string DocumentTypeCode { get; set; }

        [JsonProperty("documentid")]
        public string DocumentId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("keywords")]
        public string KeyWords { get; set; }

        [JsonProperty("searchtext")]
        public string SearchText { get; set; }

        [JsonProperty("ispublishedname")]
        public string IsPublishedName { get; set; }

        [JsonProperty("documenttypecodename")]
        public string DocumentTypeCodeName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("islatestversion")]
        public bool? IsLatestVersion { get; set; }

        [JsonProperty("islatestversionname")]
        public string IsLatestVersionName { get; set; }


    }
}

