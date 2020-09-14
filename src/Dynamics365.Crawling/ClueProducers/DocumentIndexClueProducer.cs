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
    public abstract class DocumentIndexClueProducer<T> : DynamicsClueProducer<T> where T : DocumentIndex
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DocumentIndexClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DocumentIndexId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=documentindex&id={1}", _dynamics365CrawlJobData.Api, input.DocumentIndexId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.DocumentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.DocumentId);

                         if (input.DocumentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.kbarticle, EntityEdgeType.Parent, input, input.DocumentId);

                         if (input.SubjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.subject, EntityEdgeType.Parent, input, input.SubjectId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.DocumentIndex.DocumentIndexId] = input.DocumentIndexId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.SubjectId] = input.SubjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.IsPublished] = input.IsPublished.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.DocumentTypeCode] = input.DocumentTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.DocumentId] = input.DocumentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.Location] = input.Location.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.Number] = input.Number.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.KeyWords] = input.KeyWords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.SearchText] = input.SearchText.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.IsPublishedName] = input.IsPublishedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.DocumentTypeCodeName] = input.DocumentTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.IsLatestVersion] = input.IsLatestVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DocumentIndex.IsLatestVersionName] = input.IsLatestVersionName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

