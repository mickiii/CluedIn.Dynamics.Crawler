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
    public abstract class ImportFileClueProducer<T> : DynamicsClueProducer<T> where T : ImportFile
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ImportFileClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ImportFileId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=importfile&id={1}", _dynamics365CrawlJobData.Api, input.ImportFileId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.RecordsOwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.RecordsOwnerId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.RecordsOwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.RecordsOwnerId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ImportMapId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.importmap, EntityEdgeType.Parent, input, input.ImportMapId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.ImportId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.import, EntityEdgeType.Parent, input, input.ImportId);


            */
            data.Properties[Dynamics365Vocabulary.ImportFile.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.IsFirstRowHeader] = input.IsFirstRowHeader.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.SuccessCount] = input.SuccessCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.AdditionalHeaderRow] = input.AdditionalHeaderRow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ProcessCode] = input.ProcessCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ParsedTableColumnsNumber] = input.ParsedTableColumnsNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.Content] = input.Content.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.RecordsOwnerId] = input.RecordsOwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.Source] = input.Source.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.SourceEntityName] = input.SourceEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ParsedTableColumnPrefix] = input.ParsedTableColumnPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ParsedTableName] = input.ParsedTableName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ProgressCounter] = input.ProgressCounter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.EnableDuplicateDetection] = input.EnableDuplicateDetection.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ImportId] = input.ImportId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.FailureCount] = input.FailureCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.FieldDelimiterCode] = input.FieldDelimiterCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.TargetEntityName] = input.TargetEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.HeaderRow] = input.HeaderRow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.CompletedOn] = input.CompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.DataDelimiterCode] = input.DataDelimiterCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.TotalCount] = input.TotalCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ProcessingStatus] = input.ProcessingStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ImportFileId] = input.ImportFileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.Size] = input.Size.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ImportMapId] = input.ImportMapId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.UseSystemMap] = input.UseSystemMap.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.RecordsOwnerIdType] = input.RecordsOwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.RecordsOwnerIdName] = input.RecordsOwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.DataDelimiterName] = input.DataDelimiterName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.IsFirstRowHeaderName] = input.IsFirstRowHeaderName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ImportMapIdName] = input.ImportMapIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ProcessCodeName] = input.ProcessCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.UseSystemMapName] = input.UseSystemMapName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ImportIdName] = input.ImportIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ProcessingStatusName] = input.ProcessingStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.FieldDelimiterName] = input.FieldDelimiterName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.EnableDuplicateDetectionName] = input.EnableDuplicateDetectionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.RelatedEntityColumns] = input.RelatedEntityColumns.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.FileTypeCode] = input.FileTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.FileTypeName] = input.FileTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.PartialFailureCount] = input.PartialFailureCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.UpsertModeCode] = input.UpsertModeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.UpsertModeName] = input.UpsertModeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportFile.EntityKeyId] = input.EntityKeyId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

