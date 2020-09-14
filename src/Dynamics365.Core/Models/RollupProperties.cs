using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RollupProperties : DynamicsModel
    {
        [JsonProperty("rolluppropertiesid")]
        public Guid? RollupPropertiesId { get; set; }

        [JsonProperty("aggregatetype")]
        public string AggregateType { get; set; }

        [JsonProperty("aggregatetypename")]
        public string AggregateTypeName { get; set; }

        [JsonProperty("allowhierarchyonsource")]
        public bool? AllowHierarchyOnSource { get; set; }

        [JsonProperty("allowhierarchyonsourcename")]
        public string AllowHierarchyOnSourceName { get; set; }

        [JsonProperty("rollupentitylogicalname")]
        public string RollupEntityLogicalName { get; set; }

        [JsonProperty("rollupentitytypecode")]
        public long? RollupEntityTypeCode { get; set; }

        [JsonProperty("rollupattributelogicalname")]
        public string RollupAttributeLogicalName { get; set; }

        [JsonProperty("rollupfilterattributes")]
        public string RollupFilterAttributes { get; set; }

        [JsonProperty("aggregateentitylogicalname")]
        public string AggregateEntityLogicalName { get; set; }

        [JsonProperty("aggregateentitytypecode")]
        public long? AggregateEntityTypeCode { get; set; }

        [JsonProperty("aggregateattributelogicalname")]
        public string AggregateAttributeLogicalName { get; set; }

        [JsonProperty("aggregatefilterattributes")]
        public string AggregateFilterAttributes { get; set; }

        [JsonProperty("aggregaterelationshipname")]
        public string AggregateRelationshipName { get; set; }

        [JsonProperty("sourcehierarchicalrelationshipname")]
        public string SourceHierarchicalRelationshipName { get; set; }

        [JsonProperty("lastcalculationtime")]
        public DateTimeOffset? LastCalculationTime { get; set; }

        [JsonProperty("initialvaluecalculationstatus")]
        public string InitialValueCalculationStatus { get; set; }

        [JsonProperty("initialvaluecalculationstatusname")]
        public string InitialValueCalculationStatusName { get; set; }

        [JsonProperty("bootstraprollupasyncjobid")]
        public Guid? BootstrapRollupAsyncJobId { get; set; }

        [JsonProperty("incrementalrollupasyncjobid")]
        public Guid? IncrementalRollupAsyncJobId { get; set; }

        [JsonProperty("bootstrapretrycount")]
        public long? BootstrapRetryCount { get; set; }

        [JsonProperty("bootstrapstepnumber")]
        public long? BootstrapStepNumber { get; set; }

        [JsonProperty("rollupentitybasetablename")]
        public string RollupEntityBaseTableName { get; set; }

        [JsonProperty("rollupentityprimarykeyphysicalname")]
        public string RollupEntityPrimaryKeyPhysicalName { get; set; }

        [JsonProperty("rollupstateattributephysicalname")]
        public string RollupStateAttributePhysicalName { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("datatype")]
        public string DataType { get; set; }

        [JsonProperty("bootstraptargetpointer")]
        public long? BootstrapTargetPointer { get; set; }

        [JsonProperty("bootstrapcurrentdepth")]
        public long? BootstrapCurrentDepth { get; set; }

        [JsonProperty("isactivitypartyincluded")]
        public long? IsActivityPartyIncluded { get; set; }


    }
}

