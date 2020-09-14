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
    public abstract class ChannelAccessProfileClueProducer<T> : DynamicsClueProducer<T> where T : ChannelAccessProfile
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ChannelAccessProfileClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ChannelAccessProfileId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=channelaccessprofile&id={1}", _dynamics365CrawlJobData.Api, input.ChannelAccessProfileId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

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

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ChannelAccessProfileId] = input.ChannelAccessProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.EmailAccess] = input.EmailAccess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.EmailAccessName] = input.EmailAccessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.FacebookAccess] = input.FacebookAccess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.FacebookAccessName] = input.FacebookAccessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.PhoneAccess] = input.PhoneAccess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.PhoneAccessName] = input.PhoneAccessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.TwitterAccess] = input.TwitterAccess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.TwitterAccessName] = input.TwitterAccessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.WebAccess] = input.WebAccess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.WebAccessName] = input.WebAccessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ViewKnowledgeArticles] = input.ViewKnowledgeArticles.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ViewKnowledgeArticlesName] = input.ViewKnowledgeArticlesName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ViewArticleRating] = input.ViewArticleRating.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ViewArticleRatingName] = input.ViewArticleRatingName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.RateKnowledgeArticles] = input.RateKnowledgeArticles.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.RateKnowledgeArticlesName] = input.RateKnowledgeArticlesName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.SubmitFeedback] = input.SubmitFeedback.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.SubmitFeedbackName] = input.SubmitFeedbackName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.ChannelAccessProfileIdUnique] = input.ChannelAccessProfileIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.IsGuestProfile] = input.IsGuestProfile.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.CanDeleteName] = input.CanDeleteName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.HavePrivilegesChanged] = input.HavePrivilegesChanged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfile.HavePrivilegesChangedName] = input.HavePrivilegesChangedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

