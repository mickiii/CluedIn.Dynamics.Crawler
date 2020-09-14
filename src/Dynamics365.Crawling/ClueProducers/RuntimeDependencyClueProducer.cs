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
    public abstract class RuntimeDependencyClueProducer<T> : DynamicsClueProducer<T> where T : RuntimeDependency
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RuntimeDependencyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DependencyId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=runtimedependency&id={1}", _dynamics365CrawlJobData.Api, input.DependencyId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.RuntimeDependency.DependencyId] = input.DependencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RuntimeDependency.DependentComponentNodeId] = input.DependentComponentNodeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RuntimeDependency.RequiredComponentNodeId] = input.RequiredComponentNodeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RuntimeDependency.DependentComponentType] = input.DependentComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RuntimeDependency.RequiredComponentType] = input.RequiredComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RuntimeDependency.CreatedTime] = input.CreatedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RuntimeDependency.RequiredComponentModifiedTime] = input.RequiredComponentModifiedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RuntimeDependency.IsPublished] = input.IsPublished.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

