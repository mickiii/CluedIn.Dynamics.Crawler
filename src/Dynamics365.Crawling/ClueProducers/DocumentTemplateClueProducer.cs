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
    public abstract class DocumentTemplateClueProducer<T> : DynamicsClueProducer<T> where T : DocumentTemplate
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DocumentTemplateClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DocumentTemplateId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=documenttemplate&id={1}", _dynamics365CrawlJobData.Api, input.DocumentTemplateId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.ClientData] = input.ClientData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.Content] = input.Content.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.DocumentType] = input.DocumentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.DocumentTypeName] = input.DocumentTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.DocumentTemplateId] = input.DocumentTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.AssociatedEntityTypeCode] = input.AssociatedEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.StatusName] = input.StatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.AssociatedEntityTypeCodeName] = input.AssociatedEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentTemplate.LanguageCode] = input.LanguageCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

