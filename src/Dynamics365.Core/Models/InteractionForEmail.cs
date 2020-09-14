using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class InteractionForEmail : DynamicsModel
    {
        [JsonProperty("interactionforemailid")]
        public Guid? InteractionForEmailId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("statecode")]
        public string statecode { get; set; }

        [JsonProperty("statecodename")]
        public string statecodeName { get; set; }

        [JsonProperty("statuscode")]
        public string statuscode { get; set; }

        [JsonProperty("statuscodename")]
        public string statuscodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("interactedcomponenttext")]
        public string InteractedComponentText { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("interactionlocation")]
        public string InteractionLocation { get; set; }

        [JsonProperty("interactiontype")]
        public string InteractionType { get; set; }

        [JsonProperty("interactiontypename")]
        public string InteractionTypeName { get; set; }

        [JsonProperty("interactionrepliedby")]
        public string InteractionRepliedBy { get; set; }

        [JsonProperty("interactionuseragent")]
        public string InteractionUserAgent { get; set; }

        [JsonProperty("emailinteractiontime")]
        public DateTimeOffset? EmailInteractionTime { get; set; }

        [JsonProperty("emailactivityid")]
        public Guid? EmailActivityId { get; set; }

        [JsonProperty("emailinteractionreplyid")]
        public Guid? EmailInteractionReplyId { get; set; }

        [JsonProperty("interactionreplyid")]
        public string InteractionReplyId { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("interactionpartyid")]
        public Guid? InteractionPartyId { get; set; }

        [JsonProperty("interactionpartytypecode")]
        public long? InteractionPartyTypecode { get; set; }


    }
}

