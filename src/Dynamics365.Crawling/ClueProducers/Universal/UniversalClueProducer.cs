using System;
using System.Collections.Generic;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Factories;

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
                var key = input.Custom.FirstOrDefault(c => c.Key == edge.ReferencingAttribute);
                if (!key.Equals(default(KeyValuePair<string, object>)))
                {
                    input.Custom.TryGetValue(key.Key, out object attr);
                    if (attr != null)
                    {
                        _factory.CreateOutgoingEntityReference(clue, edge.ReferencingEntity, edge.RelationshipType, input, attr.ToString());
                    }
                }       
            }
        }
    }
}

