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
    public abstract class IncidentResolutionClueProducer<T> : DynamicsClueProducer<T> where T : IncidentResolution
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public IncidentResolutionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=incidentresolution&id={1}", _dynamics365CrawlJobData.Api, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
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

                         if (input.IncidentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.IncidentId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.SenderMailboxId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.SenderMailboxId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.ServiceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ServiceId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.RegardingObjectId);


            */
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Category] = input.Category.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.TimeSpent] = input.TimeSpent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IncidentId] = input.IncidentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Subcategory] = input.Subcategory.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IncidentIdName] = input.IncidentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IncidentIdType] = input.IncidentIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.LeftVoiceMail] = input.LeftVoiceMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IsMapiPrivate] = input.IsMapiPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.DeliveryLastAttemptedOn] = input.DeliveryLastAttemptedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.PostponeActivityProcessingUntil] = input.PostponeActivityProcessingUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SentOn] = input.SentOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SortDate] = input.SortDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ExchangeWebLink] = input.ExchangeWebLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ExchangeItemId] = input.ExchangeItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SeriesId] = input.SeriesId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.DeliveryPriorityCode] = input.DeliveryPriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.InstanceTypeCode] = input.InstanceTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Community] = input.Community.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SenderMailboxId] = input.SenderMailboxId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SenderMailboxIdName] = input.SenderMailboxIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.LeftVoiceMailName] = input.LeftVoiceMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.IsMapiPrivateName] = input.IsMapiPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.DeliveryPriorityCodeName] = input.DeliveryPriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CommunityName] = input.CommunityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.InstanceTypeCodeName] = input.InstanceTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.From] = input.From.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.To] = input.To.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.CC] = input.CC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.BCC] = input.BCC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.RequiredAttendees] = input.RequiredAttendees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.OptionalAttendees] = input.OptionalAttendees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Organizer] = input.Organizer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Resources] = input.Resources.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Customers] = input.Customers.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.IncidentResolution.Partners] = input.Partners.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

