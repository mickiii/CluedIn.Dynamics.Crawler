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
    public abstract class DelveActionHubClueProducer<T> : DynamicsClueProducer<T> where T : DelveActionHub
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DelveActionHubClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DelveActionHubId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=delveactionhub&id={1}", _dynamics365CrawlJobData.Api, input.DelveActionHubId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CreatedTime] = input.CreatedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ModifiedTime] = input.ModifiedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.DelveActionHubId] = input.DelveActionHubId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.MessageId] = input.MessageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.Sender] = input.Sender.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.MessageTime] = input.MessageTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CardType] = input.CardType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.CardTypeName] = input.CardTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RegardingObjectIdDsc] = input.RegardingObjectIdDsc.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RecordId] = input.RecordId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RecordIdDsc] = input.RecordIdDsc.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RecordIdName] = input.RecordIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.MailWebLink] = input.MailWebLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RelatedMailIds] = input.RelatedMailIds.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RecordIdObjectTypeCode] = input.RecordIdObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.SenderImageUrl] = input.SenderImageUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.IconClassName] = input.IconClassName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.SenderEntityId] = input.SenderEntityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DelveActionHub.SenderEntityObjectTypeCode] = input.SenderEntityObjectTypeCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

