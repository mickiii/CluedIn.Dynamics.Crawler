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
    public abstract class RecommendedDocumentClueProducer<T> : DynamicsClueProducer<T> where T : RecommendedDocument
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RecommendedDocumentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RecommendedDocumentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=recommendeddocument&id={1}", _dynamics365CrawlJobData.Api, input.RecommendedDocumentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

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
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.RecommendedDocumentId] = input.RecommendedDocumentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ExternalDocumentId] = input.ExternalDocumentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.Version] = input.Version.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.AbsoluteUrl] = input.AbsoluteUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ReadUrl] = input.ReadUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.EditUrl] = input.EditUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ContentType] = input.ContentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.Source] = input.Source.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.FileType] = input.FileType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.Location] = input.Location.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.Author] = input.Author.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.IconClassName] = input.IconClassName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.ExternalModifiedBy] = input.ExternalModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecommendedDocument.AssociatedRecordName] = input.AssociatedRecordName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

