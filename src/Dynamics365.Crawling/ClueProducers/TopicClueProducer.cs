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
    public abstract class TopicClueProducer<T> : DynamicsClueProducer<T> where T : Topic
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TopicClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Topic, input.TopicId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=topic&id={1}", this._dynamics365CrawlJobData.Api, input.TopicId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;

            //if (input.IncidentId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.IncidentId);

            data.Properties[Dynamics365Vocabulary.Topic.TopicId] = input.TopicId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.IncidentId] = input.IncidentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.IncidentIdName] = input.IncidentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.KeyPhrase] = input.KeyPhrase.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.Score] = input.Score.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Topic.Name] = input.Name.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

