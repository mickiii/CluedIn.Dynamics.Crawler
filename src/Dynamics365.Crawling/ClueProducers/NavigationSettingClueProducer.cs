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
    public abstract class NavigationSettingClueProducer<T> : DynamicsClueProducer<T> where T : NavigationSetting
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public NavigationSettingClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.NavigationSettingId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=navigationsetting&id={1}", _dynamics365CrawlJobData.Api, input.NavigationSettingId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.AppConfigId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appconfig, EntityEdgeType.Parent, input, input.AppConfigId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.NavigationSetting.NavigationSettingId] = input.NavigationSettingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ResourceId] = input.ResourceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.PageUrl] = input.PageUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.QuickSettingOrder] = input.QuickSettingOrder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.SettingType] = input.SettingType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.GroupName] = input.GroupName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ParentNavigationSettingId] = input.ParentNavigationSettingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.AppConfigId] = input.AppConfigId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ProgressState] = input.ProgressState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ProgressStateName] = input.ProgressStateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.Privileges] = input.Privileges.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.AppConfigIdUnique] = input.AppConfigIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.GroupTypeName] = input.GroupTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.NavigationSettingIdUnique] = input.NavigationSettingIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.IconResourceId] = input.IconResourceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.NavigationSetting.AdvancedSettingOrder] = input.AdvancedSettingOrder.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

