using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ProcessTrigger : DynamicsModel
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("controlname")]
        public string ControlName { get; set; }

        [JsonProperty("controltype")]
        public string ControlType { get; set; }

        [JsonProperty("controltypename")]
        public string ControlTypeName { get; set; }

        [JsonProperty("formidname")]
        public string FormIdName { get; set; }

        [JsonProperty("formid")]
        public string FormId { get; set; }

        [JsonProperty("primaryentitytypecode")]
        public string PrimaryEntityTypeCode { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("processtriggeridunique")]
        public Guid? ProcessTriggerIdUnique { get; set; }

        [JsonProperty("processtriggerid")]
        public Guid? ProcessTriggerId { get; set; }

        [JsonProperty("processidname")]
        public string ProcessIdName { get; set; }

        [JsonProperty("processid")]
        public string ProcessId { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("primaryentitytypecodename")]
        public string PrimaryEntityTypeCodeName { get; set; }

        [JsonProperty("methodid")]
        public Guid? MethodId { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("pipelinestage")]
        public string PipelineStage { get; set; }


    }
}

