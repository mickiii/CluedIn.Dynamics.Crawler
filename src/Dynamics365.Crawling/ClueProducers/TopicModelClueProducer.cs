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
    public abstract class TopicModelClueProducer<T> : DynamicsClueProducer<T> where T : TopicModel
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TopicModelClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TopicModelId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=topicmodel&id={1}", _dynamics365CrawlJobData.Api, input.TopicModelId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.AzureServiceConnectionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.azureserviceconnection, EntityEdgeType.Parent, input, input.AzureServiceConnectionId);

                         if (input.ConfigurationUsed != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodelconfiguration, EntityEdgeType.Parent, input, input.ConfigurationUsed);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.TopicModel.TopicModelId] = input.TopicModelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.MaxTopics] = input.MaxTopics.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.BuildRecurrence] = input.BuildRecurrence.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.StartTime] = input.StartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.EndTime] = input.EndTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.SourceEntity] = input.SourceEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.SourceEntityName] = input.SourceEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ConfigurationUsed] = input.ConfigurationUsed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ConfigurationUsedName] = input.ConfigurationUsedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.AzureServiceConnectionId] = input.AzureServiceConnectionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.AzureServiceConnectionIdName] = input.AzureServiceConnectionIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.TopicsLastCreatedOn] = input.TopicsLastCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.TotalTopicsFound] = input.TotalTopicsFound.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.AvgNumberofTopics] = input.AvgNumberofTopics.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.MaxNumberofTopics] = input.MaxNumberofTopics.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.AzureSchedulerJobName] = input.AzureSchedulerJobName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.AzureSchedulerTestJobName] = input.AzureSchedulerTestJobName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.AzureSchedulerOnDemandJobName] = input.AzureSchedulerOnDemandJobName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModel.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

