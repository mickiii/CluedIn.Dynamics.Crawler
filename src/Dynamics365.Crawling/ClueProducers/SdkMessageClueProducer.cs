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
    public abstract class SdkMessageClueProducer<T> : DynamicsClueProducer<T> where T : SdkMessage
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SdkMessageClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SdkMessageId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=sdkmessage&id={1}", _dynamics365CrawlJobData.Api, input.SdkMessageId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.SdkMessage.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.SdkMessageId] = input.SdkMessageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.CategoryName] = input.CategoryName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.CustomizationLevel] = input.CustomizationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.SdkMessageIdUnique] = input.SdkMessageIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.Expand] = input.Expand.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.AutoTransact] = input.AutoTransact.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.Availability] = input.Availability.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.Template] = input.Template.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsValidForExecuteAsync] = input.IsValidForExecuteAsync.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsReadOnly] = input.IsReadOnly.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsReadOnlyName] = input.IsReadOnlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.AutoTransactName] = input.AutoTransactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ExpandName] = input.ExpandName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.TemplateName] = input.TemplateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ThrottleSettings] = input.ThrottleSettings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsActive] = input.IsActive.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsActiveName] = input.IsActiveName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.WorkflowSdkStepEnabled] = input.WorkflowSdkStepEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.WorkflowSdkStepEnabledName] = input.WorkflowSdkStepEnabledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessage.IsManagedName] = input.IsManagedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

