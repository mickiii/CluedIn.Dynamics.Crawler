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
    public abstract class WorkflowDependencyClueProducer<T> : DynamicsClueProducer<T> where T : WorkflowDependency
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public WorkflowDependencyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.WorkflowDependencyId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=workflowdependency&id={1}", _dynamics365CrawlJobData.Api, input.WorkflowDependencyId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.SdkMessageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sdkmessage, EntityEdgeType.Parent, input, input.SdkMessageId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.WorkflowId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.WorkflowId);


            */
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ParameterName] = input.ParameterName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.RelatedEntityName] = input.RelatedEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.RelatedAttributeName] = input.RelatedAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.WorkflowId] = input.WorkflowId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.SdkMessageId] = input.SdkMessageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.Type] = input.Type.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.EntityAttributes] = input.EntityAttributes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.CustomEntityName] = input.CustomEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.DependentEntityName] = input.DependentEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.DependentAttributeName] = input.DependentAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.WorkflowDependencyId] = input.WorkflowDependencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ParameterType] = input.ParameterType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.TypeName] = input.TypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.WorkflowDependency.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

