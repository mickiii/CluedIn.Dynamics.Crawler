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
    public abstract class CanvasAppClueProducer<T> : DynamicsClueProducer<T> where T : CanvasApp
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CanvasAppClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.CanvasAppId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=canvasapp&id={1}", _dynamics365CrawlJobData.Api, input.CanvasAppId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.SolutionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solution, EntityEdgeType.Parent, input, input.SolutionId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.CanvasApp.CanvasAppRowId] = input.CanvasAppRowId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.AppVersion] = input.AppVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.CreatedByClientVersion] = input.CreatedByClientVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.MinClientVersion] = input.MinClientVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.Tags] = input.Tags.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.CreatedTime] = input.CreatedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.AppOpenUri] = input.AppOpenUri.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsCdsUpgraded] = input.IsCdsUpgraded.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.GalleryItemId] = input.GalleryItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.AADLastModifiedById] = input.AADLastModifiedById.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.AADLastPublishedById] = input.AADLastPublishedById.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.DisplayName] = input.DisplayName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.CommitMessage] = input.CommitMessage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.Publisher] = input.Publisher.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.LastModifiedTime] = input.LastModifiedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.LastPublishTime] = input.LastPublishTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.ConnectionReferences] = input.ConnectionReferences.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsFeaturedApp] = input.IsFeaturedApp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.BypassConsent] = input.BypassConsent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.AdminControlBypassConsent] = input.AdminControlBypassConsent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsHeroApp] = input.IsHeroApp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsHidden] = input.IsHidden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.CanvasAppId] = input.CanvasAppId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.BackgroundColor] = input.BackgroundColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsCdsUpgradedName] = input.IsCdsUpgradedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsFeaturedAppName] = input.IsFeaturedAppName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.BypassConsentName] = input.BypassConsentName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.AdminControlBypassConsentName] = input.AdminControlBypassConsentName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsHeroAppName] = input.IsHeroAppName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsHiddenName] = input.IsHiddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.OwningBusinessUnitName] = input.OwningBusinessUnitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.AADCreatedById] = input.AADCreatedById.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.AuthorizationReferences] = input.AuthorizationReferences.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.EmbeddedApp] = input.EmbeddedApp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.CdsDependencies] = input.CdsDependencies.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CanvasApp.DatabaseReferences] = input.DatabaseReferences.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

