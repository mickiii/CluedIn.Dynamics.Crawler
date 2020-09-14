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
    public abstract class EmailClueProducer<T> : DynamicsClueProducer<T> where T : Email
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public EmailClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Mail, input.ActivityId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=email&id={1}", this._dynamics365CrawlJobData.Api, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;

            //if (input.ActivityId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ActivityId);

            //if (input.RegardingObjectId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.?, EntityEdgeType.Parent, input, input.RegardingObjectId);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            //if (input.EmailSender != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.EmailSender);

            if (input.EmailSender != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.EmailSender);

            //if (input.SLAInvokedId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            //if (input.SLAId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            //if (input.EmailSender != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.EmailSender);

            //if (input.EmailSender != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.EmailSender);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.SendersAccount != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.SendersAccount);

            if (input.EmailSender != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.EmailSender);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.EmailSender != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.EmailSender);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.SenderMailboxId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Mail.Folder, EntityEdgeType.Parent, input, input.SenderMailboxId);

            //if (input.ServiceId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ServiceId);

            //if (input.TemplateId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.template, EntityEdgeType.Parent, input, input.TemplateId);

            if (input.ParentActivityId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Mail, EntityEdgeType.Parent, input, input.ParentActivityId);

            data.Properties[Dynamics365Vocabulary.Email.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SubmittedBy] = input.SubmittedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.to] = input.to.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.MimeType] = input.MimeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ReadReceiptRequested] = input.ReadReceiptRequested.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.Subcategory] = input.Subcategory.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.from] = input.from.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.DirectionCode] = input.DirectionCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.TrackingToken] = input.TrackingToken.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.Category] = input.Category.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.bcc] = input.bcc.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.cc] = input.cc.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.Sender] = input.Sender.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ToRecipients] = input.ToRecipients.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.DeliveryReceiptRequested] = input.DeliveryReceiptRequested.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.MessageId] = input.MessageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.DeliveryReceiptRequestedName] = input.DeliveryReceiptRequestedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ReadReceiptRequestedName] = input.ReadReceiptRequestedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.DirectionCodeName] = input.DirectionCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.DeliveryAttempts] = input.DeliveryAttempts.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.MessageIdDupCheck] = input.MessageIdDupCheck.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.Compressed] = input.Compressed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.Notifications] = input.Notifications.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CompressedName] = input.CompressedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.NotificationsName] = input.NotificationsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailSender] = input.EmailSender.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailSenderName] = input.EmailSenderName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailSenderObjectTypeCode] = input.EmailSenderObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SendersAccount] = input.SendersAccount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SendersAccountObjectTypeCode] = input.SendersAccountObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.AttachmentCount] = input.AttachmentCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SenderMailboxId] = input.SenderMailboxId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SenderMailboxIdName] = input.SenderMailboxIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.DeliveryPriorityCode] = input.DeliveryPriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.DeliveryPriorityCodeName] = input.DeliveryPriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ParentActivityId] = input.ParentActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ParentActivityIdName] = input.ParentActivityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.InReplyTo] = input.InReplyTo.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.BaseConversationIndexHash] = input.BaseConversationIndexHash.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ConversationIndex] = input.ConversationIndex.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.CorrelationMethod] = input.CorrelationMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SentOn] = input.SentOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.PostponeEmailProcessingUntil] = input.PostponeEmailProcessingUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SafeDescription] = input.SafeDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsUnsafe] = input.IsUnsafe.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SendersAccountName] = input.SendersAccountName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SendersAccountYomiName] = input.SendersAccountYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailSenderYomiName] = input.EmailSenderYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.AttachmentOpenCount] = input.AttachmentOpenCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ConversationTrackingId] = input.ConversationTrackingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.DelayedEmailSendTime] = input.DelayedEmailSendTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.LastOpenedTime] = input.LastOpenedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.LinksClickedCount] = input.LinksClickedCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.OpenCount] = input.OpenCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ReplyCount] = input.ReplyCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailTrackingId] = input.EmailTrackingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.FollowEmailUserPreference] = input.FollowEmailUserPreference.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.FollowEmailUserPreferenceName] = input.FollowEmailUserPreferenceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsEmailFollowed] = input.IsEmailFollowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsEmailFollowedName] = input.IsEmailFollowedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailReminderExpiryTime] = input.EmailReminderExpiryTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailReminderType] = input.EmailReminderType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailReminderTypeName] = input.EmailReminderTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailReminderStatus] = input.EmailReminderStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailReminderStatusName] = input.EmailReminderStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.EmailReminderText] = input.EmailReminderText.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.TemplateId] = input.TemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.ReminderActionCardId] = input.ReminderActionCardId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.TemplateIdName] = input.TemplateIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.SortDate] = input.SortDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsEmailReminderSet] = input.IsEmailReminderSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Email.IsEmailReminderSetName] = input.IsEmailReminderSetName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

