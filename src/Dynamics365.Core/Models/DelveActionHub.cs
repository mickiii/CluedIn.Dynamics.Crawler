using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class DelveActionHub : DynamicsModel
    {
        [JsonProperty("createdtime")]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("modifiedtime")]
        public DateTimeOffset? ModifiedTime { get; set; }

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

        [JsonProperty("delveactionhubid")]
        public Guid? DelveActionHubId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

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

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("messageid")]
        public string MessageId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("messagetime")]
        public DateTimeOffset? MessageTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cardtype")]
        public string CardType { get; set; }

        [JsonProperty("cardtypename")]
        public string CardTypeName { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectiddsc")]
        public long? RegardingObjectIdDsc { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("recordid")]
        public string RecordId { get; set; }

        [JsonProperty("recordiddsc")]
        public long? RecordIdDsc { get; set; }

        [JsonProperty("recordidname")]
        public string RecordIdName { get; set; }

        [JsonProperty("mailweblink")]
        public string MailWebLink { get; set; }

        [JsonProperty("relatedmailids")]
        public string RelatedMailIds { get; set; }

        [JsonProperty("recordidobjecttypecode")]
        public string RecordIdObjectTypeCode { get; set; }

        [JsonProperty("senderimageurl")]
        public string SenderImageUrl { get; set; }

        [JsonProperty("iconclassname")]
        public string IconClassName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("senderentityid")]
        public Guid? SenderEntityId { get; set; }

        [JsonProperty("senderentityobjecttypecode")]
        public long? SenderEntityObjectTypeCode { get; set; }


    }
}

