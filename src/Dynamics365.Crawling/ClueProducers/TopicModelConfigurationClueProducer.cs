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
    public abstract class TopicModelConfigurationClueProducer<T> : DynamicsClueProducer<T> where T : TopicModelConfiguration
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TopicModelConfigurationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TopicModelConfigurationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=topicmodelconfiguration&id={1}", _dynamics365CrawlJobData.Api, input.TopicModelConfigurationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.TopicModelId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodel, EntityEdgeType.Parent, input, input.TopicModelId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.TopicModelConfigurationId] = input.TopicModelConfigurationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.NgramSize] = input.NgramSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.MinRelevanceScore] = input.MinRelevanceScore.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.StopWords] = input.StopWords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.TopicModelId] = input.TopicModelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.TopicModelIdName] = input.TopicModelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.TimeFilter] = input.TimeFilter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.DataFilter] = input.DataFilter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.SourceEntity] = input.SourceEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.SourceEntityName] = input.SourceEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.FetchXmlList] = input.FetchXmlList.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.TimeFilterName] = input.TimeFilterName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.TimeFilterDuration] = input.TimeFilterDuration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.TopicModelConfigurationIdUnique] = input.TopicModelConfigurationIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.componentstateName] = input.componentstateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicModelConfiguration.ismanagedName] = input.ismanagedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

