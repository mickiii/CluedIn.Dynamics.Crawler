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
    public abstract class OrganizationUIClueProducer<T> : DynamicsClueProducer<T> where T : OrganizationUI
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public OrganizationUIClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=organizationui&id={1}", _dynamics365CrawlJobData.Api, input.FormId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.OrganizationUI.FormId] = input.FormId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.FormXml] = input.FormXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.FieldXml] = input.FieldXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.PreviewXml] = input.PreviewXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.PreviewColumnsetXml] = input.PreviewColumnsetXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.Version] = input.Version.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.OutlookShortcutIcon] = input.OutlookShortcutIcon.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.GridIcon] = input.GridIcon.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.FormIdUnique] = input.FormIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.LargeEntityIcon] = input.LargeEntityIcon.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OrganizationUI.IsManagedName] = input.IsManagedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

