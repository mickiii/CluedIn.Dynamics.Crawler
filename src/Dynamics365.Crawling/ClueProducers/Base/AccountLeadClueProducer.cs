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
    public abstract class AccountLeadClueProducer<T> : DynamicsClueProducer<T> where T: AccountLead
    {
        public AccountLeadClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {

        }
        public override Clue CreateClue(T input, Guid accountId)
        {
            return _factory.Create(EntityType.Sales.Lead, input.AccountLeadId.ToString(), accountId);
        }

        public override void Customize(Clue clue, T input)
        {
            var data = clue.Data.EntityData;

            data.Name = input.Name;

            if (input.AccountId != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.AttachedTo, input, input.AccountId.ToString());

            if (input.LeadId != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.AttachedTo, input, input.LeadId.ToString());

            var vocab = new AccountLeadVocabulary();

            data.Properties[vocab.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[vocab.AccountLeadId] = input.AccountLeadId.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.LeadId] = input.LeadId.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.TimezoneRuleVersionNumber] = input.TimezoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.UtcConversionTimezoneCode] = input.UtcConversionTimezoneCode.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
        }    
    }
}

