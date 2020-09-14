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
    public abstract class KnowledgeArticleClueProducer<T> : DynamicsClueProducer<T> where T : KnowledgeArticle
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public KnowledgeArticleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.knowledgearticleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=knowledgearticle&id={1}", _dynamics365CrawlJobData.Api, input.knowledgearticleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.RootArticleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RootArticleId);

                         if (input.PreviousArticleContentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.PreviousArticleContentId);

                         if (input.ParentArticleContentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.ParentArticleContentId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.SubjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.subject, EntityEdgeType.Parent, input, input.SubjectId);

                         if (input.stageid != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.stageid);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.LanguageLocaleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.languagelocale, EntityEdgeType.Parent, input, input.LanguageLocaleId);

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

                         if (input.primaryauthorid != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.primaryauthorid);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.knowledgearticleId] = input.knowledgearticleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.processid] = input.processid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.stageid] = input.stageid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.traversedpath] = input.traversedpath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Content] = input.Content.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Keywords] = input.Keywords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.PublishOn] = input.PublishOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ExpirationDate] = input.ExpirationDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ParentArticleContentIdName] = input.ParentArticleContentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ParentArticleContentId] = input.ParentArticleContentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.KnowledgeArticleViews] = input.KnowledgeArticleViews.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.MajorVersionNumber] = input.MajorVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.MinorVersionNumber] = input.MinorVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.LanguageLocaleId] = input.LanguageLocaleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.LanguageLocaleIdName] = input.LanguageLocaleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ScheduledStatusId] = input.ScheduledStatusId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ExpirationStatusId] = input.ExpirationStatusId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.PublishStatusId] = input.PublishStatusId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.IsPrimaryName] = input.IsPrimaryName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.LanguageLocaleIdLocaleId] = input.LanguageLocaleIdLocaleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.IsPrimary] = input.IsPrimary.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ReadyForReview] = input.ReadyForReview.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.isReadyForReview] = input.isReadyForReview.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Review] = input.Review.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.isReview] = input.isReview.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.UpdateContent] = input.UpdateContent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.isUpdateContent] = input.isUpdateContent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.SetProductAssociations] = input.SetProductAssociations.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.isProductAssociations] = input.isProductAssociations.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ExpiredReviewOptions] = input.ExpiredReviewOptions.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.isExpiredReviewOptions] = input.isExpiredReviewOptions.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.SubjectId] = input.SubjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.SubjectIdDsc] = input.SubjectIdDsc.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.SubjectIdName] = input.SubjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.primaryauthorid] = input.primaryauthorid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.primaryauthoridName] = input.primaryauthoridName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.IsRootArticle] = input.IsRootArticle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.IsRootArticleName] = input.IsRootArticleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.PreviousArticleContentId] = input.PreviousArticleContentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.PreviousArticleContentIdName] = input.PreviousArticleContentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ArticlePublicNumber] = input.ArticlePublicNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.IsLatestVersion] = input.IsLatestVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.IsLatestVersionName] = input.IsLatestVersionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.RootArticleId] = input.RootArticleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.RootArticleIdName] = input.RootArticleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.KnowledgeArticleViews_Date] = input.KnowledgeArticleViews_Date.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.KnowledgeArticleViews_State] = input.KnowledgeArticleViews_State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Rating] = input.Rating.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Rating_Date] = input.Rating_Date.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Rating_State] = input.Rating_State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Rating_Sum] = input.Rating_Sum.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.Rating_Count] = input.Rating_Count.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.IsInternal] = input.IsInternal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.IsInternalName] = input.IsInternalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.SetCategoryAssociations] = input.SetCategoryAssociations.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.SetCategoryAssociationsName] = input.SetCategoryAssociationsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.KnowledgeArticle.ExpirationStateId] = input.ExpirationStateId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

