using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SLAKPIInstance : DynamicsModel
    {
        [JsonProperty("slakpiinstanceid")]
        public Guid? SLAKPIInstanceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("computedfailuretime")]
        public DateTimeOffset? ComputedFailureTime { get; set; }

        [JsonProperty("computedwarningtime")]
        public DateTimeOffset? ComputedWarningTime { get; set; }

        [JsonProperty("failuretime")]
        public DateTimeOffset? FailureTime { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("regarding")]
        public string Regarding { get; set; }

        [JsonProperty("regardingname")]
        public string RegardingName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusname")]
        public string StatusName { get; set; }

        [JsonProperty("succeededon")]
        public DateTimeOffset? SucceededOn { get; set; }

        [JsonProperty("warningtime")]
        public DateTimeOffset? WarningTime { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

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

        [JsonProperty("description")]
        public string Description { get; set; }

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

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("warningtimereached")]
        public string WarningTimeReached { get; set; }

        [JsonProperty("hasnearedviolationname")]
        public string HasNearedViolationName { get; set; }

        [JsonProperty("regardingyominame")]
        public string RegardingYomiName { get; set; }

        [JsonProperty("regardingidname")]
        public string RegardingIdName { get; set; }


    }
}

