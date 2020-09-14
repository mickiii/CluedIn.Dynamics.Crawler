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
    public abstract class CardTypeClueProducer<T> : DynamicsClueProducer<T> where T : CardType
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CardTypeClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.CardTypeId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=cardtype&id={1}", _dynamics365CrawlJobData.Api, input.CardTypeId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.CardName;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.CardType.CardTypeId] = input.CardTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.Priority] = input.Priority.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CardName] = input.CardName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IsEnabled] = input.IsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ScheduleTime] = input.ScheduleTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.LastSyncTime] = input.LastSyncTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.SoftTitle] = input.SoftTitle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.SummaryText] = input.SummaryText.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.GroupType] = input.GroupType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.HasSnoozeDismiss] = input.HasSnoozeDismiss.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.HasSnoozeDismissName] = input.HasSnoozeDismissName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CardType] = input.CardType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.Actions] = input.Actions.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IsEnabledName] = input.IsEnabledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.StringCardOption] = input.StringCardOption.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IntCardOption] = input.IntCardOption.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.BoolCardOption] = input.BoolCardOption.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.BoolCardOptionName] = input.BoolCardOptionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IsPreviewCard] = input.IsPreviewCard.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IsPreviewCardName] = input.IsPreviewCardName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IsLiveOnly] = input.IsLiveOnly.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IsLiveOnlyName] = input.IsLiveOnlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.CardTypeIcon] = input.CardTypeIcon.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ClientAvailability] = input.ClientAvailability.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.ClientAvailabilityName] = input.ClientAvailabilityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.PublisherName] = input.PublisherName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IsBaseCard] = input.IsBaseCard.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.IsBaseCardName] = input.IsBaseCardName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.GroupCategory] = input.GroupCategory.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CardType.AdaptiveCardTemplate] = input.AdaptiveCardTemplate.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

