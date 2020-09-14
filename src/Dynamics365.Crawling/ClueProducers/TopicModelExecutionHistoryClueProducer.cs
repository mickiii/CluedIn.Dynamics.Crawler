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
    public abstract class TopicModelExecutionHistoryClueProducer<T> : DynamicsClueProducer<T> where T : TopicModelExecutionHistory
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TopicModelExecutionHistoryClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TopicModelExecutionHistoryId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=topicmodelexecutionhistory&id={1}", _dynamics365CrawlJobData.Api, input.TopicModelExecutionHistoryId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.TopicModelConfigurationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodelconfiguration, EntityEdgeType.Parent, input, input.TopicModelConfigurationId);

                         if (input.TopicModelId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodel, EntityEdgeType.Parent, input, input.TopicModelId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.TopicModelExecutionHistoryId] = input.TopicModelExecutionHistoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.TopicModelId] = input.TopicModelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.TopicModelIdName] = input.TopicModelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.TopicModelConfigurationId] = input.TopicModelConfigurationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.TopicModelConfigurationIdName] = input.TopicModelConfigurationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.RecordsProcessed] = input.RecordsProcessed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.TotalTime] = input.TotalTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.NumberOfTopicsFound] = input.NumberOfTopicsFound.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.StartTime] = input.StartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.IsTestExecution] = input.IsTestExecution.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.IsTestExecutionName] = input.IsTestExecutionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.StatusName] = input.StatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.StatusReason] = input.StatusReason.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.StatusReasonName] = input.StatusReasonName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.FetchXmlList] = input.FetchXmlList.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.MaxTopics] = input.MaxTopics.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ErrorDetails] = input.ErrorDetails.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.RecordCorrelationId] = input.RecordCorrelationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelExecutionHistory.Name] = input.Name.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

