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
    public abstract class BulkOperationLogClueProducer<T> : DynamicsClueProducer<T> where T : BulkOperationLog
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public BulkOperationLogClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.BulkOperationLogId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=bulkoperationlog&id={1}", _dynamics365CrawlJobData.Api, input.BulkOperationLogId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.BulkOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.BulkOperationId);

                         if (input.CreatedObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.CreatedObjectId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CreatedObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.CreatedObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CreatedObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.CreatedObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CreatedObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.CreatedObjectId);

                         if (input.BulkOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperation, EntityEdgeType.Parent, input, input.BulkOperationId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.CreatedObjectId);

                         if (input.CampaignActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.CampaignActivityId);


            */
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.ErrorNumber] = input.ErrorNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.CreatedObjectId] = input.CreatedObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.BulkOperationLogId] = input.BulkOperationLogId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.BulkOperationId] = input.BulkOperationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.AdditionalInfo] = input.AdditionalInfo.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.BulkOperationIdName] = input.BulkOperationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.RegardingObjectIdTypeCode] = input.RegardingObjectIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.CreatedObjectIdName] = input.CreatedObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.CreatedObjectIdTypeCode] = input.CreatedObjectIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.ErrorDescriptionFormatted] = input.ErrorDescriptionFormatted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.ErrorNumberFormatted] = input.ErrorNumberFormatted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.CampaignActivityId] = input.CampaignActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.CampaignActivityIdType] = input.CampaignActivityIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.CampaignActivityIdName] = input.CampaignActivityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperationLog.CampaignActivityIdYomiName] = input.CampaignActivityIdYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

