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
    public abstract class KnowledgeArticleIncidentClueProducer<T> : DynamicsClueProducer<T> where T : KnowledgeArticleIncident
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public KnowledgeArticleIncidentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.KnowledgeArticleIncidentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=knowledgearticleincident&id={1}", _dynamics365CrawlJobData.Api, input.KnowledgeArticleIncidentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.KnowledgeArticleIdName;
            /*
             if (input.KnowledgeArticleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.KnowledgeArticleId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.IncidentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.IncidentId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);


            */
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.KnowledgeArticleIncidentId] = input.KnowledgeArticleIncidentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.IncidentId] = input.IncidentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.IncidentIdName] = input.IncidentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.KnowledgeArticleId] = input.KnowledgeArticleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.KnowledgeArticleIdName] = input.KnowledgeArticleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.KnowledgeUsage] = input.KnowledgeUsage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.KnowledgeUsageName] = input.KnowledgeUsageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.IsSentToCustomer] = input.IsSentToCustomer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.IsSentToCustomerName] = input.IsSentToCustomerName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.statecode] = input.statecode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.statecodeName] = input.statecodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.statuscode] = input.statuscode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.statuscodeName] = input.statuscodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleIncident.OwningTeam] = input.OwningTeam.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

