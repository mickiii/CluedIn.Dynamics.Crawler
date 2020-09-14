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
    public abstract class GlobalSearchConfigurationClueProducer<T> : DynamicsClueProducer<T> where T : GlobalSearchConfiguration
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public GlobalSearchConfigurationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.GlobalSearchConfigurationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=globalsearchconfiguration&id={1}", _dynamics365CrawlJobData.Api, input.GlobalSearchConfigurationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.GlobalSearchConfigurationId] = input.GlobalSearchConfigurationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.SearchProviderName] = input.SearchProviderName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.SearchProviderResultsPage] = input.SearchProviderResultsPage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.IsLocalized] = input.IsLocalized.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.IsEnabled] = input.IsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.IsSearchBoxVisible] = input.IsSearchBoxVisible.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.GlobalSearchConfigurationidUnique] = input.GlobalSearchConfigurationidUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.GlobalSearchConfiguration.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

