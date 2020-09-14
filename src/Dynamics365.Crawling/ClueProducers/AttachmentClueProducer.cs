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
    public abstract class AttachmentClueProducer<T> : DynamicsClueProducer<T> where T : Attachment
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AttachmentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.AttachmentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=attachment&id={1}", _dynamics365CrawlJobData.Api, input.AttachmentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.FileName;
            /*

            */
            data.Properties[Dynamics365Vocabulary.Attachment.AttachmentId] = input.AttachmentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.StoragePointer] = input.StoragePointer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.Body] = input.Body.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.MimeType] = input.MimeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.FileName] = input.FileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.Prefix] = input.Prefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Attachment.FilePointer] = input.FilePointer.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

