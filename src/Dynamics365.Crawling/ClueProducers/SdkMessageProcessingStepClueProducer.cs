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
    public abstract class SdkMessageProcessingStepClueProducer<T> : DynamicsClueProducer<T> where T : SdkMessageProcessingStep
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SdkMessageProcessingStepClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SdkMessageProcessingStepId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=sdkmessageprocessingstep&id={1}", _dynamics365CrawlJobData.Api, input.SdkMessageProcessingStepId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.SdkMessageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sdkmessage, EntityEdgeType.Parent, input, input.SdkMessageId);

                         if (input.SdkMessageFilterId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sdkmessagefilter, EntityEdgeType.Parent, input, input.SdkMessageFilterId);

                         if (input.EventHandler != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceendpoint, EntityEdgeType.Parent, input, input.EventHandler);

                         if (input.ImpersonatingUserId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ImpersonatingUserId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.EventHandler != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.plugintype, EntityEdgeType.Parent, input, input.EventHandler);

                         if (input.PluginTypeId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.plugintype, EntityEdgeType.Parent, input, input.PluginTypeId);

                         if (input.SdkMessageProcessingStepSecureConfigId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sdkmessageprocessingstepsecureconfig, EntityEdgeType.Parent, input, input.SdkMessageProcessingStepSecureConfigId);


            */
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.Configuration] = input.Configuration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SupportedDeployment] = input.SupportedDeployment.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.PluginTypeId] = input.PluginTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.Rank] = input.Rank.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SdkMessageId] = input.SdkMessageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SdkMessageProcessingStepId] = input.SdkMessageProcessingStepId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.Stage] = input.Stage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SdkMessageProcessingStepIdUnique] = input.SdkMessageProcessingStepIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.FilteringAttributes] = input.FilteringAttributes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CustomizationLevel] = input.CustomizationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SdkMessageProcessingStepSecureConfigId] = input.SdkMessageProcessingStepSecureConfigId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.Mode] = input.Mode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SdkMessageFilterId] = input.SdkMessageFilterId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ImpersonatingUserId] = input.ImpersonatingUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.InvocationSource] = input.InvocationSource.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.StageName] = input.StageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SupportedDeploymentName] = input.SupportedDeploymentName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ModeName] = input.ModeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.InvocationSourceName] = input.InvocationSourceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.AsyncAutoDelete] = input.AsyncAutoDelete.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.EventHandler] = input.EventHandler.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.EventHandlerTypeCode] = input.EventHandlerTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.EventHandlerName] = input.EventHandlerName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.AsyncAutoDeleteName] = input.AsyncAutoDeleteName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ImpersonatingUserIdName] = input.ImpersonatingUserIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.PluginTypeIdName] = input.PluginTypeIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SdkMessageIdName] = input.SdkMessageIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.IsHidden] = input.IsHidden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CanUseReadOnlyConnection] = input.CanUseReadOnlyConnection.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.CanUseReadOnlyConnectionName] = input.CanUseReadOnlyConnectionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageProcessingStep.EventExpander] = input.EventExpander.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

