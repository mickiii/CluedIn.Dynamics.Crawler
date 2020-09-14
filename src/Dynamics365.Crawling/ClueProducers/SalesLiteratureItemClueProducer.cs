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
    public abstract class SalesLiteratureItemClueProducer<T> : DynamicsClueProducer<T> where T : SalesLiteratureItem
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SalesLiteratureItemClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SalesLiteratureItemId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=salesliteratureitem&id={1}", _dynamics365CrawlJobData.Api, input.SalesLiteratureItemId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.SalesLiteratureId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesliterature, EntityEdgeType.Parent, input, input.SalesLiteratureId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);


            */
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.SalesLiteratureItemId] = input.SalesLiteratureItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.SalesLiteratureId] = input.SalesLiteratureId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.IsCustomerViewable] = input.IsCustomerViewable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.AttachedDocumentUrl] = input.AttachedDocumentUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.MimeType] = input.MimeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.AuthorName] = input.AuthorName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.Abstract] = input.Abstract.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.DocumentBody] = input.DocumentBody.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.KeyWords] = input.KeyWords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.FileName] = input.FileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.FileTypeCode] = input.FileTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.IsCustomerViewableName] = input.IsCustomerViewableName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.FileTypeCodeName] = input.FileTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.FileType] = input.FileType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiteratureItem.Mode] = input.Mode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

