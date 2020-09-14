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
    public abstract class PersonalDocumentTemplateClueProducer<T> : DynamicsClueProducer<T> where T : PersonalDocumentTemplate
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PersonalDocumentTemplateClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PersonalDocumentTemplateId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=personaldocumenttemplate&id={1}", _dynamics365CrawlJobData.Api, input.PersonalDocumentTemplateId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.ClientData] = input.ClientData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.Content] = input.Content.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.DocumentType] = input.DocumentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.DocumentTypeName] = input.DocumentTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.PersonalDocumentTemplateId] = input.PersonalDocumentTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.AssociatedEntityTypeCode] = input.AssociatedEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.StatusName] = input.StatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.AssociatedEntityTypeCodeName] = input.AssociatedEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PersonalDocumentTemplate.LanguageCode] = input.LanguageCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

