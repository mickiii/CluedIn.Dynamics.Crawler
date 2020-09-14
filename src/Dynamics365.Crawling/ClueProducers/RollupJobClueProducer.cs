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
    public abstract class RollupJobClueProducer<T> : DynamicsClueProducer<T> where T : RollupJob
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RollupJobClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RollupJobId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=rollupjob&id={1}", _dynamics365CrawlJobData.Api, input.RollupJobId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.RollupPropertiesId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.rollupproperties, EntityEdgeType.Parent, input, input.RollupPropertiesId);


            */
            data.Properties[Dynamics365Vocabulary.RollupJob.RollupJobId] = input.RollupJobId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.RollupPropertiesId] = input.RollupPropertiesId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.PostponeUntil] = input.PostponeUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.RetryCount] = input.RetryCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.SourceEntityTypeCode] = input.SourceEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.RecordCreatedOn] = input.RecordCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RollupJob.DepthProcessed] = input.DepthProcessed.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

