using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TopicModelExecutionHistory : DynamicsModel
    {
        [JsonProperty("topicmodelexecutionhistoryid")]
        public Guid? TopicModelExecutionHistoryId { get; set; }

        [JsonProperty("topicmodelid")]
        public string TopicModelId { get; set; }

        [JsonProperty("topicmodelidname")]
        public string TopicModelIdName { get; set; }

        [JsonProperty("topicmodelconfigurationid")]
        public string TopicModelConfigurationId { get; set; }

        [JsonProperty("topicmodelconfigurationidname")]
        public string TopicModelConfigurationIdName { get; set; }

        [JsonProperty("recordsprocessed")]
        public long? RecordsProcessed { get; set; }

        [JsonProperty("totaltime")]
        public long? TotalTime { get; set; }

        [JsonProperty("numberoftopicsfound")]
        public long? NumberOfTopicsFound { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("istestexecution")]
        public bool? IsTestExecution { get; set; }

        [JsonProperty("istestexecutionname")]
        public string IsTestExecutionName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusname")]
        public string StatusName { get; set; }

        [JsonProperty("statusreason")]
        public string StatusReason { get; set; }

        [JsonProperty("statusreasonname")]
        public string StatusReasonName { get; set; }

        [JsonProperty("fetchxmllist")]
        public string FetchXmlList { get; set; }

        [JsonProperty("maxtopics")]
        public long? MaxTopics { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

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

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("azuresyncerrormessage")]
        public string ErrorDetails { get; set; }

        [JsonProperty("recordcorrelationid")]
        public string RecordCorrelationId { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

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
        public string Name { get; set; }


    }
}

