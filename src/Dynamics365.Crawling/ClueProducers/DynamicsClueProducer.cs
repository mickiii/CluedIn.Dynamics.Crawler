using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Dynamics365.Core.Models;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using System.Linq;

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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn={1}&id={2}", _dynamics365CrawlJobData.Url, input.EntityDefinition.LogicalCollectionName, clue.Data.EntityData.Codes.FirstOrDefault().Value), UriKind.Absolute, out Uri uri))
                clue.Data.EntityData.Uri = uri;

            Customize(clue, input);

            if (!clue.Data.EntityData.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }
    }
}
