using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SdkMessageFilter : DynamicsModel
    {
        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("sdkmessagefilterid")]
        public Guid? SdkMessageFilterId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("primaryobjecttypecode")]
        public string PrimaryObjectTypeCode { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("customizationlevel")]
        public long? CustomizationLevel { get; set; }

        [JsonProperty("secondaryobjecttypecode")]
        public string SecondaryObjectTypeCode { get; set; }

        [JsonProperty("sdkmessagefilteridunique")]
        public Guid? SdkMessageFilterIdUnique { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("iscustomprocessingstepallowed")]
        public bool? IsCustomProcessingStepAllowed { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("availability")]
        public long? Availability { get; set; }

        [JsonProperty("sdkmessageid")]
        public string SdkMessageId { get; set; }

        [JsonProperty("secondaryobjecttypecodename")]
        public string SecondaryObjectTypeCodeName { get; set; }

        [JsonProperty("primaryobjecttypecodename")]
        public string PrimaryObjectTypeCodeName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("isvisible")]
        public bool? IsVisible { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("sdkmessageidname")]
        public string SdkMessageIdName { get; set; }

        [JsonProperty("iscustomprocessingstepallowedname")]
        public string IsCustomProcessingStepAllowedName { get; set; }

        [JsonProperty("workflowsdkstepenabled")]
        public bool? WorkflowSdkStepEnabled { get; set; }

        [JsonProperty("workflowsdkstepenabledname")]
        public string WorkflowSdkStepEnabledName { get; set; }

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

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("restrictionlevel")]
        public long? RestrictionLevel { get; set; }


    }
}

