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
    public abstract class WorkflowWaitSubscriptionClueProducer<T> : DynamicsClueProducer<T> where T : WorkflowWaitSubscription
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public WorkflowWaitSubscriptionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.WorkflowWaitSubscriptionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=workflowwaitsubscription&id={1}", _dynamics365CrawlJobData.Api, input.WorkflowWaitSubscriptionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.asyncoperation, EntityEdgeType.Parent, input, input.AsyncOperationId);


            */
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.EntityId] = input.EntityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.WorkflowWaitSubscriptionId] = input.WorkflowWaitSubscriptionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.AsyncOperationId] = input.AsyncOperationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.Data] = input.Data.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.EntityName] = input.EntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.IsModified] = input.IsModified.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.IsDeleted] = input.IsDeleted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowWaitSubscription.WaitOnAttributeList] = input.WaitOnAttributeList.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

