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
    public abstract class TraceLogClueProducer<T> : DynamicsClueProducer<T> where T : TraceLog
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TraceLogClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TraceLogId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=tracelog&id={1}", _dynamics365CrawlJobData.Api, input.TraceLogId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Text;
            /*
             if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.emailserverprofile, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.TraceRegardingId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.traceregarding, EntityEdgeType.Parent, input, input.TraceRegardingId);

                         if (input.ParentTraceLogId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tracelog, EntityEdgeType.Parent, input, input.ParentTraceLogId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.TraceLog.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.Level] = input.Level.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.LevelName] = input.LevelName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.RegardingObjectOwnerId] = input.RegardingObjectOwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.RegardingObjectOwnerIdType] = input.RegardingObjectOwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.RegardingObjectOwningBusinessUnit] = input.RegardingObjectOwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.Text] = input.Text.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceCode] = input.TraceCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceLogId] = input.TraceLogId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceRegardingId] = input.TraceRegardingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceParameterXml] = input.TraceParameterXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.IsUnique] = input.IsUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ParentTraceLogId] = input.ParentTraceLogId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceParameterHash] = input.TraceParameterHash.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CollationLevel] = input.CollationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.IsUniqueName] = input.IsUniqueName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceDetailXml] = input.TraceDetailXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CanBeDeleted] = input.CanBeDeleted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.CanBeDeletedName] = input.CanBeDeletedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceActionXml] = input.TraceActionXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.MachineName] = input.MachineName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ErrorTypeDisplay] = input.ErrorTypeDisplay.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceStatus] = input.TraceStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.TraceStatusName] = input.TraceStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TraceLog.ErrorDetails] = input.ErrorDetails.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

