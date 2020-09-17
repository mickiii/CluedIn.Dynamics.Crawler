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
    public  class StandardAccountClueProducer : AccountClueProducer<Account>
    {
        public StandardAccountClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {

        }

        public override void CustomizeMore(Clue clue, Account input)
        {
            foreach (var key in input.Custom.Keys)
            {
                var customVocab = $"{Dynamics365Constants.ProviderName.ToLower()}.{input.EntityDefinition.SchemaName}.{key}";
                clue.Data.EntityData.Properties[customVocab] = input.Custom[key] as string;
            }
        }
    }
}

