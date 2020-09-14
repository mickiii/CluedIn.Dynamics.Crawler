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
    public abstract class DependencyNodeClueProducer<T> : DynamicsClueProducer<T> where T : DependencyNode
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DependencyNodeClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DependencyNodeId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=dependencynode&id={1}", _dynamics365CrawlJobData.Api, input.DependencyNodeId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.BaseSolutionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solution, EntityEdgeType.Parent, input, input.BaseSolutionId);

                         if (input.TopSolutionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solution, EntityEdgeType.Parent, input, input.TopSolutionId);


            */
            data.Properties[Dynamics365Vocabulary.DependencyNode.DependencyNodeId] = input.DependencyNodeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.ComponentType] = input.ComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.BaseSolutionId] = input.BaseSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.TopSolutionId] = input.TopSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.ParentId] = input.ParentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.ComponentTypeName] = input.ComponentTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.IsSharedComponent] = input.IsSharedComponent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DependencyNode.VersionNumber] = input.VersionNumber.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

