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
    public abstract class LanguageProvisioningStateClueProducer<T> : DynamicsClueProducer<T> where T : LanguageProvisioningState
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public LanguageProvisioningStateClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            this._factory = factory;

            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Unknown, input.LanguageProvisioningStateId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=languageprovisioningstate&id={1}", _dynamics365CrawlJobData.Api, input.LanguageProvisioningStateId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*

            */
            data.Properties[Dynamics365Vocabulary.LanguageProvisioningState.LanguageProvisioningStateId] = input.LanguageProvisioningStateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LanguageProvisioningState.ApplicationVersion] = input.ApplicationVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LanguageProvisioningState.LanguageId] = input.LanguageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LanguageProvisioningState.SolutionUniqueName] = input.SolutionUniqueName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LanguageProvisioningState.SolutionFileVersion] = input.SolutionFileVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LanguageProvisioningState.ProvisioningStage] = input.ProvisioningStage.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

