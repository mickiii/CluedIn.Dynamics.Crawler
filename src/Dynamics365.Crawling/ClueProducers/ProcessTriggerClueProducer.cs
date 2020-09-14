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
    public abstract class ProcessTriggerClueProducer<T> : DynamicsClueProducer<T> where T : ProcessTrigger
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ProcessTriggerClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ProcessTriggerId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=processtrigger&id={1}", _dynamics365CrawlJobData.Api, input.ProcessTriggerId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.FormId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemform, EntityEdgeType.Parent, input, input.FormId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ProcessId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.ProcessId);


            */
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.Event] = input.Event.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ControlName] = input.ControlName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ControlType] = input.ControlType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ControlTypeName] = input.ControlTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.FormIdName] = input.FormIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.FormId] = input.FormId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.PrimaryEntityTypeCode] = input.PrimaryEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ProcessTriggerIdUnique] = input.ProcessTriggerIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ProcessTriggerId] = input.ProcessTriggerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ProcessIdName] = input.ProcessIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.PrimaryEntityTypeCodeName] = input.PrimaryEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.MethodId] = input.MethodId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.Scope] = input.Scope.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessTrigger.PipelineStage] = input.PipelineStage.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

