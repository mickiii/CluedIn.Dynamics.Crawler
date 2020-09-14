using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ActionCard : DynamicsModel
    {
        [JsonProperty("actioncardid")]
        public Guid? ActionCardId { get; set; }

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

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("recordid")]
        public string RecordId { get; set; }

        [JsonProperty("recordidname")]
        public string RecordIdName { get; set; }

        [JsonProperty("recordidobjecttypecode")]
        public string RecordIdObjectTypeCode { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("priority")]
        public long? Priority { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("visibility")]
        public bool? Visibility { get; set; }

        [JsonProperty("startdate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("expirydate")]
        public DateTimeOffset? ExpiryDate { get; set; }

        [JsonProperty("visibilityname")]
        public string VisibilityName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("sourcename")]
        public string SourceName { get; set; }

        [JsonProperty("referencetokens")]
        public string ReferenceTokens { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("statename")]
        public string StateName { get; set; }

        [JsonProperty("cardtypeid")]
        public string CardTypeId { get; set; }

        [JsonProperty("cardtypeidname")]
        public string CardTypeIdName { get; set; }

        [JsonProperty("cardtype")]
        public long? CardType { get; set; }

        [JsonProperty("recordidobjecttypecode2")]
        public long? RecordIdObjectTypeCode2 { get; set; }

        [JsonProperty("parentregardingobjectid")]
        public string ParentRegardingObjectId { get; set; }

        [JsonProperty("parentregardingobjecttypecode")]
        public string ParentRegardingObjectTypeCode { get; set; }

        [JsonProperty("parentregardingobjectiddata")]
        public string ParentRegardingObjectIdData { get; set; }


    }
}

