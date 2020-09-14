using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class PersonalDocumentTemplate : DynamicsModel
    {
        [JsonProperty("clientdata")]
        public string ClientData { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("documenttype")]
        public string DocumentType { get; set; }

        [JsonProperty("documenttypename")]
        public string DocumentTypeName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("personaldocumenttemplateid")]
        public Guid? PersonalDocumentTemplateId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("associatedentitytypecode")]
        public string AssociatedEntityTypeCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("statusname")]
        public string StatusName { get; set; }

        [JsonProperty("associatedentitytypecodename")]
        public string AssociatedEntityTypeCodeName { get; set; }

        [JsonProperty("languagecode")]
        public long? LanguageCode { get; set; }


    }
}

