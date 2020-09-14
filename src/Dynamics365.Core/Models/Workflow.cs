using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Workflow : DynamicsModel
    {
        [JsonProperty("ondemand")]
        public bool? OnDemand { get; set; }

        [JsonProperty("plugintypeid")]
        public string PluginTypeId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workflowid")]
        public Guid? WorkflowId { get; set; }

        [JsonProperty("activeworkflowid")]
        public string ActiveWorkflowId { get; set; }

        [JsonProperty("parentworkflowid")]
        public string ParentWorkflowId { get; set; }

        [JsonProperty("uidata")]
        public string UIData { get; set; }

        [JsonProperty("primaryentity")]
        public string PrimaryEntity { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("asyncautodelete")]
        public bool? AsyncAutoDelete { get; set; }

        [JsonProperty("iscrmuiworkflow")]
        public bool? IsCrmUIWorkflow { get; set; }

        [JsonProperty("subprocess")]
        public bool? Subprocess { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("scopename")]
        public string ScopeName { get; set; }

        [JsonProperty("parentworkflowidname")]
        public string ParentWorkflowIdName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("typename")]
        public string TypeName { get; set; }

        [JsonProperty("activeworkflowidname")]
        public string ActiveWorkflowIdName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("owningbusinessunitname")]
        public string OwningBusinessUnitName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("primaryentityname")]
        public string PrimaryEntityName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("workflowidunique")]
        public Guid? WorkflowIdUnique { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

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

        [JsonProperty("xaml")]
        public string Xaml { get; set; }

        [JsonProperty("triggerondelete")]
        public bool? TriggerOnDelete { get; set; }

        [JsonProperty("rendererobjecttypecode")]
        public string RendererObjectTypeCode { get; set; }

        [JsonProperty("triggeroncreate")]
        public bool? TriggerOnCreate { get; set; }

        [JsonProperty("triggeronupdateattributelist")]
        public string TriggerOnUpdateAttributeList { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("languagecode")]
        public long? LanguageCode { get; set; }

        [JsonProperty("categoryname")]
        public string CategoryName { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("inputparameters")]
        public string InputParameters { get; set; }

        [JsonProperty("asyncautodeletename")]
        public string AsyncAutoDeleteName { get; set; }

        [JsonProperty("ondemandname")]
        public string OnDemandName { get; set; }

        [JsonProperty("subprocessname")]
        public string SubprocessName { get; set; }

        [JsonProperty("triggeroncreatename")]
        public string TriggerOnCreateName { get; set; }

        [JsonProperty("triggerondeletename")]
        public string TriggerOnDeleteName { get; set; }

        [JsonProperty("clientdata")]
        public string ClientData { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createstage")]
        public string CreateStage { get; set; }

        [JsonProperty("updatestage")]
        public string UpdateStage { get; set; }

        [JsonProperty("deletestage")]
        public string DeleteStage { get; set; }

        [JsonProperty("createstagename")]
        public string CreateStageName { get; set; }

        [JsonProperty("updatestagename")]
        public string UpdateStageName { get; set; }

        [JsonProperty("deletestagename")]
        public string DeleteStageName { get; set; }

        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("runas")]
        public string RunAs { get; set; }

        [JsonProperty("runasname")]
        public string RunAsName { get; set; }

        [JsonProperty("syncworkflowlogonfailure")]
        public bool? SyncWorkflowLogOnFailure { get; set; }

        [JsonProperty("syncworkflowlogonfailurename")]
        public string SyncWorkflowLogOnFailureName { get; set; }

        [JsonProperty("uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("istransacted")]
        public bool? IsTransacted { get; set; }

        [JsonProperty("istransactedname")]
        public string IsTransactedName { get; set; }

        [JsonProperty("sdkmessageid")]
        public string SdkMessageId { get; set; }

        [JsonProperty("processorder")]
        public long? ProcessOrder { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("modename")]
        public string ModeName { get; set; }

        [JsonProperty("processroleassignment")]
        public string ProcessRoleAssignment { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("formid")]
        public Guid? FormId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("businessprocesstype")]
        public string BusinessProcessType { get; set; }

        [JsonProperty("businessprocesstypename")]
        public string BusinessProcessTypeName { get; set; }

        [JsonProperty("uiflowtype")]
        public string UIFlowType { get; set; }

        [JsonProperty("uiflowtypename")]
        public string UIFlowTypeName { get; set; }

        [JsonProperty("processtriggerformid")]
        public Guid? ProcessTriggerFormId { get; set; }

        [JsonProperty("processtriggerscope")]
        public string ProcessTriggerScope { get; set; }

        [JsonProperty("processtriggerscopename")]
        public string ProcessTriggerScopeName { get; set; }


    }
}

