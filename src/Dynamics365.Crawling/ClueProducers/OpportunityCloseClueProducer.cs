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
    public abstract class OpportunityCloseClueProducer<T> : DynamicsClueProducer<T> where T : OpportunityClose
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public OpportunityCloseClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=opportunityclose&id={1}", _dynamics365CrawlJobData.Api, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;
            /*
             if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ModifiedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.ModifiedByExternalParty);

                         if (input.CreatedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.CreatedByExternalParty);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.interactionforemail, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CompetitorId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.CompetitorId);

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

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.SenderMailboxId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.SenderMailboxId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OpportunityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.OpportunityId);

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
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActualRevenue] = input.ActualRevenue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CompetitorId] = input.CompetitorId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Category] = input.Category.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Subcategory] = input.Subcategory.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OpportunityIdName] = input.OpportunityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CompetitorIdName] = input.CompetitorIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActualRevenue_Base] = input.ActualRevenue_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OpportunityIdType] = input.OpportunityIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CompetitorIdYomiName] = input.CompetitorIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.InstanceTypeCode] = input.InstanceTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SeriesId] = input.SeriesId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.LeftVoiceMail] = input.LeftVoiceMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Community] = input.Community.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.IsMapiPrivate] = input.IsMapiPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ExchangeWebLink] = input.ExchangeWebLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ExchangeItemId] = input.ExchangeItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.DeliveryPriorityCode] = input.DeliveryPriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SentOn] = input.SentOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.DeliveryLastAttemptedOn] = input.DeliveryLastAttemptedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SenderMailboxId] = input.SenderMailboxId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.PostponeActivityProcessingUntil] = input.PostponeActivityProcessingUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SortDate] = input.SortDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.ServiceIdName] = input.ServiceIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.InstanceTypeCodeName] = input.InstanceTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.LeftVoiceMailName] = input.LeftVoiceMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CommunityName] = input.CommunityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.IsMapiPrivateName] = input.IsMapiPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.DeliveryPriorityCodeName] = input.DeliveryPriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SenderMailboxIdName] = input.SenderMailboxIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.From] = input.From.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.To] = input.To.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.CC] = input.CC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.BCC] = input.BCC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.RequiredAttendees] = input.RequiredAttendees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OptionalAttendees] = input.OptionalAttendees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Organizer] = input.Organizer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Resources] = input.Resources.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Customers] = input.Customers.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.Partners] = input.Partners.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OpportunityStatusCode] = input.OpportunityStatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.opportunitystatuscodeName] = input.opportunitystatuscodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.OpportunityStateCode] = input.OpportunityStateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityClose.opportunitystatecodeName] = input.opportunitystatecodeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

