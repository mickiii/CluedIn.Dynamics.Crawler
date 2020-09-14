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
    public abstract class RibbonContextGroupClueProducer<T> : DynamicsClueProducer<T> where T : RibbonContextGroup
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RibbonContextGroupClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RibbonContextGroupId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=ribboncontextgroup&id={1}", _dynamics365CrawlJobData.Api, input.RibbonContextGroupId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.RibbonCustomizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ribboncustomization, EntityEdgeType.Parent, input, input.RibbonCustomizationId);


            */
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.RibbonContextGroupUniqueId] = input.RibbonContextGroupUniqueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.ContextGroupXml] = input.ContextGroupXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.ContextGroupId] = input.ContextGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.RibbonContextGroupId] = input.RibbonContextGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.RibbonCustomizationId] = input.RibbonCustomizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.Entity] = input.Entity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonContextGroup.IsManagedName] = input.IsManagedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

