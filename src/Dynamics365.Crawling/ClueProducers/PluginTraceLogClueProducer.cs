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
    public abstract class PluginTraceLogClueProducer<T> : DynamicsClueProducer<T> where T : PluginTraceLog
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PluginTraceLogClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PluginTraceLogId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=plugintracelog&id={1}", _dynamics365CrawlJobData.Api, input.PluginTraceLogId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.TypeName;
            /*
             if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.PluginTraceLogId] = input.PluginTraceLogId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.Configuration] = input.Configuration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.MessageName] = input.MessageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.Depth] = input.Depth.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.Mode] = input.Mode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.ModeName] = input.ModeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.OperationType] = input.OperationType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.OperationTypeName] = input.OperationTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.PerformanceConstructorDuration] = input.PerformanceConstructorDuration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.PerformanceConstructorStartTime] = input.PerformanceConstructorStartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.PerformanceExecutionDuration] = input.PerformanceExecutionDuration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.PerformanceExecutionStartTime] = input.PerformanceExecutionStartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.PersistenceKey] = input.PersistenceKey.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.PrimaryEntity] = input.PrimaryEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.Profile] = input.Profile.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.RequestId] = input.RequestId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.SecureConfiguration] = input.SecureConfiguration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.TypeName] = input.TypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.PluginStepId] = input.PluginStepId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.MessageBlock] = input.MessageBlock.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.ExceptionDetails] = input.ExceptionDetails.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.CorrelationId] = input.CorrelationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.IsSystemCreated] = input.IsSystemCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTraceLog.IsSystemCreatedName] = input.IsSystemCreatedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

