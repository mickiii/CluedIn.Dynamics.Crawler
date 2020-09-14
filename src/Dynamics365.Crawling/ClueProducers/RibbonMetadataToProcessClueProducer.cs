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
    public abstract class RibbonMetadataToProcessClueProducer<T> : DynamicsClueProducer<T> where T : RibbonMetadataToProcess
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RibbonMetadataToProcessClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RibbonMetadataRowId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=ribbonmetadatatoprocess&id={1}", _dynamics365CrawlJobData.Api, input.RibbonMetadataRowId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.RibbonMetadataRowId] = input.RibbonMetadataRowId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.EntityName] = input.EntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.RetryCount] = input.RetryCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.ProcessedOn] = input.ProcessedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.CompletedOn] = input.CompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.ExceptionMessage] = input.ExceptionMessage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonMetadataToProcess.IsDbUpdate] = input.IsDbUpdate.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

