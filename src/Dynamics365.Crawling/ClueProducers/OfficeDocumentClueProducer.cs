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
    public abstract class OfficeDocumentClueProducer<T> : DynamicsClueProducer<T> where T : OfficeDocument
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public OfficeDocumentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.OfficeDocumentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=officedocument&id={1}", _dynamics365CrawlJobData.Api, input.OfficeDocumentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.OfficeDocument.Content] = input.Content.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.DocumentType] = input.DocumentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.DocumentTypeName] = input.DocumentTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.OfficeDocumentId] = input.OfficeDocumentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.SHA256] = input.SHA256.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.ClientData] = input.ClientData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OfficeDocument.FileLockState] = input.FileLockState.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

