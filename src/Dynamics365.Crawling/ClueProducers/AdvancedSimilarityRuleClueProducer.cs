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
    public abstract class AdvancedSimilarityRuleClueProducer<T> : DynamicsClueProducer<T> where T : AdvancedSimilarityRule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AdvancedSimilarityRuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.AdvancedSimilarityRuleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=advancedsimilarityrule&id={1}", _dynamics365CrawlJobData.Api, input.AdvancedSimilarityRuleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.name;
            /*
             if (input.AzureServiceConnectionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.azureserviceconnection, EntityEdgeType.Parent, input, input.AzureServiceConnectionId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.AdvancedSimilarityRuleId] = input.AdvancedSimilarityRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.name] = input.name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.SourceEntity] = input.SourceEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.SourceEntityName] = input.SourceEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.NgramSize] = input.NgramSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.MaxNumberKeyphrases] = input.MaxNumberKeyphrases.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.AzureServiceConnectionId] = input.AzureServiceConnectionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.AzureServiceConnectionIdName] = input.AzureServiceConnectionIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.AdvancedSimilarityRuleIdUnique] = input.AdvancedSimilarityRuleIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.Entity] = input.Entity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.FetchXmlList] = input.FetchXmlList.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.ExactMatchList] = input.ExactMatchList.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.IsAzureMLRequired] = input.IsAzureMLRequired.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.FilterResultByStatus] = input.FilterResultByStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.FilterResultByStatusName] = input.FilterResultByStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.FilterResultByStatusDisplayName] = input.FilterResultByStatusDisplayName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AdvancedSimilarityRule.NoiseKeyphraseslist] = input.NoiseKeyphraseslist.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

