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
    public abstract class SalesLiteratureClueProducer<T> : DynamicsClueProducer<T> where T : SalesLiterature
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SalesLiteratureClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SalesLiteratureId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=salesliterature&id={1}", _dynamics365CrawlJobData.Api, input.SalesLiteratureId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.SubjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.subject, EntityEdgeType.Parent, input, input.SubjectId);

                         if (input.StageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.StageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.EmployeeContactId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.EmployeeContactId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);


            */
            data.Properties[Dynamics365Vocabulary.SalesLiterature.SalesLiteratureId] = input.SalesLiteratureId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.EmployeeContactId] = input.EmployeeContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.SubjectId] = input.SubjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.LiteratureTypeCode] = input.LiteratureTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ExpirationDate] = input.ExpirationDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.IsCustomerViewable] = input.IsCustomerViewable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.KeyWords] = input.KeyWords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.HasAttachments] = input.HasAttachments.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.SubjectIdName] = input.SubjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.EmployeeContactIdName] = input.EmployeeContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.IsCustomerViewableName] = input.IsCustomerViewableName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.HasAttachmentsName] = input.HasAttachmentsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.LiteratureTypeCodeName] = input.LiteratureTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.EmployeeContactIdYomiName] = input.EmployeeContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesLiterature.TraversedPath] = input.TraversedPath.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

