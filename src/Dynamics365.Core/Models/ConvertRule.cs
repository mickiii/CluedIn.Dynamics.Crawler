using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ConvertRule : DynamicsModel
    {
        [JsonProperty("convertruleid")]
        public Guid? ConvertRuleId { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

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

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("allowunknownsender")]
        public bool? AllowUnknownSender { get; set; }

        [JsonProperty("channelpropertygroupid")]
        public string ChannelPropertyGroupId { get; set; }

        [JsonProperty("checkactiveentitlement")]
        public bool? CheckActiveEntitlement { get; set; }

        [JsonProperty("checkifresolved")]
        public bool? CheckIfResolved { get; set; }

        [JsonProperty("sendautomaticresponse")]
        public bool? SendAutomaticResponse { get; set; }

        [JsonProperty("queueid")]
        public string QueueId { get; set; }

        [JsonProperty("queueidname")]
        public string QueueIdName { get; set; }

        [JsonProperty("channelpropertygroupidname")]
        public string ChannelPropertyGroupIdName { get; set; }

        [JsonProperty("resolvedsince")]
        public long? ResolvedSince { get; set; }

        [JsonProperty("sourcetypecode")]
        public string SourceTypeCode { get; set; }

        [JsonProperty("sourcetypecodename")]
        public string SourceTypeCodeName { get; set; }

        [JsonProperty("responsetemplateid")]
        public string ResponseTemplateId { get; set; }

        [JsonProperty("responsetemplateidname")]
        public string ResponseTemplateIdName { get; set; }

        [JsonProperty("sourcechanneltypecode")]
        public string SourceChannelTypeCode { get; set; }

        [JsonProperty("sourcechanneltypecodename")]
        public string SourceChannelTypeCodeName { get; set; }

        [JsonProperty("workflowid")]
        public string WorkflowId { get; set; }

        [JsonProperty("workflowidname")]
        public string WorkflowIdName { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("allowunknownsendername")]
        public string AllowUnknownSenderName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("checkifresolvedname")]
        public string CheckIfResolvedName { get; set; }

        [JsonProperty("sendautomaticresponsename")]
        public string SendAutomaticResponseName { get; set; }

        [JsonProperty("checkactiveentitlementname")]
        public string CheckActiveEntitlementName { get; set; }

        [JsonProperty("recordversion")]
        public string RecordVersion { get; set; }

        [JsonProperty("checkblockedsocialprofile")]
        public bool? CheckBlockedSocialProfile { get; set; }

        [JsonProperty("checkblockedsocialprofilename")]
        public string CheckBlockedSocialProfileName { get; set; }

        [JsonProperty("checkdirectmessages")]
        public bool? CheckDirectMessages { get; set; }

        [JsonProperty("checkdirectmessagesname")]
        public string CheckDirectMessagesName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

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

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("convertruleidunique")]
        public Guid? ConvertRuleIdUnique { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }


    }
}

