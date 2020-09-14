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
    public abstract class ExchangeSyncIdMappingClueProducer<T> : DynamicsClueProducer<T> where T : ExchangeSyncIdMapping
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ExchangeSyncIdMappingClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ExchangeSyncIdmappingId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=exchangesyncidmapping&id={1}", _dynamics365CrawlJobData.Api, input.ExchangeSyncIdmappingId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.ExchangeSyncIdmappingId] = input.ExchangeSyncIdmappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.ExchangeEntryId] = input.ExchangeEntryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.IsDeletedInExchange] = input.IsDeletedInExchange.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.IsUnlinkedInCRM] = input.IsUnlinkedInCRM.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.FromCrmChangeType] = input.FromCrmChangeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.ToCrmChangeType] = input.ToCrmChangeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.Retries] = input.Retries.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.LastSyncError] = input.LastSyncError.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.UserDecision] = input.UserDecision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.LastSyncErrorCode] = input.LastSyncErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.LastSyncErrorOccurredOn] = input.LastSyncErrorOccurredOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ExchangeSyncIdMapping.ItemSubject] = input.ItemSubject.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

