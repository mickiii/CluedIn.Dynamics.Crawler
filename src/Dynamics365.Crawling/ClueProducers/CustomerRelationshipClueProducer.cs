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
    public abstract class CustomerRelationshipClueProducer<T> : DynamicsClueProducer<T> where T : CustomerRelationship
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CustomerRelationshipClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.CustomerRelationshipId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=customerrelationship&id={1}", _dynamics365CrawlJobData.Api, input.CustomerRelationshipId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.CustomerRoleIdName;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.PartnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.PartnerId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.CustomerRoleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.relationshiprole, EntityEdgeType.Parent, input, input.CustomerRoleId);

                         if (input.PartnerRoleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.relationshiprole, EntityEdgeType.Parent, input, input.PartnerRoleId);

                         if (input.ConverseRelationshipId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.customerrelationship, EntityEdgeType.Parent, input, input.ConverseRelationshipId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.PartnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.PartnerId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CustomerRoleId] = input.CustomerRoleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CustomerRelationshipId] = input.CustomerRelationshipId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.PartnerId] = input.PartnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ConverseRelationshipId] = input.ConverseRelationshipId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.PartnerRoleId] = input.PartnerRoleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CustomerRoleDescription] = input.CustomerRoleDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.PartnerRoleDescription] = input.PartnerRoleDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.PartnerIdType] = input.PartnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CustomerRoleIdName] = input.CustomerRoleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.PartnerRoleIdName] = input.PartnerRoleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.PartnerIdName] = input.PartnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.UniqueDscId] = input.UniqueDscId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.PartnerIdYomiName] = input.PartnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerRelationship.OwningTeam] = input.OwningTeam.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

