using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SimilarityRule : DynamicsModel
    {
        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("similarityruleid")]
        public Guid? SimilarityRuleId { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("matchingentityname")]
        public string MatchingEntityName { get; set; }

        [JsonProperty("statecode")]
        public string statecode { get; set; }

        [JsonProperty("statecodename")]
        public string statecodeName { get; set; }

        [JsonProperty("statuscode")]
        public string statuscode { get; set; }

        [JsonProperty("statuscodename")]
        public string statuscodeName { get; set; }

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

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("similarityruleidunique")]
        public Guid? SimilarityRuleIdUnique { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("baseentitytypecode")]
        public string BaseEntityTypeCode { get; set; }

        [JsonProperty("matchingentitytypecode")]
        public string MatchingEntityTypeCode { get; set; }

        [JsonProperty("excludeinactiverecords")]
        public bool? ExcludeInactiveRecords { get; set; }

        [JsonProperty("baseentitytypecodename")]
        public string BaseEntityTypeCodeName { get; set; }

        [JsonProperty("matchingentitytypecodename")]
        public string MatchingEntityTypeCodeName { get; set; }

        [JsonProperty("excludeinactiverecordsname")]
        public string ExcludeInactiveRecordsName { get; set; }

        [JsonProperty("baseentityname")]
        public string BaseEntityName { get; set; }

        [JsonProperty("activerulefetchxml")]
        public string ActiveRuleFetchXML { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("ruleconditionxml")]
        public string RuleConditionXml { get; set; }

        [JsonProperty("ngramsize")]
        public long? NgramSize { get; set; }

        [JsonProperty("maxkeywords")]
        public long? MaxKeyWords { get; set; }

        [JsonProperty("fetchxmllist")]
        public string FetchXmlList { get; set; }


    }
}

