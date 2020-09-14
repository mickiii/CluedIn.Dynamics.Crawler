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
    public abstract class ActivityPartyClueProducer<T> : DynamicsClueProducer<T> where T : ActivityParty
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ActivityPartyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ActivityPartyId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=activityparty&id={1}", _dynamics365CrawlJobData.Api, input.ActivityPartyId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.PartyIdName;
            /*
             if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quoteclose, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceappointment, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incidentresolution, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignresponse, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_activity_request, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunityclose, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_inmail, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_message, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_pointdrivepresentationviewed, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperation, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_txtmessage, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.orderclose, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ResourceSpecId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcespec, EntityEdgeType.Parent, input, input.ResourceSpecId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.PartyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.PartyId);

                         if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.ActivityId);


            */
            data.Properties[Dynamics365Vocabulary.ActivityParty.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.ActivityPartyId] = input.ActivityPartyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.PartyId] = input.PartyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.PartyObjectTypeCode] = input.PartyObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.ParticipationTypeMask] = input.ParticipationTypeMask.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.AddressUsed] = input.AddressUsed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.PartyIdName] = input.PartyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.DoNotFax] = input.DoNotFax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.Effort] = input.Effort.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.DoNotEmail] = input.DoNotEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.ExchangeEntryId] = input.ExchangeEntryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.ResourceSpecId] = input.ResourceSpecId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.ResourceSpecIdName] = input.ResourceSpecIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.DoNotFaxName] = input.DoNotFaxName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.DoNotEmailName] = input.DoNotEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.ParticipationTypeMaskName] = input.ParticipationTypeMaskName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.DoNotPostalMail] = input.DoNotPostalMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.DoNotPhone] = input.DoNotPhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.DoNotPhoneName] = input.DoNotPhoneName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.DoNotPostalMailName] = input.DoNotPostalMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.InstanceTypeCode] = input.InstanceTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.InstanceTypeCodeName] = input.InstanceTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.IsPartyDeleted] = input.IsPartyDeleted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.IsPartyDeletedName] = input.IsPartyDeletedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityParty.AddressUsedEmailColumnNumber] = input.AddressUsedEmailColumnNumber.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

