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
    public abstract class BulkOperationClueProducer<T> : DynamicsClueProducer<T> where T : BulkOperation
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public BulkOperationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ActivityId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=bulkoperation&id={1}", _dynamics365CrawlJobData.Api, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;
            /*
             if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.list, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.interactionforemail, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.SLAId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

                         if (input.SLAInvokedId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.SenderMailboxId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.SenderMailboxId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.BulkOperation.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.TargetedRecordTypeCode] = input.TargetedRecordTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedRecordTypeCode] = input.CreatedRecordTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.Parameters] = input.Parameters.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ErrorNumber] = input.ErrorNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.BulkOperationNumber] = input.BulkOperationNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OperationTypeCode] = input.OperationTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.TargetMembersCount] = input.TargetMembersCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SuccessCount] = input.SuccessCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.FailureCount] = input.FailureCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OperationTypeCodeName] = input.OperationTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedRecordTypeCodeName] = input.CreatedRecordTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.TargetedRecordTypeCodeName] = input.TargetedRecordTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.LeftVoiceMail] = input.LeftVoiceMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.IsMapiPrivate] = input.IsMapiPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.DeliveryLastAttemptedOn] = input.DeliveryLastAttemptedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.PostponeActivityProcessingUntil] = input.PostponeActivityProcessingUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SentOn] = input.SentOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SortDate] = input.SortDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ExchangeWebLink] = input.ExchangeWebLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ExchangeItemId] = input.ExchangeItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SeriesId] = input.SeriesId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.DeliveryPriorityCode] = input.DeliveryPriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.InstanceTypeCode] = input.InstanceTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.Community] = input.Community.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SenderMailboxId] = input.SenderMailboxId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SenderMailboxIdName] = input.SenderMailboxIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.LeftVoiceMailName] = input.LeftVoiceMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.IsMapiPrivateName] = input.IsMapiPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.DeliveryPriorityCodeName] = input.DeliveryPriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CommunityName] = input.CommunityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.InstanceTypeCodeName] = input.InstanceTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.from] = input.from.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.To] = input.To.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.CC] = input.CC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.BCC] = input.BCC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.RequiredAttendees] = input.RequiredAttendees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.OptionalAttendees] = input.OptionalAttendees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.Organizer] = input.Organizer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.Resources] = input.Resources.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.Customers] = input.Customers.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.Partners] = input.Partners.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BulkOperation.WorkflowInfo] = input.WorkflowInfo.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

