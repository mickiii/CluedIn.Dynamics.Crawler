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
    public abstract class WorkflowClueProducer<T> : DynamicsClueProducer<T> where T : Workflow
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public WorkflowClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.WorkflowId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=workflow&id={1}", _dynamics365CrawlJobData.Api, input.WorkflowId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ParentWorkflowId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.ParentWorkflowId);

                         if (input.ActiveWorkflowId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.ActiveWorkflowId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);


            */
            data.Properties[Dynamics365Vocabulary.Workflow.OnDemand] = input.OnDemand.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.PluginTypeId] = input.PluginTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Type] = input.Type.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.WorkflowId] = input.WorkflowId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ActiveWorkflowId] = input.ActiveWorkflowId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ParentWorkflowId] = input.ParentWorkflowId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.UIData] = input.UIData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.PrimaryEntity] = input.PrimaryEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.AsyncAutoDelete] = input.AsyncAutoDelete.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.IsCrmUIWorkflow] = input.IsCrmUIWorkflow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Subprocess] = input.Subprocess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Scope] = input.Scope.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ScopeName] = input.ScopeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ParentWorkflowIdName] = input.ParentWorkflowIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.TypeName] = input.TypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ActiveWorkflowIdName] = input.ActiveWorkflowIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OwningBusinessUnitName] = input.OwningBusinessUnitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.PrimaryEntityName] = input.PrimaryEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.WorkflowIdUnique] = input.WorkflowIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Xaml] = input.Xaml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.TriggerOnDelete] = input.TriggerOnDelete.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.RendererObjectTypeCode] = input.RendererObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.TriggerOnCreate] = input.TriggerOnCreate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.TriggerOnUpdateAttributeList] = input.TriggerOnUpdateAttributeList.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Category] = input.Category.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.LanguageCode] = input.LanguageCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CategoryName] = input.CategoryName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.InputParameters] = input.InputParameters.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.AsyncAutoDeleteName] = input.AsyncAutoDeleteName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.OnDemandName] = input.OnDemandName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.SubprocessName] = input.SubprocessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.TriggerOnCreateName] = input.TriggerOnCreateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.TriggerOnDeleteName] = input.TriggerOnDeleteName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ClientData] = input.ClientData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreateStage] = input.CreateStage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.UpdateStage] = input.UpdateStage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.DeleteStage] = input.DeleteStage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.CreateStageName] = input.CreateStageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.UpdateStageName] = input.UpdateStageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.DeleteStageName] = input.DeleteStageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Rank] = input.Rank.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.RunAs] = input.RunAs.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.RunAsName] = input.RunAsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.SyncWorkflowLogOnFailure] = input.SyncWorkflowLogOnFailure.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.SyncWorkflowLogOnFailureName] = input.SyncWorkflowLogOnFailureName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.UniqueName] = input.UniqueName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.IsTransacted] = input.IsTransacted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.IsTransactedName] = input.IsTransactedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.SdkMessageId] = input.SdkMessageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ProcessOrder] = input.ProcessOrder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.Mode] = input.Mode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ModeName] = input.ModeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ProcessRoleAssignment] = input.ProcessRoleAssignment.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.FormId] = input.FormId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.BusinessProcessType] = input.BusinessProcessType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.BusinessProcessTypeName] = input.BusinessProcessTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.UIFlowType] = input.UIFlowType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.UIFlowTypeName] = input.UIFlowTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ProcessTriggerFormId] = input.ProcessTriggerFormId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ProcessTriggerScope] = input.ProcessTriggerScope.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Workflow.ProcessTriggerScopeName] = input.ProcessTriggerScopeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

