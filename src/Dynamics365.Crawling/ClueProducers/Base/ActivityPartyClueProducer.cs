using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class ActivityPartyClueProducer<T> : DynamicsClueProducer<T> where T : ActivityParty
    {
        public ActivityPartyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {

        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Unknown, input.ActivityPartyId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=activityparty&id={1}", _dynamics365CrawlJobData.Url, input.ActivityPartyId.ToString()), UriKind.Absolute, out Uri uri))
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

            var vocab = new ActivityPartyVocabulary();

            data.Properties[vocab.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[vocab.ActivityPartyId] = input.ActivityPartyId.PrintIfAvailable();
            data.Properties[vocab.PartyId] = input.PartyId.PrintIfAvailable();
            data.Properties[vocab.PartyObjectTypeCode] = input.PartyObjectTypeCode.PrintIfAvailable();
            data.Properties[vocab.ParticipationTypeMask] = input.ParticipationTypeMask.PrintIfAvailable();
            data.Properties[vocab.AddressUsed] = input.AddressUsed.PrintIfAvailable();
            data.Properties[vocab.PartyIdName] = input.PartyIdName.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.DoNotFax] = input.DoNotFax.PrintIfAvailable();
            data.Properties[vocab.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[vocab.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[vocab.Effort] = input.Effort.PrintIfAvailable();
            data.Properties[vocab.DoNotEmail] = input.DoNotEmail.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.ExchangeEntryId] = input.ExchangeEntryId.PrintIfAvailable();
            data.Properties[vocab.ResourceSpecId] = input.ResourceSpecId.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.ResourceSpecIdName] = input.ResourceSpecIdName.PrintIfAvailable();
            data.Properties[vocab.DoNotFaxName] = input.DoNotFaxName.PrintIfAvailable();
            data.Properties[vocab.DoNotEmailName] = input.DoNotEmailName.PrintIfAvailable();
            data.Properties[vocab.ParticipationTypeMaskName] = input.ParticipationTypeMaskName.PrintIfAvailable();
            data.Properties[vocab.DoNotPostalMail] = input.DoNotPostalMail.PrintIfAvailable();
            data.Properties[vocab.DoNotPhone] = input.DoNotPhone.PrintIfAvailable();
            data.Properties[vocab.DoNotPhoneName] = input.DoNotPhoneName.PrintIfAvailable();
            data.Properties[vocab.DoNotPostalMailName] = input.DoNotPostalMailName.PrintIfAvailable();
            data.Properties[vocab.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[vocab.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[vocab.InstanceTypeCode] = input.InstanceTypeCode.PrintIfAvailable();
            data.Properties[vocab.InstanceTypeCodeName] = input.InstanceTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.IsPartyDeleted] = input.IsPartyDeleted.PrintIfAvailable();
            data.Properties[vocab.IsPartyDeletedName] = input.IsPartyDeletedName.PrintIfAvailable();
            data.Properties[vocab.AddressUsedEmailColumnNumber] = input.AddressUsedEmailColumnNumber.PrintIfAvailable();

            // Add custom vocabulary
            foreach (var key in input.Custom.Keys)
            {
                var vocabName = $"{vocab.KeyPrefix}{vocab.KeySeparator}{key}";
                var vocabKey = new VocabularyKey(vocabName, VocabularyKeyDataType.Json, VocabularyKeyVisibility.Visible);
                data.Properties[vocabKey] = input.Custom[key].ToString().PrintIfAvailable();
            }

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

