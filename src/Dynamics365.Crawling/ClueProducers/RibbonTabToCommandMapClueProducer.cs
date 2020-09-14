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
    public abstract class RibbonTabToCommandMapClueProducer<T> : DynamicsClueProducer<T> where T : RibbonTabToCommandMap
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RibbonTabToCommandMapClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RibbonTabToCommandMapId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=ribbontabtocommandmap&id={1}", _dynamics365CrawlJobData.Api, input.RibbonTabToCommandMapId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.RibbonDiffId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ribbondiff, EntityEdgeType.Parent, input, input.RibbonDiffId);


            */
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.TabId] = input.TabId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.RibbonTabToCommandMapUniqueId] = input.RibbonTabToCommandMapUniqueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.ControlId] = input.ControlId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.Entity] = input.Entity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.Command] = input.Command.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.RibbonTabToCommandMapId] = input.RibbonTabToCommandMapId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.RibbonDiffId] = input.RibbonDiffId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RibbonTabToCommandMap.IsManagedName] = input.IsManagedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

