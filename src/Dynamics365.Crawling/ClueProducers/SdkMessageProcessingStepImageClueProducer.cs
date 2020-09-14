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
    public abstract class SdkMessageProcessingStepImageClueProducer<T> : DynamicsClueProducer<T> where T : SdkMessageProcessingStepImage
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SdkMessageProcessingStepImageClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SdkMessageProcessingStepImageId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=sdkmessageprocessingstepimage&id={1}", _dynamics365CrawlJobData.Api, input.SdkMessageProcessingStepImageId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.SdkMessageProcessingStepId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sdkmessageprocessingstep, EntityEdgeType.Parent, input, input.SdkMessageProcessingStepId);


            */
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.SdkMessageProcessingStepId] = input.SdkMessageProcessingStepId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.SdkMessageProcessingStepImageId] = input.SdkMessageProcessingStepImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.EntityAlias] = input.EntityAlias.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.CustomizationLevel] = input.CustomizationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.SdkMessageProcessingStepImageIdUnique] = input.SdkMessageProcessingStepImageIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ImageType] = input.ImageType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.RelatedAttributeName] = input.RelatedAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.MessagePropertyName] = input.MessagePropertyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.Attributes] = input.Attributes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ImageTypeName] = input.ImageTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStepImage.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

