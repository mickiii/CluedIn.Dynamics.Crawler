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
    public abstract class BusinessProcessFlowInstanceClueProducer<T> : DynamicsClueProducer<T> where T : BusinessProcessFlowInstance
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public BusinessProcessFlowInstanceClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.BusinessProcessFlowInstanceId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=businessprocessflowinstance&id={1}", _dynamics365CrawlJobData.Api, input.BusinessProcessFlowInstanceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);


            */
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.BusinessProcessFlowInstanceId] = input.BusinessProcessFlowInstanceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity1Id] = input.Entity1Id.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity1ObjectTypeCode] = input.Entity1ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity2Id] = input.Entity2Id.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity2ObjectTypeCode] = input.Entity2ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity3Id] = input.Entity3Id.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity3ObjectTypeCode] = input.Entity3ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity4Id] = input.Entity4Id.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity4ObjectTypeCode] = input.Entity4ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity5Id] = input.Entity5Id.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Entity5ObjectTypeCode] = input.Entity5ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ProcessStageId] = input.ProcessStageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ActiveStageStartedOn] = input.ActiveStageStartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.CompletedOn] = input.CompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessProcessFlowInstance.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

