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
    public abstract class SubscriptionClientsClueProducer<T> : DynamicsClueProducer<T> where T : SubscriptionClients
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SubscriptionClientsClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SubscriptionClientId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=subscriptionclients&id={1}", _dynamics365CrawlJobData.Api, input.SubscriptionClientId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.SubscriptionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.subscription, EntityEdgeType.Parent, input, input.SubscriptionId);


            */
            data.Properties[Dynamics365Vocabulary.SubscriptionClients.ClientId] = input.ClientId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionClients.MachineName] = input.MachineName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionClients.SubscriptionId] = input.SubscriptionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionClients.IsPrimaryClient] = input.IsPrimaryClient.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SubscriptionClients.SubscriptionClientId] = input.SubscriptionClientId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

