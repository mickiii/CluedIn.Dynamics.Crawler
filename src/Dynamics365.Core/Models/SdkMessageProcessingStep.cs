using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SdkMessageProcessingStep : DynamicsModel
    {
        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("configuration")]
        public string Configuration { get; set; }

        [JsonProperty("supporteddeployment")]
        public string SupportedDeployment { get; set; }

        [JsonProperty("plugintypeid")]
        public string PluginTypeId { get; set; }

        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("sdkmessageid")]
        public string SdkMessageId { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("sdkmessageprocessingstepid")]
        public Guid? SdkMessageProcessingStepId { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("sdkmessageprocessingstepidunique")]
        public Guid? SdkMessageProcessingStepIdUnique { get; set; }

        [JsonProperty("filteringattributes")]
        public string FilteringAttributes { get; set; }

        [JsonProperty("customizationlevel")]
        public long? CustomizationLevel { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("sdkmessageprocessingstepsecureconfigid")]
        public string SdkMessageProcessingStepSecureConfigId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("sdkmessagefilterid")]
        public string SdkMessageFilterId { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("impersonatinguserid")]
        public string ImpersonatingUserId { get; set; }

        [JsonProperty("invocationsource")]
        public string InvocationSource { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("stagename")]
        public string StageName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("supporteddeploymentname")]
        public string SupportedDeploymentName { get; set; }

        [JsonProperty("modename")]
        public string ModeName { get; set; }

        [JsonProperty("invocationsourcename")]
        public string InvocationSourceName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("asyncautodelete")]
        public bool? AsyncAutoDelete { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("eventhandler")]
        public string EventHandler { get; set; }

        [JsonProperty("eventhandlertypecode")]
        public string EventHandlerTypeCode { get; set; }

        [JsonProperty("eventhandlername")]
        public string EventHandlerName { get; set; }

        [JsonProperty("asyncautodeletename")]
        public string AsyncAutoDeleteName { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("impersonatinguseridname")]
        public string ImpersonatingUserIdName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("plugintypeidname")]
        public string PluginTypeIdName { get; set; }

        [JsonProperty("sdkmessageidname")]
        public string SdkMessageIdName { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("ishidden")]
        public string IsHidden { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("canusereadonlyconnection")]
        public bool? CanUseReadOnlyConnection { get; set; }

        [JsonProperty("canusereadonlyconnectionname")]
        public string CanUseReadOnlyConnectionName { get; set; }

        [JsonProperty("eventexpander")]
        public string EventExpander { get; set; }


    }
}

