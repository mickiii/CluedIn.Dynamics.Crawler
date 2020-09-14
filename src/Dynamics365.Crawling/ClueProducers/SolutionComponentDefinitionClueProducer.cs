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
    public abstract class SolutionComponentDefinitionClueProducer<T> : DynamicsClueProducer<T> where T : SolutionComponentDefinition
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SolutionComponentDefinitionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SolutionComponentDefinitionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=solutioncomponentdefinition&id={1}", _dynamics365CrawlJobData.Api, input.SolutionComponentDefinitionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*

            */
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.SolutionComponentDefinitionId] = input.SolutionComponentDefinitionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.ComponentXPath] = input.ComponentXPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.SolutionComponentType] = input.SolutionComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.SolutionComponentDefinitionIdUnique] = input.SolutionComponentDefinitionIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.IsMetadata] = input.IsMetadata.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.LabelTypeCode] = input.LabelTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.UseForceUpdateAlways] = input.UseForceUpdateAlways.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.UseForceDeleteForSolutionUpdate] = input.UseForceDeleteForSolutionUpdate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.UseSentinelRowInBaseSolution] = input.UseSentinelRowInBaseSolution.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.AllowDeleteBaseSolutionRowAndFakeDelete] = input.AllowDeleteBaseSolutionRowAndFakeDelete.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.AllowRecreateForLogicallyDeletedRow] = input.AllowRecreateForLogicallyDeletedRow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.AlwaysRemoveActiveCustomizationsOnUninstall] = input.AlwaysRemoveActiveCustomizationsOnUninstall.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.GroupParentComponentType] = input.GroupParentComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.GroupParentComponentAttributeName] = input.GroupParentComponentAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.IsViewable] = input.IsViewable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.AllowOverwriteCustomizations] = input.AllowOverwriteCustomizations.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.IsMergeable] = input.IsMergeable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.CanBeHidden] = input.CanBeHidden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.DescendentIsViewableComponent] = input.DescendentIsViewableComponent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.ViewableDescendentComponentType] = input.ViewableDescendentComponentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.ParentAttributeName] = input.ParentAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.IsDependencyDisabled] = input.IsDependencyDisabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.CanBeAddedToSolutionComponents] = input.CanBeAddedToSolutionComponents.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.RootComponent] = input.RootComponent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.RootAttributeName] = input.RootAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.HasIsRenameableAttribute] = input.HasIsRenameableAttribute.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.SolutionComponentTypeName] = input.SolutionComponentTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.RemoveActiveCustomizationsBehavior] = input.RemoveActiveCustomizationsBehavior.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.IsDisplayable] = input.IsDisplayable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SolutionComponentDefinition.PrimaryEntityName] = input.PrimaryEntityName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

