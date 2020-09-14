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
    public abstract class BulkDeleteOperationClueProducer<T> : DynamicsClueProducer<T> where T : BulkDeleteOperation
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public BulkDeleteOperationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.BulkDeleteOperationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=bulkdeleteoperation&id={1}", _dynamics365CrawlJobData.Api, input.BulkDeleteOperationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.asyncoperation, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);


            */
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.BulkDeleteOperationId] = input.BulkDeleteOperationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.IsRecurring] = input.IsRecurring.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.ProcessingQEIndex] = input.ProcessingQEIndex.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.AsyncOperationId] = input.AsyncOperationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.OrderedQuerySetXml] = input.OrderedQuerySetXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.FailureCount] = input.FailureCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.NextRun] = input.NextRun.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.SuccessCount] = input.SuccessCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.IsRecurringName] = input.IsRecurringName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkDeleteOperation.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

