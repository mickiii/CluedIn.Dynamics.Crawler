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
    public abstract class InvalidDependencyClueProducer<T> : DynamicsClueProducer<T> where T : InvalidDependency
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public InvalidDependencyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.InvalidDependencyId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=invaliddependency&id={1}", _dynamics365CrawlJobData.Api, input.InvalidDependencyId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.InvalidDependency.InvalidDependencyId] = input.InvalidDependencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.IsExistingNodeRequiredComponent] = input.IsExistingNodeRequiredComponent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.ExistingDependencyType] = input.ExistingDependencyType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.MissingComponentType] = input.MissingComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.MissingComponentId] = input.MissingComponentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.MissingComponentInfo] = input.MissingComponentInfo.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.MissingComponentLookupType] = input.MissingComponentLookupType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.ExistingComponentId] = input.ExistingComponentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.ExistingComponentType] = input.ExistingComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.ExistingDependencyTypeName] = input.ExistingDependencyTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.MissingComponentTypeName] = input.MissingComponentTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvalidDependency.ExistingComponentTypeName] = input.ExistingComponentTypeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

