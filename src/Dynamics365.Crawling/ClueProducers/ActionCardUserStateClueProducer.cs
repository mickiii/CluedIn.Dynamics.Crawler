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
    public abstract class ActionCardUserStateClueProducer<T> : DynamicsClueProducer<T> where T : ActionCardUserState
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ActionCardUserStateClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ActionCardUserStateId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=actioncarduserstate&id={1}", _dynamics365CrawlJobData.Api, input.ActionCardUserStateId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.ActionCardId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.actioncard, EntityEdgeType.Parent, input, input.ActionCardId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.ActionCardUserStateId] = input.ActionCardUserStateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.State] = input.State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.StateName] = input.StateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.ActionCardId] = input.ActionCardId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.ActionCardIdName] = input.ActionCardIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.ActionCardIdObjectTypeCode] = input.ActionCardIdObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserState.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

