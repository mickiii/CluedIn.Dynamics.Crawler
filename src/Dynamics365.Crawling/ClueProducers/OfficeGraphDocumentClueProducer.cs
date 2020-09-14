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
    public abstract class OfficeGraphDocumentClueProducer<T> : DynamicsClueProducer<T> where T : OfficeGraphDocument
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public OfficeGraphDocumentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.OfficeGraphDocumentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=officegraphdocument&id={1}", _dynamics365CrawlJobData.Api, input.OfficeGraphDocumentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.OfficeGraphDocumentId] = input.OfficeGraphDocumentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.PreviewImageUrl] = input.PreviewImageUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.FileType] = input.FileType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.WebLocationUrl] = input.WebLocationUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.ViewCount] = input.ViewCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.AuthorNames] = input.AuthorNames.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.QueryType] = input.QueryType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.CreatedTime] = input.CreatedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.ModifiedTime] = input.ModifiedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.DocumentId] = input.DocumentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.Rank] = input.Rank.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.SiteUrl] = input.SiteUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.ReadUrl] = input.ReadUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.SiteTitle] = input.SiteTitle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.DocumentLastModifiedBy] = input.DocumentLastModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.DocumentLastModifiedOn] = input.DocumentLastModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.FileExtension] = input.FileExtension.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.SecondaryFileExtension] = input.SecondaryFileExtension.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeGraphDocument.DocumentPreviewMetadata] = input.DocumentPreviewMetadata.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

