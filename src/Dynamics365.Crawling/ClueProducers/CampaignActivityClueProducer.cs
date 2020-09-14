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
    public abstract class CampaignActivityClueProducer<T> : DynamicsClueProducer<T> where T : CampaignActivity
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CampaignActivityClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Activity, input.ActivityId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=campaignactivity&id={1}", this._dynamics365CrawlJobData.Api, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;

            //if (input.ActivityId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ActivityId);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.OwnedBy, input, input.OwningTeam);

            //if (input.SLAId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            //if (input.SLAInvokedId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            if (input.RegardingObjectId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Marketing.Campaign, EntityEdgeType.Parent, input, input.RegardingObjectId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            //if (input.RegardingObjectId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.RegardingObjectId);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            //if (input.RegardingObjectId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.RegardingObjectId);

            if (input.SenderMailboxId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Mail.Folder, EntityEdgeType.Parent, input, input.SenderMailboxId);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            var vocab = new CampaignActivityVocabulary();

            data.Properties[vocab.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[vocab.IgnoreInactiveListMembers] = input.IgnoreInactiveListMembers.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.ActualCost] = input.ActualCost.PrintIfAvailable();
            data.Properties[vocab.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[vocab.ChannelTypeCode] = input.ChannelTypeCode.PrintIfAvailable();
            data.Properties[vocab.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[vocab.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[vocab.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.BudgetedCost] = input.BudgetedCost.PrintIfAvailable();
            data.Properties[vocab.TypeCode] = input.TypeCode.PrintIfAvailable();
            data.Properties[vocab.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[vocab.Partners] = input.Partners.PrintIfAvailable();
            data.Properties[vocab.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[vocab.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[vocab.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[vocab.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[vocab.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[vocab.ExcludeIfContactedInXDays] = input.ExcludeIfContactedInXDays.PrintIfAvailable();
            data.Properties[vocab.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[vocab.Category] = input.Category.PrintIfAvailable();
            data.Properties[vocab.DoNotSendOnOptOut] = input.DoNotSendOnOptOut.PrintIfAvailable();
            data.Properties[vocab.Subcategory] = input.Subcategory.PrintIfAvailable();
            data.Properties[vocab.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[vocab.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[vocab.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[vocab.From] = input.from.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.ChannelTypeCodeName] = input.ChannelTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[vocab.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[vocab.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[vocab.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[vocab.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[vocab.CheckForDoNotSendMMOnListMembersName] = input.CheckForDoNotSendMMOnListMembersName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[vocab.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[vocab.IgnoreInactiveListMembersName] = input.IgnoreInactiveListMembersName.PrintIfAvailable();
            data.Properties[vocab.TypeCodeName] = input.TypeCodeName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[vocab.BudgetedCost_Base] = input.BudgetedCost_Base.PrintIfAvailable();
            data.Properties[vocab.ActualCost_Base] = input.ActualCost_Base.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[vocab.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[vocab.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[vocab.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[vocab.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[vocab.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[vocab.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[vocab.LeftVoiceMail] = input.LeftVoiceMail.PrintIfAvailable();
            data.Properties[vocab.IsMapiPrivate] = input.IsMapiPrivate.PrintIfAvailable();
            data.Properties[vocab.DeliveryLastAttemptedOn] = input.DeliveryLastAttemptedOn.PrintIfAvailable();
            data.Properties[vocab.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[vocab.PostponeActivityProcessingUntil] = input.PostponeActivityProcessingUntil.PrintIfAvailable();
            data.Properties[vocab.SentOn] = input.SentOn.PrintIfAvailable();
            data.Properties[vocab.SortDate] = input.SortDate.PrintIfAvailable();
            data.Properties[vocab.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[vocab.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[vocab.ExchangeWebLink] = input.ExchangeWebLink.PrintIfAvailable();
            data.Properties[vocab.ExchangeItemId] = input.ExchangeItemId.PrintIfAvailable();
            data.Properties[vocab.SeriesId] = input.SeriesId.PrintIfAvailable();
            data.Properties[vocab.DeliveryPriorityCode] = input.DeliveryPriorityCode.PrintIfAvailable();
            data.Properties[vocab.InstanceTypeCode] = input.InstanceTypeCode.PrintIfAvailable();
            data.Properties[vocab.Community] = input.Community.PrintIfAvailable();
            data.Properties[vocab.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[vocab.SenderMailboxId] = input.SenderMailboxId.PrintIfAvailable();
            data.Properties[vocab.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[vocab.SenderMailboxIdName] = input.SenderMailboxIdName.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[vocab.LeftVoiceMailName] = input.LeftVoiceMailName.PrintIfAvailable();
            data.Properties[vocab.IsMapiPrivateName] = input.IsMapiPrivateName.PrintIfAvailable();
            data.Properties[vocab.DeliveryPriorityCodeName] = input.DeliveryPriorityCodeName.PrintIfAvailable();
            data.Properties[vocab.CommunityName] = input.CommunityName.PrintIfAvailable();
            data.Properties[vocab.InstanceTypeCodeName] = input.InstanceTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.To] = input.To.PrintIfAvailable();
            data.Properties[vocab.CC] = input.CC.PrintIfAvailable();
            data.Properties[vocab.BCC] = input.BCC.PrintIfAvailable();
            data.Properties[vocab.RequiredAttendees] = input.RequiredAttendees.PrintIfAvailable();
            data.Properties[vocab.OptionalAttendees] = input.OptionalAttendees.PrintIfAvailable();
            data.Properties[vocab.Organizer] = input.Organizer.PrintIfAvailable();
            data.Properties[vocab.Resources] = input.Resources.PrintIfAvailable();
            data.Properties[vocab.Customers] = input.Customers.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

