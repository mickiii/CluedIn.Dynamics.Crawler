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
    public abstract class TextAnalyticsEntityMappingClueProducer<T> : DynamicsClueProducer<T> where T : TextAnalyticsEntityMapping
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TextAnalyticsEntityMappingClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TextAnalyticsEntityMappingId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=textanalyticsentitymapping&id={1}", _dynamics365CrawlJobData.Api, input.TextAnalyticsEntityMappingId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.TopicModelConfigurationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodelconfiguration, EntityEdgeType.Parent, input, input.TopicModelConfigurationId);

                         if (input.AdvancedSimilarityRuleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.advancedsimilarityrule, EntityEdgeType.Parent, input, input.AdvancedSimilarityRuleId);

                         if (input.KnowledgeSearchModelId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgesearchmodel, EntityEdgeType.Parent, input, input.KnowledgeSearchModelId);

                         if (input.SimilarityRuleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.similarityrule, EntityEdgeType.Parent, input, input.SimilarityRuleId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.TextAnalyticsEntityMappingId] = input.TextAnalyticsEntityMappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.TopicModelConfigurationId] = input.TopicModelConfigurationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.TopicModelConfigurationIdName] = input.TopicModelConfigurationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.Entity] = input.Entity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.Field] = input.Field.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.RelationshipName] = input.RelationshipName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.KnowledgeSearchModelId] = input.KnowledgeSearchModelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.KnowledgeSearchModelIdName] = input.KnowledgeSearchModelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.ModelType] = input.ModelType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.SimilarityRuleId] = input.SimilarityRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.SimilarityRuleIdName] = input.SimilarityRuleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.TextAnalyticsEntityMappingIdUnique] = input.TextAnalyticsEntityMappingIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.EntityPickList] = input.EntityPickList.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.EntityPickListName] = input.EntityPickListName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.FieldPickList] = input.FieldPickList.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.FieldPickListName] = input.FieldPickListName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.EntityDisplayName] = input.EntityDisplayName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.FieldDisplayName] = input.FieldDisplayName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.AdvancedSimilarityRuleId] = input.AdvancedSimilarityRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.AdvancedSimilarityRuleIdName] = input.AdvancedSimilarityRuleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.IsTextMatchMapping] = input.IsTextMatchMapping.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TextAnalyticsEntityMapping.IsTextMatchMappingName] = input.IsTextMatchMappingName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

