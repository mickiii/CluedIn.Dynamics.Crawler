using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CardType : DynamicsModel
    {
        [JsonProperty("cardtypeid")]
        public Guid? CardTypeId { get; set; }

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

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("priority")]
        public long? Priority { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("cardname")]
        public string CardName { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("isenabled")]
        public bool? IsEnabled { get; set; }

        [JsonProperty("scheduletime")]
        public DateTimeOffset? ScheduleTime { get; set; }

        [JsonProperty("lastsynctime")]
        public DateTimeOffset? LastSyncTime { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("softtitle")]
        public string SoftTitle { get; set; }

        [JsonProperty("summarytext")]
        public string SummaryText { get; set; }

        [JsonProperty("grouptype")]
        public string GroupType { get; set; }

        [JsonProperty("hassnoozedismiss")]
        public bool? HasSnoozeDismiss { get; set; }

        [JsonProperty("hassnoozedismissname")]
        public string HasSnoozeDismissName { get; set; }

        [JsonProperty("cardtype")]
        public long? CardType1 { get; set; }

        [JsonProperty("actions")]
        public string Actions { get; set; }

        [JsonProperty("isenabledname")]
        public string IsEnabledName { get; set; }

        [JsonProperty("stringcardoption")]
        public string StringCardOption { get; set; }

        [JsonProperty("intcardoption")]
        public long? IntCardOption { get; set; }

        [JsonProperty("boolcardoption")]
        public bool? BoolCardOption { get; set; }

        [JsonProperty("boolcardoptionname")]
        public string BoolCardOptionName { get; set; }

        [JsonProperty("ispreviewcard")]
        public bool? IsPreviewCard { get; set; }

        [JsonProperty("ispreviewcardname")]
        public string IsPreviewCardName { get; set; }

        [JsonProperty("isliveonly")]
        public bool? IsLiveOnly { get; set; }

        [JsonProperty("isliveonlyname")]
        public string IsLiveOnlyName { get; set; }

        [JsonProperty("cardtypeicon")]
        public string CardTypeIcon { get; set; }

        [JsonProperty("clientavailability")]
        public string ClientAvailability { get; set; }

        [JsonProperty("clientavailabilityname")]
        public string ClientAvailabilityName { get; set; }

        [JsonProperty("publishername")]
        public string PublisherName { get; set; }

        [JsonProperty("isbasecard")]
        public bool? IsBaseCard { get; set; }

        [JsonProperty("isbasecardname")]
        public string IsBaseCardName { get; set; }

        [JsonProperty("groupcategory")]
        public long? GroupCategory { get; set; }

        [JsonProperty("adaptivecardtemplate")]
        public string AdaptiveCardTemplate { get; set; }


    }
}

