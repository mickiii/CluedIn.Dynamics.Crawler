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
    public abstract class RelationshipRoleMapClueProducer<T> : DynamicsClueProducer<T> where T : RelationshipRoleMap
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RelationshipRoleMapClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RelationshipRoleMapId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=relationshiprolemap&id={1}", _dynamics365CrawlJobData.Api, input.RelationshipRoleMapId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.RelationshipRoleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.relationshiprole, EntityEdgeType.Parent, input, input.RelationshipRoleId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.RelationshipRoleMapId] = input.RelationshipRoleMapId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.AssociateObjectTypeCode] = input.AssociateObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.RelationshipRoleId] = input.RelationshipRoleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.PrimaryObjectTypeCode] = input.PrimaryObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.RelationshipRoleIdName] = input.RelationshipRoleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.AssociateObjectTypeCodeName] = input.AssociateObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.PrimaryObjectTypeCodeName] = input.PrimaryObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RelationshipRoleMap.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

