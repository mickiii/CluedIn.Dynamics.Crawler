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
    public abstract class SystemApplicationMetadataClueProducer<T> : DynamicsClueProducer<T> where T : SystemApplicationMetadata
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SystemApplicationMetadataClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SystemApplicationMetadataId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=systemapplicationmetadata&id={1}", _dynamics365CrawlJobData.Api, input.SystemApplicationMetadataId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.SystemApplicationMetadataId] = input.SystemApplicationMetadataId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.AssociatedEntityLogicalName] = input.AssociatedEntityLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.Data] = input.Data.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.DisplayName] = input.DisplayName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.FormFactor] = input.FormFactor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.MetadataType] = input.MetadataType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.SourceId] = input.SourceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.MetadataSubtype] = input.MetadataSubtype.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.Lcid] = input.Lcid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.Version] = input.Version.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.State] = input.State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemApplicationMetadata.Dependency] = input.Dependency.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

