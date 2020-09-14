using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ProcessSession : DynamicsModel
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }

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

        [JsonProperty("errorcode")]
        public long? ErrorCode { get; set; }

        [JsonProperty("executedby")]
        public string ExecutedBy { get; set; }

        [JsonProperty("executedbyname")]
        public string ExecutedByName { get; set; }

        [JsonProperty("executedbyyominame")]
        public string ExecutedByYomiName { get; set; }

        [JsonProperty("executedon")]
        public DateTimeOffset? ExecutedOn { get; set; }

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

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nextlinkedsessionid")]
        public string NextLinkedSessionId { get; set; }

        [JsonProperty("nextlinkedsessionidname")]
        public string NextLinkedSessionIdName { get; set; }

        [JsonProperty("originatingsessionid")]
        public string OriginatingSessionId { get; set; }

        [JsonProperty("originatingsessionidname")]
        public string OriginatingSessionIdName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("previouslinkedsessionid")]
        public string PreviousLinkedSessionId { get; set; }

        [JsonProperty("previouslinkedsessionidname")]
        public string PreviousLinkedSessionIdName { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("startedon")]
        public DateTimeOffset? StartedOn { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("stepname")]
        public string StepName { get; set; }

        [JsonProperty("completedon")]
        public DateTimeOffset? CompletedOn { get; set; }

        [JsonProperty("processid")]
        public string ProcessId { get; set; }

        [JsonProperty("processidname")]
        public string ProcessIdName { get; set; }

        [JsonProperty("processsessionid")]
        public Guid? ProcessSessionId { get; set; }

        [JsonProperty("processstagename")]
        public string ProcessStageName { get; set; }

        [JsonProperty("activityname")]
        public string ActivityName { get; set; }

        [JsonProperty("completedby")]
        public string CompletedBy { get; set; }

        [JsonProperty("completedbyname")]
        public string CompletedByName { get; set; }

        [JsonProperty("completedbyyominame")]
        public string CompletedByYomiName { get; set; }

        [JsonProperty("startedby")]
        public string StartedBy { get; set; }

        [JsonProperty("startedbyname")]
        public string StartedByName { get; set; }

        [JsonProperty("startedbyyominame")]
        public string StartedByYomiName { get; set; }

        [JsonProperty("canceledby")]
        public string CanceledBy { get; set; }

        [JsonProperty("canceledbyname")]
        public string CanceledByName { get; set; }

        [JsonProperty("canceledbyyominame")]
        public string CanceledByYomiName { get; set; }

        [JsonProperty("canceledon")]
        public DateTimeOffset? CanceledOn { get; set; }

        [JsonProperty("inputarguments")]
        public string InputArguments { get; set; }

        [JsonProperty("processstate")]
        public string ProcessState { get; set; }

        [JsonProperty("protectionkey")]
        public string ProtectionKey { get; set; }


    }
}

