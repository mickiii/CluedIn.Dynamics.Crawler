using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TopicModel : DynamicsModel
    {
        [JsonProperty("topicmodelid")]
        public Guid? TopicModelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("maxtopics")]
        public long? MaxTopics { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("buildrecurrence")]
        public string BuildRecurrence { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("endtime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("sourceentity")]
        public string SourceEntity { get; set; }

        [JsonProperty("sourceentityname")]
        public string SourceEntityName { get; set; }

        [JsonProperty("configurationused")]
        public string ConfigurationUsed { get; set; }

        [JsonProperty("configurationusedname")]
        public string ConfigurationUsedName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("azureserviceconnectionid")]
        public string AzureServiceConnectionId { get; set; }

        [JsonProperty("azureserviceconnectionidname")]
        public string AzureServiceConnectionIdName { get; set; }

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

        [JsonProperty("topicslastcreatedon")]
        public DateTimeOffset? TopicsLastCreatedOn { get; set; }

        [JsonProperty("totaltopicsfound")]
        public long? TotalTopicsFound { get; set; }

        [JsonProperty("avgnumberoftopics")]
        public long? AvgNumberofTopics { get; set; }

        [JsonProperty("maxnumberoftopics")]
        public long? MaxNumberofTopics { get; set; }

        [JsonProperty("azureschedulerjobname")]
        public string AzureSchedulerJobName { get; set; }

        [JsonProperty("azureschedulertestjobname")]
        public string AzureSchedulerTestJobName { get; set; }

        [JsonProperty("azureschedulerondemandjobname")]
        public string AzureSchedulerOnDemandJobName { get; set; }

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


    }
}

