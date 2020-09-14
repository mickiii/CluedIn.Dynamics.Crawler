using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SdkMessage : DynamicsModel
    {
        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("isprivate")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("sdkmessageid")]
        public Guid? SdkMessageId { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("categoryname")]
        public string CategoryName { get; set; }

        [JsonProperty("customizationlevel")]
        public long? CustomizationLevel { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("sdkmessageidunique")]
        public Guid? SdkMessageIdUnique { get; set; }

        [JsonProperty("expand")]
        public bool? Expand { get; set; }

        [JsonProperty("autotransact")]
        public bool? AutoTransact { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("availability")]
        public long? Availability { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("template")]
        public bool? Template { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("isvalidforexecuteasync")]
        public bool? IsValidForExecuteAsync { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("isreadonly")]
        public bool? IsReadOnly { get; set; }

        [JsonProperty("isreadonlyname")]
        public string IsReadOnlyName { get; set; }

        [JsonProperty("autotransactname")]
        public string AutoTransactName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("expandname")]
        public string ExpandName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("templatename")]
        public string TemplateName { get; set; }

        [JsonProperty("isprivatename")]
        public string IsPrivateName { get; set; }

        [JsonProperty("throttlesettings")]
        public string ThrottleSettings { get; set; }

        [JsonProperty("isactive")]
        public bool? IsActive { get; set; }

        [JsonProperty("isactivename")]
        public string IsActiveName { get; set; }

        [JsonProperty("workflowsdkstepenabled")]
        public bool? WorkflowSdkStepEnabled { get; set; }

        [JsonProperty("workflowsdkstepenabledname")]
        public string WorkflowSdkStepEnabledName { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }


    }
}

