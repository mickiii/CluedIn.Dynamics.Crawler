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
    public abstract class ResourceGroupExpansionClueProducer<T> : DynamicsClueProducer<T> where T : ResourceGroupExpansion
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ResourceGroupExpansionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ResourceGroupExpansionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=resourcegroupexpansion&id={1}", _dynamics365CrawlJobData.Api, input.ResourceGroupExpansionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*

            */
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.ResourceGroupExpansionId] = input.ResourceGroupExpansionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.ItemId] = input.ItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.MethodCode] = input.MethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.methodcodeName] = input.methodcodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ResourceGroupExpansion.Name] = input.Name.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

