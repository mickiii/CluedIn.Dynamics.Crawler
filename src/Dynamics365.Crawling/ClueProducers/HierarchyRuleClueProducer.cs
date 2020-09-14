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
    public abstract class HierarchyRuleClueProducer<T> : DynamicsClueProducer<T> where T : HierarchyRule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public HierarchyRuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.HierarchyRuleID.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=hierarchyrule&id={1}", _dynamics365CrawlJobData.Api, input.HierarchyRuleID.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.HierarchyRule.HierarchyRuleID] = input.HierarchyRuleID.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.PrimaryEntityFormID] = input.PrimaryEntityFormID.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.RelatedEntityFormId] = input.RelatedEntityFormId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.PrimaryEntityLogicalName] = input.PrimaryEntityLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.RelatedEntityLogicalName] = input.RelatedEntityLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.PublishedOn] = input.PublishedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.HierarchyRuleIDUnique] = input.HierarchyRuleIDUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.SortBy] = input.SortBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.ShowDisabled] = input.ShowDisabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.HierarchyRule.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

