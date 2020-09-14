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
    public abstract class BusinessUnitNewsArticleClueProducer<T> : DynamicsClueProducer<T> where T : BusinessUnitNewsArticle
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public BusinessUnitNewsArticleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.BusinessUnitNewsArticleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=businessunitnewsarticle&id={1}", _dynamics365CrawlJobData.Api, input.BusinessUnitNewsArticleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.ArticleTitle;
            /*
             if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.BusinessUnitNewsArticleId] = input.BusinessUnitNewsArticleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ActiveOn] = input.ActiveOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ActiveUntil] = input.ActiveUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.NewsArticle] = input.NewsArticle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ArticleTypeCode] = input.ArticleTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ShowOnHomepage] = input.ShowOnHomepage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ArticleTitle] = input.ArticleTitle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ArticleUrl] = input.ArticleUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ShowOnHomepageName] = input.ShowOnHomepageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ArticleTypeCodeName] = input.ArticleTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BusinessUnitNewsArticle.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

