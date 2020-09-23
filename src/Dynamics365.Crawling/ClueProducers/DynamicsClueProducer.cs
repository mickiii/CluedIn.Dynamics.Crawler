using System;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Factories;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class DynamicsClueProducer<T> : BaseClueProducer<T> where T : DynamicsModel
    {
        public abstract Clue CreateClue(T input, Guid accountId);
        public abstract void Customize(Clue clue, T input);

        internal readonly IClueFactory _factory;

        internal readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DynamicsClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            _factory = factory;

            _dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl(T input, Guid accountId)
        {
            var clue = CreateClue(input, accountId);

            Customize(clue, input);

            try
            {
                if (string.IsNullOrWhiteSpace(clue.Data.EntityData.Name))
                    clue.Data.EntityData.Name = input.Custom[input.EntityDefinition.Attributes.FirstOrDefault(a => a.IsPrimaryName).LogicalName]?.ToString();

                if (clue.Data.EntityData.Uri == null)
                    if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn={1}&id={2}", _dynamics365CrawlJobData.Url, input.EntityDefinition.LogicalCollectionName, clue.Data.EntityData.Codes.FirstOrDefault().Value), UriKind.Absolute, out Uri uri))
                        clue.Data.EntityData.Uri = uri;
            }
            catch
            {

            }

            //whatever is left
            if (input.EntityDefinition?.SchemaName != null)
            {
                foreach (var key in input.Custom.Keys)
                {
                    var customVocab = $"{Dynamics365Constants.ProviderName.ToLower()}.{input.EntityDefinition.SchemaName}.{key}";
                    clue.Data.EntityData.Properties[customVocab] = input.Custom[key] as string;
                }
            }     

            if (!clue.Data.EntityData.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }
    }
}
