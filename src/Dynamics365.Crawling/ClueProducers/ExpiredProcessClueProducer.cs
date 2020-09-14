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
    public abstract class ExpiredProcessClueProducer<T> : DynamicsClueProducer<T> where T : ExpiredProcess
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ExpiredProcessClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=expiredprocess&id={1}", _dynamics365CrawlJobData.Api, input.BusinessProcessFlowInstanceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.KnowledgeArticleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.KnowledgeArticleId);

                         if (input.ActiveStageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.ActiveStageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ProcessId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.ProcessId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.BusinessProcessFlowInstanceId] = input.BusinessProcessFlowInstanceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ActiveStageId] = input.ActiveStageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ActiveStageIdName] = input.ActiveStageIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ActiveStageStartedOn] = input.ActiveStageStartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.CompletedOn] = input.CompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ProcessIdName] = input.ProcessIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.KnowledgeArticleId] = input.KnowledgeArticleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.KnowledgeArticleIdName] = input.KnowledgeArticleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.Duration] = input.Duration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExpiredProcess.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

