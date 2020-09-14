using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RollupPropertiesVocabulary : SimpleVocabulary
    {
        public RollupPropertiesVocabulary()
        {
            VocabularyName = "Dynamics365 RollupProperties";
            KeyPrefix = "dynamics365.rollupproperties";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RollupProperties", group =>
            {
                this.RollupPropertiesId = group.Add(new VocabularyKey("RollupPropertiesId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the current record.")
                    .WithDisplayName("Rollup Properties Id")
                    .ModelProperty("rolluppropertiesid", typeof(Guid)));

                this.AggregateType = group.Add(new VocabularyKey("AggregateType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of aggregation to perform")
                    .WithDisplayName("Rollup Aggregation Type")
                    .ModelProperty("aggregatetype", typeof(string)));

                this.AggregateTypeName = group.Add(new VocabularyKey("AggregateTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Describes the aggregation type")
                    .WithDisplayName("AggregateTypeName")
                    .ModelProperty("aggregatetypename", typeof(string)));

                this.AllowHierarchyOnSource = group.Add(new VocabularyKey("AllowHierarchyOnSource", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Allow source entity to be hierarchical")
                    .WithDisplayName("Allow Hierarchy on Source")
                    .ModelProperty("allowhierarchyonsource", typeof(bool)));

                this.AllowHierarchyOnSourceName = group.Add(new VocabularyKey("AllowHierarchyOnSourceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Describes the Allow hierarchy on source field.")
                    .WithDisplayName("AllowHierarchyOnSourceName")
                    .ModelProperty("allowhierarchyonsourcename", typeof(string)));

                this.RollupEntityLogicalName = group.Add(new VocabularyKey("RollupEntityLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"Logical name of source entity")
                    .WithDisplayName("Source Entity Logical Name")
                    .ModelProperty("rollupentitylogicalname", typeof(string)));

                this.RollupEntityTypeCode = group.Add(new VocabularyKey("RollupEntityTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type code of rollup entity")
                    .WithDisplayName("Rollup Entity Type Code")
                    .ModelProperty("rollupentitytypecode", typeof(long)));

                this.RollupAttributeLogicalName = group.Add(new VocabularyKey("RollupAttributeLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(50))
                    .WithDescription(@"Logical name of source attribute")
                    .WithDisplayName("Source Attribute Logical Name")
                    .ModelProperty("rollupattributelogicalname", typeof(string)));

                this.RollupFilterAttributes = group.Add(new VocabularyKey("RollupFilterAttributes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"Filter criteria for source")
                    .WithDisplayName("Source filter criteria")
                    .ModelProperty("rollupfilterattributes", typeof(string)));

                this.AggregateEntityLogicalName = group.Add(new VocabularyKey("AggregateEntityLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"Logical name of target entity")
                    .WithDisplayName("Target entity logical name")
                    .ModelProperty("aggregateentitylogicalname", typeof(string)));

                this.AggregateEntityTypeCode = group.Add(new VocabularyKey("AggregateEntityTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type code of aggregate entity")
                    .WithDisplayName("Aggregate entity type code")
                    .ModelProperty("aggregateentitytypecode", typeof(long)));

                this.AggregateAttributeLogicalName = group.Add(new VocabularyKey("AggregateAttributeLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(50))
                    .WithDescription(@"Logical name of target attribute")
                    .WithDisplayName("Target attribute logical name")
                    .ModelProperty("aggregateattributelogicalname", typeof(string)));

                this.AggregateFilterAttributes = group.Add(new VocabularyKey("AggregateFilterAttributes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"Filter criteria for target")
                    .WithDisplayName("Target filter criteria")
                    .ModelProperty("aggregatefilterattributes", typeof(string)));

                this.AggregateRelationshipName = group.Add(new VocabularyKey("AggregateRelationshipName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"Relationship name of the source-target relationship.")
                    .WithDisplayName("Source-Target relationship name")
                    .ModelProperty("aggregaterelationshipname", typeof(string)));

                this.SourceHierarchicalRelationshipName = group.Add(new VocabularyKey("SourceHierarchicalRelationshipName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"Relationship name of the source hierarchical relationship")
                    .WithDisplayName("Source hierarchical relationship name")
                    .ModelProperty("sourcehierarchicalrelationshipname", typeof(string)));

                this.LastCalculationTime = group.Add(new VocabularyKey("LastCalculationTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last time when calculations were performed for this rollup field.")
                    .WithDisplayName("Last Calculation Time")
                    .ModelProperty("lastcalculationtime", typeof(DateTime)));

                this.InitialValueCalculationStatus = group.Add(new VocabularyKey("InitialValueCalculationStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status of initial value calculation.")
                    .WithDisplayName("Initial Value Calculation Status")
                    .ModelProperty("initialvaluecalculationstatus", typeof(string)));

                this.InitialValueCalculationStatusName = group.Add(new VocabularyKey("InitialValueCalculationStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Describes the initial value calculation status field.")
                    .WithDisplayName("InitialValueCalculationStatusName")
                    .ModelProperty("initialvaluecalculationstatusname", typeof(string)));

                this.BootstrapRollupAsyncJobId = group.Add(new VocabularyKey("BootstrapRollupAsyncJobId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier representing the mass calculate async job id.")
                    .WithDisplayName("Mass calculate async job id.")
                    .ModelProperty("bootstraprollupasyncjobid", typeof(Guid)));

                this.IncrementalRollupAsyncJobId = group.Add(new VocabularyKey("IncrementalRollupAsyncJobId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier representing the calculate entity async job id.")
                    .WithDisplayName("Calculate entity async job Id")
                    .ModelProperty("incrementalrollupasyncjobid", typeof(Guid)));

                this.BootstrapRetryCount = group.Add(new VocabularyKey("BootstrapRetryCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Retry count for bootstrap")
                    .WithDisplayName("Bootstrap Retry count")
                    .ModelProperty("bootstrapretrycount", typeof(long)));

                this.BootstrapStepNumber = group.Add(new VocabularyKey("BootstrapStepNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Step number to start bootstrap execution")
                    .WithDisplayName("Step number to start bootstrap execution")
                    .ModelProperty("bootstrapstepnumber", typeof(long)));

                this.RollupEntityBaseTableName = group.Add(new VocabularyKey("RollupEntityBaseTableName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"Base Table Name Of Rollup Entity")
                    .WithDisplayName("Rollup Entity Base Table Name")
                    .ModelProperty("rollupentitybasetablename", typeof(string)));

                this.RollupEntityPrimaryKeyPhysicalName = group.Add(new VocabularyKey("RollupEntityPrimaryKeyPhysicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"Physical Name of Primary Key Of Rollup Entity")
                    .WithDisplayName("Rollup Entity Primary Key Physical Name")
                    .ModelProperty("rollupentityprimarykeyphysicalname", typeof(string)));

                this.RollupStateAttributePhysicalName = group.Add(new VocabularyKey("RollupStateAttributePhysicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"Physical Name of Rollup State Attribute")
                    .WithDisplayName("Rollup State Attribute Physical Name")
                    .ModelProperty("rollupstateattributephysicalname", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status of the Rollup.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Describes the StateCode")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Additional information about status of the rollup properties.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Describes the Status Reason")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of rollup.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.DataType = group.Add(new VocabularyKey("DataType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"Rollup field data type")
                    .WithDisplayName("Rollup field data type")
                    .ModelProperty("datatype", typeof(string)));

                this.BootstrapTargetPointer = group.Add(new VocabularyKey("BootstrapTargetPointer", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Target pointer used for bootstrap calculations")
                    .WithDisplayName("Target pointer used for bootstrap calculations")
                    .ModelProperty("bootstraptargetpointer", typeof(long)));

                this.BootstrapCurrentDepth = group.Add(new VocabularyKey("BootstrapCurrentDepth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Depth used for bootstrap calculations")
                    .WithDisplayName("Depth used for bootstrap calculations")
                    .ModelProperty("bootstrapcurrentdepth", typeof(long)));

                this.IsActivityPartyIncluded = group.Add(new VocabularyKey("IsActivityPartyIncluded", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Flag indicating whether Activity Party is included")
                    .WithDisplayName("Flag indicating whether Activity Party is included")
                    .ModelProperty("isactivitypartyincluded", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey RollupPropertiesId { get; private set; }

        public VocabularyKey AggregateType { get; private set; }

        public VocabularyKey AggregateTypeName { get; private set; }

        public VocabularyKey AllowHierarchyOnSource { get; private set; }

        public VocabularyKey AllowHierarchyOnSourceName { get; private set; }

        public VocabularyKey RollupEntityLogicalName { get; private set; }

        public VocabularyKey RollupEntityTypeCode { get; private set; }

        public VocabularyKey RollupAttributeLogicalName { get; private set; }

        public VocabularyKey RollupFilterAttributes { get; private set; }

        public VocabularyKey AggregateEntityLogicalName { get; private set; }

        public VocabularyKey AggregateEntityTypeCode { get; private set; }

        public VocabularyKey AggregateAttributeLogicalName { get; private set; }

        public VocabularyKey AggregateFilterAttributes { get; private set; }

        public VocabularyKey AggregateRelationshipName { get; private set; }

        public VocabularyKey SourceHierarchicalRelationshipName { get; private set; }

        public VocabularyKey LastCalculationTime { get; private set; }

        public VocabularyKey InitialValueCalculationStatus { get; private set; }

        public VocabularyKey InitialValueCalculationStatusName { get; private set; }

        public VocabularyKey BootstrapRollupAsyncJobId { get; private set; }

        public VocabularyKey IncrementalRollupAsyncJobId { get; private set; }

        public VocabularyKey BootstrapRetryCount { get; private set; }

        public VocabularyKey BootstrapStepNumber { get; private set; }

        public VocabularyKey RollupEntityBaseTableName { get; private set; }

        public VocabularyKey RollupEntityPrimaryKeyPhysicalName { get; private set; }

        public VocabularyKey RollupStateAttributePhysicalName { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey DataType { get; private set; }

        public VocabularyKey BootstrapTargetPointer { get; private set; }

        public VocabularyKey BootstrapCurrentDepth { get; private set; }

        public VocabularyKey IsActivityPartyIncluded { get; private set; }


    }
}

