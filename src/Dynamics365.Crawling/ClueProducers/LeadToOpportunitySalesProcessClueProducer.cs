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
    public abstract class LeadToOpportunitySalesProcessClueProducer<T> : DynamicsClueProducer<T> where T : LeadToOpportunitySalesProcess
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public LeadToOpportunitySalesProcessClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=leadtoopportunitysalesprocess&id={1}", _dynamics365CrawlJobData.Api, input.BusinessProcessFlowInstanceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.LeadId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.LeadId);

                         if (input.ActiveStageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.ActiveStageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ProcessId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.ProcessId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.OpportunityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.OpportunityId);


            */
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.BusinessProcessFlowInstanceId] = input.BusinessProcessFlowInstanceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ActiveStageId] = input.ActiveStageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ActiveStageIdName] = input.ActiveStageIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ActiveStageStartedOn] = input.ActiveStageStartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.CompletedOn] = input.CompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ProcessIdName] = input.ProcessIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.LeadId] = input.LeadId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.LeadIdName] = input.LeadIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.OpportunityIdName] = input.OpportunityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.Duration] = input.Duration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadToOpportunitySalesProcess.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

