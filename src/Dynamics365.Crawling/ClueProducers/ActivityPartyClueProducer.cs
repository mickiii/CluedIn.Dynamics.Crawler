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
    public class ActivityPartyClueProducer : DynamicsClueProducer<ActivityParty>
    {
        public ActivityPartyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {

        }
        public override Clue CreateClue(ActivityParty input, Guid accountId)
        {
            return _factory.Create(EntityType.Infrastructure.User, input.ActivityPartyId.ToString(), accountId);
        }

        public override void Customize(Clue clue, ActivityParty input)
        {
            var data = clue.Data.EntityData;

            data.Name = input.PartyIdName;
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

       }
    }
}

