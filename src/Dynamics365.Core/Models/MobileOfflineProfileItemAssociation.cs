using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class MobileOfflineProfileItemAssociation : DynamicsModel
    {
        [JsonProperty("mobileofflineprofileitemassociationid")]
        public Guid? MobileOfflineProfileItemAssociationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("selectedrelationshipsschema")]
        public string SelectedRelationShipsSchema { get; set; }

        [JsonProperty("selectedrelationshipsschemaname")]
        public string SelectedRelationShipsSchemaName { get; set; }

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

        [JsonProperty("mobileofflineprofileitemid")]
        public string MobileOfflineProfileItemId { get; set; }

        [JsonProperty("mobileofflineprofileitemidname")]
        public string MobileOfflineProfileItemIdName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("relationshipid")]
        public Guid? RelationshipId { get; set; }

        [JsonProperty("relationshipdisplayname")]
        public string RelationshipDisplayName { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("publishedon")]
        public DateTimeOffset? PublishedOn { get; set; }

        [JsonProperty("mobileofflineprofileitemassociationidunique")]
        public Guid? MobileOfflineProfileItemAssociationIdUnique { get; set; }

        [JsonProperty("relationshipdata")]
        public string RelationshipData { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("isvalidated")]
        public bool? IsValidated { get; set; }

        [JsonProperty("isvalidatedname")]
        public string IsValidatedName { get; set; }

        [JsonProperty("relationshipname")]
        public string RelationshipName { get; set; }

        [JsonProperty("profileitemassociationentityfilter")]
        public string ProfileItemAssociationEntityFilter { get; set; }


    }
}

