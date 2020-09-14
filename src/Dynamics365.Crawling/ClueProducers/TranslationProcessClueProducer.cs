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
    public abstract class TranslationProcessClueProducer<T> : DynamicsClueProducer<T> where T : TranslationProcess
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TranslationProcessClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.BusinessProcessFlowInstanceId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=translationprocess&id={1}", _dynamics365CrawlJobData.Api, input.BusinessProcessFlowInstanceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.KnowledgeArticleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.KnowledgeArticleId);

                         if (input.ActiveStageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.ActiveStageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ProcessId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.ProcessId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.TranslationProcess.BusinessProcessFlowInstanceId] = input.BusinessProcessFlowInstanceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ActiveStageId] = input.ActiveStageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ActiveStageIdName] = input.ActiveStageIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ActiveStageStartedOn] = input.ActiveStageStartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.CompletedOn] = input.CompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ProcessIdName] = input.ProcessIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.KnowledgeArticleId] = input.KnowledgeArticleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.KnowledgeArticleIdName] = input.KnowledgeArticleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.Duration] = input.Duration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TranslationProcess.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

