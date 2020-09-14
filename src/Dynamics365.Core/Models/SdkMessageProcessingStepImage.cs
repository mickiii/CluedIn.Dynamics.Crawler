using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SdkMessageProcessingStepImage : DynamicsModel
    {
        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("sdkmessageprocessingstepid")]
        public string SdkMessageProcessingStepId { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("sdkmessageprocessingstepimageid")]
        public Guid? SdkMessageProcessingStepImageId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("entityalias")]
        public string EntityAlias { get; set; }

        [JsonProperty("customizationlevel")]
        public long? CustomizationLevel { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("sdkmessageprocessingstepimageidunique")]
        public Guid? SdkMessageProcessingStepImageIdUnique { get; set; }

        [JsonProperty("imagetype")]
        public string ImageType { get; set; }

        [JsonProperty("relatedattributename")]
        public string RelatedAttributeName { get; set; }

        [JsonProperty("messagepropertyname")]
        public string MessagePropertyName { get; set; }

        [JsonProperty("attributes")]
        public string Attributes { get; set; }

        [JsonProperty("imagetypename")]
        public string ImageTypeName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }


    }
}

