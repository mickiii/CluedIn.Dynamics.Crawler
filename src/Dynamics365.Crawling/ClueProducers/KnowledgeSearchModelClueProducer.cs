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
    public abstract class KnowledgeSearchModelClueProducer<T> : DynamicsClueProducer<T> where T : KnowledgeSearchModel
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public KnowledgeSearchModelClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.KnowledgeSearchModelId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=knowledgesearchmodel&id={1}", _dynamics365CrawlJobData.Api, input.KnowledgeSearchModelId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.AzureServiceConnectionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.azureserviceconnection, EntityEdgeType.Parent, input, input.AzureServiceConnectionId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.KnowledgeSearchModelId] = input.KnowledgeSearchModelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.NgramSize] = input.NgramSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.MaxKeyWords] = input.MaxKeyWords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.FetchXmlList] = input.FetchXmlList.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.SourceEntity] = input.SourceEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.SourceEntityName] = input.SourceEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.AzureServiceConnectionId] = input.AzureServiceConnectionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.AzureServiceConnectionIdName] = input.AzureServiceConnectionIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.KnowledgeSearchModelIdUnique] = input.KnowledgeSearchModelIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.Entity] = input.Entity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeSearchModel.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

