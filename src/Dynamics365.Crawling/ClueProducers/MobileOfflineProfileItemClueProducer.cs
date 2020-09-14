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
    public abstract class MobileOfflineProfileItemClueProducer<T> : DynamicsClueProducer<T> where T : MobileOfflineProfileItem
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public MobileOfflineProfileItemClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.MobileOfflineProfileItemId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=mobileofflineprofileitem&id={1}", _dynamics365CrawlJobData.Api, input.MobileOfflineProfileItemId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mobileofflineprofile, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ProfileItemRule != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.savedquery, EntityEdgeType.Parent, input, input.ProfileItemRule);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.MobileOfflineProfileItemId] = input.MobileOfflineProfileItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ViewQuery] = input.ViewQuery.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CanBeFollowed] = input.CanBeFollowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CanBeFollowedName] = input.CanBeFollowedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.GetRelatedEntityRecords] = input.GetRelatedEntityRecords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.GetRelatedEntityRecordsName] = input.GetRelatedEntityRecordsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ProfileItemRule] = input.ProfileItemRule.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ProfileItemRuleName] = input.ProfileItemRuleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.PublishedOn] = input.PublishedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.MobileOfflineProfileItemIdUnique] = input.MobileOfflineProfileItemIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.SelectedEntityTypeCode] = input.SelectedEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.SelectedEntityTypeCodeName] = input.SelectedEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.IsVisibleInGrid] = input.IsVisibleInGrid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.IsVisibleInGridName] = input.IsVisibleInGridName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RecordDistributionCriteria] = input.RecordDistributionCriteria.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RecordDistributionCriteriaName] = input.RecordDistributionCriteriaName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RecordsOwnedByMe] = input.RecordsOwnedByMe.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RecordsOwnedByMeName] = input.RecordsOwnedByMeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RecordsOwnedByMyTeam] = input.RecordsOwnedByMyTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RecordsOwnedByMyTeamName] = input.RecordsOwnedByMyTeamName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RecordsOwnedByMyBusinessUnit] = input.RecordsOwnedByMyBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RecordsOwnedByMyBusinessUnitName] = input.RecordsOwnedByMyBusinessUnitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.RelationshipData] = input.RelationshipData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.IsValidated] = input.IsValidated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.IsValidatedName] = input.IsValidatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.SelectedEntityMetadata] = input.SelectedEntityMetadata.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.EntityObjectTypeCode] = input.EntityObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MobileOfflineProfileItem.ProfileItemEntityFilter] = input.ProfileItemEntityFilter.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

