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
    public abstract class DependencyClueProducer<T> : DynamicsClueProducer<T> where T : Dependency
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DependencyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=dependency&id={1}", _dynamics365CrawlJobData.Api, input.DependencyId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.DependentComponentNodeId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dependencynode, EntityEdgeType.Parent, input, input.DependentComponentNodeId);

                         if (input.RequiredComponentNodeId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dependencynode, EntityEdgeType.Parent, input, input.RequiredComponentNodeId);


            */
            data.Properties[Dynamics365Vocabulary.Dependency.DependencyId] = input.DependencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.DependencyType] = input.DependencyType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.RequiredComponentNodeId] = input.RequiredComponentNodeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.RequiredComponentObjectId] = input.RequiredComponentObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.RequiredComponentType] = input.RequiredComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.RequiredComponentBaseSolutionId] = input.RequiredComponentBaseSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.RequiredComponentParentId] = input.RequiredComponentParentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.DependentComponentNodeId] = input.DependentComponentNodeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.DependentComponentObjectId] = input.DependentComponentObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.DependentComponentType] = input.DependentComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.DependentComponentBaseSolutionId] = input.DependentComponentBaseSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.DependentComponentParentId] = input.DependentComponentParentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.DependencyTypeName] = input.DependencyTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.RequiredComponentTypeName] = input.RequiredComponentTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.DependentComponentTypeName] = input.DependentComponentTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.RequiredComponentIntroducedVersion] = input.RequiredComponentIntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Dependency.VersionNumber] = input.VersionNumber.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

