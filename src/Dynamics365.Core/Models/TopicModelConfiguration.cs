using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TopicModelConfiguration : DynamicsModel
    {
        [JsonProperty("topicmodelconfigurationid")]
        public Guid? TopicModelConfigurationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ngramsize")]
        public long? NgramSize { get; set; }

        [JsonProperty("minrelevancescore")]
        public decimal? MinRelevanceScore { get; set; }

        [JsonProperty("stopwords")]
        public string StopWords { get; set; }

        [JsonProperty("topicmodelid")]
        public string TopicModelId { get; set; }

        [JsonProperty("topicmodelidname")]
        public string TopicModelIdName { get; set; }

        [JsonProperty("timefilter")]
        public string TimeFilter { get; set; }

        [JsonProperty("datafilter")]
        public string DataFilter { get; set; }

        [JsonProperty("sourceentity")]
        public string SourceEntity { get; set; }

        [JsonProperty("sourceentityname")]
        public string SourceEntityName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("fetchxmllist")]
        public string FetchXmlList { get; set; }

        [JsonProperty("timefiltername")]
        public string TimeFilterName { get; set; }

        [JsonProperty("timefilterduration")]
        public long? TimeFilterDuration { get; set; }

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

        [JsonProperty("topicmodelconfigurationidunique")]
        public Guid? TopicModelConfigurationIdUnique { get; set; }

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

        [JsonProperty("componentstatename")]
        public string componentstateName { get; set; }

        [JsonProperty("ismanagedname")]
        public string ismanagedName { get; set; }


    }
}

