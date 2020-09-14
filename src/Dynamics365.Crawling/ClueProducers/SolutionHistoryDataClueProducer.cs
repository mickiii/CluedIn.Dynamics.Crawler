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
    public abstract class SolutionHistoryDataClueProducer<T> : DynamicsClueProducer<T> where T : SolutionHistoryData
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SolutionHistoryDataClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SolutionHistoryDataId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=solutionhistorydata&id={1}", _dynamics365CrawlJobData.Api, input.SolutionHistoryDataId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.SolutionHistoryDataId] = input.SolutionHistoryDataId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.StartTime] = input.StartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.EndTime] = input.EndTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.Operation] = input.Operation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.SubOperation] = input.SubOperation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.SolutionName] = input.SolutionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.SolutionVersion] = input.SolutionVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.Result] = input.Result.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.ErrorCode] = input.ErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.ExceptionMessage] = input.ExceptionMessage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.ExceptionStack] = input.ExceptionStack.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.CorrelationId] = input.CorrelationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.IsPatch] = input.IsPatch.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.IsOverwriteCustomizations] = input.IsOverwriteCustomizations.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.IsMicrosoftPublisher] = input.IsMicrosoftPublisher.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.PublisherName] = input.PublisherName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.PackageName] = input.PackageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionHistoryData.PackageVersion] = input.PackageVersion.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

