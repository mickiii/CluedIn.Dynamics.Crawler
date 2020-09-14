using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ImportMap : DynamicsModel
    {
        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("targetentity")]
        public string TargetEntity { get; set; }

        [JsonProperty("importmaptype")]
        public string ImportMapType { get; set; }

        [JsonProperty("targetuseridentifierforsourcecrmuserlink")]
        public string TargetUserIdentifierForSourceCRMUserLink { get; set; }

        [JsonProperty("iswizardcreated")]
        public bool? IsWizardCreated { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("importmapid")]
        public Guid? ImportMapId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("sourceuseridentifierforsourcedatasourceuserlink")]
        public string SourceUserIdentifierForSourceDataSourceUserLink { get; set; }

        [JsonProperty("sourceuseridentifierforsourcecrmuserlink")]
        public string SourceUserIdentifierForSourceCRMUserLink { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("isvalidforimport")]
        public bool? IsValidForImport { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("importmaptypename")]
        public string ImportMapTypeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("isvalidforimportname")]
        public string IsValidForImportName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("iswizardcreatedname")]
        public string IsWizardCreatedName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("targetentityname")]
        public string TargetEntityName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

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

        [JsonProperty("mapcustomizations")]
        public string MapCustomizations { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("entitiesperfile")]
        public string EntitiesPerFile { get; set; }

        [JsonProperty("entitiesperfilename")]
        public string EntitiesPerFileName { get; set; }

        [JsonProperty("sourcetype")]
        public string SourceType { get; set; }

        [JsonProperty("sourcetypename")]
        public string SourceTypeName { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("importmapidunique")]
        public Guid? ImportMapIdUnique { get; set; }


    }
}

