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
    public abstract class SubscriptionClueProducer<T> : DynamicsClueProducer<T> where T : Subscription
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SubscriptionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SubscriptionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=subscription&id={1}", _dynamics365CrawlJobData.Api, input.SubscriptionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.Subscription.SubscriptionId] = input.SubscriptionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.SystemUserId] = input.SystemUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.MachineName] = input.MachineName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.LastSyncStartedOn] = input.LastSyncStartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.SyncEntryTableName] = input.SyncEntryTableName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.SubscriptionType] = input.SubscriptionType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.CompletedSyncStartedOn] = input.CompletedSyncStartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.ReInitialize] = input.ReInitialize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.CompletedSyncVersionNumber] = input.CompletedSyncVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.ClientVersion] = input.ClientVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subscription.ResetForCreate] = input.ResetForCreate.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

