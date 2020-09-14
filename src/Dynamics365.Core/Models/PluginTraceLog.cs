using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class PluginTraceLog : DynamicsModel
    {
        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("plugintracelogid")]
        public Guid? PluginTraceLogId { get; set; }

        [JsonProperty("configuration")]
        public string Configuration { get; set; }

        [JsonProperty("messagename")]
        public string MessageName { get; set; }

        [JsonProperty("depth")]
        public long? Depth { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("modename")]
        public string ModeName { get; set; }

        [JsonProperty("operationtype")]
        public string OperationType { get; set; }

        [JsonProperty("operationtypename")]
        public string OperationTypeName { get; set; }

        [JsonProperty("performanceconstructorduration")]
        public long? PerformanceConstructorDuration { get; set; }

        [JsonProperty("performanceconstructorstarttime")]
        public DateTimeOffset? PerformanceConstructorStartTime { get; set; }

        [JsonProperty("performanceexecutionduration")]
        public long? PerformanceExecutionDuration { get; set; }

        [JsonProperty("performanceexecutionstarttime")]
        public DateTimeOffset? PerformanceExecutionStartTime { get; set; }

        [JsonProperty("persistencekey")]
        public Guid? PersistenceKey { get; set; }

        [JsonProperty("primaryentity")]
        public string PrimaryEntity { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("requestid")]
        public Guid? RequestId { get; set; }

        [JsonProperty("secureconfiguration")]
        public string SecureConfiguration { get; set; }

        [JsonProperty("typename")]
        public string TypeName { get; set; }

        [JsonProperty("pluginstepid")]
        public Guid? PluginStepId { get; set; }

        [JsonProperty("messageblock")]
        public string MessageBlock { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("exceptiondetails")]
        public string ExceptionDetails { get; set; }

        [JsonProperty("correlationid")]
        public Guid? CorrelationId { get; set; }

        [JsonProperty("issystemcreated")]
        public bool? IsSystemCreated { get; set; }

        [JsonProperty("issystemcreatedname")]
        public string IsSystemCreatedName { get; set; }


    }
}

