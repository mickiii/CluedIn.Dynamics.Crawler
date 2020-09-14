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
    public abstract class BookableResourceBookingExchangeSyncIdMappingClueProducer<T> : DynamicsClueProducer<T> where T : BookableResourceBookingExchangeSyncIdMapping
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public BookableResourceBookingExchangeSyncIdMappingClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.BookableResourceBookingExchangeSyncIdMappingId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=bookableresourcebookingexchangesyncidmapping&id={1}", _dynamics365CrawlJobData.Api, input.BookableResourceBookingExchangeSyncIdMappingId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ExchangeEntryId] = input.ExchangeEntryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.BookableResourceBookingExchangeSyncIdMappingId] = input.BookableResourceBookingExchangeSyncIdMappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.IsDeletedInExchange] = input.IsDeletedInExchange.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.BookableResourceBookingId] = input.BookableResourceBookingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.LastSyncErrorOccurredOn] = input.LastSyncErrorOccurredOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.Retries] = input.Retries.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.LastSyncErrorCode] = input.LastSyncErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.LastSyncError] = input.LastSyncError.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.UserId] = input.UserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.SyncStatus] = input.SyncStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.SyncVersionNumber] = input.SyncVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.isdeletedinexchangeName] = input.isdeletedinexchangeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.syncstatusName] = input.syncstatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceBookingExchangeSyncIdMapping.Name] = input.Name.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

