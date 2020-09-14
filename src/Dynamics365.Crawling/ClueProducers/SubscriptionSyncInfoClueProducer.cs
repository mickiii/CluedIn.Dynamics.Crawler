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
    public abstract class SubscriptionSyncInfoClueProducer<T> : DynamicsClueProducer<T> where T : SubscriptionSyncInfo
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SubscriptionSyncInfoClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SubscriptionSyncInfoId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=subscriptionsyncinfo&id={1}", _dynamics365CrawlJobData.Api, input.SubscriptionSyncInfoId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.SubscriptionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.subscription, EntityEdgeType.Parent, input, input.SubscriptionId);


            */
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.EndTime] = input.EndTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.SubscriptionSyncInfoId] = input.SubscriptionSyncInfoId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.DeleteObjectCount] = input.DeleteObjectCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.SubscriptionId] = input.SubscriptionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.SyncResult] = input.SyncResult.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.StartTime] = input.StartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.DataSize] = input.DataSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.InsertObjectCount] = input.InsertObjectCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionSyncInfo.ClientVersion] = input.ClientVersion.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

