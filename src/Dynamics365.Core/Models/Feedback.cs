using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Feedback : DynamicsModel
    {
        [JsonProperty("feedbackid")]
        public Guid? FeedbackId { get; set; }

        [JsonProperty("rating")]
        public long? Rating { get; set; }

        [JsonProperty("minrating")]
        public long? MinRating { get; set; }

        [JsonProperty("maxrating")]
        public long? MaxRating { get; set; }

        [JsonProperty("normalizedrating")]
        public decimal? NormalizedRating { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("sourcename")]
        public string SourceName { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string statecodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string statuscodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

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

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("closedby")]
        public string ClosedBy { get; set; }

        [JsonProperty("closedbyname")]
        public string ClosedByName { get; set; }

        [JsonProperty("closedbyyominame")]
        public string ClosedByYomiName { get; set; }

        [JsonProperty("closedon")]
        public DateTimeOffset? ClosedOn { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdbycontact")]
        public string CreatedByContact { get; set; }

        [JsonProperty("createdbycontactname")]
        public string CreatedByContactName { get; set; }

        [JsonProperty("createdonbehalfbycontact")]
        public string CreatedOnBehalfByContact { get; set; }

        [JsonProperty("createdonbehalfbycontactname")]
        public string CreatedOnBehalfByContactName { get; set; }

        [JsonProperty("createdonbehalfbycontactyominame")]
        public string CreatedOnBehalfByContactYomiName { get; set; }


    }
}

