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
    public abstract class TopicHistoryClueProducer<T> : DynamicsClueProducer<T> where T : TopicHistory
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TopicHistoryClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TopicHistoryId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=topichistory&id={1}", _dynamics365CrawlJobData.Api, input.TopicHistoryId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.TopicModelExecutionHistoryId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodelexecutionhistory, EntityEdgeType.Parent, input, input.TopicModelExecutionHistoryId);


            */
            data.Properties[Dynamics365Vocabulary.TopicHistory.TopicModelExecutionHistoryId] = input.TopicModelExecutionHistoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.TopicModelExecutionHistoryIdName] = input.TopicModelExecutionHistoryIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.TopicHistoryId] = input.TopicHistoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.KeyPhrase] = input.KeyPhrase.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.Weight] = input.Weight.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TopicHistory.Name] = input.Name.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}
