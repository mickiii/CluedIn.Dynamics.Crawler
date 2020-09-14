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
    public abstract class SavedOrgInsightsConfigurationClueProducer<T> : DynamicsClueProducer<T> where T : SavedOrgInsightsConfiguration
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SavedOrgInsightsConfigurationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SavedOrgInsightsConfigurationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=savedorginsightsconfiguration&id={1}", _dynamics365CrawlJobData.Api, input.SavedOrgInsightsConfigurationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.SavedOrgInsightsConfigurationId] = input.SavedOrgInsightsConfigurationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.PlotOption] = input.PlotOption.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.PlotOptionName] = input.PlotOptionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.Lookback] = input.Lookback.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.LookbackName] = input.LookbackName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.Parameters] = input.Parameters.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.MetricType] = input.MetricType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.MetricTypeName] = input.MetricTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.JsonData] = input.JsonData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.IsDrilldown] = input.IsDrilldown.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.IsDrilldownName] = input.IsDrilldownName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.JsonDataStartTime] = input.JsonDataStartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedOrgInsightsConfiguration.JsonDataEndTime] = input.JsonDataEndTime.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

