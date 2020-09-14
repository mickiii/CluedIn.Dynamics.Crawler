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
    public abstract class ActivityMimeAttachmentClueProducer<T> : DynamicsClueProducer<T> where T : ActivityMimeAttachment
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ActivityMimeAttachmentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ActivityMimeAttachmentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=activitymimeattachment&id={1}", _dynamics365CrawlJobData.Api, input.ActivityMimeAttachmentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.FileName;
            /*
             if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.AttachmentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.attachment, EntityEdgeType.Parent, input, input.AttachmentId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.template, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.ObjectId);


            */
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.AttachmentNumber] = input.AttachmentNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.ActivityMimeAttachmentId] = input.ActivityMimeAttachmentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.Body] = input.Body.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.MimeType] = input.MimeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.FileName] = input.FileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.AttachmentId] = input.AttachmentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.ActivityMimeAttachmentIdUnique] = input.ActivityMimeAttachmentIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.AttachmentContentId] = input.AttachmentContentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.IsFollowed] = input.IsFollowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.IsFollowedName] = input.IsFollowedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.AnonymousLink] = input.AnonymousLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.ActivitySubject] = input.ActivitySubject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActivityMimeAttachment.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

