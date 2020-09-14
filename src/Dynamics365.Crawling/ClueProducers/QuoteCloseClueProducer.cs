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
    public abstract class QuoteCloseClueProducer<T> : DynamicsClueProducer<T> where T : QuoteClose
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public QuoteCloseClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=quoteclose&id={1}", _dynamics365CrawlJobData.Api, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;
            /*
             if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CreatedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.CreatedByExternalParty);

                         if (input.ModifiedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.ModifiedByExternalParty);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.interactionforemail, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.SLAId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

                         if (input.SLAInvokedId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperation, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.QuoteId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.QuoteId);

                         if (input.SenderMailboxId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.SenderMailboxId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.site, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ServiceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ServiceId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.RegardingObjectId);


            */
            data.Properties[Dynamics365Vocabulary.QuoteClose.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Revision] = input.Revision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.QuoteId] = input.QuoteId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Subcategory] = input.Subcategory.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.QuoteNumber] = input.QuoteNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Category] = input.Category.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.QuoteIdName] = input.QuoteIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.QuoteIdType] = input.QuoteIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.InstanceTypeCode] = input.InstanceTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SeriesId] = input.SeriesId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.LeftVoiceMail] = input.LeftVoiceMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Community] = input.Community.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.IsMapiPrivate] = input.IsMapiPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ExchangeWebLink] = input.ExchangeWebLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ExchangeItemId] = input.ExchangeItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.DeliveryPriorityCode] = input.DeliveryPriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SentOn] = input.SentOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.DeliveryLastAttemptedOn] = input.DeliveryLastAttemptedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SenderMailboxId] = input.SenderMailboxId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.PostponeActivityProcessingUntil] = input.PostponeActivityProcessingUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SortDate] = input.SortDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.ServiceIdName] = input.ServiceIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.InstanceTypeCodeName] = input.InstanceTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.LeftVoiceMailName] = input.LeftVoiceMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CommunityName] = input.CommunityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.IsMapiPrivateName] = input.IsMapiPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.DeliveryPriorityCodeName] = input.DeliveryPriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SenderMailboxIdName] = input.SenderMailboxIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.From] = input.From.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.To] = input.To.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.CC] = input.CC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.BCC] = input.BCC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.RequiredAttendees] = input.RequiredAttendees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.OptionalAttendees] = input.OptionalAttendees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Organizer] = input.Organizer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Resources] = input.Resources.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Customers] = input.Customers.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteClose.Partners] = input.Partners.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

