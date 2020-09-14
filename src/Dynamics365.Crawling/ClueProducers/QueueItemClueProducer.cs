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
    public abstract class QueueItemClueProducer<T> : DynamicsClueProducer<T> where T : QueueItem
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public QueueItemClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.QueueItemId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=queueitem&id={1}", _dynamics365CrawlJobData.Api, input.QueueItemId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceappointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotalert, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignresponse, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.WorkerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.WorkerId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_activity_request, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_inmail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_message, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.QueueId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.QueueId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_pointdrivepresentationviewed, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticletemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_txtmessage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.WorkerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.WorkerId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.ObjectId);


            */
            data.Properties[Dynamics365Vocabulary.QueueItem.QueueItemId] = input.QueueItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.QueueId] = input.QueueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.EnteredOn] = input.EnteredOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.Priority] = input.Priority.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.State] = input.State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ToRecipients] = input.ToRecipients.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.Sender] = input.Sender.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.WorkerIdModifiedOn] = input.WorkerIdModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.WorkerId] = input.WorkerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.QueueIdName] = input.QueueIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.WorkerIdName] = input.WorkerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.WorkerIdYomiName] = input.WorkerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ObjectIdTypeCode] = input.ObjectIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ObjectIdName] = input.ObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QueueItem.WorkerIdType] = input.WorkerIdType.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

