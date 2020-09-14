using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ActionCardUserState : DynamicsModel
    {
        [JsonProperty("actioncarduserstateid")]
        public Guid? ActionCardUserStateId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

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

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("statename")]
        public string StateName { get; set; }

        [JsonProperty("actioncardid")]
        public string ActionCardId { get; set; }

        [JsonProperty("actioncardidname")]
        public string ActionCardIdName { get; set; }

        [JsonProperty("actioncardidobjecttypecode")]
        public string ActionCardIdObjectTypeCode { get; set; }

        [JsonProperty("startdate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }


    }
}

