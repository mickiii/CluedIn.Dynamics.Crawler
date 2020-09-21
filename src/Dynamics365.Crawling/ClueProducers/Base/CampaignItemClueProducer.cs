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
    public abstract class CampaignItemClueProducer<T> : DynamicsClueProducer<T> where T : CampaignItem
    {

        public CampaignItemClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {

        }

        public override Clue CreateClue(T input, Guid accountId)
        {
            return _factory.Create("/CampaignItem", input.CampaignItemId.ToString(), accountId);
        }

        public override void Customize(Clue clue, T input)
        {
            var data = clue.Data.EntityData;

            data.Name = input.Name;

            if (input.EntityId != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input, input.EntityId.ToString());

            if (input.OwningUser != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser.ToString());

            if (input.OwningBusinessUnit != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit.ToString());

            var vocab = new CampaignItemVocabulary();

            data.Properties[vocab.CampaignItemId] = input.CampaignItemId.PrintIfAvailable();
            data.Properties[vocab.EntityId] = input.EntityId.PrintIfAvailable();
            data.Properties[vocab.EntityType] = input.EntityType.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.TimezoneRuleVersionNumber] = input.TimezoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.UtcConversionTimezoneCode] = input.UtcConversionTimezoneCode.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
        }
    }
}

