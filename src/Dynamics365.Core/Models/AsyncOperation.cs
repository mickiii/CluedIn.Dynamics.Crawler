using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class AsyncOperation : DynamicsModel
    {
        [JsonProperty("messagename")]
        public string MessageName { get; set; }

        [JsonProperty("depth")]
        public long? Depth { get; set; }

        [JsonProperty("primaryentitytype")]
        public string PrimaryEntityType { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("workflowstagename")]
        public string WorkflowStageName { get; set; }

        [JsonProperty("operationtype")]
        public string OperationType { get; set; }

        [JsonProperty("dependencytoken")]
        public string DependencyToken { get; set; }

        [JsonProperty("recurrencepattern")]
        public string RecurrencePattern { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postponeuntil")]
        public DateTimeOffset? PostponeUntil { get; set; }

        [JsonProperty("workflowstate")]
        public string WorkflowState { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("iswaitingforevent")]
        public bool? IsWaitingForEvent { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("errorcode")]
        public long? ErrorCode { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("correlationid")]
        public Guid? CorrelationId { get; set; }

        [JsonProperty("recurrencestarttime")]
        public DateTimeOffset? RecurrenceStartTime { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("asyncoperationid")]
        public Guid? AsyncOperationId { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("requestid")]
        public Guid? RequestId { get; set; }

        [JsonProperty("workflowisblocked")]
        public bool? WorkflowIsBlocked { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("startedon")]
        public DateTimeOffset? StartedOn { get; set; }

        [JsonProperty("hostid")]
        public string HostId { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("workflowactivationid")]
        public string WorkflowActivationId { get; set; }

        [JsonProperty("completedon")]
        public DateTimeOffset? CompletedOn { get; set; }

        [JsonProperty("correlationupdatedtime")]
        public DateTimeOffset? CorrelationUpdatedTime { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("retrycount")]
        public long? RetryCount { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("primaryentitytypename")]
        public string PrimaryEntityTypeName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("workflowactivationidname")]
        public string WorkflowActivationIdName { get; set; }

        [JsonProperty("operationtypename")]
        public string OperationTypeName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("friendlymessage")]
        public string FriendlyMessage { get; set; }

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

        [JsonProperty("owningextensionid")]
        public string OwningExtensionId { get; set; }

        [JsonProperty("owningextensionidname")]
        public string OwningExtensionIdName { get; set; }

        [JsonProperty("owningextensiontypecode")]
        public string OwningExtensionTypeCode { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("executiontimespan")]
        public double? ExecutionTimeSpan { get; set; }

        [JsonProperty("subtype")]
        public long? Subtype { get; set; }

        [JsonProperty("parentpluginexecutionid")]
        public Guid? ParentPluginExecutionId { get; set; }

        [JsonProperty("rootexecutioncontext")]
        public string RootExecutionContext { get; set; }

        [JsonProperty("workload")]
        public string Workload { get; set; }

        [JsonProperty("expanderstarttime")]
        public DateTimeOffset? ExpanderStartTime { get; set; }


    }
}

