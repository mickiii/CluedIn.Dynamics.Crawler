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
    public abstract class MailboxStatisticsClueProducer<T> : DynamicsClueProducer<T> where T : MailboxStatistics
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public MailboxStatisticsClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.MailboxStatisticsId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=mailboxstatistics&id={1}", _dynamics365CrawlJobData.Api, input.MailboxStatisticsId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.MailboxId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.MailboxId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.MailboxStatisticsId] = input.MailboxStatisticsId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.MailboxId] = input.MailboxId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.OperationTypeId] = input.OperationTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.ItemsProcessed] = input.ItemsProcessed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.ItemsFailed] = input.ItemsFailed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.ProcessResult] = input.ProcessResult.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.MailboxProcessScheduledOn] = input.MailboxProcessScheduledOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.MachineName] = input.MachineName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.MailboxProcessStartedOn] = input.MailboxProcessStartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.CrmItemsBacklog] = input.CrmItemsBacklog.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.MailboxProcessCompletedOn] = input.MailboxProcessCompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.IndividualStepDurations] = input.IndividualStepDurations.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.ScheduledTimeIntervalInMinutes] = input.ScheduledTimeIntervalInMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.ProcessTimeIntervalInMinutes] = input.ProcessTimeIntervalInMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.ProcessResultName] = input.ProcessResultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.OperationTypeIdName] = input.OperationTypeIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxStatistics.AsyncEventId] = input.AsyncEventId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

