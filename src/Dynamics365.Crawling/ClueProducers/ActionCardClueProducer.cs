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
    public abstract class ActionCardClueProducer<T> : DynamicsClueProducer<T> where T : ActionCard
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ActionCardClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ActionCardId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=actioncard&id={1}", _dynamics365CrawlJobData.Api, input.ActionCardId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceappointment, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_activity_request, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_inmail, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_message, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_pointdrivepresentationviewed, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_txtmessage, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CardTypeId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cardtype, EntityEdgeType.Parent, input, input.CardTypeId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.RegardingObjectId);


            */
            data.Properties[Dynamics365Vocabulary.ActionCard.ActionCardId] = input.ActionCardId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.RecordId] = input.RecordId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.RecordIdName] = input.RecordIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.RecordIdObjectTypeCode] = input.RecordIdObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.Priority] = input.Priority.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.Data] = input.Data.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.Visibility] = input.Visibility.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ExpiryDate] = input.ExpiryDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.VisibilityName] = input.VisibilityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.Source] = input.Source.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.SourceName] = input.SourceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ReferenceTokens] = input.ReferenceTokens.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.State] = input.State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.StateName] = input.StateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CardTypeId] = input.CardTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CardTypeIdName] = input.CardTypeIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.CardType] = input.CardType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.RecordIdObjectTypeCode2] = input.RecordIdObjectTypeCode2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ParentRegardingObjectId] = input.ParentRegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ParentRegardingObjectTypeCode] = input.ParentRegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCard.ParentRegardingObjectIdData] = input.ParentRegardingObjectIdData.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

