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
    public class AccountLeadClueProducer : DynamicsClueProducer<AccountLead>
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AccountLeadClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            _factory = factory;

            _dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        public override void Customize(Clue clue, AccountLead input)
        {
            foreach (var key in input.Custom.Keys)
            {
                clue.Data.EntityData.Properties[key] = input.Custom[key].PrintIfAvailable();
            }
        }

        protected override Clue MakeClueImpl([NotNull] AccountLead input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = _factory.Create(EntityType.Sales.Lead, input.AccountLeadId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=accountlead&id={1}", _dynamics365CrawlJobData.Url, input.AccountLeadId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

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

            // Add custom vocab
            foreach (var key in input.Custom.Keys)
            {
                var vocabName = $"{vocab.KeyPrefix}{vocab.KeySeparator}{key}";
                var vocabKey = new VocabularyKey(vocabName, VocabularyKeyDataType.Json, VocabularyKeyVisibility.Visible);
                data.Properties[vocabKey] = input.Custom[key].ToString().PrintIfAvailable();
            }

            Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

