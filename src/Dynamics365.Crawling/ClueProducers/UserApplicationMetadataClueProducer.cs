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
    public abstract class UserApplicationMetadataClueProducer<T> : DynamicsClueProducer<T> where T : UserApplicationMetadata
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public UserApplicationMetadataClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.UserApplicationMetadataId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=userapplicationmetadata&id={1}", _dynamics365CrawlJobData.Api, input.UserApplicationMetadataId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.UserApplicationMetadataId] = input.UserApplicationMetadataId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.AssociatedEntityLogicalName] = input.AssociatedEntityLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.Data] = input.Data.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.DisplayName] = input.DisplayName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.FormFactor] = input.FormFactor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.MetadataType] = input.MetadataType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.MetadataSubtype] = input.MetadataSubtype.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.SourceId] = input.SourceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.State] = input.State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.Lcid] = input.Lcid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserApplicationMetadata.Dependency] = input.Dependency.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

