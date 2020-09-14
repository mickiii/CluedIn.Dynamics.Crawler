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
    public abstract class RibbonDiffClueProducer<T> : DynamicsClueProducer<T> where T : RibbonDiff
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RibbonDiffClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RibbonDiffId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=ribbondiff&id={1}", _dynamics365CrawlJobData.Api, input.RibbonDiffId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.RibbonCustomizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ribboncustomization, EntityEdgeType.Parent, input, input.RibbonCustomizationId);


            */
            data.Properties[Dynamics365Vocabulary.RibbonDiff.TabId] = input.TabId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.RDX] = input.RDX.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.ContextGroupId] = input.ContextGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.RibbonDiffUniqueId] = input.RibbonDiffUniqueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.Entity] = input.Entity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.Sequence] = input.Sequence.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.RibbonDiffId] = input.RibbonDiffId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.DiffType] = input.DiffType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.RibbonCustomizationId] = input.RibbonCustomizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.DiffId] = input.DiffId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.IsAppAware] = input.IsAppAware.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonDiff.IsAppAwareName] = input.IsAppAwareName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

