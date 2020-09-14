using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TextAnalyticsEntityMapping : DynamicsModel
    {
        [JsonProperty("textanalyticsentitymappingid")]
        public Guid? TextAnalyticsEntityMappingId { get; set; }

        [JsonProperty("topicmodelconfigurationid")]
        public string TopicModelConfigurationId { get; set; }

        [JsonProperty("topicmodelconfigurationidname")]
        public string TopicModelConfigurationIdName { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("relationshipname")]
        public string RelationshipName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("knowledgesearchmodelid")]
        public string KnowledgeSearchModelId { get; set; }

        [JsonProperty("knowledgesearchmodelidname")]
        public string KnowledgeSearchModelIdName { get; set; }

        [JsonProperty("modeltype")]
        public long? ModelType { get; set; }

        [JsonProperty("similarityruleid")]
        public string SimilarityRuleId { get; set; }

        [JsonProperty("similarityruleidname")]
        public string SimilarityRuleIdName { get; set; }

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

        [JsonProperty("textanalyticsentitymappingidunique")]
        public Guid? TextAnalyticsEntityMappingIdUnique { get; set; }

        [JsonProperty("entitypicklist")]
        public string EntityPickList { get; set; }

        [JsonProperty("entitypicklistname")]
        public string EntityPickListName { get; set; }

        [JsonProperty("fieldpicklist")]
        public string FieldPickList { get; set; }

        [JsonProperty("fieldpicklistname")]
        public string FieldPickListName { get; set; }

        [JsonProperty("entitydisplayname")]
        public string EntityDisplayName { get; set; }

        [JsonProperty("fielddisplayname")]
        public string FieldDisplayName { get; set; }

        [JsonProperty("advancedsimilarityruleid")]
        public string AdvancedSimilarityRuleId { get; set; }

        [JsonProperty("advancedsimilarityruleidname")]
        public string AdvancedSimilarityRuleIdName { get; set; }

        [JsonProperty("istextmatchmapping")]
        public bool? IsTextMatchMapping { get; set; }

        [JsonProperty("istextmatchmappingname")]
        public string IsTextMatchMappingName { get; set; }


    }
}

