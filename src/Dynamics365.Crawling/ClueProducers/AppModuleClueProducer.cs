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
    public abstract class AppModuleClueProducer<T> : DynamicsClueProducer<T> where T : AppModule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AppModuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.AppModuleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=appmodule&id={1}", _dynamics365CrawlJobData.Api, input.AppModuleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.PublisherId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.publisher, EntityEdgeType.Parent, input, input.PublisherId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.AppModule.AppModuleId] = input.AppModuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.FormFactor] = input.FormFactor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.AppModuleVersion] = input.AppModuleVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.IsFeatured] = input.IsFeatured.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.PublisherId] = input.PublisherId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.PublisherIdName] = input.PublisherIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.AppModuleXmlManaged] = input.AppModuleXmlManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.PublishedOn] = input.PublishedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.URL] = input.URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.AppModuleIdUnique] = input.AppModuleIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.WebResourceId] = input.WebResourceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ConfigXML] = input.ConfigXML.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.ClientType] = input.ClientType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.UniqueName] = input.UniqueName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.WelcomePageId] = input.WelcomePageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.Descriptor] = input.Descriptor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.EventHandlers] = input.EventHandlers.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.NavigationType] = input.NavigationType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AppModule.OptimizedFor] = input.OptimizedFor.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

