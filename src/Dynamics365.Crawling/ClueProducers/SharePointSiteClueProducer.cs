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
    public abstract class SharePointSiteClueProducer<T> : DynamicsClueProducer<T> where T : SharePointSite
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SharePointSiteClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SharePointSiteId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=sharepointsite&id={1}", _dynamics365CrawlJobData.Api, input.SharePointSiteId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.ParentSite != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sharepointsite, EntityEdgeType.Parent, input, input.ParentSite);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.SharePointSite.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.SharePointSiteId] = input.SharePointSiteId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.RelativeUrl] = input.RelativeUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ParentSite] = input.ParentSite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ParentSiteName] = input.ParentSiteName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ParentSiteObjectTypeCode] = input.ParentSiteObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ValidationStatus] = input.ValidationStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ValidationStatusName] = input.ValidationStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.LastValidated] = input.LastValidated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.SiteCollectionId] = input.SiteCollectionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ValidationStatusErrorCodeName] = input.ValidationStatusErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ValidationStatusErrorCode] = input.ValidationStatusErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.AbsoluteURL] = input.AbsoluteURL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.IsGridPresent] = input.IsGridPresent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.IsGridPresentName] = input.IsGridPresentName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.FolderStructureEntity] = input.FolderStructureEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.FolderStructureEntityName] = input.FolderStructureEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.IsPowerBISite] = input.IsPowerBISite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.IsPowerBISiteName] = input.IsPowerBISiteName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ServiceType] = input.ServiceType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.UserId] = input.UserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointSite.ServiceTypeName] = input.ServiceTypeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

