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
    public abstract class KnowledgeArticleViewsClueProducer<T> : DynamicsClueProducer<T> where T : KnowledgeArticleViews
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public KnowledgeArticleViewsClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.KnowledgeArticleViewsId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=knowledgearticleviews&id={1}", _dynamics365CrawlJobData.Api, input.KnowledgeArticleViewsId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.KnowledgeArticleIdName;
            /*
             if (input.KnowledgeArticleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.KnowledgeArticleId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);


            */
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.KnowledgeArticleViewsId] = input.KnowledgeArticleViewsId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.KnowledgeArticleView] = input.KnowledgeArticleView.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ViewDate] = input.ViewDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.KnowledgeArticleId] = input.KnowledgeArticleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.KnowledgeArticleIdName] = input.KnowledgeArticleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.statecode] = input.statecode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.statecodeName] = input.statecodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.statuscode] = input.statuscode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.statuscodeName] = input.statuscodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.Location] = input.Location.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticleViews.LocationName] = input.LocationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

