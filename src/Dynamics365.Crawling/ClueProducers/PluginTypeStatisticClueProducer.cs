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
    public abstract class PluginTypeStatisticClueProducer<T> : DynamicsClueProducer<T> where T : PluginTypeStatistic
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PluginTypeStatisticClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PluginTypeStatisticId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=plugintypestatistic&id={1}", _dynamics365CrawlJobData.Api, input.PluginTypeStatisticId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.PluginTypeId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.plugintype, EntityEdgeType.Parent, input, input.PluginTypeId);


            */
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.PluginTypeStatisticId] = input.PluginTypeStatisticId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.PluginTypeId] = input.PluginTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.ExecuteCount] = input.ExecuteCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.FailureCount] = input.FailureCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CrashCount] = input.CrashCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.FailurePercent] = input.FailurePercent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CrashPercent] = input.CrashPercent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CrashContributionPercent] = input.CrashContributionPercent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.TerminateCpuContributionPercent] = input.TerminateCpuContributionPercent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.TerminateMemoryContributionPercent] = input.TerminateMemoryContributionPercent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.TerminateHandlesContributionPercent] = input.TerminateHandlesContributionPercent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.TerminateOtherContributionPercent] = input.TerminateOtherContributionPercent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.AverageExecuteTimeInMilliseconds] = input.AverageExecuteTimeInMilliseconds.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginTypeStatistic.PluginTypeIdName] = input.PluginTypeIdName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

