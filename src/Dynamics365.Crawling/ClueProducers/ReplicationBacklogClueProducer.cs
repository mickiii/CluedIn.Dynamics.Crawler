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
    public abstract class ReplicationBacklogClueProducer<T> : DynamicsClueProducer<T> where T : ReplicationBacklog
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ReplicationBacklogClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ReplicationBacklogId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=replicationbacklog&id={1}", _dynamics365CrawlJobData.Api, input.ReplicationBacklogId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.TargetObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.report, EntityEdgeType.Parent, input, input.TargetObjectId);


            */
            data.Properties[Dynamics365Vocabulary.ReplicationBacklog.Data] = input.Data.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ReplicationBacklog.ReplicationBacklogId] = input.ReplicationBacklogId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ReplicationBacklog.ReplicationBacklogType] = input.ReplicationBacklogType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ReplicationBacklog.ReplicationBacklogTypeName] = input.ReplicationBacklogTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ReplicationBacklog.TargetObjectId] = input.TargetObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ReplicationBacklog.TargetObjectIdName] = input.TargetObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ReplicationBacklog.TargetObjectTypeCode] = input.TargetObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ReplicationBacklog.TargetDatacenterId] = input.TargetDatacenterId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

