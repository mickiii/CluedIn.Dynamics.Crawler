using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Subject : DynamicsModel
    {
        [JsonProperty("subjectid")]
        public Guid? SubjectId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parentsubject")]
        public string ParentSubject { get; set; }

        [JsonProperty("featuremask")]
        public long? FeatureMask { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("parentsubjectname")]
        public string ParentSubjectName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

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


    }
}

