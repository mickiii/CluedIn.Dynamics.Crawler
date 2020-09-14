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
    public abstract class QueueClueProducer<T> : DynamicsClueProducer<T> where T : Queue
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public QueueClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.QueueId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=queue&id={1}", _dynamics365CrawlJobData.Api, input.QueueId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.QueueId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queueitemcount, EntityEdgeType.Parent, input, input.QueueId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.BusinessUnitId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.BusinessUnitId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.PrimaryUserId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.PrimaryUserId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.DefaultMailbox != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.DefaultMailbox);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

                         if (input.QueueId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queuemembercount, EntityEdgeType.Parent, input, input.QueueId);


            */
            data.Properties[Dynamics365Vocabulary.Queue.QueueId] = input.QueueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EMailAddress] = input.EMailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.PrimaryUserId] = input.PrimaryUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.QueueTypeCode] = input.QueueTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.PrimaryUserIdName] = input.PrimaryUserIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.QueueTypeCodeName] = input.QueueTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IgnoreUnsolicitedEmail] = input.IgnoreUnsolicitedEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IsFaxQueue] = input.IsFaxQueue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IsFaxQueueName] = input.IsFaxQueueName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IgnoreUnsolicitedEmailName] = input.IgnoreUnsolicitedEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EmailPassword] = input.EmailPassword.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IncomingEmailDeliveryMethod] = input.IncomingEmailDeliveryMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EmailUsername] = input.EmailUsername.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OutgoingEmailDeliveryMethod] = input.OutgoingEmailDeliveryMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.AllowEmailCredentials] = input.AllowEmailCredentials.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IncomingEmailFilteringMethod] = input.IncomingEmailFilteringMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OutgoingEmailDeliveryMethodName] = input.OutgoingEmailDeliveryMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.AllowEmailCredentialsName] = input.AllowEmailCredentialsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IncomingEmailFilteringMethodName] = input.IncomingEmailFilteringMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IncomingEmailDeliveryMethodName] = input.IncomingEmailDeliveryMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.PrimaryUserIdYomiName] = input.PrimaryUserIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.NumberOfItems] = input.NumberOfItems.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.NumberOfMembers] = input.NumberOfMembers.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EmailRouterAccessApproval] = input.EmailRouterAccessApproval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EmailRouterAccessApprovalName] = input.EmailRouterAccessApprovalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.DefaultMailbox] = input.DefaultMailbox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.DefaultMailboxName] = input.DefaultMailboxName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.IsEmailAddressApprovedByO365Admin] = input.IsEmailAddressApprovedByO365Admin.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.QueueViewType] = input.QueueViewType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Queue.QueueViewTypeName] = input.QueueViewTypeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

