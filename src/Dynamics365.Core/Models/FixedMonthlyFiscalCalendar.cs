using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class FixedMonthlyFiscalCalendar : DynamicsModel
    {
        [JsonProperty("userfiscalcalendarid")]
        public Guid? UserFiscalCalendarId { get; set; }

        [JsonProperty("salespersonid")]
        public string SalesPersonId { get; set; }

        [JsonProperty("salespersonidname")]
        public string SalesPersonIdName { get; set; }

        [JsonProperty("fiscalperiodtype")]
        public long? FiscalPeriodType { get; set; }

        [JsonProperty("effectiveon")]
        public DateTimeOffset? EffectiveOn { get; set; }

        [JsonProperty("period1")]
        public string Period1 { get; set; }

        [JsonProperty("period2")]
        public string Period2 { get; set; }

        [JsonProperty("period3")]
        public string Period3 { get; set; }

        [JsonProperty("period4")]
        public string Period4 { get; set; }

        [JsonProperty("period5")]
        public string Period5 { get; set; }

        [JsonProperty("period6")]
        public string Period6 { get; set; }

        [JsonProperty("period7")]
        public string Period7 { get; set; }

        [JsonProperty("period8")]
        public string Period8 { get; set; }

        [JsonProperty("period9")]
        public string Period9 { get; set; }

        [JsonProperty("period10")]
        public string Period10 { get; set; }

        [JsonProperty("period11")]
        public string Period11 { get; set; }

        [JsonProperty("period12")]
        public string Period12 { get; set; }

        [JsonProperty("period13")]
        public string Period13 { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("businessunitid")]
        public string BusinessUnitId { get; set; }

        [JsonProperty("businessunitidname")]
        public string BusinessUnitIdName { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("period11_base")]
        public string Period11_Base { get; set; }

        [JsonProperty("period9_base")]
        public string Period9_Base { get; set; }

        [JsonProperty("period12_base")]
        public string Period12_Base { get; set; }

        [JsonProperty("period2_base")]
        public string Period2_Base { get; set; }

        [JsonProperty("period5_base")]
        public string Period5_Base { get; set; }

        [JsonProperty("period13_base")]
        public string Period13_Base { get; set; }

        [JsonProperty("period3_base")]
        public string Period3_Base { get; set; }

        [JsonProperty("period10_base")]
        public string Period10_Base { get; set; }

        [JsonProperty("period8_base")]
        public string Period8_Base { get; set; }

        [JsonProperty("period4_base")]
        public string Period4_Base { get; set; }

        [JsonProperty("period6_base")]
        public string Period6_Base { get; set; }

        [JsonProperty("period1_base")]
        public string Period1_Base { get; set; }

        [JsonProperty("period7_base")]
        public string Period7_Base { get; set; }

        [JsonProperty("salespersonidyominame")]
        public string SalesPersonIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

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


    }
}

