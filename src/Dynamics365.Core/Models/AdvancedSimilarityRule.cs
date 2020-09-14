using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class AdvancedSimilarityRule : DynamicsModel
    {
        [JsonProperty("advancedsimilarityruleid")]
        public Guid? AdvancedSimilarityRuleId { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sourceentity")]
        public string SourceEntity { get; set; }

        [JsonProperty("sourceentityname")]
        public string SourceEntityName { get; set; }

        [JsonProperty("ngramsize")]
        public long? NgramSize { get; set; }

        [JsonProperty("maxnumberkeyphrases")]
        public long? MaxNumberKeyphrases { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("azureserviceconnectionid")]
        public string AzureServiceConnectionId { get; set; }

        [JsonProperty("azureserviceconnectionidname")]
        public string AzureServiceConnectionIdName { get; set; }

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

        [JsonProperty("advancedsimilarityruleidunique")]
        public Guid? AdvancedSimilarityRuleIdUnique { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("fetchxmllist")]
        public string FetchXmlList { get; set; }

        [JsonProperty("exactmatchlist")]
        public string ExactMatchList { get; set; }

        [JsonProperty("isazuremlrequired")]
        public bool? IsAzureMLRequired { get; set; }

        [JsonProperty("filterresultbystatus")]
        public string FilterResultByStatus { get; set; }

        [JsonProperty("filterresultbystatusname")]
        public string FilterResultByStatusName { get; set; }

        [JsonProperty("filterresultbystatusdisplayname")]
        public string FilterResultByStatusDisplayName { get; set; }

        [JsonProperty("noisekeyphraseslist")]
        public string NoiseKeyphraseslist { get; set; }


    }
}

