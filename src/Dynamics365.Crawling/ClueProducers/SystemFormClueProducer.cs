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
    public abstract class SystemFormClueProducer<T> : DynamicsClueProducer<T> where T : SystemForm
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SystemFormClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.FormId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=systemform&id={1}", _dynamics365CrawlJobData.Api, input.FormId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.AncestorFormId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemform, EntityEdgeType.Parent, input, input.AncestorFormId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.SystemForm.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormId] = input.FormId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormIdUnique] = input.FormIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormXml] = input.FormXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.Type] = input.Type.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.TypeName] = input.TypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.Version] = input.Version.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.PublishedOn] = input.PublishedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.AncestorFormId] = input.AncestorFormId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.AncestorFormIdName] = input.AncestorFormIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormXmlManaged] = input.FormXmlManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.CanBeDeleted] = input.CanBeDeleted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IsAIRMerged] = input.IsAIRMerged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormPresentation] = input.FormPresentation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormActivationState] = input.FormActivationState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormActivationStateName] = input.FormActivationStateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormPresentationName] = input.FormPresentationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IsTabletEnabled] = input.IsTabletEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.UniqueName] = input.UniqueName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.IsDesktopEnabled] = input.IsDesktopEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemForm.FormJson] = input.FormJson.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

