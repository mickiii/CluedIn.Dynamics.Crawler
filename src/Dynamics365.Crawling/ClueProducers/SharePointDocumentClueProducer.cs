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
    public abstract class SharePointDocumentClueProducer<T> : DynamicsClueProducer<T> where T : SharePointDocument
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SharePointDocumentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SharePointDocumentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=sharepointdocument&id={1}", _dynamics365CrawlJobData.Api, input.SharePointDocumentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.FullName;
            /*
             if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookactivity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.kbarticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.BusinessUnitId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.BusinessUnitId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesliterature, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticletemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.category, EntityEdgeType.Parent, input, input.RegardingObjectId);


            */
            data.Properties[Dynamics365Vocabulary.SharePointDocument.AbsoluteUrl] = input.AbsoluteUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.AppCreatedBy] = input.AppCreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.AppModifiedBy] = input.AppModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.Author] = input.Author.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CheckedOutTo] = input.CheckedOutTo.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CheckInComment] = input.CheckInComment.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ContentType] = input.ContentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ContentTypeId] = input.ContentTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CopySource] = input.CopySource.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.DocumentId] = input.DocumentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.EditUrl] = input.EditUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.Edit] = input.Edit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.FileType] = input.FileType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ChildFolderCount] = input.ChildFolderCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.IsCheckedOut] = input.IsCheckedOut.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.IsFolder] = input.IsFolder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ChildItemCount] = input.ChildItemCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.Modified] = input.Modified.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ReadUrl] = input.ReadUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.SharePointCreatedOn] = input.SharePointCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.SharePointDocumentId] = input.SharePointDocumentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.LocationId] = input.LocationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.SharePointModifiedBy] = input.SharePointModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.Version] = input.Version.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.RelativeLocation] = input.RelativeLocation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.DocumentLocationType] = input.DocumentLocationType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.DocumentLocationTypeName] = input.DocumentLocationTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.IsRecursiveFetch] = input.IsRecursiveFetch.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ServiceType] = input.ServiceType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.ServiceTypeName] = input.ServiceTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.IconClassName] = input.IconClassName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SharePointDocument.LocationName] = input.LocationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

