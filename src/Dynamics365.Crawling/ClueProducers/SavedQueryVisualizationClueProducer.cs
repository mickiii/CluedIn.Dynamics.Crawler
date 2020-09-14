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
    public abstract class SavedQueryVisualizationClueProducer<T> : DynamicsClueProducer<T> where T : SavedQueryVisualization
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SavedQueryVisualizationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SavedQueryVisualizationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=savedqueryvisualization&id={1}", _dynamics365CrawlJobData.Api, input.SavedQueryVisualizationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.WebResourceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.webresource, EntityEdgeType.Parent, input, input.WebResourceId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.SavedQueryVisualizationId] = input.SavedQueryVisualizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.PrimaryEntityTypeCode] = input.PrimaryEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.DataDescription] = input.DataDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.PresentationDescription] = input.PresentationDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.SavedQueryVisualizationIdUnique] = input.SavedQueryVisualizationIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.WebResourceId] = input.WebResourceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.CanBeDeleted] = input.CanBeDeleted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.Type] = input.Type.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQueryVisualization.ChartType] = input.ChartType.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

