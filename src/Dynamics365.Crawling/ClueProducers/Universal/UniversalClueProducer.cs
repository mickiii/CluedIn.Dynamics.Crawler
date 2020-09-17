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
    public class UniversalClueProducer : DynamicsClueProducer<DynamicsModel>
    {
        public UniversalClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {

        }

        public override Clue CreateClue(DynamicsModel input, Guid accountId)
        {
            var clue = _factory.Create("/" + input.EntityDefinition.SchemaName, input.Custom.FirstOrDefault(custom => custom.Key == input.EntityDefinition.PrimaryIdAttribute).Value.ToString(), accountId);
            return clue;
        }

        public override void Customize(Clue clue, DynamicsModel input)
        {
            var data = clue.Data.EntityData;

            foreach (var edge in input.RelationshipDefinitions)
            {
                var attr = input.Custom.FirstOrDefault(c => c.Key == edge.ReferencingAttribute);
                if (attr.Value != null)
                {
                    _factory.CreateOutgoingEntityReference(clue, edge.ReferencingEntity, edge.RelationshipType, input, attr.Value.ToString());
                }
            }
            foreach (var key in input.Custom.Keys)
            {
                var customVocab = $"{Dynamics365Constants.ProviderName.ToLower()}.{input.EntityDefinition.SchemaName}.{key}";
                data.Properties[customVocab] = input.Custom[key] as string;
            }
        }
    }
}

