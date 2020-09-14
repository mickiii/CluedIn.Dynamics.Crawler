using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class WorkflowLog : DynamicsModel
    {
        [JsonProperty("asyncoperationid")]
        public string AsyncOperationId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("completedon")]
        public DateTimeOffset? CompletedOn { get; set; }

        [JsonProperty("workflowlogid")]
        public Guid? WorkflowLogId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("stagename")]
        public string StageName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("stepname")]
        public string StepName { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("errorcode")]
        public long? ErrorCode { get; set; }

        [JsonProperty("activityname")]
        public string ActivityName { get; set; }

        [JsonProperty("asyncoperationidname")]
        public string AsyncOperationIdName { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("statusname")]
        public string StatusName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("childworkflowinstanceid")]
        public string ChildWorkflowInstanceId { get; set; }

        [JsonProperty("childworkflowinstanceidname")]
        public string ChildWorkflowInstanceIdName { get; set; }

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

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("childworkflowinstanceobjecttypecode")]
        public string ChildWorkflowInstanceObjectTypeCode { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("interactionactivityresult")]
        public string InteractionActivityResult { get; set; }

        [JsonProperty("startedon")]
        public DateTimeOffset? StartedOn { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("errortext")]
        public string ErrorText { get; set; }

        [JsonProperty("inputs_name")]
        public string Inputs_Name { get; set; }

        [JsonProperty("outputs_name")]
        public string Outputs_Name { get; set; }

        [JsonProperty("iterationcount")]
        public long? IterationCount { get; set; }

        [JsonProperty("repetitioncount")]
        public long? RepetitionCount { get; set; }

        [JsonProperty("repetitionid")]
        public string RepetitionId { get; set; }


    }
}

