using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class RollupPropertiesClueProducer<T> : DynamicsClueProducer<T> where T : RollupProperties
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RollupPropertiesClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            this._factory = factory;

            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Unknown, input.RollupPropertiesId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=rollupproperties&id={1}", _dynamics365CrawlJobData.Api, input.RollupPropertiesId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.RollupProperties.RollupPropertiesId] = input.RollupPropertiesId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AggregateType] = input.AggregateType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AggregateTypeName] = input.AggregateTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AllowHierarchyOnSource] = input.AllowHierarchyOnSource.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AllowHierarchyOnSourceName] = input.AllowHierarchyOnSourceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.RollupEntityLogicalName] = input.RollupEntityLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.RollupEntityTypeCode] = input.RollupEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.RollupAttributeLogicalName] = input.RollupAttributeLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.RollupFilterAttributes] = input.RollupFilterAttributes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AggregateEntityLogicalName] = input.AggregateEntityLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AggregateEntityTypeCode] = input.AggregateEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AggregateAttributeLogicalName] = input.AggregateAttributeLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AggregateFilterAttributes] = input.AggregateFilterAttributes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.AggregateRelationshipName] = input.AggregateRelationshipName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.SourceHierarchicalRelationshipName] = input.SourceHierarchicalRelationshipName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.LastCalculationTime] = input.LastCalculationTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.InitialValueCalculationStatus] = input.InitialValueCalculationStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.InitialValueCalculationStatusName] = input.InitialValueCalculationStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.BootstrapRollupAsyncJobId] = input.BootstrapRollupAsyncJobId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.IncrementalRollupAsyncJobId] = input.IncrementalRollupAsyncJobId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.BootstrapRetryCount] = input.BootstrapRetryCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.BootstrapStepNumber] = input.BootstrapStepNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.RollupEntityBaseTableName] = input.RollupEntityBaseTableName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.RollupEntityPrimaryKeyPhysicalName] = input.RollupEntityPrimaryKeyPhysicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.RollupStateAttributePhysicalName] = input.RollupStateAttributePhysicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.DataType] = input.DataType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.BootstrapTargetPointer] = input.BootstrapTargetPointer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.BootstrapCurrentDepth] = input.BootstrapCurrentDepth.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupProperties.IsActivityPartyIncluded] = input.IsActivityPartyIncluded.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

