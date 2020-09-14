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
    public abstract class WorkflowLogClueProducer<T> : DynamicsClueProducer<T> where T : WorkflowLog
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public WorkflowLogClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.WorkflowLogId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=workflowlog&id={1}", _dynamics365CrawlJobData.Api, input.WorkflowLogId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.ChildWorkflowInstanceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.flowsession, EntityEdgeType.Parent, input, input.ChildWorkflowInstanceId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.flowsession, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.newprocess, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonetocaseprocess, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.expiredprocess, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.leadtoopportunitysalesprocess, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountplanningbpf, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processsession, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.ChildWorkflowInstanceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processsession, EntityEdgeType.Parent, input, input.ChildWorkflowInstanceId);

                         if (input.ChildWorkflowInstanceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.asyncoperation, EntityEdgeType.Parent, input, input.ChildWorkflowInstanceId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.asyncoperation, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_bpf_0b7ea545de274ec3ba678109f8d9f28c, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_bpf_7935ac28ccb54d34b25f4aa1f53c0111, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.translationprocess, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunitysalesprocess, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iottocaseprocess, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_bpf_dfc751aa1f3e47f583330ef7f904075e, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_bpf_c99fcd1f78374f328ef2c6cf84983cff, EntityEdgeType.Parent, input, input.AsyncOperationId);


            */
            data.Properties[Dynamics365Vocabulary.WorkflowLog.AsyncOperationId] = input.AsyncOperationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.CompletedOn] = input.CompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.WorkflowLogId] = input.WorkflowLogId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.Message] = input.Message.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.StageName] = input.StageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.StepName] = input.StepName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ErrorCode] = input.ErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ActivityName] = input.ActivityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.AsyncOperationIdName] = input.AsyncOperationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.StatusName] = input.StatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ChildWorkflowInstanceId] = input.ChildWorkflowInstanceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ChildWorkflowInstanceIdName] = input.ChildWorkflowInstanceIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ChildWorkflowInstanceObjectTypeCode] = input.ChildWorkflowInstanceObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.InteractionActivityResult] = input.InteractionActivityResult.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.StartedOn] = input.StartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.Duration] = input.Duration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.ErrorText] = input.ErrorText.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.Inputs_Name] = input.Inputs_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.Outputs_Name] = input.Outputs_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.IterationCount] = input.IterationCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.RepetitionCount] = input.RepetitionCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowLog.RepetitionId] = input.RepetitionId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

