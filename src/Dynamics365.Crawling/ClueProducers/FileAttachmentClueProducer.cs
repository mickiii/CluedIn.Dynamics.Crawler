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
    public abstract class FileAttachmentClueProducer<T> : DynamicsClueProducer<T> where T : FileAttachment
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public FileAttachmentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.FileAttachmentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=fileattachment&id={1}", _dynamics365CrawlJobData.Api, input.FileAttachmentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.FileName;
            /*
             if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.flowsession, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticleimage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibfile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.stagesolutionupload, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solution, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflowlog, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflowbinary, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.ObjectId);


            */
            data.Properties[Dynamics365Vocabulary.FileAttachment.FileAttachmentId] = input.FileAttachmentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.FilePointer] = input.FilePointer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.FileName] = input.FileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.MimeType] = input.MimeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.Prefix] = input.Prefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.StoragePointer] = input.StoragePointer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.ObjectIdTypeCode] = input.ObjectIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.RegardingFieldName] = input.RegardingFieldName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FileAttachment.FileSizeInBytes] = input.FileSizeInBytes.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

