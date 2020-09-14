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
    public abstract class SdkMessageFilterClueProducer<T> : DynamicsClueProducer<T> where T : SdkMessageFilter
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SdkMessageFilterClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SdkMessageFilterId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=sdkmessagefilter&id={1}", _dynamics365CrawlJobData.Api, input.SdkMessageFilterId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.SdkMessageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sdkmessage, EntityEdgeType.Parent, input, input.SdkMessageId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.SdkMessageFilterId] = input.SdkMessageFilterId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.PrimaryObjectTypeCode] = input.PrimaryObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.CustomizationLevel] = input.CustomizationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.SecondaryObjectTypeCode] = input.SecondaryObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.SdkMessageFilterIdUnique] = input.SdkMessageFilterIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.IsCustomProcessingStepAllowed] = input.IsCustomProcessingStepAllowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.Availability] = input.Availability.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.SdkMessageId] = input.SdkMessageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.SecondaryObjectTypeCodeName] = input.SecondaryObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.PrimaryObjectTypeCodeName] = input.PrimaryObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.IsVisible] = input.IsVisible.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.SdkMessageIdName] = input.SdkMessageIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.IsCustomProcessingStepAllowedName] = input.IsCustomProcessingStepAllowedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.WorkflowSdkStepEnabled] = input.WorkflowSdkStepEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.WorkflowSdkStepEnabledName] = input.WorkflowSdkStepEnabledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageFilter.RestrictionLevel] = input.RestrictionLevel.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

